using Barangay_Clearance_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Clearance_System.User_Controls
{
    public partial class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void RecoveryButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete all current recovery codes and create a new one. Continue?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
                {
                    connection.Open();

                    // Delete all existing codes
                    string DELETE_ALL_CODES = "DELETE FROM recovery_codes";
                    using (SQLiteCommand deleteAllCodesCommand = new SQLiteCommand(DELETE_ALL_CODES, connection))
                    {
                        deleteAllCodesCommand.ExecuteNonQuery();
                    }

                    // Add new recovery codes
                    AddRecoveryCodes(connection);
                }
            }
        }

        private static void AddRecoveryCodes(SQLiteConnection connection)
        {
            List<string> recoveryCodes = new List<string>();

            for (int i = 0; i < 8;)
            {
                string generatedCode = GenerateRandomCode();
                string CHECK_CODE_EXISTENCE = "SELECT COUNT(*) FROM recovery_codes WHERE code = @code";

                using (SQLiteCommand checkCodeCommand = new SQLiteCommand(CHECK_CODE_EXISTENCE, connection))
                {
                    checkCodeCommand.Parameters.AddWithValue("@code", generatedCode);
                    int codeExistence = Convert.ToInt32(checkCodeCommand.ExecuteScalar());

                    if (codeExistence == 0)
                    {
                        string INSERT_CODE = "INSERT INTO recovery_codes (code, is_used) VALUES (@code, FALSE)";
                        using (SQLiteCommand insertCodeCommand = new SQLiteCommand(INSERT_CODE, connection))
                        {
                            insertCodeCommand.Parameters.AddWithValue("@code", generatedCode);
                            int rowsAffected = insertCodeCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                recoveryCodes.Add(generatedCode); // Store the code in the list
                                i++; // Increment only when a unique code is successfully inserted
                            }
                        }
                    }
                }
            }

            // Write the recovery codes to a text file
            // Display a SaveFileDialog to choose the file path and name
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save Recovery Codes";
            saveFileDialog.FileName = "ABCS-Recovery-Codes.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine("-----------DO NOT DELETE THIS FILE. SAVE IT SOMEWHERE SAFE -----------");
                    writer.WriteLine("");
                    writer.WriteLine("");
                    writer.WriteLine("RECOVERY CODES:");
                    writer.WriteLine("");

                    foreach (string code in recoveryCodes)
                    {
                        writer.WriteLine(code);
                    }
                }
                // Open the Notepad file
                System.Diagnostics.Process.Start("notepad.exe", saveFileDialog.FileName);
            }
        }

        private static readonly Random random = new Random();
        private static string GenerateRandomCode()
        {
            const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(characters, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void GenerateRecoveryCode()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string CHECK_CODE_COUNT = "SELECT COUNT(*) FROM recovery_codes WHERE is_used = FALSE";
                using (SQLiteCommand command = new SQLiteCommand(CHECK_CODE_COUNT, connection))
                {
                    int? count = Convert.ToInt32(command.ExecuteScalar());

                    if (count.HasValue && count > 0)
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Recovery Codes are automatically created for you. Save it immediately.", "SAVE ASAP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        using (SQLiteConnection connection2 = new SQLiteConnection(Main.connectionString))
                        {
                            connection2.Open();

                            // Delete all existing codes
                            string DELETE_ALL_CODES = "DELETE FROM recovery_codes";
                            using (SQLiteCommand deleteAllCodesCommand = new SQLiteCommand(DELETE_ALL_CODES, connection2))
                            {
                                deleteAllCodesCommand.ExecuteNonQuery();
                            }

                            // Add new recovery codes
                            AddRecoveryCodes(connection);
                        }
                    }
                }
            }
        }


        private void ChangeJSONFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open a file dialog to select the JSON file
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "JSON Files (*.json)|*.json",
                    Title = "Select a Service Account JSON File"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Copy the file to the AppData directory
                    File.Copy(openFileDialog.FileName, Main.JSONFilePath, true);

                    MessageBox.Show("JSON file uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while uploading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SpreadsheetConfigButton_Click(object sender, EventArgs e)
        {
            SpreadsheetConfigForm spreadsheetConfigForm = new SpreadsheetConfigForm();
            spreadsheetConfigForm.ShowDialog();
        }
    }
}
