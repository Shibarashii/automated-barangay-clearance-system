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
            this.AboutButton = new Guna.UI2.WinForms.Guna2Button();
            this.HistoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.GoogleFormsButton = new Guna.UI2.WinForms.Guna2Button();
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
            this.SidebarColorFill.Controls.Add(this.AboutButton);
            this.SidebarColorFill.Controls.Add(this.HistoryButton);
            this.SidebarColorFill.Controls.Add(this.GoogleFormsButton);
            this.SidebarColorFill.Controls.Add(BarangayClearanceButton);
            this.SidebarColorFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidebarColorFill.Location = new System.Drawing.Point(0, 0);
            this.SidebarColorFill.Name = "SidebarColorFill";
            this.SidebarColorFill.Size = new System.Drawing.Size(225, 729);
            this.SidebarColorFill.TabIndex = 0;
            // 
            // AboutButton
            // 
            this.AboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AboutButton.Animated = true;
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.BorderRadius = 10;
            this.AboutButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AboutButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            this.AboutButton.CheckedState.Parent = this.AboutButton;
            this.AboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutButton.CustomImages.Parent = this.AboutButton;
            this.AboutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            this.AboutButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.White;
            this.AboutButton.HoverState.Parent = this.AboutButton;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AboutButton.ImageSize = new System.Drawing.Size(30, 30);
            this.AboutButton.Location = new System.Drawing.Point(7, 653);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.ShadowDecoration.Parent = this.AboutButton;
            this.AboutButton.Size = new System.Drawing.Size(208, 57);
            this.AboutButton.TabIndex = 4;
            this.AboutButton.Text = "About";
            this.AboutButton.TextOffset = new System.Drawing.Point(6, 0);
            this.AboutButton.CheckedChanged += new System.EventHandler(this.AboutButton_CheckedChanged);
            // 
            // HistoryButton
            // 
            this.HistoryButton.Animated = true;
            this.HistoryButton.BorderRadius = 10;
            this.HistoryButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HistoryButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            this.HistoryButton.CheckedState.Parent = this.HistoryButton;
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.CustomImages.Parent = this.HistoryButton;
            this.HistoryButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            this.HistoryButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.HoverState.Parent = this.HistoryButton;
            this.HistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoryButton.Image")));
            this.HistoryButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HistoryButton.ImageSize = new System.Drawing.Size(25, 25);
            this.HistoryButton.Location = new System.Drawing.Point(7, 304);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.ShadowDecoration.Parent = this.HistoryButton;
            this.HistoryButton.Size = new System.Drawing.Size(208, 57);
            this.HistoryButton.TabIndex = 2;
            this.HistoryButton.Text = "History";
            this.HistoryButton.TextOffset = new System.Drawing.Point(6, 0);
            this.HistoryButton.CheckedChanged += new System.EventHandler(this.HistoryButton_CheckedChanged);
            // 
            // GoogleFormsButton
            // 
            this.GoogleFormsButton.Animated = true;
            this.GoogleFormsButton.BorderRadius = 10;
            this.GoogleFormsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.GoogleFormsButton.Checked = true;
            this.GoogleFormsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(187)))), ((int)(((byte)(251)))));
            this.GoogleFormsButton.CheckedState.Parent = this.GoogleFormsButton;
            this.GoogleFormsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoogleFormsButton.CustomImages.Parent = this.GoogleFormsButton;
            this.GoogleFormsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            this.GoogleFormsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleFormsButton.ForeColor = System.Drawing.Color.White;
            this.GoogleFormsButton.HoverState.Parent = this.GoogleFormsButton;
            this.GoogleFormsButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleFormsButton.Image")));
            this.GoogleFormsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.GoogleFormsButton.ImageSize = new System.Drawing.Size(25, 25);
            this.GoogleFormsButton.Location = new System.Drawing.Point(7, 241);
            this.GoogleFormsButton.Name = "GoogleFormsButton";
            this.GoogleFormsButton.ShadowDecoration.Parent = this.GoogleFormsButton;
            this.GoogleFormsButton.Size = new System.Drawing.Size(208, 57);
            this.GoogleFormsButton.TabIndex = 1;
            this.GoogleFormsButton.Text = "Google Forms";
            this.GoogleFormsButton.TextOffset = new System.Drawing.Point(6, 0);
            this.GoogleFormsButton.CheckedChanged += new System.EventHandler(this.GoogleFormsButton_CheckedChanged);
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
            BarangayClearanceButton.Text = "Barangay Clearance";
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
        public Guna.UI2.WinForms.Guna2Button GoogleFormsButton;
        public Guna.UI2.WinForms.Guna2Button HistoryButton;
        public Guna.UI2.WinForms.Guna2Button AboutButton;
        private Guna.UI2.WinForms.Guna2Panel LinePanel;
        public static Guna.UI2.WinForms.Guna2Button BarangayClearanceButton;
    }
}

