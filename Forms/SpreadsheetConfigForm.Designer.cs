namespace Barangay_Clearance_System.Forms
{
    partial class SpreadsheetConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetConfigForm));
            this.SaveChangesButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            RangeTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ChangePasswordLabel = new System.Windows.Forms.Label();
            this.KeyIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            SpreadsheetIDTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesButton.CheckedState.Parent = this.SaveChangesButton;
            this.SaveChangesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveChangesButton.CustomImages.Parent = this.SaveChangesButton;
            this.SaveChangesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.SaveChangesButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.White;
            this.SaveChangesButton.HoverState.Parent = this.SaveChangesButton;
            this.SaveChangesButton.Location = new System.Drawing.Point(420, 369);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.ShadowDecoration.Parent = this.SaveChangesButton;
            this.SaveChangesButton.Size = new System.Drawing.Size(188, 45);
            this.SaveChangesButton.TabIndex = 29;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Range";
            // 
            // RangeTextbox
            // 
            RangeTextbox.Animated = true;
            RangeTextbox.AutoSize = true;
            RangeTextbox.BorderColor = System.Drawing.Color.Black;
            RangeTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            RangeTextbox.DefaultText = "";
            RangeTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            RangeTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            RangeTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            RangeTextbox.DisabledState.Parent = RangeTextbox;
            RangeTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            RangeTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            RangeTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            RangeTextbox.FocusedState.Parent = RangeTextbox;
            RangeTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RangeTextbox.ForeColor = System.Drawing.Color.Black;
            RangeTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            RangeTextbox.HoverState.Parent = RangeTextbox;
            RangeTextbox.Location = new System.Drawing.Point(185, 239);
            RangeTextbox.Margin = new System.Windows.Forms.Padding(5);
            RangeTextbox.Name = "RangeTextbox";
            RangeTextbox.PasswordChar = '\0';
            RangeTextbox.PlaceholderText = "";
            RangeTextbox.SelectedText = "";
            RangeTextbox.ShadowDecoration.Parent = RangeTextbox;
            RangeTextbox.Size = new System.Drawing.Size(423, 34);
            RangeTextbox.TabIndex = 25;
            // 
            // ChangePasswordLabel
            // 
            this.ChangePasswordLabel.AutoSize = true;
            this.ChangePasswordLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.ChangePasswordLabel.Location = new System.Drawing.Point(73, 29);
            this.ChangePasswordLabel.Name = "ChangePasswordLabel";
            this.ChangePasswordLabel.Size = new System.Drawing.Size(320, 32);
            this.ChangePasswordLabel.TabIndex = 24;
            this.ChangePasswordLabel.Text = "Spreadsheet Configuration";
            // 
            // KeyIcon
            // 
            this.KeyIcon.Image = ((System.Drawing.Image)(resources.GetObject("KeyIcon.Image")));
            this.KeyIcon.Location = new System.Drawing.Point(37, 31);
            this.KeyIcon.Name = "KeyIcon";
            this.KeyIcon.Size = new System.Drawing.Size(30, 30);
            this.KeyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KeyIcon.TabIndex = 23;
            this.KeyIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Spreadsheet ID";
            // 
            // SpreadsheetIDTextbox
            // 
            SpreadsheetIDTextbox.Animated = true;
            SpreadsheetIDTextbox.AutoSize = true;
            SpreadsheetIDTextbox.BorderColor = System.Drawing.Color.Black;
            SpreadsheetIDTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            SpreadsheetIDTextbox.DefaultText = "";
            SpreadsheetIDTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            SpreadsheetIDTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            SpreadsheetIDTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            SpreadsheetIDTextbox.DisabledState.Parent = SpreadsheetIDTextbox;
            SpreadsheetIDTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            SpreadsheetIDTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            SpreadsheetIDTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            SpreadsheetIDTextbox.FocusedState.Parent = SpreadsheetIDTextbox;
            SpreadsheetIDTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SpreadsheetIDTextbox.ForeColor = System.Drawing.Color.Black;
            SpreadsheetIDTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            SpreadsheetIDTextbox.HoverState.Parent = SpreadsheetIDTextbox;
            SpreadsheetIDTextbox.Location = new System.Drawing.Point(185, 158);
            SpreadsheetIDTextbox.Margin = new System.Windows.Forms.Padding(5);
            SpreadsheetIDTextbox.Name = "SpreadsheetIDTextbox";
            SpreadsheetIDTextbox.PasswordChar = '\0';
            SpreadsheetIDTextbox.PlaceholderText = "";
            SpreadsheetIDTextbox.SelectedText = "";
            SpreadsheetIDTextbox.ShadowDecoration.Parent = SpreadsheetIDTextbox;
            SpreadsheetIDTextbox.Size = new System.Drawing.Size(423, 34);
            SpreadsheetIDTextbox.TabIndex = 21;
            // 
            // SpreadsheetConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(RangeTextbox);
            this.Controls.Add(this.ChangePasswordLabel);
            this.Controls.Add(this.KeyIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(SpreadsheetIDTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpreadsheetConfigForm";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spreadsheet Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.KeyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button SaveChangesButton;
        private System.Windows.Forms.Label label2;
        public static Guna.UI2.WinForms.Guna2TextBox RangeTextbox;
        private System.Windows.Forms.Label ChangePasswordLabel;
        private System.Windows.Forms.PictureBox KeyIcon;
        private System.Windows.Forms.Label label1;
        public static Guna.UI2.WinForms.Guna2TextBox SpreadsheetIDTextbox;
    }
}