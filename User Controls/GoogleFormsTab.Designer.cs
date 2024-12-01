namespace Barangay_Clearance_System.User_Controls
{
    partial class GoogleFormsTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleFormsTab));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.DataGridViewPanel = new System.Windows.Forms.Panel();
            DatabaseGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SearchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.HardDriveIcon1 = new System.Windows.Forms.PictureBox();
            this.GoogleFormsLabel = new System.Windows.Forms.Label();
            this.ImportButton = new Guna.UI2.WinForms.Guna2Button();
            this.FormPanel.SuspendLayout();
            this.DataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(DatabaseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPanel.Controls.Add(this.DataGridViewPanel);
            this.FormPanel.Controls.Add(this.SearchTextbox);
            this.FormPanel.Controls.Add(this.HardDriveIcon1);
            this.FormPanel.Controls.Add(this.GoogleFormsLabel);
            this.FormPanel.Controls.Add(this.ImportButton);
            this.FormPanel.Location = new System.Drawing.Point(41, 59);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(1068, 569);
            this.FormPanel.TabIndex = 9;
            // 
            // DataGridViewPanel
            // 
            this.DataGridViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataGridViewPanel.Controls.Add(DatabaseGridView);
            this.DataGridViewPanel.Location = new System.Drawing.Point(0, 35);
            this.DataGridViewPanel.Name = "DataGridViewPanel";
            this.DataGridViewPanel.Size = new System.Drawing.Size(1065, 461);
            this.DataGridViewPanel.TabIndex = 11;
            // 
            // DatabaseGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            DatabaseGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DatabaseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DatabaseGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            DatabaseGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            DatabaseGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DatabaseGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DatabaseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DatabaseGridView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DatabaseGridView.DefaultCellStyle = dataGridViewCellStyle3;
            DatabaseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            DatabaseGridView.EnableHeadersVisualStyles = false;
            DatabaseGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            DatabaseGridView.Location = new System.Drawing.Point(0, 0);
            DatabaseGridView.Name = "DatabaseGridView";
            DatabaseGridView.ReadOnly = true;
            DatabaseGridView.RowHeadersVisible = false;
            DatabaseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DatabaseGridView.Size = new System.Drawing.Size(1063, 459);
            DatabaseGridView.TabIndex = 12;
            DatabaseGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            DatabaseGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            DatabaseGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            DatabaseGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            DatabaseGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            DatabaseGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            DatabaseGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            DatabaseGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            DatabaseGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            DatabaseGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            DatabaseGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            DatabaseGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            DatabaseGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DatabaseGridView.ThemeStyle.HeaderStyle.Height = 50;
            DatabaseGridView.ThemeStyle.ReadOnly = true;
            DatabaseGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            DatabaseGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DatabaseGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            DatabaseGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            DatabaseGridView.ThemeStyle.RowsStyle.Height = 22;
            DatabaseGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            DatabaseGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextbox.Animated = true;
            this.SearchTextbox.AutoSize = true;
            this.SearchTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextbox.BorderRadius = 10;
            this.SearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextbox.DefaultText = "";
            this.SearchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextbox.DisabledState.Parent = this.SearchTextbox;
            this.SearchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.SearchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextbox.FocusedState.Parent = this.SearchTextbox;
            this.SearchTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextbox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextbox.HoverState.Parent = this.SearchTextbox;
            this.SearchTextbox.Location = new System.Drawing.Point(685, 3);
            this.SearchTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.PasswordChar = '\0';
            this.SearchTextbox.PlaceholderForeColor = System.Drawing.Color.White;
            this.SearchTextbox.PlaceholderText = "Search";
            this.SearchTextbox.SelectedText = "";
            this.SearchTextbox.ShadowDecoration.Parent = this.SearchTextbox;
            this.SearchTextbox.Size = new System.Drawing.Size(375, 29);
            this.SearchTextbox.TabIndex = 9;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // HardDriveIcon1
            // 
            this.HardDriveIcon1.Image = ((System.Drawing.Image)(resources.GetObject("HardDriveIcon1.Image")));
            this.HardDriveIcon1.Location = new System.Drawing.Point(5, 4);
            this.HardDriveIcon1.Name = "HardDriveIcon1";
            this.HardDriveIcon1.Size = new System.Drawing.Size(25, 25);
            this.HardDriveIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HardDriveIcon1.TabIndex = 8;
            this.HardDriveIcon1.TabStop = false;
            // 
            // GoogleFormsLabel
            // 
            this.GoogleFormsLabel.AutoSize = true;
            this.GoogleFormsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleFormsLabel.Location = new System.Drawing.Point(36, 3);
            this.GoogleFormsLabel.Name = "GoogleFormsLabel";
            this.GoogleFormsLabel.Size = new System.Drawing.Size(131, 25);
            this.GoogleFormsLabel.TabIndex = 7;
            this.GoogleFormsLabel.Text = "Google Forms";
            // 
            // ImportButton
            // 
            this.ImportButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImportButton.CheckedState.Parent = this.ImportButton;
            this.ImportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportButton.CustomImages.Parent = this.ImportButton;
            this.ImportButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.ImportButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.HoverState.Parent = this.ImportButton;
            this.ImportButton.Location = new System.Drawing.Point(402, 512);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.ShadowDecoration.Parent = this.ImportButton;
            this.ImportButton.Size = new System.Drawing.Size(253, 45);
            this.ImportButton.TabIndex = 3;
            this.ImportButton.Text = "Sync to Google Forms";
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // GoogleFormsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.FormPanel);
            this.Name = "GoogleFormsTab";
            this.Size = new System.Drawing.Size(1130, 649);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.DataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(DatabaseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.PictureBox HardDriveIcon1;
        private System.Windows.Forms.Label GoogleFormsLabel;
        private Guna.UI2.WinForms.Guna2Button ImportButton;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextbox;
        private System.Windows.Forms.Panel DataGridViewPanel;
        public static Guna.UI2.WinForms.Guna2DataGridView DatabaseGridView;
    }
}
