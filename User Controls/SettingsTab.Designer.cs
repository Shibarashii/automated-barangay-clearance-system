namespace Barangay_Clearance_System.User_Controls
{
    partial class SettingsTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsTab));
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.InfoIcon = new System.Windows.Forms.PictureBox();
            this.HistoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.ChangePasswordButton = new Guna.UI2.WinForms.Guna2Button();
            this.ChangeJSONFileButton = new Guna.UI2.WinForms.Guna2Button();
            this.RecoveryButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.SettingsLabel.Location = new System.Drawing.Point(80, 50);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(106, 32);
            this.SettingsLabel.TabIndex = 10;
            this.SettingsLabel.Text = "Settings";
            // 
            // InfoIcon
            // 
            this.InfoIcon.Image = ((System.Drawing.Image)(resources.GetObject("InfoIcon.Image")));
            this.InfoIcon.Location = new System.Drawing.Point(44, 52);
            this.InfoIcon.Name = "InfoIcon";
            this.InfoIcon.Size = new System.Drawing.Size(30, 30);
            this.InfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoIcon.TabIndex = 9;
            this.InfoIcon.TabStop = false;
            // 
            // HistoryButton
            // 
            this.HistoryButton.Animated = true;
            this.HistoryButton.BorderColor = System.Drawing.Color.Gray;
            this.HistoryButton.BorderRadius = 10;
            this.HistoryButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            this.HistoryButton.CheckedState.Parent = this.HistoryButton;
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.HistoryButton.CustomBorderColor = System.Drawing.Color.Gray;
            this.HistoryButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.HistoryButton.CustomImages.Parent = this.HistoryButton;
            this.HistoryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.HistoryButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.HistoryButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.HistoryButton.HoverState.Parent = this.HistoryButton;
            this.HistoryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HistoryButton.ImageSize = new System.Drawing.Size(25, 25);
            this.HistoryButton.Location = new System.Drawing.Point(44, 128);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.PressedColor = System.Drawing.Color.Transparent;
            this.HistoryButton.PressedDepth = 0;
            this.HistoryButton.ShadowDecoration.Parent = this.HistoryButton;
            this.HistoryButton.Size = new System.Drawing.Size(666, 57);
            this.HistoryButton.TabIndex = 11;
            this.HistoryButton.Text = "General";
            this.HistoryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Animated = true;
            this.ChangePasswordButton.BorderColor = System.Drawing.Color.Gray;
            this.ChangePasswordButton.BorderRadius = 10;
            this.ChangePasswordButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            this.ChangePasswordButton.CheckedState.Parent = this.ChangePasswordButton;
            this.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordButton.CustomBorderColor = System.Drawing.Color.Gray;
            this.ChangePasswordButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ChangePasswordButton.CustomImages.Parent = this.ChangePasswordButton;
            this.ChangePasswordButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ChangePasswordButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.ChangePasswordButton.HoverState.Parent = this.ChangePasswordButton;
            this.ChangePasswordButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangePasswordButton.Image")));
            this.ChangePasswordButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChangePasswordButton.ImageSize = new System.Drawing.Size(25, 25);
            this.ChangePasswordButton.Location = new System.Drawing.Point(44, 185);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.ChangePasswordButton.ShadowDecoration.Parent = this.ChangePasswordButton;
            this.ChangePasswordButton.Size = new System.Drawing.Size(666, 57);
            this.ChangePasswordButton.TabIndex = 12;
            this.ChangePasswordButton.Text = "Change Password";
            this.ChangePasswordButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChangePasswordButton.TextOffset = new System.Drawing.Point(6, 0);
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangeJSONFileButton
            // 
            this.ChangeJSONFileButton.Animated = true;
            this.ChangeJSONFileButton.BorderColor = System.Drawing.Color.Gray;
            this.ChangeJSONFileButton.BorderRadius = 10;
            this.ChangeJSONFileButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            this.ChangeJSONFileButton.CheckedState.Parent = this.ChangeJSONFileButton;
            this.ChangeJSONFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeJSONFileButton.CustomBorderColor = System.Drawing.Color.Gray;
            this.ChangeJSONFileButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ChangeJSONFileButton.CustomImages.Parent = this.ChangeJSONFileButton;
            this.ChangeJSONFileButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ChangeJSONFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeJSONFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.ChangeJSONFileButton.HoverState.Parent = this.ChangeJSONFileButton;
            this.ChangeJSONFileButton.Image = ((System.Drawing.Image)(resources.GetObject("ChangeJSONFileButton.Image")));
            this.ChangeJSONFileButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChangeJSONFileButton.ImageSize = new System.Drawing.Size(30, 30);
            this.ChangeJSONFileButton.Location = new System.Drawing.Point(44, 242);
            this.ChangeJSONFileButton.Name = "ChangeJSONFileButton";
            this.ChangeJSONFileButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.ChangeJSONFileButton.ShadowDecoration.Parent = this.ChangeJSONFileButton;
            this.ChangeJSONFileButton.Size = new System.Drawing.Size(666, 57);
            this.ChangeJSONFileButton.TabIndex = 13;
            this.ChangeJSONFileButton.Text = "Change JSON File";
            this.ChangeJSONFileButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChangeJSONFileButton.TextOffset = new System.Drawing.Point(4, 0);
            this.ChangeJSONFileButton.Click += new System.EventHandler(this.ChangeJSONFileButton_Click_1);
            // 
            // RecoveryButton
            // 
            this.RecoveryButton.Animated = true;
            this.RecoveryButton.BorderColor = System.Drawing.Color.Gray;
            this.RecoveryButton.BorderRadius = 10;
            this.RecoveryButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            this.RecoveryButton.CheckedState.Parent = this.RecoveryButton;
            this.RecoveryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecoveryButton.CustomBorderColor = System.Drawing.Color.Gray;
            this.RecoveryButton.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.RecoveryButton.CustomImages.Parent = this.RecoveryButton;
            this.RecoveryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.RecoveryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoveryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.RecoveryButton.HoverState.Parent = this.RecoveryButton;
            this.RecoveryButton.Image = ((System.Drawing.Image)(resources.GetObject("RecoveryButton.Image")));
            this.RecoveryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RecoveryButton.ImageSize = new System.Drawing.Size(25, 25);
            this.RecoveryButton.Location = new System.Drawing.Point(44, 299);
            this.RecoveryButton.Name = "RecoveryButton";
            this.RecoveryButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.RecoveryButton.ShadowDecoration.Parent = this.RecoveryButton;
            this.RecoveryButton.Size = new System.Drawing.Size(666, 57);
            this.RecoveryButton.TabIndex = 14;
            this.RecoveryButton.Text = "Create Recovery Key";
            this.RecoveryButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RecoveryButton.TextOffset = new System.Drawing.Point(6, 0);
            this.RecoveryButton.Click += new System.EventHandler(this.RecoveryButton_Click);
            // 
            // SettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.RecoveryButton);
            this.Controls.Add(this.ChangeJSONFileButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.InfoIcon);
            this.Name = "SettingsTab";
            this.Size = new System.Drawing.Size(1130, 649);
            ((System.ComponentModel.ISupportInitialize)(this.InfoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.PictureBox InfoIcon;
        public Guna.UI2.WinForms.Guna2Button HistoryButton;
        public Guna.UI2.WinForms.Guna2Button ChangePasswordButton;
        public Guna.UI2.WinForms.Guna2Button ChangeJSONFileButton;
        public Guna.UI2.WinForms.Guna2Button RecoveryButton;
    }
}
