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

namespace Barangay_Clearance_System
{
    public partial class ChangePasswordForm : KryptonForm
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void NewPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswords();
        }

        private void ConfirmPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswords();
        }

        private void OldPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            OldPasswordErrorLabel.Visible = false;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (PasswordNotMatchLabel.Visible)
            {
                MessageBox.Show("New Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verify the old password
            if (!VerifyOldPassword(OldPasswordTextbox.Text))
            {
                OldPasswordErrorLabel.Visible = true;
                return;
            }

            // Update the password
            UpdatePassword(NewPasswordTextbox.Text);
            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void ValidatePasswords()
        {
            if (NewPasswordTextbox.Text != ConfirmPasswordTextbox.Text &&
                !string.IsNullOrEmpty(NewPasswordTextbox.Text) &&
                !string.IsNullOrEmpty(ConfirmPasswordTextbox.Text))
            {
                PasswordNotMatchLabel.Visible = true;
                return;
            }
            PasswordNotMatchLabel.Visible = false;
        }

        private bool VerifyOldPassword(string oldPassword)
        {
            string hashedOldPassword = AuthForm.HashPassword(oldPassword);

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

        private void UpdatePassword(string newPassword)
        {
            string hashedNewPassword = AuthForm.HashPassword(newPassword);

            using (SQLiteConnection connection = new SQLiteConnection(Main.connectionString))
            {
                connection.Open();
                string query = "UPDATE settings SET password = @password WHERE id = 1"; // Assuming id = 1 for a single settings row
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@password", hashedNewPassword);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
