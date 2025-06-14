namespace GunesMotel.UI.WinForms.Control
{
    partial class AddCustomerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Label lblSearchType;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCustomerForm;
        private System.Windows.Forms.Panel pnlFormHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFormContent;
        private System.Windows.Forms.GroupBox grpPersonalInfo;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.TextBox txtPassportNo;
        private System.Windows.Forms.Label lblPassportNo;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox grpContactInfo;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlFormButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlCustomerList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Panel pnlListButtons;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.lblSearchType = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlCustomerList = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.pnlListButtons = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.pnlCustomerForm = new System.Windows.Forms.Panel();
            this.pnlFormButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlFormContent = new System.Windows.Forms.Panel();
            this.grpNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpContactInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpPersonalInfo = new System.Windows.Forms.GroupBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtPassportNo = new System.Windows.Forms.TextBox();
            this.lblPassportNo = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlFormHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlSearch.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.pnlListButtons.SuspendLayout();
            this.pnlCustomerForm.SuspendLayout();
            this.pnlFormButtons.SuspendLayout();
            this.pnlFormContent.SuspendLayout();
            this.grpNotes.SuspendLayout();
            this.grpContactInfo.SuspendLayout();
            this.grpPersonalInfo.SuspendLayout();
            this.pnlFormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.cmbSearchType);
            this.pnlSearch.Controls.Add(this.lblSearchType);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlSearch.Size = new System.Drawing.Size(1200, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(570, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
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
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Ad Soyad",
            "Telefon",
            "E-posta",
            "TC Kimlik No",
            "Pasaport No"});
            this.cmbSearchType.Location = new System.Drawing.Point(130, 17);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(150, 31);
            this.cmbSearchType.TabIndex = 1;
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
            this.pnlMain.Controls.Add(this.pnlCustomerList);
            this.pnlMain.Controls.Add(this.pnlCustomerForm);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(1200, 640);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlCustomerList
            // 
            this.pnlCustomerList.BackColor = System.Drawing.Color.White;
            this.pnlCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomerList.Controls.Add(this.dgvCustomers);
            this.pnlCustomerList.Controls.Add(this.pnlListButtons);
            this.pnlCustomerList.Controls.Add(this.lblListTitle);
            this.pnlCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerList.Location = new System.Drawing.Point(460, 10);
            this.pnlCustomerList.Name = "pnlCustomerList";
            this.pnlCustomerList.Size = new System.Drawing.Size(730, 620);
            this.pnlCustomerList.TabIndex = 1;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvCustomers.ColumnHeadersHeight = 50;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.dgvCustomers.Location = new System.Drawing.Point(0, 50);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 40;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(728, 508);
            this.dgvCustomers.TabIndex = 2;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
            // 
            // pnlListButtons
            // 
            this.pnlListButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlListButtons.Controls.Add(this.btnExport);
            this.pnlListButtons.Controls.Add(this.btnRefresh);
            this.pnlListButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlListButtons.Location = new System.Drawing.Point(0, 558);
            this.pnlListButtons.Name = "pnlListButtons";
            this.pnlListButtons.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlListButtons.Size = new System.Drawing.Size(728, 60);
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
            this.btnExport.Location = new System.Drawing.Point(638, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 35);
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
            this.btnRefresh.Location = new System.Drawing.Point(548, 12);
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
            this.lblListTitle.Size = new System.Drawing.Size(728, 50);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "📊 Müşteri Listesi";
            this.lblListTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCustomerForm
            // 
            this.pnlCustomerForm.BackColor = System.Drawing.Color.White;
            this.pnlCustomerForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomerForm.Controls.Add(this.pnlFormButtons);
            this.pnlCustomerForm.Controls.Add(this.pnlFormContent);
            this.pnlCustomerForm.Controls.Add(this.pnlFormHeader);
            this.pnlCustomerForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCustomerForm.Location = new System.Drawing.Point(10, 10);
            this.pnlCustomerForm.Name = "pnlCustomerForm";
            this.pnlCustomerForm.Size = new System.Drawing.Size(450, 620);
            this.pnlCustomerForm.TabIndex = 0;
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
            this.pnlFormButtons.Size = new System.Drawing.Size(448, 60);
            this.pnlFormButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(101, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "🗑️ Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(187, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 35);
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
            this.btnNew.Location = new System.Drawing.Point(273, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 35);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "➕ Temizle";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnSave.Size = new System.Drawing.Size(80, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.Controls.Add(this.grpNotes);
            this.pnlFormContent.Controls.Add(this.grpContactInfo);
            this.pnlFormContent.Controls.Add(this.grpPersonalInfo);
            this.pnlFormContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContent.Location = new System.Drawing.Point(0, 50);
            this.pnlFormContent.Name = "pnlFormContent";
            this.pnlFormContent.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlFormContent.Size = new System.Drawing.Size(448, 568);
            this.pnlFormContent.TabIndex = 1;
            // 
            // grpNotes
            // 
            this.grpNotes.Controls.Add(this.txtNotes);
            this.grpNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.grpNotes.Location = new System.Drawing.Point(15, 310);
            this.grpNotes.Name = "grpNotes";
            this.grpNotes.Size = new System.Drawing.Size(418, 80);
            this.grpNotes.TabIndex = 2;
            this.grpNotes.TabStop = false;
            this.grpNotes.Text = "📋 Notlar";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(3, 26);
            this.txtNotes.MaxLength = 255;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(412, 51);
            this.txtNotes.TabIndex = 0;
            // 
            // grpContactInfo
            // 
            this.grpContactInfo.Controls.Add(this.txtAddress);
            this.grpContactInfo.Controls.Add(this.lblAddress);
            this.grpContactInfo.Controls.Add(this.txtEmail);
            this.grpContactInfo.Controls.Add(this.lblEmail);
            this.grpContactInfo.Controls.Add(this.txtPhone);
            this.grpContactInfo.Controls.Add(this.lblPhone);
            this.grpContactInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpContactInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpContactInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.grpContactInfo.Location = new System.Drawing.Point(15, 190);
            this.grpContactInfo.Name = "grpContactInfo";
            this.grpContactInfo.Size = new System.Drawing.Size(418, 120);
            this.grpContactInfo.TabIndex = 1;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "📞 İletişim Bilgileri";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(90, 62);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 40);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblAddress.Location = new System.Drawing.Point(15, 65);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Adres:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(260, 55);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(140, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblEmail.Location = new System.Drawing.Point(260, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-posta:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(90, 27);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 27);
            this.txtPhone.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblPhone.Location = new System.Drawing.Point(15, 30);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Telefon:";
            // 
            // grpPersonalInfo
            // 
            this.grpPersonalInfo.Controls.Add(this.cmbGender);
            this.grpPersonalInfo.Controls.Add(this.lblGender);
            this.grpPersonalInfo.Controls.Add(this.dtpBirthDate);
            this.grpPersonalInfo.Controls.Add(this.lblBirthDate);
            this.grpPersonalInfo.Controls.Add(this.txtPassportNo);
            this.grpPersonalInfo.Controls.Add(this.lblPassportNo);
            this.grpPersonalInfo.Controls.Add(this.txtNationalID);
            this.grpPersonalInfo.Controls.Add(this.lblNationalID);
            this.grpPersonalInfo.Controls.Add(this.txtFullName);
            this.grpPersonalInfo.Controls.Add(this.lblFullName);
            this.grpPersonalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPersonalInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPersonalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.grpPersonalInfo.Location = new System.Drawing.Point(15, 10);
            this.grpPersonalInfo.Name = "grpPersonalInfo";
            this.grpPersonalInfo.Size = new System.Drawing.Size(418, 180);
            this.grpPersonalInfo.TabIndex = 0;
            this.grpPersonalInfo.TabStop = false;
            this.grpPersonalInfo.Text = "👤 Kişisel Bilgiler";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbGender.Location = new System.Drawing.Point(120, 132);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(80, 28);
            this.cmbGender.TabIndex = 9;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblGender.Location = new System.Drawing.Point(15, 135);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "Cinsiyet:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate.Location = new System.Drawing.Point(120, 97);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(130, 27);
            this.dtpBirthDate.TabIndex = 7;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblBirthDate.Location = new System.Drawing.Point(15, 100);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(101, 20);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "Doğum Tarihi:";
            // 
            // txtPassportNo
            // 
            this.txtPassportNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassportNo.Location = new System.Drawing.Point(270, 90);
            this.txtPassportNo.MaxLength = 20;
            this.txtPassportNo.Name = "txtPassportNo";
            this.txtPassportNo.Size = new System.Drawing.Size(130, 27);
            this.txtPassportNo.TabIndex = 5;
            // 
            // lblPassportNo
            // 
            this.lblPassportNo.AutoSize = true;
            this.lblPassportNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassportNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblPassportNo.Location = new System.Drawing.Point(270, 65);
            this.lblPassportNo.Name = "lblPassportNo";
            this.lblPassportNo.Size = new System.Drawing.Size(93, 20);
            this.lblPassportNo.TabIndex = 4;
            this.lblPassportNo.Text = "Pasaport No:";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalID.Location = new System.Drawing.Point(120, 62);
            this.txtNationalID.MaxLength = 11;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(130, 27);
            this.txtNationalID.TabIndex = 3;
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblNationalID.Location = new System.Drawing.Point(15, 65);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(97, 20);
            this.lblNationalID.TabIndex = 2;
            this.lblNationalID.Text = "TC Kimlik No:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.Location = new System.Drawing.Point(120, 27);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(280, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblFullName.Location = new System.Drawing.Point(15, 30);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Ad Soyad:";
            // 
            // pnlFormHeader
            // 
            this.pnlFormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.pnlFormHeader.Controls.Add(this.lblFormTitle);
            this.pnlFormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlFormHeader.Name = "pnlFormHeader";
            this.pnlFormHeader.Size = new System.Drawing.Size(448, 50);
            this.pnlFormHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblFormTitle.Location = new System.Drawing.Point(15, 12);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(199, 28);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "📝 Müşteri Bilgileri";
            // 
            // AddCustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSearch);
            this.Name = "AddCustomerControl";
            this.Size = new System.Drawing.Size(1200, 700);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.pnlListButtons.ResumeLayout(false);
            this.pnlCustomerForm.ResumeLayout(false);
            this.pnlFormButtons.ResumeLayout(false);
            this.pnlFormContent.ResumeLayout(false);
            this.grpNotes.ResumeLayout(false);
            this.grpNotes.PerformLayout();
            this.grpContactInfo.ResumeLayout(false);
            this.grpContactInfo.PerformLayout();
            this.grpPersonalInfo.ResumeLayout(false);
            this.grpPersonalInfo.PerformLayout();
            this.pnlFormHeader.ResumeLayout(false);
            this.pnlFormHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
