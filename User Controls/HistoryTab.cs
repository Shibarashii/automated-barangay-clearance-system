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

namespace Barangay_Clearance_System.User_Controls
{
    public partial class HistoryTab : UserControl
    {
        public HistoryTab()
        {
            InitializeComponent();
            sortOrder = "DESC"; // Initialize para naka descending

            PopulateGridView();

            HistoryGridView.AllowUserToResizeRows = false;
            HistoryGridView.ReadOnly = true;
            HistoryGridView.MultiSelect = false;
        }

        public static void PopulateGridView()
        {
            HistoryGridView.Columns.Clear();
            HistoryGridView.Rows.Clear();
            for (int i = MonthCombobox.Items.Count - 1; i >= 1; i--) // resetting the month combobox
            {
                MonthCombobox.Items.RemoveAt(i);
            }

            HistoryGridView.Columns.Add("timestamp", "Date");
            HistoryGridView.Columns.Add("email_address", "Email Address");
            HistoryGridView.Columns.Add("name", "Name");
            HistoryGridView.Columns.Add("purok_number", "Purok Number");
            HistoryGridView.Columns.Add("house_number", "House Number");
            HistoryGridView.Columns.Add("date_of_birth", "Date of Birth");
            HistoryGridView.Columns.Add("place_of_birth", "Place of Birth");
            HistoryGridView.Columns.Add("sex", "Sex");
            HistoryGridView.Columns.Add("civil_status", "Civil Status");
            HistoryGridView.Columns.Add("application_purpose", "Application Purpose");

            HistoryGridView.Columns["name"].Width = 150;
            HistoryGridView.Columns["purok_number"].Width = 75;
            HistoryGridView.Columns["house_number"].Width = 75;
            HistoryGridView.Columns["date_of_birth"].Width = 100;
            HistoryGridView.Columns["place_of_birth"].Width = 100;
            HistoryGridView.Columns["sex"].Width = 75;
            HistoryGridView.Columns["civil_status"].Width = 75;
            HistoryGridView.Columns["application_purpose"].Width = 125;

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM sheet WHERE is_approved = TRUE ORDER BY timestamp {sortOrder}";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();

                    Dictionary<string, List<object[]>> monthGroups = new Dictionary<string, List<object[]>>();

                    while (reader.Read())
                    {
                        string rawTimestamp = reader["timestamp"].ToString();

                        if (DateTime.TryParse(rawTimestamp, out DateTime dateTime))
                        {
                            string formattedTimestamp = dateTime.ToString("MMM dd, yyyy HH:mm:ss");
                            string monthKey = dateTime.ToString("MMMM yyyy");

                            if (!monthGroups.ContainsKey(monthKey))
                            {
                                monthGroups[monthKey] = new List<object[]>();
                            }

                            monthGroups[monthKey].Add(new object[]
                            {
                            formattedTimestamp,
                            reader["email_address"].ToString(),
                            reader["name"].ToString(),
                            reader["purok_number"].ToString(),
                            reader["house_number"].ToString(),
                            reader["date_of_birth"].ToString(),
                            reader["place_of_birth"].ToString(),
                            reader["sex"].ToString(),
                            reader["civil_status"].ToString(),
                            reader["application_purpose"].ToString()
                            });
                        }
                    }

                    // Add grouped data to the DataGridView
                    foreach (var monthGroup in monthGroups)
                    {
                        // Sort rows within the group by timestamp
                        var sortedRows = sortOrder == "DESC"
                            ? monthGroup.Value.OrderByDescending(row => DateTime.ParseExact(row[0].ToString(), "MMM dd, yyyy HH:mm:ss", null)).ToList()
                            : monthGroup.Value.OrderBy(row => DateTime.ParseExact(row[0].ToString(), "MMM dd, yyyy HH:mm:ss", null)).ToList();

                        MonthCombobox.Items.Add(monthGroup.Key); // Populate the Month Combobox

                        int rowIndex = HistoryGridView.Rows.Add();
                        DataGridViewRow headerRow = HistoryGridView.Rows[rowIndex];
                        headerRow.DefaultCellStyle.Font = new Font(HistoryGridView.Font, FontStyle.Bold);
                        headerRow.DefaultCellStyle.BackColor = Color.FromArgb(211, 203, 255);
                        headerRow.DefaultCellStyle.ForeColor = Color.FromArgb(71, 69, 94);
                        headerRow.Cells[0].Value = monthGroup.Key; // Set month header (e.g., "November 2024")
                        HistoryGridView.Rows[rowIndex].ReadOnly = true;

                        // Add all rows for the current month
                        foreach (var rowData in sortedRows)
                        {
                            HistoryGridView.Rows.Add(rowData);
                        }
                    }
                }
            }
            // Disable sorting on all columns
            foreach (DataGridViewColumn column in HistoryGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private static string sortOrder;
        private void RecentOldestCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RecentOldestCombobox.SelectedIndex == 0)
            {
                sortOrder = "DESC";
            }
            else
            {
                sortOrder = "ASC";
            }

