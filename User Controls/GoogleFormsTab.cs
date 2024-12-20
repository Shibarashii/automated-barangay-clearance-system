using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Clearance_System.User_Controls
{
    public partial class GoogleFormsTab : UserControl
    {
        private static string rawTimeStamp;

        public GoogleFormsTab()
        {
            InitializeComponent();
            try
            {
                if (File.Exists(Main.databasePath))
                {
                    PopulateGridView();
                }

                DatabaseGridView.CellContentClick += DatabaseGridView_CellContentClick;
                DatabaseGridView.AllowUserToResizeRows = false;
                DatabaseGridView.ReadOnly = true;
                DatabaseGridView.MultiSelect = false;
            }
            catch
            {
                MessageBox.Show("Error loading the spreadsheet. Please check the spreadsheet ID and range in the settings for accuracy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void PopulateGridView()
        {
            DatabaseGridView.Columns.Clear();
            DatabaseGridView.Rows.Clear();

            DatabaseGridView.Columns.Add("timestamp", "Date");
            DatabaseGridView.Columns.Add("email_address", "Contact Information");
            DatabaseGridView.Columns.Add("name", "Name");
            DatabaseGridView.Columns.Add("purok_number", "Purok Number");
            DatabaseGridView.Columns.Add("house_number", "House Number");
            DatabaseGridView.Columns.Add("date_of_birth", "Date of Birth");
            DatabaseGridView.Columns.Add("place_of_birth", "Place of Birth");
            DatabaseGridView.Columns.Add("sex", "Sex");
            DatabaseGridView.Columns.Add("civil_status", "Civil Status");
            DatabaseGridView.Columns.Add("application_purpose", "Application Purpose");

            // Approve Button Column
            DataGridViewButtonColumn approveButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "approve_button",
                HeaderText = "Approve",
                Text = "Approve",
                UseColumnTextForButtonValue = true
            };
            DatabaseGridView.Columns.Add(approveButtonColumn);

            // Remove Button Column
            DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "remove_button",
                HeaderText = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true,
            };
            DatabaseGridView.Columns.Add(removeButtonColumn);

            // Adjust width
            DatabaseGridView.Columns["name"].Width = 150;
            DatabaseGridView.Columns["purok_number"].Width = 75;
            DatabaseGridView.Columns["house_number"].Width = 75;
            DatabaseGridView.Columns["date_of_birth"].Width = 100;
            DatabaseGridView.Columns["place_of_birth"].Width = 100;
            DatabaseGridView.Columns["sex"].Width = 75;
            DatabaseGridView.Columns["civil_status"].Width = 75;
            DatabaseGridView.Columns["application_purpose"].Width = 125;
            DatabaseGridView.Columns["approve_button"].Width = 75;
            DatabaseGridView.Columns["remove_button"].Width = 75;

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM sheet WHERE is_archived = FALSE";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        rawTimeStamp = reader["timestamp"].ToString();
                        string timestamp = DateTime.Parse(rawTimeStamp).ToString("MM-dd-yyyy HH:mm:ss");

                        // Add row with timestamp
                        var rowIndex = DatabaseGridView.Rows.Add(
                            timestamp,
                            reader["email_address"].ToString(),
                            reader["name"].ToString(),
                            reader["purok_number"].ToString(),
                            reader["house_number"].ToString(),
                            reader["date_of_birth"].ToString(),
                            reader["place_of_birth"].ToString(),
                            reader["sex"].ToString(),
                            reader["civil_status"].ToString(),
                            reader["application_purpose"].ToString()
                        );

                        // Store rawTimeStamp in the row (hidden or as a tag for internal use)
                        DatabaseGridView.Rows[rowIndex].Tag = rawTimeStamp;  // Use Tag to store the rawTimeStamp
                    }
                }
            }

            DatabaseGridView.Sort(DatabaseGridView.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }



        private void Search()
        {
            string searchText = SearchTextbox.Text.Trim().ToLower(); // Get the search text in lowercase
            if (string.IsNullOrWhiteSpace(searchText))
            {
                PopulateGridView(); // Reload the full data if the search text is empty
                return;
            }

            DatabaseGridView.Rows.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = @"SELECT * FROM sheet WHERE 
                     LOWER(name) LIKE @search OR 
                     LOWER(purok_number) LIKE @search OR 
                     LOWER(house_number) LIKE @search OR 
                     LOWER(date_of_birth) LIKE @search OR 
                     LOWER(place_of_birth) LIKE @search OR 
                     LOWER(civil_status) LIKE @search OR 
                     LOWER(application_purpose) LIKE @search AND
                     is_archived = FALSE";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@search", $"%{searchText}%");

                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DatabaseGridView.Rows.Add(
                            reader["timestamp"].ToString(),
                            reader["email_address"].ToString(),
                            reader["name"].ToString(),
                            reader["purok_number"].ToString(),
                            reader["house_number"].ToString(),
                            reader["date_of_birth"].ToString(),
                            reader["place_of_birth"].ToString(),
                            reader["sex"].ToString(),
                            reader["civil_status"].ToString(),
                            reader["application_purpose"].ToString()
                        );

                    }
                }
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the JSON file exists
                if (!File.Exists(Main.JSONFilePath))
                {
                    MessageBox.Show("No JSON file found. Please upload a service account JSON file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GoogleSheets.FetchDataAndInsert();
                HistoryTab.PopulateGridView();
                PopulateGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void DatabaseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DatabaseGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string rawTimeStamp = DatabaseGridView.Rows[e.RowIndex].Tag?.ToString();

                if (string.IsNullOrWhiteSpace(rawTimeStamp))
                {
                    return;
                }

                // APPROVE BUTTON
                if (DatabaseGridView.Columns[e.ColumnIndex].Name == "approve_button")
                {
                    var confirmResult = MessageBox.Show(
                        "Are you sure you want to approve this entry?",
                        "Confirm Approval",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question
                    );

                    if (confirmResult == DialogResult.OK)
                    {
                        string email = DatabaseGridView.Rows[e.RowIndex].Cells["email_address"].Value.ToString();
                        string name = DatabaseGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
                        string purokNumber = DatabaseGridView.Rows[e.RowIndex].Cells["purok_number"].Value.ToString();
                        string houseNumber = DatabaseGridView.Rows[e.RowIndex].Cells["house_number"].Value.ToString();
                        string dateOfBirth = DatabaseGridView.Rows[e.RowIndex].Cells["date_of_birth"].Value.ToString();
                        string placeOfBirth = DatabaseGridView.Rows[e.RowIndex].Cells["place_of_birth"].Value.ToString();
                        string sex = DatabaseGridView.Rows[e.RowIndex].Cells["sex"].Value.ToString();
                        string civilStatus = DatabaseGridView.Rows[e.RowIndex].Cells["civil_status"].Value.ToString();
                        string applicationPurpose = DatabaseGridView.Rows[e.RowIndex].Cells["application_purpose"].Value.ToString();

                        MainForm.googleFormsTab.Hide();
                        MainForm.clearanceTab.Show();
                        MainForm.BarangayClearanceButton.Checked = true;
                        ClearanceTab.PopulateForms(rawTimeStamp, email, name, purokNumber, houseNumber, dateOfBirth, placeOfBirth, sex, civilStatus, applicationPurpose);
                    }
                }

                // REMOVE BUTTON
                if (DatabaseGridView.Columns[e.ColumnIndex].Name == "remove_button")
                {
                    var confirmResult = MessageBox.Show(
                        "Are you sure you want to remove this entry?",
                        "Confirm Removal",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning

                    );

                    if (confirmResult == DialogResult.OK)
                    {
                        GoogleSheets.DeleteEntry(rawTimeStamp);
                        GoogleSheets.FetchDataAndInsert();
                        PopulateGridView();
                        ClearanceTab.ClearResources(rawTimeStamp);
                        HistoryTab.PopulateGridView();
                    }
                }
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
