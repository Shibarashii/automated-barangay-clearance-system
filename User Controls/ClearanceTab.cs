using CefSharp;
using CefSharp.WinForms;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Word = Microsoft.Office.Interop.Word;

namespace Barangay_Clearance_System.User_Controls
{
    public partial class ClearanceTab : UserControl
    {
        private static string savedPdfFilePath = null;
        private static string tempFilePath;
        public ClearanceTab()
        {
            InitializeComponent();

            // Initialize the embedded template
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
                // Define the temporary file path
                string tempPath = Path.Combine(Path.GetTempPath(), "barangay-clearance-template.docx");

                // Use the resource name to access the embedded file
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
            // Check if essential fields are empty, return early to avoid unnecessary processing
            if (string.IsNullOrEmpty(NameTextbox.Text))
                return;

            // Parse the Date of Birth from the TextBox
            ParseDate(DateOfBirthTextbox.Text, out string month, out string day, out string year);

            // Create replacements for placeholders in the Word document
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

            // Update the Sex checkbox
            if (SexTextbox.Text == "Male")
            {
                replacements["MG"] = "✔";
            }
            else if (SexTextbox.Text == "Female")
            {
                replacements["FG"] = "✔";
            }

            // Update the Application Purpose field
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

            // Perform the heavy lifting asynchronously
            await Task.Run(() => ReplaceText(tempFilePath, replacements));
        }


        private static void ReplaceText(string path, Dictionary<string, string> replacements)
        {
            // Start Word application to open and modify the document
            Word.Application wordApp = new Word.Application();
            Word.Document document = null;

            try
            {
                // Open the document (ensure the path is correct)
                document = wordApp.Documents.Open(path, ReadOnly: false);

                // Loop through each shape in the document (like TextBoxes, etc.)
                foreach (Word.Shape shape in document.Shapes)
                {
                    if (shape.TextFrame.HasText == -1) // Check if the shape contains text
                    {
                        Word.TextFrame textFrame = shape.TextFrame;
                        string text = textFrame.TextRange.Text;

                        // Replace placeholders with actual values
                        foreach (var pair in replacements)
                        {
                            if (text.Contains(pair.Key))
                            {
                                shape.TextFrame.TextRange.Text = text.Replace(pair.Key, pair.Value);
                            }
                        }
                    }
                }

                // Save the modified document as a PDF
                savedPdfFilePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".pdf";
                document.SaveAs2(savedPdfFilePath, Word.WdSaveFormat.wdFormatPDF);

                // After saving, load the PDF into the preview browser
                LoadPdfPreview(savedPdfFilePath);
            }
            catch (Exception ex)
            {
                // Handle errors during document processing
                MessageBox.Show($"Error processing document: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up Word application and close document
                document?.Close(false);
                wordApp.Quit(false);
            }
        }

        private static void LoadPdfPreview(string pdfPath)
        {
            // Ensure that the ChromiumWebBrowser control is correctly initialized
            if (ChromiumWebBrowserPreview != null && !string.IsNullOrEmpty(pdfPath))
            {
                // Load the generated PDF into the preview browser
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
                // Specify the format "MMMM dd, yyyy"
                DateTime parsedDate = DateTime.ParseExact(dateInput, "MMMM dd, yyyy",
                                                          System.Globalization.CultureInfo.InvariantCulture);

                // Extract components
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
            // Enable or disable buttons based on the NameTextbox
            SaveAsPDFButton.Enabled = !string.IsNullOrEmpty(NameTextbox.Text);
            PrintButton.Enabled = !string.IsNullOrEmpty(NameTextbox.Text);
        }

        private void SaveAsPDFButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(savedPdfFilePath) || !System.IO.File.Exists(savedPdfFilePath))
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
                    // Copy the temporary file to the selected location
                    System.IO.File.Copy(savedPdfFilePath, saveFileDialog.FileName, true);
                    MessageBox.Show($"File saved successfully to: {saveFileDialog.FileName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error printing PDF: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
