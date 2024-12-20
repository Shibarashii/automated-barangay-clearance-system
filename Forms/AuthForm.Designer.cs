namespace Barangay_Clearance_System
{
    partial class AuthForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.LinePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DocumentIcon = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EnterButton = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IncorrectPasswordLabel = new System.Windows.Forms.Label();
            this.Developers = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RecoveryToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LinePanel
            // 
            this.LinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.LinePanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.LinePanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.LinePanel.Location = new System.Drawing.Point(20, 101);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.ShadowDecoration.Parent = this.LinePanel;
            this.LinePanel.Size = new System.Drawing.Size(749, 10);
            this.LinePanel.TabIndex = 16;
            // 
            // DocumentIcon
            // 
            this.DocumentIcon.Image = ((System.Drawing.Image)(resources.GetObject("DocumentIcon.Image")));
            this.DocumentIcon.Location = new System.Drawing.Point(22, 34);
            this.DocumentIcon.Name = "DocumentIcon";
            this.DocumentIcon.Size = new System.Drawing.Size(50, 50);
            this.DocumentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DocumentIcon.TabIndex = 15;
            this.DocumentIcon.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("IBM Plex Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            this.TitleLabel.Location = new System.Drawing.Point(86, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(683, 42);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "AUTOMATED BARANGAY CLEARANCE SYSTEM";
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterButton.CheckedState.Parent = this.EnterButton;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.CustomImages.Parent = this.EnterButton;
            this.EnterButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.EnterButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.HoverState.Parent = this.EnterButton;
            this.EnterButton.Location = new System.Drawing.Point(291, 310);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.ShadowDecoration.Parent = this.EnterButton;
            this.EnterButton.Size = new System.Drawing.Size(188, 45);
            this.EnterButton.TabIndex = 19;
            this.EnterButton.Text = "Enter";
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Animated = true;
            this.PasswordTextbox.AutoSize = true;
            this.PasswordTextbox.BorderColor = System.Drawing.Color.Black;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.FocusedState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.HoverState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.Location = new System.Drawing.Point(179, 199);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '•';
            this.PasswordTextbox.PlaceholderText = "";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.ShadowDecoration.Parent = this.PasswordTextbox;
            this.PasswordTextbox.Size = new System.Drawing.Size(423, 34);
            this.PasswordTextbox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter Password";
            // 
            // IncorrectPasswordLabel
            // 
            this.IncorrectPasswordLabel.AutoSize = true;
            this.IncorrectPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.IncorrectPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IncorrectPasswordLabel.Location = new System.Drawing.Point(610, 205);
            this.IncorrectPasswordLabel.Name = "IncorrectPasswordLabel";
            this.IncorrectPasswordLabel.Size = new System.Drawing.Size(141, 21);
            this.IncorrectPasswordLabel.TabIndex = 22;
            this.IncorrectPasswordLabel.Text = "Incorrect Password";
            this.IncorrectPasswordLabel.Visible = false;
            // 
            // Developers
            // 
            this.Developers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Developers.AutoSize = true;
            this.Developers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Developers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.Developers.Location = new System.Drawing.Point(12, 425);
            this.Developers.Name = "Developers";
            this.Developers.Size = new System.Drawing.Size(409, 16);
            this.Developers.TabIndex = 34;
            this.Developers.Text = "Developed by: LSPU-SCC BSCS 3B-IS Group 2 (BATCH 2024-2025)";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.VersionLabel.Location = new System.Drawing.Point(705, 425);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(83, 16);
            this.VersionLabel.TabIndex = 33;
            this.VersionLabel.Text = "Version 1.1.0";
            // 
            // RecoveryToggle
            // 
            this.RecoveryToggle.Animated = true;
            this.RecoveryToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.RecoveryToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.RecoveryToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RecoveryToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RecoveryToggle.CheckedState.Parent = this.RecoveryToggle;
            this.RecoveryToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecoveryToggle.Location = new System.Drawing.Point(444, 250);
            this.RecoveryToggle.Name = "RecoveryToggle";
            this.RecoveryToggle.ShadowDecoration.Parent = this.RecoveryToggle;
            this.RecoveryToggle.Size = new System.Drawing.Size(35, 20);
            this.RecoveryToggle.TabIndex = 36;
            this.RecoveryToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RecoveryToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RecoveryToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RecoveryToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.RecoveryToggle.UncheckedState.Parent = this.RecoveryToggle;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(308, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Use Recovery Code";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecoveryToggle);
            this.Controls.Add(this.Developers);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.IncorrectPasswordLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.DocumentIcon);
            this.Controls.Add(this.TitleLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)(this.DocumentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LinePanel;
        private System.Windows.Forms.PictureBox DocumentIcon;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2Button EnterButton;
        public Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IncorrectPasswordLabel;
        private System.Windows.Forms.Label Developers;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RecoveryToggle;
        private System.Windows.Forms.Label label2;
    }
}