namespace GunesMotel.UI.WinForms.Control
{
    partial class ReservationManagementControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbDateType;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlReservationForm;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFormContent;
        private System.Windows.Forms.GroupBox grpReservationInfo;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown nudGuestCount;
        private System.Windows.Forms.Label lblGuestCount;
        private System.Windows.Forms.GroupBox grpReservationDetails;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.DateTimePicker dtpReservationDate;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Panel pnlFormButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlReservationList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Panel pnlListButtons;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnFilter;

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
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbDateType = new System.Windows.Forms.ComboBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlReservationList = new System.Windows.Forms.Panel();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.pnlListButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlReservationForm = new System.Windows.Forms.Panel();
            this.pnlFormContent = new System.Windows.Forms.Panel();
            this.grpReservationDetails = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dtpReservationDate = new System.Windows.Forms.DateTimePicker();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.grpReservationInfo = new System.Windows.Forms.GroupBox();
            this.nudGuestCount = new System.Windows.Forms.NumericUpDown();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnlFormButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlReservationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.pnlListButtons.SuspendLayout();
            this.pnlReservationForm.SuspendLayout();
            this.pnlFormContent.SuspendLayout();
            this.grpReservationDetails.SuspendLayout();
            this.grpReservationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestCount)).BeginInit();
            this.pnlFormButtons.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.pnlSearch.Controls.Add(this.dtpStartDate);
            this.pnlSearch.Controls.Add(this.dtpEndDate);
            this.pnlSearch.Controls.Add(this.btnFilter);
            this.pnlSearch.Controls.Add(this.btnCancel);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.cmbDateType);
            this.pnlSearch.Controls.Add(this.lblSearchType);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlSearch.Size = new System.Drawing.Size(1200, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(567, 25);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(773, 25);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 5;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(990, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(120, 35);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "🗂️ Tarih Filtresi";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(300, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Aranacak değeri giriniz...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbDateType
            // 
            this.cmbDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDateType.FormattingEnabled = true;
            this.cmbDateType.Items.AddRange(new object[] {
            "Rezervasyon Tarihi",
            "Giriş Tarihi",
            "Çıkış Tarihi"});
            this.cmbDateType.Location = new System.Drawing.Point(130, 17);
            this.cmbDateType.Name = "cmbDateType";
            this.cmbDateType.Size = new System.Drawing.Size(150, 31);
            this.cmbDateType.TabIndex = 1;
            // 
            // lblSearchType
            // 
            this.lblSearchType.AutoSize = true;
            this.lblSearchType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblSearchType.Location = new System.Drawing.Point(20, 20);
            this.lblSearchType.Name = "lblSearchType";
            this.lblSearchType.Size = new System.Drawing.Size(109, 23);
            this.lblSearchType.TabIndex = 0;
            this.lblSearchType.Text = "Arama Türü:";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlReservationList);
            this.pnlMain.Controls.Add(this.pnlReservationForm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1200, 640);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlReservationList
            // 
            this.pnlReservationList.BackColor = System.Drawing.Color.White;
            this.pnlReservationList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservationList.Controls.Add(this.dgvReservations);
            this.pnlReservationList.Controls.Add(this.pnlListButtons);
            this.pnlReservationList.Controls.Add(this.lblListTitle);
            this.pnlReservationList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservationList.Location = new System.Drawing.Point(490, 10);
            this.pnlReservationList.Name = "pnlReservationList";
            this.pnlReservationList.Size = new System.Drawing.Size(700, 620);
            this.pnlReservationList.TabIndex = 1;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservations.ColumnHeadersHeight = 50;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservations.EnableHeadersVisualStyles = false;
            this.dgvReservations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.dgvReservations.Location = new System.Drawing.Point(0, 50);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.dgvReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservations.RowHeadersVisible = false;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 40;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(698, 510);
            this.dgvReservations.TabIndex = 2;
            this.dgvReservations.SelectionChanged += new System.EventHandler(this.dgvReservations_SelectionChanged);
            // 
            // pnlListButtons
            // 
            this.pnlListButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlListButtons.Controls.Add(this.btnExport);
            this.pnlListButtons.Controls.Add(this.btnRefresh);
            this.pnlListButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlListButtons.Location = new System.Drawing.Point(0, 560);
            this.pnlListButtons.Name = "pnlListButtons";
            this.pnlListButtons.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlListButtons.Size = new System.Drawing.Size(698, 58);
            this.pnlListButtons.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(568, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(115, 35);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "📤 Dışa Aktar";
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(478, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "🔄 Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblListTitle
            // 
            this.lblListTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.lblListTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblListTitle.Location = new System.Drawing.Point(0, 0);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.lblListTitle.Size = new System.Drawing.Size(698, 50);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "📊 Rezervasyon Listesi";
            this.lblListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlReservationForm
            // 
            this.pnlReservationForm.BackColor = System.Drawing.Color.White;
            this.pnlReservationForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservationForm.Controls.Add(this.pnlFormContent);
            this.pnlReservationForm.Controls.Add(this.pnlFormButtons);
            this.pnlReservationForm.Controls.Add(this.pnlFormHeader);
            this.pnlReservationForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlReservationForm.Location = new System.Drawing.Point(10, 10);
            this.pnlReservationForm.Name = "pnlReservationForm";
            this.pnlReservationForm.Size = new System.Drawing.Size(480, 620);
            this.pnlReservationForm.TabIndex = 0;
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.grpReservationDetails);
            this.pnlFormContent.Controls.Add(this.grpReservationInfo);
            this.pnlFormContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContent.Location = new System.Drawing.Point(0, 50);
            this.pnlFormContent.Name = "pnlFormContent";
            this.pnlFormContent.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlFormContent.Size = new System.Drawing.Size(478, 508);
            this.pnlFormContent.TabIndex = 1;
            // 
            // grpReservationDetails
            // 
            this.grpReservationDetails.Controls.Add(this.txtNotes);
            this.grpReservationDetails.Controls.Add(this.lblNotes);
            this.grpReservationDetails.Controls.Add(this.dtpReservationDate);
            this.grpReservationDetails.Controls.Add(this.lblReservationDate);
            this.grpReservationDetails.Controls.Add(this.cmbSource);
            this.grpReservationDetails.Controls.Add(this.lblSource);
            this.grpReservationDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpReservationDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpReservationDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.grpReservationDetails.Location = new System.Drawing.Point(15, 230);
            this.grpReservationDetails.Name = "grpReservationDetails";
            this.grpReservationDetails.Size = new System.Drawing.Size(448, 150);
            this.grpReservationDetails.TabIndex = 1;
            this.grpReservationDetails.TabStop = false;
            this.grpReservationDetails.Text = "📋 Rezervasyon Detayları";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(15, 90);
            this.txtNotes.MaxLength = 255;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(415, 50);
            this.txtNotes.TabIndex = 5;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblNotes.Location = new System.Drawing.Point(15, 65);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(54, 20);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notlar:";
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReservationDate.Location = new System.Drawing.Point(260, 55);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(150, 27);
            this.dtpReservationDate.TabIndex = 3;
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblReservationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblReservationDate.Location = new System.Drawing.Point(260, 30);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(133, 20);
            this.lblReservationDate.TabIndex = 2;
            this.lblReservationDate.Text = "Rezervasyon Tarihi:";
            // 
            // cmbSource
            // 
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Items.AddRange(new object[] {
            "Website",
            "Telefon",
            "Email",
            "Booking.com",
            "Expedia",
            "Hotels.com",
            "Tripadvisor",
            "Walk-in",
            "Diğer"});
            this.cmbSource.Location = new System.Drawing.Point(90, 27);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(150, 28);
            this.cmbSource.TabIndex = 1;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblSource.Location = new System.Drawing.Point(15, 30);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(59, 20);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Kaynak:";
            // 
            // grpReservationInfo
            // 
            this.grpReservationInfo.Controls.Add(this.nudGuestCount);
            this.grpReservationInfo.Controls.Add(this.lblGuestCount);
            this.grpReservationInfo.Controls.Add(this.cmbStatus);
            this.grpReservationInfo.Controls.Add(this.lblStatus);
            this.grpReservationInfo.Controls.Add(this.dtpCheckOutDate);
            this.grpReservationInfo.Controls.Add(this.lblCheckOutDate);
            this.grpReservationInfo.Controls.Add(this.dtpCheckInDate);
            this.grpReservationInfo.Controls.Add(this.lblCheckInDate);
            this.grpReservationInfo.Controls.Add(this.cmbRoom);
            this.grpReservationInfo.Controls.Add(this.lblRoom);
            this.grpReservationInfo.Controls.Add(this.cmbCustomer);
            this.grpReservationInfo.Controls.Add(this.lblCustomer);
            this.grpReservationInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpReservationInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpReservationInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.grpReservationInfo.Location = new System.Drawing.Point(15, 10);
            this.grpReservationInfo.Name = "grpReservationInfo";
            this.grpReservationInfo.Size = new System.Drawing.Size(448, 220);
            this.grpReservationInfo.TabIndex = 0;
            this.grpReservationInfo.TabStop = false;
            this.grpReservationInfo.Text = "🏨 Rezervasyon Bilgileri";
            // 
            // nudGuestCount
            // 
            this.nudGuestCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudGuestCount.Location = new System.Drawing.Point(120, 167);
            this.nudGuestCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGuestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuestCount.Name = "nudGuestCount";
            this.nudGuestCount.Size = new System.Drawing.Size(80, 27);
            this.nudGuestCount.TabIndex = 11;
            this.nudGuestCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblGuestCount
            // 
            this.lblGuestCount.AutoSize = true;
            this.lblGuestCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGuestCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblGuestCount.Location = new System.Drawing.Point(15, 170);
            this.lblGuestCount.Name = "lblGuestCount";
            this.lblGuestCount.Size = new System.Drawing.Size(88, 20);
            this.lblGuestCount.TabIndex = 10;
            this.lblGuestCount.Text = "Misafir Sayı:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Beklemede",
            "Onaylandı",
            "Check-in",
            "Check-out",
            "İptal"});
            this.cmbStatus.Location = new System.Drawing.Point(90, 132);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(130, 28);
            this.cmbStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblStatus.Location = new System.Drawing.Point(15, 135);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Durum:";
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(270, 125);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(130, 27);
            this.dtpCheckOutDate.TabIndex = 7;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckOutDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblCheckOutDate.Location = new System.Drawing.Point(270, 100);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(81, 20);
            this.lblCheckOutDate.TabIndex = 6;
            this.lblCheckOutDate.Text = "Çıkış Tarihi:";
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(120, 97);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(130, 27);
            this.dtpCheckInDate.TabIndex = 5;
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCheckInDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblCheckInDate.Location = new System.Drawing.Point(15, 100);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(80, 20);
            this.lblCheckInDate.TabIndex = 4;
            this.lblCheckInDate.Text = "Giriş Tarihi:";
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(90, 62);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(340, 28);
            this.cmbRoom.TabIndex = 3;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblRoom.Location = new System.Drawing.Point(15, 65);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(40, 20);
            this.lblRoom.TabIndex = 2;
            this.lblRoom.Text = "Oda:";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(90, 27);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(340, 28);
            this.cmbCustomer.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblCustomer.Location = new System.Drawing.Point(15, 30);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(61, 20);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Müşteri:";
            // 
            // pnlFormButtons
            // 
            this.pnlFormButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlFormButtons.Controls.Add(this.btnDelete);
            this.pnlFormButtons.Controls.Add(this.btnEdit);
            this.pnlFormButtons.Controls.Add(this.btnNew);
            this.pnlFormButtons.Controls.Add(this.btnSave);
            this.pnlFormButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFormButtons.Location = new System.Drawing.Point(0, 558);
            this.pnlFormButtons.Name = "pnlFormButtons";
            this.pnlFormButtons.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlFormButtons.Size = new System.Drawing.Size(478, 60);
            this.pnlFormButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(395, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "🗑️ Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(300, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 35);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "✏️ Düzenle";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(205, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "➕ Yeni";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1116, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "❌ İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(15, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.pnlFormHeader.Controls.Add(this.lblFormTitle);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(478, 50);
            this.pnlFormHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblFormTitle.Location = new System.Drawing.Point(15, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(220, 28);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "📝 Rezervasyon Form";
            // 
            // ReservationManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ReservationManagementControl";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.ReservationManagementControl_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlReservationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.pnlListButtons.ResumeLayout(false);
            this.pnlReservationForm.ResumeLayout(false);
            this.pnlFormContent.ResumeLayout(false);
            this.grpReservationDetails.ResumeLayout(false);
            this.grpReservationDetails.PerformLayout();
            this.grpReservationInfo.ResumeLayout(false);
            this.grpReservationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestCount)).EndInit();
            this.pnlFormButtons.ResumeLayout(false);
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}
