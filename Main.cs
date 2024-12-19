using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barangay_Clearance_System
{
    /* NOTE
        
        * PANGALANAN LAHAT NG TOOLS/COMPONENTS. GUMAMIT NG PascalCase PARA SA PANGALAN NG TOOLS

            Example:
                Sabihin nating gagawa kayo ng button. Pangalanan mo yung button base sa kung anong function nya.
                Halimbawa gagawa kayo ng button para sa pagprint. Ang ilalagay nyo sa name niya ay "PrintButton"

        * Sundin ang naming convention ng C# sa pagcode
        
            variables, fields, parameters = camelCase
            classes, functions, constants = PascalCase

        * Huwag kayong maglagay ng mga blank functions. Like pag ni-double click nyo yung label, automatically
        magcrecreate siya ng Label_Clicked na function. Kung wala namang ilalagay sa loob ng function na yun, tanggalin niyo nalang
        tas ayusin nyo yung designer after.

     */

    // Automated Barangay Clearance System
    // LSPU-SCC BSCS 3B-IS (BATCH 2024-2025)
    // An Automated Barangay Clearance System for Barangay Banago, created by the LSPU-SCC BSCS 3B-IS (BATCH 2024-2025)

    public class Main
    {
        public static readonly string databasePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "barangay_clearance.db"
        );

        public static readonly string JSONFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "service-account.json");
        public static readonly string connectionString = $@"Data Source={databasePath};Version=3;";

        public static void UpdateRecords()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Extract approved records before dropping the table
                List<Dictionary<string, object>> approvedRecords = new List<Dictionary<string, object>>();
                string selectApprovedQuery = "SELECT * FROM sheet WHERE is_approved = 1;";
                using (SQLiteCommand selectCommand = new SQLiteCommand(selectApprovedQuery, connection))
                using (SQLiteDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        approvedRecords.Add(row);
                    }
                }

                // Drop the "sheet" table if it exists
                string dropSheetTableQuery = "DROP TABLE IF EXISTS sheet;";
                using (SQLiteCommand dropCommand = new SQLiteCommand(dropSheetTableQuery, connection))
                {
                    dropCommand.ExecuteNonQuery();
                }

                // Create the "sheet" table
                string createSheetTableQuery = @"
                CREATE TABLE sheet (
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
                    application_purpose TEXT NOT NULL,
                    is_approved INTEGER DEFAULT 0,
                    is_archived INTEGER DEFAULT 0
                );";
                using (SQLiteCommand createCommand = new SQLiteCommand(createSheetTableQuery, connection))
                {
                    createCommand.ExecuteNonQuery();
                }

                string insertQuery = @"
                INSERT INTO sheet (
                    timestamp, email_address, name, purok_number, house_number, date_of_birth,
                    place_of_birth, sex, civil_status, application_purpose, is_approved, is_archived
                ) VALUES (
                    @timestamp, @EmailAddress, @Name, @PurokNumber, @HouseNumber, @DateOfBirth,
                    @PlaceOfBirth, @Sex, @CivilStatus, @ApplicationPurpose, @IsApproved, @IsArchived
                );";

                foreach (var record in approvedRecords)
                {
                    using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@timestamp", record.ContainsKey("timestamp") ? record["timestamp"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@EmailAddress", record.ContainsKey("email_address") ? record["email_address"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@Name", record.ContainsKey("name") ? record["name"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@PurokNumber", record.ContainsKey("purok_number") ? record["purok_number"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@HouseNumber", record.ContainsKey("house_number") ? record["house_number"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@DateOfBirth", record.ContainsKey("date_of_birth") ? record["date_of_birth"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@PlaceOfBirth", record.ContainsKey("place_of_birth") ? record["place_of_birth"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@Sex", record.ContainsKey("sex") ? record["sex"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@CivilStatus", record.ContainsKey("civil_status") ? record["civil_status"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@ApplicationPurpose", record.ContainsKey("application_purpose") ? record["application_purpose"] : DBNull.Value);
                        insertCommand.Parameters.AddWithValue("@IsApproved", record.ContainsKey("is_approved") ? record["is_approved"] : 0); // Default to 0
                        insertCommand.Parameters.AddWithValue("@IsArchived", record.ContainsKey("is_archived") ? record["is_archived"] : 0); // Default to 0

                        int count = insertCommand.ExecuteNonQuery();
                    }
                }

                connection.Close();
            }
        }


    public static void InitializeDatabase()
    {
        try
        {
            // Delete the database if it exists
            if (File.Exists(databasePath))
            {
                File.Delete(databasePath);
            }
            else
            {
                MessageBox.Show("Local Database Initialized.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Create a new database file
            SQLiteConnection.CreateFile(databasePath);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Create the "sheet" table
                string createSheetTableQuery = @"
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
                        application_purpose TEXT NOT NULL,
                        is_approved INTEGER DEFAULT 0,
                        is_archived INTEGER DEFAULT 0
                    );";

                using (SQLiteCommand command = new SQLiteCommand(createSheetTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string createSettingsTableQuery = @"
                    CREATE TABLE IF NOT EXISTS settings (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        password TEXT DEFAULT '',
                        config_json TEXT
                    );";

                using (SQLiteCommand command = new SQLiteCommand(createSettingsTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                string insertDefaultPasswordQuery = @"
                    INSERT INTO settings (password, config_json)
                    VALUES (@password, NULL)";
                using (SQLiteCommand command = new SQLiteCommand(insertDefaultPasswordQuery, connection))
                {
                    string defaultPassword = AuthForm.HashPassword(""); // Replace with an actual default password
                    command.Parameters.AddWithValue("@password", defaultPassword);
                    command.ExecuteNonQuery();
                }

                // Create the "recovery_codes" table
                string createRecoveryCodesTableQuery = @"
                    CREATE TABLE IF NOT EXISTS recovery_codes (
                        code TEXT NOT NULL,
                        is_used INTEGER NOT NULL DEFAULT 0,
                        PRIMARY KEY (code)
                    );";

                using (SQLiteCommand command = new SQLiteCommand(createRecoveryCodesTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Database initialization failed: {ex.Message}");
        }
    }
}
}
