using Google.Apis.Sheets.v4;
using System;
using System.Data.SQLite;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.Linq;
using System.Windows.Forms;
using Google.Apis.Sheets.v4.Data;
using System.Collections.Generic;

namespace Barangay_Clearance_System
{
    public class GoogleSheets
    {
        private static readonly string[] scopes = { SheetsService.Scope.Spreadsheets };
        private static readonly string applicationName = "BarangayClearance";
        public static string spreadSheetID;
        public static string range;

        public static void FetchDataAndInsert()
        {
            if (spreadSheetID == null ||  range == null)
            {
                MessageBox.Show("Please set the spreadsheet ID and range first in settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Authenticate with the Google Sheets API using the provided JSON file
            var credential = GoogleCredential.FromFile(Main.JSONFilePath).CreateScoped(scopes);

            // Create the Sheets API service
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName,
            });

            var request = service.Spreadsheets.Values.Get(spreadSheetID, range);
            var response = request.Execute();
            var values = response.Values;

            if (values != null && values.Count > 0)
            {
                Main.UpdateRecords();

                foreach (var row in values)
                {
                    string timestamp = row.ElementAtOrDefault(0)?.ToString() ?? string.Empty;
                    string emailAddress = row.ElementAtOrDefault(1)?.ToString() ?? string.Empty;
                    string name = row.ElementAtOrDefault(2)?.ToString() ?? string.Empty;
                    string purokNumber = row.ElementAtOrDefault(3)?.ToString() ?? string.Empty;
                    string houseNumber = row.ElementAtOrDefault(4)?.ToString() ?? string.Empty;
                    string dateOfBirth = row.ElementAtOrDefault(5)?.ToString() ?? string.Empty;
                    string placeOfBirth = row.ElementAtOrDefault(6)?.ToString() ?? string.Empty;
                    string sex = row.ElementAtOrDefault(7)?.ToString() ?? string.Empty;
                    string civilStatus = row.ElementAtOrDefault(8)?.ToString() ?? string.Empty;
                    string applicationPurpose = row.ElementAtOrDefault(9)?.ToString() ?? string.Empty;

                    InsertIntoDatabase(timestamp, emailAddress, name, purokNumber, houseNumber, dateOfBirth, placeOfBirth, sex, civilStatus, applicationPurpose);
                }
                MessageBox.Show("Local Database Synced to Google Forms.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No data found.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteEntry(string timestamp)
        {
            try
            {
                var credential = GoogleCredential.FromFile(Main.JSONFilePath).CreateScoped(scopes);

                var service = new SheetsService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = applicationName,
                });

                var spreadsheet = service.Spreadsheets.Get(spreadSheetID).Execute();
                var sheetId = spreadsheet.Sheets[0].Properties.SheetId;  // Getting SheetId of the first sheet

                var request = service.Spreadsheets.Values.Get(spreadSheetID, range);
                var response = request.Execute();
                var values = response.Values;

                int rowIndex = -1;
                for (int i = 0; i < values.Count; i++)
                {
                    if (values[i][0].ToString() == timestamp)
                    {
                        rowIndex = i + 1;
                        break;
                    }
                }

                if (rowIndex != -1)
                {
                    var deleteRequest = service.Spreadsheets.BatchUpdate(new BatchUpdateSpreadsheetRequest()
                    {
                        Requests = new List<Request>
                        {
                            new Request
                            {
                                DeleteDimension = new DeleteDimensionRequest
                                {
                                    Range = new DimensionRange
                                    {
                                        SheetId = sheetId,  // Using dynamic SheetId
                                        Dimension = "ROWS", // Deleting rows
                                        StartIndex = rowIndex, // Corrected: subtract 1 for 0-based index
                                        EndIndex = rowIndex + 1    // EndIndex is exclusive, so this is fine
                                    }
                                }
                            }
                        }
                    }, spreadSheetID);

                    // Execute the request
                    deleteRequest.Execute();
                    MessageBox.Show("Entry deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Entry not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Delete entry from local database
                using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM sheet WHERE timestamp = @timestamp;";
                    using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@timestamp", timestamp);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static void InsertIntoDatabase(string timestamp, string emailAddress, string name, string purokNumber, string houseNumber, string dateOfBirth, string placeOfBirth, string sex, string civilStatus, string applicationPurpose)
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM sheet WHERE timestamp = @timestamp";
                    using (SQLiteCommand checkCommand = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@timestamp", timestamp);

                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (count == 0)
                        {
                            string query = @"
                        INSERT INTO sheet (timestamp, email_address, name, purok_number, house_number, date_of_birth, place_of_birth, sex, civil_status, application_purpose)
                        VALUES (@timestamp, @emailAddress, @name, @purokNumber, @houseNumber, @dateOfBirth, @placeOfBirth, @sex, @civilStatus, @applicationPurpose)";

                            using (SQLiteCommand command = new SQLiteCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@timestamp", timestamp);
                                command.Parameters.AddWithValue("@emailAddress", emailAddress);
                                command.Parameters.AddWithValue("@name", name);
                                command.Parameters.AddWithValue("@purokNumber", purokNumber);
                                command.Parameters.AddWithValue("@houseNumber", houseNumber);
                                command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                                command.Parameters.AddWithValue("@placeOfBirth", placeOfBirth);
                                command.Parameters.AddWithValue("@sex", sex);
                                command.Parameters.AddWithValue("@civilStatus", civilStatus);
                                command.Parameters.AddWithValue("@applicationPurpose", applicationPurpose);

                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
