namespace Barangay_Clearance_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SidebarColorFill = new System.Windows.Forms.Panel();
            SettingsButton = new Guna.UI2.WinForms.Guna2Button();
            AboutButton = new Guna.UI2.WinForms.Guna2Button();
            RecordsButton = new Guna.UI2.WinForms.Guna2Button();
            FormResponsesButton = new Guna.UI2.WinForms.Guna2Button();
            BarangayClearanceButton = new Guna.UI2.WinForms.Guna2Button();
            this.Logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.DocumentIcon = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LinePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SidebarColorFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SidebarColorFill
            // 
            this.SidebarColorFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            this.SidebarColorFill.Controls.Add(SettingsButton);
            this.SidebarColorFill.Controls.Add(AboutButton);
            this.SidebarColorFill.Controls.Add(RecordsButton);
            this.SidebarColorFill.Controls.Add(FormResponsesButton);
            this.SidebarColorFill.Controls.Add(BarangayClearanceButton);
            this.SidebarColorFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarColorFill.Location = new System.Drawing.Point(0, 0);
            this.SidebarColorFill.Name = "SidebarColorFill";
            this.SidebarColorFill.Size = new System.Drawing.Size(225, 729);
            this.SidebarColorFill.TabIndex = 0;
            // 
            // SettingsButton
            // 
            SettingsButton.Animated = true;
            SettingsButton.BorderRadius = 10;
            SettingsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            SettingsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            SettingsButton.CheckedState.Parent = SettingsButton;
            SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            SettingsButton.CustomImages.Parent = SettingsButton;
            SettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            SettingsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SettingsButton.ForeColor = System.Drawing.Color.White;
            SettingsButton.HoverState.Parent = SettingsButton;
            SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            SettingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            SettingsButton.ImageSize = new System.Drawing.Size(25, 25);
            SettingsButton.Location = new System.Drawing.Point(7, 430);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.ShadowDecoration.Parent = SettingsButton;
            SettingsButton.Size = new System.Drawing.Size(208, 57);
            SettingsButton.TabIndex = 5;
            SettingsButton.Text = "Settings";
            SettingsButton.TextOffset = new System.Drawing.Point(6, 0);
            SettingsButton.CheckedChanged += new System.EventHandler(SettingsButton_CheckedChanged);
            // 
            // AboutButton
            // 
            AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            AboutButton.Animated = true;
            AboutButton.BackColor = System.Drawing.Color.Transparent;
            AboutButton.BorderRadius = 10;
            AboutButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            AboutButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            AboutButton.CheckedState.Parent = AboutButton;
            AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            AboutButton.CustomImages.Parent = AboutButton;
            AboutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            AboutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AboutButton.ForeColor = System.Drawing.Color.White;
            AboutButton.HoverState.Parent = AboutButton;
            AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            AboutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            AboutButton.ImageSize = new System.Drawing.Size(30, 30);
            AboutButton.Location = new System.Drawing.Point(7, 653);
            AboutButton.Name = "AboutButton";
            AboutButton.ShadowDecoration.Parent = AboutButton;
            AboutButton.Size = new System.Drawing.Size(208, 57);
            AboutButton.TabIndex = 4;
            AboutButton.Text = "About";
            AboutButton.TextOffset = new System.Drawing.Point(6, 0);
            AboutButton.CheckedChanged += new System.EventHandler(AboutButton_CheckedChanged);
            // 
            // RecordsButton
            // 
            RecordsButton.Animated = true;
            RecordsButton.BorderRadius = 10;
            RecordsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            RecordsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            RecordsButton.CheckedState.Parent = RecordsButton;
            RecordsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            RecordsButton.CustomImages.Parent = RecordsButton;
            RecordsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            RecordsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RecordsButton.ForeColor = System.Drawing.Color.White;
            RecordsButton.HoverState.Parent = RecordsButton;
            RecordsButton.Image = ((System.Drawing.Image)(resources.GetObject("RecordsButton.Image")));
            RecordsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            RecordsButton.ImageSize = new System.Drawing.Size(25, 25);
            RecordsButton.Location = new System.Drawing.Point(7, 304);
            RecordsButton.Name = "RecordsButton";
            RecordsButton.ShadowDecoration.Parent = RecordsButton;
            RecordsButton.Size = new System.Drawing.Size(208, 57);
            RecordsButton.TabIndex = 2;
            RecordsButton.Text = "Records";
            RecordsButton.TextOffset = new System.Drawing.Point(6, 0);
            RecordsButton.CheckedChanged += new System.EventHandler(this.HistoryButton_CheckedChanged);
            // 
            // FormResponsesButton
            // 
            FormResponsesButton.Animated = true;
            FormResponsesButton.BorderRadius = 10;
            FormResponsesButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            FormResponsesButton.Checked = true;
            FormResponsesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            FormResponsesButton.CheckedState.Parent = FormResponsesButton;
            FormResponsesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            FormResponsesButton.CustomImages.Parent = FormResponsesButton;
            FormResponsesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            FormResponsesButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FormResponsesButton.ForeColor = System.Drawing.Color.White;
            FormResponsesButton.HoverState.Parent = FormResponsesButton;
            FormResponsesButton.Image = ((System.Drawing.Image)(resources.GetObject("FormResponsesButton.Image")));
            FormResponsesButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            FormResponsesButton.ImageSize = new System.Drawing.Size(25, 25);
            FormResponsesButton.Location = new System.Drawing.Point(7, 241);
            FormResponsesButton.Name = "FormResponsesButton";
            FormResponsesButton.ShadowDecoration.Parent = FormResponsesButton;
            FormResponsesButton.Size = new System.Drawing.Size(208, 57);
            FormResponsesButton.TabIndex = 1;
            FormResponsesButton.Text = "Form Responses";
            FormResponsesButton.TextOffset = new System.Drawing.Point(6, 0);
            FormResponsesButton.CheckedChanged += new System.EventHandler(RecordsButton_CheckedChanged);
            // 
            // BarangayClearanceButton
            // 
            BarangayClearanceButton.Animated = true;
            BarangayClearanceButton.BorderRadius = 10;
            BarangayClearanceButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            BarangayClearanceButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            BarangayClearanceButton.CheckedState.Parent = BarangayClearanceButton;
            BarangayClearanceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            BarangayClearanceButton.CustomImages.Parent = BarangayClearanceButton;
            BarangayClearanceButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            BarangayClearanceButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BarangayClearanceButton.ForeColor = System.Drawing.Color.White;
            BarangayClearanceButton.HoverState.Parent = BarangayClearanceButton;
            BarangayClearanceButton.Image = ((System.Drawing.Image)(resources.GetObject("BarangayClearanceButton.Image")));
            BarangayClearanceButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            BarangayClearanceButton.ImageSize = new System.Drawing.Size(25, 25);
            BarangayClearanceButton.Location = new System.Drawing.Point(7, 367);
            BarangayClearanceButton.Name = "BarangayClearanceButton";
            BarangayClearanceButton.ShadowDecoration.Parent = BarangayClearanceButton;
            BarangayClearanceButton.Size = new System.Drawing.Size(208, 57);
            BarangayClearanceButton.TabIndex = 0;
            BarangayClearanceButton.Text = "Document";
            BarangayClearanceButton.TextOffset = new System.Drawing.Point(6, 0);
            BarangayClearanceButton.CheckedChanged += new System.EventHandler(BarangayClearanceButton_CheckedChanged);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Logo.ShadowDecoration.Parent = this.Logo;
            this.Logo.Size = new System.Drawing.Size(225, 225);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Sidebar
            // 
            this.Sidebar.Controls.Add(this.Logo);
            this.Sidebar.Controls.Add(this.SidebarColorFill);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(225, 729);
            this.Sidebar.TabIndex = 2;
            // 
            // DocumentIcon
            // 
            this.DocumentIcon.Image = ((System.Drawing.Image)(resources.GetObject("DocumentIcon.Image")));
            this.DocumentIcon.Location = new System.Drawing.Point(258, 30);
            this.DocumentIcon.Name = "DocumentIcon";
            this.DocumentIcon.Size = new System.Drawing.Size(50, 50);
            this.DocumentIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DocumentIcon.TabIndex = 11;
            this.DocumentIcon.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("IBM Plex Mono", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(1)))), ((int)(((byte)(250)))));
            this.TitleLabel.Location = new System.Drawing.Point(322, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(683, 42);
            this.TitleLabel.TabIndex = 10;
            this.TitleLabel.Text = "AUTOMATED BARANGAY CLEARANCE SYSTEM";
            // 
            // LinePanel
            // 
            this.LinePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinePanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.LinePanel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.LinePanel.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.LinePanel.Location = new System.Drawing.Point(258, 99);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.ShadowDecoration.Parent = this.LinePanel;
            this.LinePanel.Size = new System.Drawing.Size(1071, 10);
            this.LinePanel.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.DocumentIcon);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Sidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainForm";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateActive.Header.Border.Rounding = 15;
            this.Text = "Automated Barangay Clearance System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SidebarColorFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DocumentIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidebarColorFill;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Logo;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.PictureBox DocumentIcon;
        private System.Windows.Forms.Label TitleLabel;
        private Guna.UI2.WinForms.Guna2Panel LinePanel;
        public static Guna.UI2.WinForms.Guna2Button FormResponsesButton;
        public static Guna.UI2.WinForms.Guna2Button RecordsButton;
        public static Guna.UI2.WinForms.Guna2Button AboutButton;
        public static Guna.UI2.WinForms.Guna2Button SettingsButton;
        public static Guna.UI2.WinForms.Guna2Button BarangayClearanceButton;
    }
}

