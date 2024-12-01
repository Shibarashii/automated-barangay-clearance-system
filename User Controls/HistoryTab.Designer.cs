﻿namespace Barangay_Clearance_System.User_Controls
{
    partial class HistoryTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryTab));
            HistoryGridViewPanel = new System.Windows.Forms.Panel();
            HistoryGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            MonthCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            RecentOldestCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.HardDriveIcon1 = new System.Windows.Forms.PictureBox();
            this.HistoryLabel = new System.Windows.Forms.Label();
            HistoryGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(HistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon1)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryGridViewPanel
            // 
            HistoryGridViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            HistoryGridViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            HistoryGridViewPanel.Controls.Add(HistoryGridView);
            HistoryGridViewPanel.Location = new System.Drawing.Point(41, 115);
            HistoryGridViewPanel.Name = "HistoryGridViewPanel";
            HistoryGridViewPanel.Size = new System.Drawing.Size(1049, 506);
            HistoryGridViewPanel.TabIndex = 8;
            // 
            // HistoryGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            HistoryGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            HistoryGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            HistoryGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            HistoryGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            HistoryGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            HistoryGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            HistoryGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            HistoryGridView.ColumnHeadersHeight = 50;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            HistoryGridView.DefaultCellStyle = dataGridViewCellStyle3;
            HistoryGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            HistoryGridView.EnableHeadersVisualStyles = false;
            HistoryGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            HistoryGridView.Location = new System.Drawing.Point(0, 0);
            HistoryGridView.Name = "HistoryGridView";
            HistoryGridView.ReadOnly = true;
            HistoryGridView.RowHeadersVisible = false;
            HistoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            HistoryGridView.Size = new System.Drawing.Size(1047, 504);
            HistoryGridView.TabIndex = 11;
            HistoryGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            HistoryGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            HistoryGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            HistoryGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            HistoryGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            HistoryGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            HistoryGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            HistoryGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            HistoryGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(12)))), ((int)(((byte)(167)))));
            HistoryGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            HistoryGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            HistoryGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            HistoryGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            HistoryGridView.ThemeStyle.HeaderStyle.Height = 50;
            HistoryGridView.ThemeStyle.ReadOnly = true;
            HistoryGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            HistoryGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            HistoryGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            HistoryGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            HistoryGridView.ThemeStyle.RowsStyle.Height = 22;
            HistoryGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            HistoryGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MonthCombobox
            // 
            MonthCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            MonthCombobox.BackColor = System.Drawing.Color.Transparent;
            MonthCombobox.BorderColor = System.Drawing.Color.Black;
            MonthCombobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            MonthCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            MonthCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            MonthCombobox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            MonthCombobox.FocusedColor = System.Drawing.Color.Empty;
            MonthCombobox.FocusedState.Parent = MonthCombobox;
            MonthCombobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MonthCombobox.ForeColor = System.Drawing.Color.Black;
            MonthCombobox.FormattingEnabled = true;
            MonthCombobox.HoverState.Parent = MonthCombobox;
            MonthCombobox.ItemHeight = 34;
            MonthCombobox.Items.AddRange(new object[] {
            "-- All Months --"});
            MonthCombobox.ItemsAppearance.Parent = MonthCombobox;
            MonthCombobox.Location = new System.Drawing.Point(903, 68);
            MonthCombobox.Name = "MonthCombobox";
            MonthCombobox.ShadowDecoration.Parent = MonthCombobox;
            MonthCombobox.Size = new System.Drawing.Size(186, 40);
            MonthCombobox.StartIndex = 0;
            MonthCombobox.TabIndex = 30;
            MonthCombobox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            MonthCombobox.SelectedIndexChanged += new System.EventHandler(MonthCombobox_SelectedIndexChanged);
            // 
            // RecentOldestCombobox
            // 
            RecentOldestCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            RecentOldestCombobox.BackColor = System.Drawing.Color.Transparent;
            RecentOldestCombobox.BorderColor = System.Drawing.Color.Black;
            RecentOldestCombobox.Cursor = System.Windows.Forms.Cursors.Arrow;
            RecentOldestCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            RecentOldestCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            RecentOldestCombobox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            RecentOldestCombobox.FocusedColor = System.Drawing.Color.Empty;
            RecentOldestCombobox.FocusedState.Parent = RecentOldestCombobox;
            RecentOldestCombobox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            RecentOldestCombobox.ForeColor = System.Drawing.Color.Black;
            RecentOldestCombobox.FormattingEnabled = true;
            RecentOldestCombobox.HoverState.Parent = RecentOldestCombobox;
            RecentOldestCombobox.ItemHeight = 34;
            RecentOldestCombobox.Items.AddRange(new object[] {
            "Recent to Oldest",
            "Oldest to Recent"});
            RecentOldestCombobox.ItemsAppearance.Parent = RecentOldestCombobox;
            RecentOldestCombobox.Location = new System.Drawing.Point(711, 68);
            RecentOldestCombobox.Name = "RecentOldestCombobox";
            RecentOldestCombobox.ShadowDecoration.Parent = RecentOldestCombobox;
            RecentOldestCombobox.Size = new System.Drawing.Size(186, 40);
            RecentOldestCombobox.StartIndex = 0;
            RecentOldestCombobox.TabIndex = 31;
            RecentOldestCombobox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            RecentOldestCombobox.SelectedIndexChanged += new System.EventHandler(RecentOldestCombobox_SelectedIndexChanged);
            // 
            // HardDriveIcon1
            // 
            this.HardDriveIcon1.Image = ((System.Drawing.Image)(resources.GetObject("HardDriveIcon1.Image")));
            this.HardDriveIcon1.Location = new System.Drawing.Point(43, 69);
            this.HardDriveIcon1.Name = "HardDriveIcon1";
            this.HardDriveIcon1.Size = new System.Drawing.Size(25, 25);
            this.HardDriveIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HardDriveIcon1.TabIndex = 33;
            this.HardDriveIcon1.TabStop = false;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.Location = new System.Drawing.Point(74, 68);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(75, 25);
            this.HistoryLabel.TabIndex = 32;
            this.HistoryLabel.Text = "History";
            // 
            // HistoryTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.HardDriveIcon1);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(RecentOldestCombobox);
            this.Controls.Add(MonthCombobox);
            this.Controls.Add(HistoryGridViewPanel);
            this.Name = "HistoryTab";
            this.Size = new System.Drawing.Size(1130, 649);
            HistoryGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(HistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel HistoryGridViewPanel;
        public static Guna.UI2.WinForms.Guna2DataGridView HistoryGridView;
        public static Guna.UI2.WinForms.Guna2ComboBox MonthCombobox;
        public static Guna.UI2.WinForms.Guna2ComboBox RecentOldestCombobox;
        private System.Windows.Forms.PictureBox HardDriveIcon1;
        private System.Windows.Forms.Label HistoryLabel;
    }
}