            if (MonthCombobox.SelectedIndex == 0)
            {
                PopulateGridView();
            }
            else
            {
                SortMonth();
            }
        }

        private void SortMonth()
        {
            // Get the selected month
            string selectedMonth = MonthCombobox.SelectedItem.ToString();

            HistoryGridView.Rows.Clear();

            // Handle "All Months" selection
            if (selectedMonth == "-- All Months --")
            {
                PopulateGridView();
                return;
            }

            int rowIndex = HistoryGridView.Rows.Add();
            DataGridViewRow headerRow = HistoryGridView.Rows[rowIndex];
            headerRow.DefaultCellStyle.Font = new Font(HistoryGridView.Font, FontStyle.Bold);
            headerRow.DefaultCellStyle.BackColor = Color.FromArgb(211, 203, 255);
            headerRow.DefaultCellStyle.ForeColor = Color.FromArgb(71, 69, 94);
            headerRow.Cells[0].Value = selectedMonth; // Set month header (e.g., "November 2024")

            headerRow.Cells[1].Value = ""; // Clear other columns
            HistoryGridView.Rows[rowIndex].ReadOnly = true;

            List<object[]> rows = new List<object[]>(); // Store rows for sorting

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM sheet";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string rawTimestamp = reader["timestamp"].ToString();

                        // Check if the row's timestamp matches the selected month
                        if (DateTime.TryParse(rawTimestamp, out DateTime dateTime))
                        {
                            string formattedTimestamp = dateTime.ToString("MMM dd, yyyy HH:mm:ss");
                            string monthKey = dateTime.ToString("MMMM yyyy");
                            if (monthKey == selectedMonth)
                            {
                                // Add matching row to the list for later sorting
                                rows.Add(new object[]
                                {
                            formattedTimestamp,
                            reader["email_address"].ToString(),
                            reader["name"].ToString(),
                            reader["purok_number"].ToString(),
                            reader["house_number"].ToString(),
                            reader["date_of_birth"].ToString(),
                            reader["place_of_birth"].ToString(),
                            reader["sex"].ToString(),
                            reader["civil_status"].ToString(),
                            reader["application_purpose"].ToString()
                                });
                            }
                        }
                    }
                }
            }

            // Sort the rows by timestamp
            var sortedRows = sortOrder == "DESC"
                ? rows.OrderByDescending(row => DateTime.ParseExact(row[0].ToString(), "MMM dd, yyyy HH:mm:ss", null)).ToList()
                : rows.OrderBy(row => DateTime.ParseExact(row[0].ToString(), "MMM dd, yyyy HH:mm:ss", null)).ToList();

            // Add sorted rows to the DataGridView
            foreach (var rowData in sortedRows)
            {
                HistoryGridView.Rows.Add(rowData);
            }
        }


        private void MonthCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortMonth();
        }
    }
}
