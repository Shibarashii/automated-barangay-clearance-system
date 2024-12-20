using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.IO;
using System.Data.SqlClient;
using Barangay_Clearance_System.User_Controls;



namespace Barangay_Clearance_System
{
    public partial class AuthForm : KryptonForm
    {
        public AuthForm()
        {
            InitializeComponent();
            if (!File.Exists(Main.databasePath))
            {
                Main.InitializeDatabase();
            }
        }

        private bool VerifyPassword(string oldPassword)
        {
            string hashedOldPassword = HashPassword(oldPassword);

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(1) FROM settings WHERE password = @password";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", hashedOldPassword);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (!VerifyPassword(PasswordTextbox.Text) && !RecoveryToggle.Checked)
            {
                IncorrectPasswordLabel.Visible = true;
                return;
            }

            if (RecoveryToggle.Checked)
            {
                using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
                {
                    connection.Open();
                    using (SQLiteTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string CHECK_RECOVERY_CODE = "SELECT COUNT(*), is_used FROM recovery_codes WHERE code = @code";
                            using (SQLiteCommand command = new SQLiteCommand(CHECK_RECOVERY_CODE, connection, transaction))
                            {
                                command.Parameters.AddWithValue("@code", PasswordTextbox.Text);

                                using (SQLiteDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int count = reader.IsDBNull(0) ? 0 : Convert.ToInt32(reader[0]);
                                        bool isUsed = reader.IsDBNull(1) ? false : Convert.ToBoolean(reader[1]);

                                        if (count > 0 && !isUsed)
                                        {
                                            string UPDATE_RECOVERY_CODE = "UPDATE recovery_codes SET is_used = TRUE WHERE code = @code";
                                            using (SQLiteCommand updateCodeCommand = new SQLiteCommand(UPDATE_RECOVERY_CODE, connection, transaction))
                                            {
                                                updateCodeCommand.Parameters.AddWithValue("@code", PasswordTextbox.Text);
                                                updateCodeCommand.ExecuteNonQuery();
                                            }

                                            string defaultPassword = HashPassword("");
                                            string RESET_PASSWORD = $"UPDATE settings SET password = '{defaultPassword}'";
                                            using (SQLiteCommand resetPasswordCommand = new SQLiteCommand(RESET_PASSWORD, connection, transaction))
                                            {
                                                resetPasswordCommand.ExecuteNonQuery();
                                            }

                                            MessageBox.Show($"Recovery code {PasswordTextbox.Text} has been used. This code cannot be used again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            MessageBox.Show($"The password has been reset.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else if (count > 0 && isUsed)
                                        {
                                            MessageBox.Show("Recovery code already used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid recovery code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }
                            }

                            // Commit the transaction if all operations are successful
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }


            MainForm mainForm = new MainForm();
            mainForm.Show();
            Hide();
        }
    }
}
