using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Clearance_System.User_Controls
{
    public partial class GoogleFormsTab : UserControl
    {
        public GoogleFormsTab()
        {
            InitializeComponent();

            if (File.Exists(Main.databasePath))
            {
                PopulateGridView();
            }

            DatabaseGridView.CellContentClick += DatabaseGridView_CellContentClick;
            DatabaseGridView.AllowUserToResizeRows = false;
            DatabaseGridView.ReadOnly = true;
            DatabaseGridView.MultiSelect = false;
        }

        public static void PopulateGridView()
        {
            DatabaseGridView.Columns.Clear();
            DatabaseGridView.Rows.Clear();

            DatabaseGridView.Columns.Add("timestamp", "Date");
            DatabaseGridView.Columns.Add("email_address", "Email Address");
            DatabaseGridView.Columns.Add("name", "Name");
            DatabaseGridView.Columns.Add("purok_number", "Purok Number");
            DatabaseGridView.Columns.Add("house_number", "House Number");
            DatabaseGridView.Columns.Add("date_of_birth", "Date of Birth");
            DatabaseGridView.Columns.Add("place_of_birth", "Place of Birth");
            DatabaseGridView.Columns.Add("sex", "Sex");
            DatabaseGridView.Columns.Add("civil_status", "Civil Status");
            DatabaseGridView.Columns.Add("application_purpose", "Application Purpose");

            DataGridViewButtonColumn selectButtonColumn = new DataGridViewButtonColumn()
            {
                Name = "select_button",
                HeaderText = "Actions",
                Text = "Select",
                UseColumnTextForButtonValue = true,
            };
            DatabaseGridView.Columns.Add(selectButtonColumn);

            // Adjust width
            DatabaseGridView.Columns["name"].Width = 150;
            DatabaseGridView.Columns["purok_number"].Width = 75;
            DatabaseGridView.Columns["house_number"].Width = 75;
            DatabaseGridView.Columns["date_of_birth"].Width = 100;
            DatabaseGridView.Columns["place_of_birth"].Width = 100;
            DatabaseGridView.Columns["sex"].Width = 75;
            DatabaseGridView.Columns["civil_status"].Width = 75;
            DatabaseGridView.Columns["application_purpose"].Width = 125;
            DatabaseGridView.Columns["select_button"].Width = 75;

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM sheet";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime timestamp = DateTime.Parse(reader["timestamp"].ToString());

                        DatabaseGridView.Rows.Add(
                            timestamp.ToString("yyyy-MM-dd HH:mm:ss"), // Format date as string
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
                     LOWER(application_purpose) LIKE @search";

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
            GoogleSheets.FetchDataAndInsert();
            HistoryTab.PopulateGridView();
            PopulateGridView();
        }

        private void DatabaseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the Edit Button column
            if (e.RowIndex >= 0 && DatabaseGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string timestamp = DatabaseGridView.Rows[e.RowIndex].Cells["timestamp"].Value?.ToString();

                // Do nothing if the row's "timestamp" field (or any key field) is empty
                if (string.IsNullOrWhiteSpace(timestamp))
                {
                    return;
                }

                string email = DatabaseGridView.Rows[e.RowIndex].Cells["email_address"].Value.ToString();
                string name = DatabaseGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
                string purokNumber = DatabaseGridView.Rows[e.RowIndex].Cells["purok_number"].Value.ToString();
                string houseNumber = DatabaseGridView.Rows[e.RowIndex].Cells["house_number"].Value.ToString();
                string dateOfBirth = DatabaseGridView.Rows[e.RowIndex].Cells["date_of_birth"].Value.ToString();
                string placeOfBirth = DatabaseGridView.Rows[e.RowIndex].Cells["place_of_birth"].Value.ToString();
                string sex = DatabaseGridView.Rows[e.RowIndex].Cells["sex"].Value.ToString();
                string civilStatus = DatabaseGridView.Rows[e.RowIndex].Cells["civil_status"].Value.ToString();
                string applicationPurpose = DatabaseGridView.Rows[e.RowIndex].Cells["application_purpose"].Value.ToString();


                // Switch to clearanceTab
                MainForm.googleFormsTab.Hide();
                MainForm.clearanceTab.Show();
                MainForm.BarangayClearanceButton.Checked = true;

                ClearanceTab.PopulateForms(timestamp, email, name, purokNumber, houseNumber, dateOfBirth, placeOfBirth, sex, civilStatus, applicationPurpose);
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
