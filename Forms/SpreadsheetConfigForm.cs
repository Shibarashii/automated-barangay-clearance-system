using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Barangay_Clearance_System.Forms
{
    public partial class SpreadsheetConfigForm : KryptonForm
    {
        public SpreadsheetConfigForm()
        {
            InitializeComponent();
            GetSetSpreadsheetID();
            GetSetRange();
            SpreadsheetIDTextbox.Text = GoogleSheets.spreadSheetID;
            RangeTextbox.Text = GoogleSheets.range;
        }

        public static void GetSetSpreadsheetID()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "SELECT spreadsheet_id FROM google_sheets";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        GoogleSheets.spreadSheetID = result.ToString();
                    }

                }
                connection.Close();
            }
        }

        public static void GetSetRange()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "SELECT range FROM google_sheets";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        GoogleSheets.range = result.ToString();
                    }
                }
                connection.Close();
            }
        }

        private void UpdateOrInsertSpreadsheetID()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM google_sheets";
                using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (rowCount == 0)
                    {
                        string insertQuery = "INSERT INTO google_sheets (spreadsheet_id) VALUES (@spreadSheetID)";
                        using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("spreadSheetID", SpreadsheetIDTextbox.Text);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string updateQuery = "UPDATE google_sheets SET spreadsheet_id = @spreadSheetID";
                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("spreadSheetID", SpreadsheetIDTextbox.Text);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
                connection.Close();
            }
        }

        private void UpdateOrInsertRange()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM google_sheets";
                using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
                {
                    int rowCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (rowCount == 0)
                    {
                        string insertQuery = "INSERT INTO google_sheets (range) VALUES (@range)";
                        using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("range", RangeTextbox.Text);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string updateQuery = "UPDATE google_sheets SET range = @range";
                        using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("range", RangeTextbox.Text);
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                }
                connection.Close();
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Please double-check the information before saving to ensure everything is correct. Inaccuracy could lead to potential errors",
                                                  "Confirm Changes",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                UpdateOrInsertSpreadsheetID();
                UpdateOrInsertRange();
                MessageBox.Show("Successfully configured the spreadsheet.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetSetSpreadsheetID();
                GetSetRange();
            }
        }
    }
}
