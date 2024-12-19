using CefSharp;
using CefSharp.WinForms;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace Barangay_Clearance_System.User_Controls
{
    public partial class ClearanceTab : UserControl
    {
        private static string savedPdfFilePath = null;
        private static string tempFilePath;

        public static string rawTimeStamp;
        public ClearanceTab()
        {
            InitializeComponent();

            // embedded template
            tempFilePath = ExtractEmbeddedFile("Barangay_Clearance_System.Resources.barangay-clearance-template.docx");

            NameTextbox.ReadOnly = true;
            PurokNoTextbox.ReadOnly = true;
            HouseNoTextbox.ReadOnly = true;
            DateOfBirthTextbox.ReadOnly = true;
            PlaceOfBirthTextbox.ReadOnly = true;
            SexTextbox.ReadOnly = true;
            CivilStatusTextbox.ReadOnly = true;
            ApplicationPurposeTextbox.ReadOnly = true;
            SpecifyTextbox.ReadOnly = true;

            SaveAsPDFButton.Enabled = false;
            PrintButton.Enabled = false;
        }

        private string ExtractEmbeddedFile(string resourceName)
        {
            try
            {
                string tempPath = Path.Combine(Path.GetTempPath(), "barangay-clearance-template.docx");

                using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    if (resourceStream == null)
                        throw new Exception($"Resource '{resourceName}' not found.");

                    using (FileStream fileStream = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                    {
                        resourceStream.CopyTo(fileStream);
                    }
                }

                return tempPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error extracting embedded file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void PopulateForms(string timestamp, string email, string name, string purokNumber, string houseNumber, string dateOfBirth, string placeOfBirth, string sex, string civilStatus, string applicationPurpose)
        {
            rawTimeStamp = timestamp;
            DateTime parsedDate = DateTime.Parse(dateOfBirth);

            NameTextbox.Text = name;
            PurokNoTextbox.Text = purokNumber;
            HouseNoTextbox.Text = houseNumber;
            DateOfBirthTextbox.Text = parsedDate.ToString("MMMM dd, yyyy");
            PlaceOfBirthTextbox.Text = placeOfBirth;
            SexTextbox.Text = sex;
            CivilStatusTextbox.Text = civilStatus;
            ApplicationPurposeTextbox.Text = applicationPurpose;

            List<string> applicationPurposeList = new List<string>()
            { "Local Employment", "Passport Application", "Loan Purpose", "Open Bank Account",
              "4P's Requirements", "Postal ID", "Police Clearance", "NBI Clearance", "Water Permit",
              "School Requirements"
            };

            // Checking if the applicationPurpose is in the Combo Box
            if (applicationPurposeList.Contains(applicationPurpose))
            {
                ApplicationPurposeTextbox.Text = applicationPurpose;
                SpecifyTextbox.Hide();
                SpecifyLabel.Hide();
            }
            else
            {
                ApplicationPurposeTextbox.Text = "Others";
                SpecifyTextbox.Text = applicationPurpose;
                SpecifyTextbox.Show();
                SpecifyLabel.Show();
            }

            LoadPreview();
        }

        private static async void LoadPreview()
        {
            if (string.IsNullOrEmpty(NameTextbox.Text))
                return;

            ParseDate(DateOfBirthTextbox.Text, out string month, out string day, out string year);

            var replacements = new Dictionary<string, string>
            {
                { "FullName", NameTextbox.Text },
                { "Purok", PurokNoTextbox.Text },
                { "House", HouseNoTextbox.Text },
                { "Month", month },
                { "Day", day },
                { "Year", year },
                { "MG", "" },
                { "FG", "" },
                { "CivilStatus", CivilStatusTextbox.Text },
                { "BirthPlace", PlaceOfBirthTextbox.Text },
                { "P1", "" }, { "P2", "" }, { "P3", "" }, { "P4", "" },
                { "P5", "" }, { "P6", "" }, { "P7", "" }, { "P8", "" },
                { "P9", "" }, { "P10", "" }, { "P11", "" }
            };

            if (SexTextbox.Text == "Male")
            {
                replacements["MG"] = "✔";
            }
            else if (SexTextbox.Text == "Female")
            {
                replacements["FG"] = "✔";
            }

            switch (ApplicationPurposeTextbox.Text)
            {
                case "Local Employment": replacements["P1"] = "✔"; break;
                case "Passport Application": replacements["P2"] = "✔"; break;
                case "Loan Purpose": replacements["P3"] = "✔"; break;
                case "Open Bank Account": replacements["P4"] = "✔"; break;
                case "4P's Requirements": replacements["P5"] = "✔"; break;
                case "Postal ID": replacements["P6"] = "✔"; break;
                case "Police Clearance": replacements["P7"] = "✔"; break;
                case "NBI Clearance": replacements["P8"] = "✔"; break;
                case "Water Permit": replacements["P9"] = "✔"; break;
                case "School Requirements": replacements["P10"] = "✔"; break;
                default:
                    replacements["P11"] = SpecifyTextbox.Text;
                    break;
            }

            await Task.Run(() => ReplaceText(tempFilePath, replacements));
        }

        public static void ClearResources(string timestamp)
        {
            if (rawTimeStamp == timestamp)
            {
                NameTextbox.Text = "";
                PurokNoTextbox.Text = "";
                HouseNoTextbox.Text = "";
                DateOfBirthTextbox.Text = "";
                PlaceOfBirthTextbox.Text = "";
                SexTextbox.Text = "";
                CivilStatusTextbox.Text = "";
                ApplicationPurposeTextbox.Text = "";
                SpecifyTextbox.Text = "";
                ChromiumWebBrowserPreview = null;
            }
        }

        private static void ReplaceText(string path, Dictionary<string, string> replacements)
        {
            Word.Application wordApp = new Word.Application();
            Word.Document document = null;

            try
            {
                document = wordApp.Documents.Open(path, ReadOnly: false);

                foreach (Word.Shape shape in document.Shapes)
                {
                    if (shape.TextFrame.HasText == -1) // Check if the shape contains text
                    {
                        Word.TextFrame textFrame = shape.TextFrame;
                        string text = textFrame.TextRange.Text;

                        foreach (var pair in replacements)
                        {
                            if (text.Contains(pair.Key))
                            {
                                shape.TextFrame.TextRange.Text = text.Replace(pair.Key, pair.Value);
                            }
                        }
                    }
                }

                savedPdfFilePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf";
                document.SaveAs2(savedPdfFilePath, Word.WdSaveFormat.wdFormatPDF);

                LoadPdfPreview(savedPdfFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document?.Close(false);
                wordApp.Quit(false);
            }
        }

        private static void LoadPdfPreview(string pdfPath)
        {
            if (ChromiumWebBrowserPreview != null && !string.IsNullOrEmpty(pdfPath))
            {
                ChromiumWebBrowserPreview.Load(pdfPath);
            }
            else
            {
                MessageBox.Show("Error loading PDF preview.", "Preview Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void ParseDate(string dateInput, out string month, out string day, out string year)
        {
            month = day = year = string.Empty;

            try
            {
                DateTime parsedDate = DateTime.ParseExact(dateInput, "MMMM dd, yyyy",
                                                          System.Globalization.CultureInfo.InvariantCulture);

                month = parsedDate.ToString("MMMM"); // January
                day = parsedDate.Day.ToString();     // 05
                year = parsedDate.Year.ToString();   // 2003
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date format. Please enter a valid date (e.g., May 05, 2003).",
                                "Date Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Textboxes_TextChanged(object sender, EventArgs e)
        {
            SaveAsPDFButton.Enabled = !string.IsNullOrEmpty(NameTextbox.Text);
            PrintButton.Enabled = !string.IsNullOrEmpty(NameTextbox.Text);
        }

        private void SaveAsPDFButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(savedPdfFilePath) || !File.Exists(savedPdfFilePath))
            {
                MessageBox.Show("No previewed file to save. Please load a preview first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Save PDF File",
                FileName = NameTextbox.Text + " - Barangay_Clearance.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(savedPdfFilePath, saveFileDialog.FileName, true);
                    MessageBox.Show($"File saved successfully to: {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetApprovedToTrue();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(savedPdfFilePath))
            {
                MessageBox.Show("No PDF file available to print. Please save a PDF first.", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.AllowSomePages = true; // Allow user to specify page range
                printDialog.AllowSelection = true; // Allow user to select parts of the document

                // Show the print dialog to select a printer
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (System.Diagnostics.Process process = new System.Diagnostics.Process())
                        {
                            process.StartInfo.FileName = savedPdfFilePath;
                            process.StartInfo.Verb = "print"; // Use the print verb instead of printto
                            process.StartInfo.CreateNoWindow = true;
                            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                            // Start the print process
                            process.Start();

                            // Wait for a short period to allow the print process to initiate
                            process.WaitForExit(10000); // Wait up to 10 seconds for the print operation
                        }

                        MessageBox.Show("PDF sent to printer.", "Print Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetApprovedToTrue();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error printing PDF: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetApprovedToTrue()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "UPDATE sheet SET is_approved = TRUE WHERE timestamp = @timestamp";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("timestamp", rawTimeStamp);

                    int count = command.ExecuteNonQuery();

                    if (count > 0)
                    {
                        HistoryTab.PopulateGridView();
                        MessageBox.Show("Submission is approved and recorded.", "Approved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
