using Google.Apis.Sheets.v4;
using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System.Linq;
using System.Windows.Forms;
using Barangay_Clearance_System.User_Controls;

namespace Barangay_Clearance_System
{
    public class GoogleSheets
    {
        private static readonly string[] scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        private static readonly string applicationName = "BarangayClearance";
        private static readonly string spreadSheetID = "1ONH2Kxfurs0xAw62E8rLBIdCN6EqCy37z34y3qQCerk";
        private static readonly string range = "Form Responses 1!A2:J";

        public static void FetchDataAndInsert()
        {
            try
            {
                // Retrieve the embedded JSON content
                string jsonContent = GetEmbeddedJson();

                // Save it to a temporary file
                string tempPath = Path.Combine(Path.GetTempPath(), "service-account.json");
                File.WriteAllText(tempPath, jsonContent);

                // Authenticate with the Google Sheets API using the temporary JSON file
                var credential = GoogleCredential.FromFile(tempPath).CreateScoped(scopes);

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
                    InitializeDatabase();

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
                }
                else
                {
                    MessageBox.Show("No data found.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}. Check your internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static void InitializeDatabase()
        {
            try
            {
                if (File.Exists(Main.databasePath))
                {
                    File.Delete(Main.databasePath); // Delete the database file
                }

                // Create a new database file
                SQLiteConnection.CreateFile(Main.databasePath);
                MessageBox.Show("Local database synced to Google Sheets.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
                {
                    connection.Open();
                    string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS sheet (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    timestamp TEXT UNIQUE NOT NULL,
                    email_address TEXT NOT NULL,
                    name TEXT NOT NULL,
                    purok_number TEXT NOT NULL,
                    house_number TEXT,
                    date_of_birth TEXT NOT NULL,
                    place_of_birth TEXT NOT NULL,
                    sex TEXT NOT NULL,
                    civil_status TEXT NOT NULL,
                    application_purpose TEXT NOT NULL
                );";
                    using (SQLiteCommand command = new SQLiteCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static string GetEmbeddedJson()
        {
            string resourceName = "Barangay_Clearance_System.Resources.key.json";
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
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
