namespace Barangay_Clearance_System.User_Controls
{
    partial class ClearanceTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearanceTab));
            this.FormPanel = new System.Windows.Forms.Panel();
            this.HardDriveIcon1 = new System.Windows.Forms.PictureBox();
            this.FormLabel = new System.Windows.Forms.Label();
            this.FieldsPanel = new System.Windows.Forms.Panel();
            DateOfBirthTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            CivilStatusTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            SexTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            ApplicationPurposeTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            SpecifyLabel = new System.Windows.Forms.Label();
            SpecifyTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ApplicationPurposeLabel = new System.Windows.Forms.Label();
            this.CivilStatusLabel = new System.Windows.Forms.Label();
            this.PlaceOfBirthLabel = new System.Windows.Forms.Label();
            PlaceOfBirthTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SexLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.HouseNoLabel = new System.Windows.Forms.Label();
            HouseNoTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PurokNoLabel = new System.Windows.Forms.Label();
            PurokNoTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            NameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PrintPreviewPanel = new System.Windows.Forms.Panel();
            this.HardDriveIcon2 = new System.Windows.Forms.PictureBox();
            this.PrintPreviewLabel = new System.Windows.Forms.Label();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            ChromiumWebBrowserPreview = new CefSharp.WinForms.ChromiumWebBrowser();
            this.SaveAsPDFButton = new Guna.UI2.WinForms.Guna2Button();
            this.PrintButton = new Guna.UI2.WinForms.Guna2Button();
            this.FormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon1)).BeginInit();
            this.FieldsPanel.SuspendLayout();
            this.PrintPreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon2)).BeginInit();
            this.PreviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormPanel
            // 
            this.FormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormPanel.Controls.Add(this.HardDriveIcon1);
            this.FormPanel.Controls.Add(this.FormLabel);
            this.FormPanel.Controls.Add(this.FieldsPanel);
            this.FormPanel.Location = new System.Drawing.Point(41, 59);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(632, 541);
            this.FormPanel.TabIndex = 7;
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
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(36, 3);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(57, 25);
            this.FormLabel.TabIndex = 7;
            this.FormLabel.Text = "Form";
            // 
            // FieldsPanel
            // 
            this.FieldsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldsPanel.BackColor = System.Drawing.Color.Transparent;
            this.FieldsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FieldsPanel.Controls.Add(DateOfBirthTextbox);
            this.FieldsPanel.Controls.Add(CivilStatusTextbox);
            this.FieldsPanel.Controls.Add(SexTextbox);
            this.FieldsPanel.Controls.Add(ApplicationPurposeTextbox);
            this.FieldsPanel.Controls.Add(SpecifyLabel);
            this.FieldsPanel.Controls.Add(SpecifyTextbox);
            this.FieldsPanel.Controls.Add(this.ApplicationPurposeLabel);
            this.FieldsPanel.Controls.Add(this.CivilStatusLabel);
            this.FieldsPanel.Controls.Add(this.PlaceOfBirthLabel);
            this.FieldsPanel.Controls.Add(PlaceOfBirthTextbox);
            this.FieldsPanel.Controls.Add(this.SexLabel);
            this.FieldsPanel.Controls.Add(this.DateOfBirthLabel);
            this.FieldsPanel.Controls.Add(this.HouseNoLabel);
            this.FieldsPanel.Controls.Add(HouseNoTextbox);
            this.FieldsPanel.Controls.Add(this.PurokNoLabel);
            this.FieldsPanel.Controls.Add(PurokNoTextbox);
            this.FieldsPanel.Controls.Add(this.NameLabel);
            this.FieldsPanel.Controls.Add(NameTextbox);
            this.FieldsPanel.Location = new System.Drawing.Point(3, 35);
            this.FieldsPanel.Name = "FieldsPanel";
            this.FieldsPanel.Size = new System.Drawing.Size(629, 433);
            this.FieldsPanel.TabIndex = 2;
            // 
            // DateOfBirthTextbox
            // 
            DateOfBirthTextbox.Animated = true;
            DateOfBirthTextbox.AutoSize = true;
            DateOfBirthTextbox.BorderColor = System.Drawing.Color.Black;
            DateOfBirthTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            DateOfBirthTextbox.DefaultText = "";
            DateOfBirthTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            DateOfBirthTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            DateOfBirthTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            DateOfBirthTextbox.DisabledState.Parent = DateOfBirthTextbox;
            DateOfBirthTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            DateOfBirthTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            DateOfBirthTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            DateOfBirthTextbox.FocusedState.Parent = DateOfBirthTextbox;
            DateOfBirthTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOfBirthTextbox.ForeColor = System.Drawing.Color.Black;
            DateOfBirthTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            DateOfBirthTextbox.HoverState.Parent = DateOfBirthTextbox;
            DateOfBirthTextbox.Location = new System.Drawing.Point(214, 136);
            DateOfBirthTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            DateOfBirthTextbox.Name = "DateOfBirthTextbox";
            DateOfBirthTextbox.PasswordChar = '\0';
            DateOfBirthTextbox.PlaceholderText = "";
            DateOfBirthTextbox.SelectedText = "";
            DateOfBirthTextbox.ShadowDecoration.Parent = DateOfBirthTextbox;
            DateOfBirthTextbox.Size = new System.Drawing.Size(186, 40);
            DateOfBirthTextbox.TabIndex = 39;
            DateOfBirthTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // CivilStatusTextbox
            // 
            CivilStatusTextbox.Animated = true;
            CivilStatusTextbox.AutoSize = true;
            CivilStatusTextbox.BorderColor = System.Drawing.Color.Black;
            CivilStatusTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            CivilStatusTextbox.DefaultText = "";
            CivilStatusTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            CivilStatusTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            CivilStatusTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            CivilStatusTextbox.DisabledState.Parent = CivilStatusTextbox;
            CivilStatusTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            CivilStatusTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            CivilStatusTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            CivilStatusTextbox.FocusedState.Parent = CivilStatusTextbox;
            CivilStatusTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            CivilStatusTextbox.ForeColor = System.Drawing.Color.Black;
            CivilStatusTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            CivilStatusTextbox.HoverState.Parent = CivilStatusTextbox;
            CivilStatusTextbox.Location = new System.Drawing.Point(214, 231);
            CivilStatusTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            CivilStatusTextbox.Name = "CivilStatusTextbox";
            CivilStatusTextbox.PasswordChar = '\0';
            CivilStatusTextbox.PlaceholderText = "";
            CivilStatusTextbox.SelectedText = "";
            CivilStatusTextbox.ShadowDecoration.Parent = CivilStatusTextbox;
            CivilStatusTextbox.Size = new System.Drawing.Size(187, 40);
            CivilStatusTextbox.TabIndex = 38;
            CivilStatusTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // SexTextbox
            // 
            SexTextbox.Animated = true;
            SexTextbox.AutoSize = true;
            SexTextbox.BorderColor = System.Drawing.Color.Black;
            SexTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            SexTextbox.DefaultText = "";
            SexTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            SexTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            SexTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            SexTextbox.DisabledState.Parent = SexTextbox;
            SexTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            SexTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            SexTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            SexTextbox.FocusedState.Parent = SexTextbox;
            SexTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SexTextbox.ForeColor = System.Drawing.Color.Black;
            SexTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            SexTextbox.HoverState.Parent = SexTextbox;
            SexTextbox.Location = new System.Drawing.Point(12, 231);
            SexTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            SexTextbox.Name = "SexTextbox";
            SexTextbox.PasswordChar = '\0';
            SexTextbox.PlaceholderText = "";
            SexTextbox.SelectedText = "";
            SexTextbox.ShadowDecoration.Parent = SexTextbox;
            SexTextbox.Size = new System.Drawing.Size(185, 40);
            SexTextbox.TabIndex = 37;
            SexTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // ApplicationPurposeTextbox
            // 
            ApplicationPurposeTextbox.Animated = true;
            ApplicationPurposeTextbox.AutoSize = true;
            ApplicationPurposeTextbox.BorderColor = System.Drawing.Color.Black;
            ApplicationPurposeTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            ApplicationPurposeTextbox.DefaultText = "";
            ApplicationPurposeTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            ApplicationPurposeTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            ApplicationPurposeTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            ApplicationPurposeTextbox.DisabledState.Parent = ApplicationPurposeTextbox;
            ApplicationPurposeTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            ApplicationPurposeTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            ApplicationPurposeTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            ApplicationPurposeTextbox.FocusedState.Parent = ApplicationPurposeTextbox;
            ApplicationPurposeTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ApplicationPurposeTextbox.ForeColor = System.Drawing.Color.Black;
            ApplicationPurposeTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            ApplicationPurposeTextbox.HoverState.Parent = ApplicationPurposeTextbox;
            ApplicationPurposeTextbox.Location = new System.Drawing.Point(12, 327);
            ApplicationPurposeTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            ApplicationPurposeTextbox.Name = "ApplicationPurposeTextbox";
            ApplicationPurposeTextbox.PasswordChar = '\0';
            ApplicationPurposeTextbox.PlaceholderText = "";
            ApplicationPurposeTextbox.SelectedText = "";
            ApplicationPurposeTextbox.ShadowDecoration.Parent = ApplicationPurposeTextbox;
            ApplicationPurposeTextbox.Size = new System.Drawing.Size(185, 40);
            ApplicationPurposeTextbox.TabIndex = 36;
            ApplicationPurposeTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // SpecifyLabel
            // 
            SpecifyLabel.AutoSize = true;
            SpecifyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SpecifyLabel.Location = new System.Drawing.Point(210, 303);
            SpecifyLabel.Name = "SpecifyLabel";
            SpecifyLabel.Size = new System.Drawing.Size(63, 21);
            SpecifyLabel.TabIndex = 35;
            SpecifyLabel.Text = "Specify:";
            SpecifyLabel.Visible = false;
            // 
            // SpecifyTextbox
            // 
            SpecifyTextbox.Animated = true;
            SpecifyTextbox.AutoSize = true;
            SpecifyTextbox.BorderColor = System.Drawing.Color.Black;
            SpecifyTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            SpecifyTextbox.DefaultText = "";
            SpecifyTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            SpecifyTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            SpecifyTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            SpecifyTextbox.DisabledState.Parent = SpecifyTextbox;
            SpecifyTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            SpecifyTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            SpecifyTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            SpecifyTextbox.FocusedState.Parent = SpecifyTextbox;
            SpecifyTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SpecifyTextbox.ForeColor = System.Drawing.Color.Black;
            SpecifyTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            SpecifyTextbox.HoverState.Parent = SpecifyTextbox;
            SpecifyTextbox.Location = new System.Drawing.Point(214, 327);
            SpecifyTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            SpecifyTextbox.Name = "SpecifyTextbox";
            SpecifyTextbox.PasswordChar = '\0';
            SpecifyTextbox.PlaceholderText = "";
            SpecifyTextbox.SelectedText = "";
            SpecifyTextbox.ShadowDecoration.Parent = SpecifyTextbox;
            SpecifyTextbox.Size = new System.Drawing.Size(385, 40);
            SpecifyTextbox.TabIndex = 34;
            SpecifyTextbox.Visible = false;
            SpecifyTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // ApplicationPurposeLabel
            // 
            this.ApplicationPurposeLabel.AutoSize = true;
            this.ApplicationPurposeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationPurposeLabel.Location = new System.Drawing.Point(15, 303);
            this.ApplicationPurposeLabel.Name = "ApplicationPurposeLabel";
            this.ApplicationPurposeLabel.Size = new System.Drawing.Size(160, 21);
            this.ApplicationPurposeLabel.TabIndex = 32;
            this.ApplicationPurposeLabel.Text = "Application Purpose *";
            // 
            // CivilStatusLabel
            // 
            this.CivilStatusLabel.AutoSize = true;
            this.CivilStatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CivilStatusLabel.Location = new System.Drawing.Point(213, 207);
            this.CivilStatusLabel.Name = "CivilStatusLabel";
            this.CivilStatusLabel.Size = new System.Drawing.Size(97, 21);
            this.CivilStatusLabel.TabIndex = 28;
            this.CivilStatusLabel.Text = "Civil Status *";
            // 
            // PlaceOfBirthLabel
            // 
            this.PlaceOfBirthLabel.AutoSize = true;
            this.PlaceOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceOfBirthLabel.Location = new System.Drawing.Point(409, 111);
            this.PlaceOfBirthLabel.Name = "PlaceOfBirthLabel";
            this.PlaceOfBirthLabel.Size = new System.Drawing.Size(112, 21);
            this.PlaceOfBirthLabel.TabIndex = 27;
            this.PlaceOfBirthLabel.Text = "Place of Birth *";
            // 
            // PlaceOfBirthTextbox
            // 
            PlaceOfBirthTextbox.Animated = true;
            PlaceOfBirthTextbox.AutoSize = true;
            PlaceOfBirthTextbox.BorderColor = System.Drawing.Color.Black;
            PlaceOfBirthTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            PlaceOfBirthTextbox.DefaultText = "";
            PlaceOfBirthTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            PlaceOfBirthTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            PlaceOfBirthTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            PlaceOfBirthTextbox.DisabledState.Parent = PlaceOfBirthTextbox;
            PlaceOfBirthTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            PlaceOfBirthTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            PlaceOfBirthTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            PlaceOfBirthTextbox.FocusedState.Parent = PlaceOfBirthTextbox;
            PlaceOfBirthTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PlaceOfBirthTextbox.ForeColor = System.Drawing.Color.Black;
            PlaceOfBirthTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            PlaceOfBirthTextbox.HoverState.Parent = PlaceOfBirthTextbox;
            PlaceOfBirthTextbox.Location = new System.Drawing.Point(413, 135);
            PlaceOfBirthTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            PlaceOfBirthTextbox.Name = "PlaceOfBirthTextbox";
            PlaceOfBirthTextbox.PasswordChar = '\0';
            PlaceOfBirthTextbox.PlaceholderText = "";
            PlaceOfBirthTextbox.SelectedText = "";
            PlaceOfBirthTextbox.ShadowDecoration.Parent = PlaceOfBirthTextbox;
            PlaceOfBirthTextbox.Size = new System.Drawing.Size(186, 40);
            PlaceOfBirthTextbox.TabIndex = 26;
            PlaceOfBirthTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.Location = new System.Drawing.Point(10, 207);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(45, 21);
            this.SexLabel.TabIndex = 24;
            this.SexLabel.Text = "Sex *";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(210, 111);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(108, 21);
            this.DateOfBirthLabel.TabIndex = 21;
            this.DateOfBirthLabel.Text = "Date of Birth *";
            // 
            // HouseNoLabel
            // 
            this.HouseNoLabel.AutoSize = true;
            this.HouseNoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseNoLabel.Location = new System.Drawing.Point(115, 111);
            this.HouseNoLabel.Name = "HouseNoLabel";
            this.HouseNoLabel.Size = new System.Drawing.Size(82, 21);
            this.HouseNoLabel.TabIndex = 19;
            this.HouseNoLabel.Text = "House No.";
            // 
            // HouseNoTextbox
            // 
            HouseNoTextbox.Animated = true;
            HouseNoTextbox.AutoSize = true;
            HouseNoTextbox.BorderColor = System.Drawing.Color.Black;
            HouseNoTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            HouseNoTextbox.DefaultText = "";
            HouseNoTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            HouseNoTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            HouseNoTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            HouseNoTextbox.DisabledState.Parent = HouseNoTextbox;
            HouseNoTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            HouseNoTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            HouseNoTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            HouseNoTextbox.FocusedState.Parent = HouseNoTextbox;
            HouseNoTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            HouseNoTextbox.ForeColor = System.Drawing.Color.Black;
            HouseNoTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            HouseNoTextbox.HoverState.Parent = HouseNoTextbox;
            HouseNoTextbox.Location = new System.Drawing.Point(119, 135);
            HouseNoTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            HouseNoTextbox.Name = "HouseNoTextbox";
            HouseNoTextbox.PasswordChar = '\0';
            HouseNoTextbox.PlaceholderText = "";
            HouseNoTextbox.SelectedText = "";
            HouseNoTextbox.ShadowDecoration.Parent = HouseNoTextbox;
            HouseNoTextbox.Size = new System.Drawing.Size(79, 40);
            HouseNoTextbox.TabIndex = 18;
            HouseNoTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // PurokNoLabel
            // 
            this.PurokNoLabel.AutoSize = true;
            this.PurokNoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurokNoLabel.Location = new System.Drawing.Point(10, 111);
            this.PurokNoLabel.Name = "PurokNoLabel";
            this.PurokNoLabel.Size = new System.Drawing.Size(90, 21);
            this.PurokNoLabel.TabIndex = 17;
            this.PurokNoLabel.Text = "Purok No. *";
            // 
            // PurokNoTextbox
            // 
            PurokNoTextbox.Animated = true;
            PurokNoTextbox.AutoSize = true;
            PurokNoTextbox.BorderColor = System.Drawing.Color.Black;
            PurokNoTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            PurokNoTextbox.DefaultText = "";
            PurokNoTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            PurokNoTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            PurokNoTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            PurokNoTextbox.DisabledState.Parent = PurokNoTextbox;
            PurokNoTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            PurokNoTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            PurokNoTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            PurokNoTextbox.FocusedState.Parent = PurokNoTextbox;
            PurokNoTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            PurokNoTextbox.ForeColor = System.Drawing.Color.Black;
            PurokNoTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            PurokNoTextbox.HoverState.Parent = PurokNoTextbox;
            PurokNoTextbox.Location = new System.Drawing.Point(12, 135);
            PurokNoTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            PurokNoTextbox.Name = "PurokNoTextbox";
            PurokNoTextbox.PasswordChar = '\0';
            PurokNoTextbox.PlaceholderText = "";
            PurokNoTextbox.SelectedText = "";
            PurokNoTextbox.ShadowDecoration.Parent = PurokNoTextbox;
            PurokNoTextbox.Size = new System.Drawing.Size(99, 40);
            PurokNoTextbox.TabIndex = 16;
            PurokNoTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(8, 17);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(339, 21);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name (First Name, Middle Name, Last Name)  *";
            // 
            // NameTextbox
            // 
            NameTextbox.Animated = true;
            NameTextbox.AutoSize = true;
            NameTextbox.BorderColor = System.Drawing.Color.Black;
            NameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            NameTextbox.DefaultText = "";
            NameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            NameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            NameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            NameTextbox.DisabledState.Parent = NameTextbox;
            NameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            NameTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            NameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            NameTextbox.FocusedState.Parent = NameTextbox;
            NameTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NameTextbox.ForeColor = System.Drawing.Color.Black;
            NameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            NameTextbox.HoverState.Parent = NameTextbox;
            NameTextbox.Location = new System.Drawing.Point(12, 41);
            NameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.PasswordChar = '\0';
            NameTextbox.PlaceholderText = "";
            NameTextbox.SelectedText = "";
            NameTextbox.ShadowDecoration.Parent = NameTextbox;
            NameTextbox.Size = new System.Drawing.Size(587, 40);
            NameTextbox.TabIndex = 0;
            NameTextbox.TextChanged += new System.EventHandler(this.Textboxes_TextChanged);
            // 
            // PrintPreviewPanel
            // 
            this.PrintPreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintPreviewPanel.Controls.Add(this.HardDriveIcon2);
            this.PrintPreviewPanel.Controls.Add(this.PrintPreviewLabel);
            this.PrintPreviewPanel.Controls.Add(this.PreviewPanel);
            this.PrintPreviewPanel.Controls.Add(this.SaveAsPDFButton);
            this.PrintPreviewPanel.Controls.Add(this.PrintButton);
            this.PrintPreviewPanel.Location = new System.Drawing.Point(679, 59);
            this.PrintPreviewPanel.Name = "PrintPreviewPanel";
            this.PrintPreviewPanel.Size = new System.Drawing.Size(424, 541);
            this.PrintPreviewPanel.TabIndex = 6;
            // 
            // HardDriveIcon2
            // 
            this.HardDriveIcon2.Image = ((System.Drawing.Image)(resources.GetObject("HardDriveIcon2.Image")));
            this.HardDriveIcon2.Location = new System.Drawing.Point(5, 3);
            this.HardDriveIcon2.Name = "HardDriveIcon2";
            this.HardDriveIcon2.Size = new System.Drawing.Size(25, 25);
            this.HardDriveIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HardDriveIcon2.TabIndex = 6;
            this.HardDriveIcon2.TabStop = false;
            // 
            // PrintPreviewLabel
            // 
            this.PrintPreviewLabel.AutoSize = true;
            this.PrintPreviewLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintPreviewLabel.Location = new System.Drawing.Point(36, 2);
            this.PrintPreviewLabel.Name = "PrintPreviewLabel";
            this.PrintPreviewLabel.Size = new System.Drawing.Size(125, 25);
            this.PrintPreviewLabel.TabIndex = 5;
            this.PrintPreviewLabel.Text = "Print Preview";
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewPanel.BackColor = System.Drawing.Color.Transparent;
            this.PreviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewPanel.Controls.Add(ChromiumWebBrowserPreview);
            this.PreviewPanel.Location = new System.Drawing.Point(0, 35);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(421, 433);
            this.PreviewPanel.TabIndex = 2;
            // 
            // ChromiumWebBrowserPreview
            // 
            ChromiumWebBrowserPreview.ActivateBrowserOnCreation = false;
            ChromiumWebBrowserPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            ChromiumWebBrowserPreview.Location = new System.Drawing.Point(0, 0);
            ChromiumWebBrowserPreview.Name = "ChromiumWebBrowserPreview";
            ChromiumWebBrowserPreview.Size = new System.Drawing.Size(419, 431);
            ChromiumWebBrowserPreview.TabIndex = 0;
            // 
            // SaveAsPDFButton
            // 
            this.SaveAsPDFButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAsPDFButton.CheckedState.Parent = this.SaveAsPDFButton;
            this.SaveAsPDFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAsPDFButton.CustomImages.Parent = this.SaveAsPDFButton;
            this.SaveAsPDFButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.SaveAsPDFButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsPDFButton.ForeColor = System.Drawing.Color.White;
            this.SaveAsPDFButton.HoverState.Parent = this.SaveAsPDFButton;
            this.SaveAsPDFButton.Location = new System.Drawing.Point(44, 484);
            this.SaveAsPDFButton.Name = "SaveAsPDFButton";
            this.SaveAsPDFButton.ShadowDecoration.Parent = this.SaveAsPDFButton;
            this.SaveAsPDFButton.Size = new System.Drawing.Size(180, 45);
            this.SaveAsPDFButton.TabIndex = 4;
            this.SaveAsPDFButton.Text = "Save As PDF";
            this.SaveAsPDFButton.Click += new System.EventHandler(this.SaveAsPDFButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.CheckedState.Parent = this.PrintButton;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.CustomImages.Parent = this.PrintButton;
            this.PrintButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.HoverState.Parent = this.PrintButton;
            this.PrintButton.Location = new System.Drawing.Point(231, 484);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.ShadowDecoration.Parent = this.PrintButton;
            this.PrintButton.Size = new System.Drawing.Size(180, 45);
            this.PrintButton.TabIndex = 3;
            this.PrintButton.Text = "Print";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // Clearance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(this.PrintPreviewPanel);
            this.Name = "Clearance";
            this.Size = new System.Drawing.Size(1130, 649);
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon1)).EndInit();
            this.FieldsPanel.ResumeLayout(false);
            this.FieldsPanel.PerformLayout();
            this.PrintPreviewPanel.ResumeLayout(false);
            this.PrintPreviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardDriveIcon2)).EndInit();
            this.PreviewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Panel FieldsPanel;
        private System.Windows.Forms.Panel PrintPreviewPanel;
        private System.Windows.Forms.Label PrintPreviewLabel;
        private System.Windows.Forms.Panel PreviewPanel;
        private Guna.UI2.WinForms.Guna2Button SaveAsPDFButton;
        private Guna.UI2.WinForms.Guna2Button PrintButton;
        private System.Windows.Forms.PictureBox HardDriveIcon1;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.PictureBox HardDriveIcon2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PurokNoLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label PlaceOfBirthLabel;
        private System.Windows.Forms.Label HouseNoLabel;
        private System.Windows.Forms.Label ApplicationPurposeLabel;
        private System.Windows.Forms.Label CivilStatusLabel;
        public static CefSharp.WinForms.ChromiumWebBrowser ChromiumWebBrowserPreview;
        public static System.Windows.Forms.Label SpecifyLabel;
        public static Guna.UI2.WinForms.Guna2TextBox NameTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox HouseNoTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox PurokNoTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox PlaceOfBirthTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox SpecifyTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox ApplicationPurposeTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox DateOfBirthTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox CivilStatusTextbox;
        public static Guna.UI2.WinForms.Guna2TextBox SexTextbox;
    }
}
