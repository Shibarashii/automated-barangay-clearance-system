using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Barangay_Clearance_System.User_Controls
{
    public partial class HistoryTab : UserControl
    {
        public HistoryTab()
        {
            InitializeComponent();
            sortOrder = "DESC"; // Initialize for descending order

            PopulateGridView();

            HistoryGridView.AllowUserToResizeRows = false;
            HistoryGridView.ReadOnly = true;
            HistoryGridView.MultiSelect = false;

            FilterCombobox.SelectedIndex = 0; // Default to "All Records"
        }

        public static void PopulateGridView()
        {
            HistoryGridView.Columns.Clear();
            HistoryGridView.Rows.Clear();

            HistoryGridView.Columns.Add("timestamp", "Date");
            HistoryGridView.Columns.Add("email_address", "Contact Information");
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

            LoadRecords(null, null);
        }

        private static string sortOrder;

        private void RecentOldestCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortOrder = RecentOldestCombobox.SelectedIndex == 0 ? "DESC" : "ASC";
            ApplyFilters();
        }

        private void FilterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string filterType = FilterCombobox.SelectedItem.ToString();
            DateTime? startDate = null;
            DateTime? endDate = null;

            if (filterType == "This Day")
            {
                startDate = DateTime.Now.Date;
                endDate = startDate.Value.AddDays(1).AddTicks(-1);
            }
            else if (filterType == "This Week")
            {
                startDate = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
                endDate = startDate.Value.AddDays(7).AddTicks(-1);
            }
            else if (filterType == "This Month")
            {
                startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                endDate = startDate.Value.AddMonths(1).AddTicks(-1);
            }
            else if (filterType == "This Year")
            {
                startDate = new DateTime(DateTime.Now.Year, 1, 1);
                endDate = startDate.Value.AddYears(1).AddTicks(-1);
            }

            LoadRecords(startDate, endDate);
        }


        private static void LoadRecords(DateTime? startDate, DateTime? endDate)
        {
            HistoryGridView.Rows.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM sheet WHERE is_approved = TRUE";

                if (startDate.HasValue && endDate.HasValue)
                {
                    query += " AND timestamp BETWEEN @startDate AND @endDate";
                }

                query += $" ORDER BY timestamp {sortOrder}";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    if (startDate.HasValue && endDate.HasValue)
                    {
                        command.Parameters.AddWithValue("@startDate", startDate.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                        command.Parameters.AddWithValue("@endDate", endDate.Value.ToString("MM/dd/yyyy HH:mm:ss"));
                    }

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

                    var sortedMonthGroups = sortOrder == "DESC"
                    ? monthGroups.OrderByDescending(group => DateTime.ParseExact(group.Key, "MMMM yyyy", null))
                    : monthGroups.OrderBy(group => DateTime.ParseExact(group.Key, "MMMM yyyy", null));

                    foreach (var monthGroup in sortedMonthGroups)
                    {
                        // Add a header row for the month
                        int rowIndex = HistoryGridView.Rows.Add();
                        DataGridViewRow headerRow = HistoryGridView.Rows[rowIndex];
                        headerRow.DefaultCellStyle.Font = new Font(HistoryGridView.Font, FontStyle.Bold);
                        headerRow.DefaultCellStyle.BackColor = Color.FromArgb(211, 203, 255);
                        headerRow.DefaultCellStyle.ForeColor = Color.FromArgb(71, 69, 94);
                        headerRow.Cells[0].Value = monthGroup.Key; // Month-Year (e.g., "February 2021")
                        HistoryGridView.Rows[rowIndex].ReadOnly = true;

                        // Sort and add all rows for this month
                        var sortedRows = sortOrder == "DESC"
                            ? monthGroup.Value.OrderByDescending(row => DateTime.ParseExact(row[0].ToString(), "MMM dd, yyyy HH:mm:ss", null)).ToList()
                            : monthGroup.Value.OrderBy(row => DateTime.ParseExact(row[0].ToString(), "MMM dd, yyyy HH:mm:ss", null)).ToList();

                        foreach (var rowData in sortedRows)
                        {
                            HistoryGridView.Rows.Add(rowData);
                        }
                    }

                }
            }

            foreach (DataGridViewColumn column in HistoryGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            bool hasRows = HistoryGridView.Rows.Cast<DataGridViewRow>().Any(row => !row.IsNewRow);

            if (!hasRows)
            {
                MessageBox.Show("There are no records to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Exported Data";
                saveFileDialog.FileName = "";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("History");

                            // Add headers
                            for (int col = 0; col < HistoryGridView.Columns.Count; col++)
                            {
                                worksheet.Cell(1, col + 1).Value = HistoryGridView.Columns[col].HeaderText;
                            }

                            // Add rows
                            int currentRow = 2;
                            foreach (DataGridViewRow row in HistoryGridView.Rows)
                            {
                                if (row.IsNewRow) continue;

                                for (int col = 0; col < HistoryGridView.Columns.Count; col++)
                                {
                                    var cellValue = row.Cells[col].Value;
                                    worksheet.Cell(currentRow, col + 1).Value = cellValue?.ToString() ?? string.Empty;
                                }

                                currentRow++;
                            }

                            // Save the file
                            workbook.SaveAs(saveFileDialog.FileName);
                        }

                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
