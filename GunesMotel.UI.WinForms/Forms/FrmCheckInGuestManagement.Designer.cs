namespace GunesMotel.UI.WinForms.Forms
{
    partial class FrmCheckInGuestManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Ana Container
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblFormTitle;

        // Üst Panel - Rezervasyon Bilgileri
        private System.Windows.Forms.Panel pnlReservationInfo;
        private System.Windows.Forms.Label lblReservationTitle;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblTotalGuests;

        // Sol Panel - Mevcut Müşteriler
        private System.Windows.Forms.Panel pnlExistingCustomers;
        private System.Windows.Forms.Label lblExistingCustomersTitle;
        private System.Windows.Forms.Panel pnlCustomerSearch;
        private System.Windows.Forms.TextBox txtCustomerSearch;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.DataGridView dgvExistingCustomers;

        // Sağ Panel - Misafir Kayıt/Düzenleme (Customers tablosuna uygun)
        private System.Windows.Forms.Panel pnlGuestForm;
        private System.Windows.Forms.Label lblGuestFormTitle;
        private System.Windows.Forms.Panel pnlCustomerTypeSelection;
        private System.Windows.Forms.RadioButton rbExistingCustomer;
        private System.Windows.Forms.RadioButton rbNewCustomer;

        // Misafir Form Alanları (Customers entity'sine uygun)
        private System.Windows.Forms.Panel pnlGuestFields;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblNationalID;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label lblPassportNo;
        private System.Windows.Forms.TextBox txtPassportNo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnClearForm;

        // Alt Panel - Rezervasyon Misafirleri
        private System.Windows.Forms.Panel pnlReservationGuests;
        private System.Windows.Forms.Label lblReservationGuestsTitle;
        private System.Windows.Forms.DataGridView dgvReservationGuests;
        private System.Windows.Forms.Panel pnlGuestActions;
        private System.Windows.Forms.Button btnRemoveGuest;

        // En Alt Panel - Ana İşlem Butonları
        private System.Windows.Forms.Panel pnlMainActions;
        private System.Windows.Forms.Button btnCompleteCheckIn;
        private System.Windows.Forms.Button btnCancel;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMainActions = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCompleteCheckIn = new System.Windows.Forms.Button();
            this.pnlReservationGuests = new System.Windows.Forms.Panel();
            this.pnlGuestActions = new System.Windows.Forms.Panel();
            this.btnRemoveGuest = new System.Windows.Forms.Button();
            this.dgvReservationGuests = new System.Windows.Forms.DataGridView();
            this.lblReservationGuestsTitle = new System.Windows.Forms.Label();
            this.pnlGuestForm = new System.Windows.Forms.Panel();
            this.pnlGuestFields = new System.Windows.Forms.Panel();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPassportNo = new System.Windows.Forms.TextBox();
            this.lblPassportNo = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.pnlCustomerTypeSelection = new System.Windows.Forms.Panel();
            this.rbNewCustomer = new System.Windows.Forms.RadioButton();
            this.rbExistingCustomer = new System.Windows.Forms.RadioButton();
            this.lblGuestFormTitle = new System.Windows.Forms.Label();
            this.pnlExistingCustomers = new System.Windows.Forms.Panel();
            this.dgvExistingCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustomerSearch = new System.Windows.Forms.Panel();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtCustomerSearch = new System.Windows.Forms.TextBox();
            this.lblExistingCustomersTitle = new System.Windows.Forms.Label();
            this.pnlReservationInfo = new System.Windows.Forms.Panel();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.lblReservationTitle = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlMainActions.SuspendLayout();
            this.pnlReservationGuests.SuspendLayout();
            this.pnlGuestActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationGuests)).BeginInit();
            this.pnlGuestForm.SuspendLayout();
            this.pnlGuestFields.SuspendLayout();
            this.pnlCustomerTypeSelection.SuspendLayout();
            this.pnlExistingCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingCustomers)).BeginInit();
            this.pnlCustomerSearch.SuspendLayout();
            this.pnlReservationInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlMainActions);
            this.pnlMain.Controls.Add(this.pnlReservationGuests);
            this.pnlMain.Controls.Add(this.pnlGuestForm);
            this.pnlMain.Controls.Add(this.pnlExistingCustomers);
            this.pnlMain.Controls.Add(this.pnlReservationInfo);
            this.pnlMain.Controls.Add(this.lblFormTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1400, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlMainActions
            // 
            this.pnlMainActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlMainActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMainActions.Controls.Add(this.btnCancel);
            this.pnlMainActions.Controls.Add(this.btnCompleteCheckIn);
            this.pnlMainActions.Location = new System.Drawing.Point(12, 656);
            this.pnlMainActions.Name = "pnlMainActions";
            this.pnlMainActions.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainActions.Size = new System.Drawing.Size(1360, 80);
            this.pnlMainActions.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(255, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "❌ İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCompleteCheckIn
            // 
            this.btnCompleteCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnCompleteCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCompleteCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteCheckIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCompleteCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCompleteCheckIn.Location = new System.Drawing.Point(15, 15);
            this.btnCompleteCheckIn.Name = "btnCompleteCheckIn";
            this.btnCompleteCheckIn.Size = new System.Drawing.Size(220, 50);
            this.btnCompleteCheckIn.TabIndex = 0;
            this.btnCompleteCheckIn.Text = "✅ Check-In\'i Tamamla";
            this.btnCompleteCheckIn.UseVisualStyleBackColor = false;
            // 
            // pnlReservationGuests
            // 
            this.pnlReservationGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlReservationGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservationGuests.Controls.Add(this.pnlGuestActions);
            this.pnlReservationGuests.Controls.Add(this.dgvReservationGuests);
            this.pnlReservationGuests.Controls.Add(this.lblReservationGuestsTitle);
            this.pnlReservationGuests.Location = new System.Drawing.Point(952, 256);
            this.pnlReservationGuests.Name = "pnlReservationGuests";
            this.pnlReservationGuests.Padding = new System.Windows.Forms.Padding(15);
            this.pnlReservationGuests.Size = new System.Drawing.Size(420, 380);
            this.pnlReservationGuests.TabIndex = 4;
            // 
            // pnlGuestActions
            // 
            this.pnlGuestActions.Controls.Add(this.btnRemoveGuest);
            this.pnlGuestActions.Location = new System.Drawing.Point(15, 330);
            this.pnlGuestActions.Name = "pnlGuestActions";
            this.pnlGuestActions.Size = new System.Drawing.Size(388, 40);
            this.pnlGuestActions.TabIndex = 2;
            // 
            // btnRemoveGuest
            // 
            this.btnRemoveGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnRemoveGuest.FlatAppearance.BorderSize = 0;
            this.btnRemoveGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveGuest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveGuest.ForeColor = System.Drawing.Color.White;
            this.btnRemoveGuest.Location = new System.Drawing.Point(0, 5);
            this.btnRemoveGuest.Name = "btnRemoveGuest";
            this.btnRemoveGuest.Size = new System.Drawing.Size(169, 30);
            this.btnRemoveGuest.TabIndex = 0;
            this.btnRemoveGuest.Text = "➖ Misafiri Kaldır";
            this.btnRemoveGuest.UseVisualStyleBackColor = false;
            // 
            // dgvReservationGuests
            // 
            this.dgvReservationGuests.AllowUserToAddRows = false;
            this.dgvReservationGuests.AllowUserToDeleteRows = false;
            this.dgvReservationGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservationGuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservationGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservationGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservationGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservationGuests.EnableHeadersVisualStyles = false;
            this.dgvReservationGuests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvReservationGuests.Location = new System.Drawing.Point(15, 55);
            this.dgvReservationGuests.MultiSelect = false;
            this.dgvReservationGuests.Name = "dgvReservationGuests";
            this.dgvReservationGuests.ReadOnly = true;
            this.dgvReservationGuests.RowHeadersVisible = false;
            this.dgvReservationGuests.RowHeadersWidth = 51;
            this.dgvReservationGuests.RowTemplate.Height = 35;
            this.dgvReservationGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservationGuests.Size = new System.Drawing.Size(388, 265);
            this.dgvReservationGuests.TabIndex = 1;
            // 
            // lblReservationGuestsTitle
            // 
            this.lblReservationGuestsTitle.AutoSize = true;
            this.lblReservationGuestsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationGuestsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblReservationGuestsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblReservationGuestsTitle.Name = "lblReservationGuestsTitle";
            this.lblReservationGuestsTitle.Size = new System.Drawing.Size(270, 28);
            this.lblReservationGuestsTitle.TabIndex = 0;
            this.lblReservationGuestsTitle.Text = "🛏 Rezervasyon Misafirleri";
            // 
            // pnlGuestForm
            // 
            this.pnlGuestForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlGuestForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGuestForm.Controls.Add(this.pnlGuestFields);
            this.pnlGuestForm.Controls.Add(this.pnlCustomerTypeSelection);
            this.pnlGuestForm.Controls.Add(this.lblGuestFormTitle);
            this.pnlGuestForm.Location = new System.Drawing.Point(482, 256);
            this.pnlGuestForm.Name = "pnlGuestForm";
            this.pnlGuestForm.Padding = new System.Windows.Forms.Padding(15);
            this.pnlGuestForm.Size = new System.Drawing.Size(450, 380);
            this.pnlGuestForm.TabIndex = 3;
            // 
            // pnlGuestFields
            // 
            this.pnlGuestFields.Controls.Add(this.btnClearForm);
            this.pnlGuestFields.Controls.Add(this.btnAddGuest);
            this.pnlGuestFields.Controls.Add(this.cmbGender);
            this.pnlGuestFields.Controls.Add(this.lblGender);
            this.pnlGuestFields.Controls.Add(this.txtAddress);
            this.pnlGuestFields.Controls.Add(this.lblAddress);
            this.pnlGuestFields.Controls.Add(this.dtpBirthDate);
            this.pnlGuestFields.Controls.Add(this.lblBirthDate);
            this.pnlGuestFields.Controls.Add(this.txtEmail);
            this.pnlGuestFields.Controls.Add(this.lblEmail);
            this.pnlGuestFields.Controls.Add(this.txtPhone);
            this.pnlGuestFields.Controls.Add(this.lblPhone);
            this.pnlGuestFields.Controls.Add(this.txtPassportNo);
            this.pnlGuestFields.Controls.Add(this.lblPassportNo);
            this.pnlGuestFields.Controls.Add(this.txtNationalID);
            this.pnlGuestFields.Controls.Add(this.lblNationalID);
            this.pnlGuestFields.Controls.Add(this.txtFullName);
            this.pnlGuestFields.Controls.Add(this.lblFullName);
            this.pnlGuestFields.Location = new System.Drawing.Point(15, 100);
            this.pnlGuestFields.Name = "pnlGuestFields";
            this.pnlGuestFields.Size = new System.Drawing.Size(418, 265);
            this.pnlGuestFields.TabIndex = 2;
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnClearForm.FlatAppearance.BorderSize = 0;
            this.btnClearForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearForm.ForeColor = System.Drawing.Color.White;
            this.btnClearForm.Location = new System.Drawing.Point(380, 190);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(30, 30);
            this.btnClearForm.TabIndex = 17;
            this.btnClearForm.Text = "🗑";
            this.btnClearForm.UseVisualStyleBackColor = false;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnAddGuest.FlatAppearance.BorderSize = 0;
            this.btnAddGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGuest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddGuest.ForeColor = System.Drawing.Color.White;
            this.btnAddGuest.Location = new System.Drawing.Point(320, 225);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(90, 35);
            this.btnAddGuest.TabIndex = 16;
            this.btnAddGuest.Text = "➕ Ekle";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbGender.Location = new System.Drawing.Point(218, 230);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(80, 28);
            this.cmbGender.TabIndex = 15;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblGender.Location = new System.Drawing.Point(218, 205);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 20);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "Cinsiyet:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(0, 230);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 27);
            this.txtAddress.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblAddress.Location = new System.Drawing.Point(0, 205);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(50, 20);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Adres:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(218, 165);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(130, 27);
            this.dtpBirthDate.TabIndex = 11;
            this.dtpBirthDate.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblBirthDate.Location = new System.Drawing.Point(218, 140);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(101, 20);
            this.lblBirthDate.TabIndex = 10;
            this.lblBirthDate.Text = "Doğum Tarihi:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(0, 165);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblEmail.Location = new System.Drawing.Point(0, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(218, 100);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 27);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblPhone.Location = new System.Drawing.Point(218, 75);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefon:";
            // 
            // txtPassportNo
            // 
            this.txtPassportNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassportNo.Location = new System.Drawing.Point(0, 100);
            this.txtPassportNo.MaxLength = 20;
            this.txtPassportNo.Name = "txtPassportNo";
            this.txtPassportNo.Size = new System.Drawing.Size(200, 27);
            this.txtPassportNo.TabIndex = 5;
            // 
            // lblPassportNo
            // 
            this.lblPassportNo.AutoSize = true;
            this.lblPassportNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPassportNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblPassportNo.Location = new System.Drawing.Point(0, 75);
            this.lblPassportNo.Name = "lblPassportNo";
            this.lblPassportNo.Size = new System.Drawing.Size(93, 20);
            this.lblPassportNo.TabIndex = 4;
            this.lblPassportNo.Text = "Pasaport No:";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationalID.Location = new System.Drawing.Point(218, 35);
            this.txtNationalID.MaxLength = 11;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(200, 27);
            this.txtNationalID.TabIndex = 3;
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblNationalID.Location = new System.Drawing.Point(218, 10);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(97, 20);
            this.lblNationalID.TabIndex = 2;
            this.lblNationalID.Text = "TC Kimlik No:";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.Location = new System.Drawing.Point(0, 35);
            this.txtFullName.MaxLength = 100;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 27);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblFullName.Location = new System.Drawing.Point(0, 10);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(76, 20);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Ad Soyad:";
            // 
            // pnlCustomerTypeSelection
            // 
            this.pnlCustomerTypeSelection.Controls.Add(this.rbNewCustomer);
            this.pnlCustomerTypeSelection.Controls.Add(this.rbExistingCustomer);
            this.pnlCustomerTypeSelection.Location = new System.Drawing.Point(15, 55);
            this.pnlCustomerTypeSelection.Name = "pnlCustomerTypeSelection";
            this.pnlCustomerTypeSelection.Size = new System.Drawing.Size(418, 35);
            this.pnlCustomerTypeSelection.TabIndex = 1;
            // 
            // rbNewCustomer
            // 
            this.rbNewCustomer.AutoSize = true;
            this.rbNewCustomer.Checked = true;
            this.rbNewCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbNewCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.rbNewCustomer.Location = new System.Drawing.Point(160, 5);
            this.rbNewCustomer.Name = "rbNewCustomer";
            this.rbNewCustomer.Size = new System.Drawing.Size(124, 27);
            this.rbNewCustomer.TabIndex = 1;
            this.rbNewCustomer.TabStop = true;
            this.rbNewCustomer.Text = "Yeni Müşteri";
            this.rbNewCustomer.UseVisualStyleBackColor = true;
            // 
            // rbExistingCustomer
            // 
            this.rbExistingCustomer.AutoSize = true;
            this.rbExistingCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbExistingCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.rbExistingCustomer.Location = new System.Drawing.Point(0, 5);
            this.rbExistingCustomer.Name = "rbExistingCustomer";
            this.rbExistingCustomer.Size = new System.Drawing.Size(149, 27);
            this.rbExistingCustomer.TabIndex = 0;
            this.rbExistingCustomer.Text = "Mevcut Müşteri";
            this.rbExistingCustomer.UseVisualStyleBackColor = true;
            // 
            // lblGuestFormTitle
            // 
            this.lblGuestFormTitle.AutoSize = true;
            this.lblGuestFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGuestFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblGuestFormTitle.Location = new System.Drawing.Point(15, 15);
            this.lblGuestFormTitle.Name = "lblGuestFormTitle";
            this.lblGuestFormTitle.Size = new System.Drawing.Size(193, 28);
            this.lblGuestFormTitle.TabIndex = 0;
            this.lblGuestFormTitle.Text = "📝 Misafir Bilgileri";
            // 
            // pnlExistingCustomers
            // 
            this.pnlExistingCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlExistingCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExistingCustomers.Controls.Add(this.dgvExistingCustomers);
            this.pnlExistingCustomers.Controls.Add(this.pnlCustomerSearch);
            this.pnlExistingCustomers.Controls.Add(this.lblExistingCustomersTitle);
            this.pnlExistingCustomers.Location = new System.Drawing.Point(12, 256);
            this.pnlExistingCustomers.Name = "pnlExistingCustomers";
            this.pnlExistingCustomers.Padding = new System.Windows.Forms.Padding(15);
            this.pnlExistingCustomers.Size = new System.Drawing.Size(450, 380);
            this.pnlExistingCustomers.TabIndex = 2;
            // 
            // dgvExistingCustomers
            // 
            this.dgvExistingCustomers.AllowUserToAddRows = false;
            this.dgvExistingCustomers.AllowUserToDeleteRows = false;
            this.dgvExistingCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExistingCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvExistingCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExistingCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExistingCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingCustomers.EnableHeadersVisualStyles = false;
            this.dgvExistingCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvExistingCustomers.Location = new System.Drawing.Point(15, 105);
            this.dgvExistingCustomers.MultiSelect = false;
            this.dgvExistingCustomers.Name = "dgvExistingCustomers";
            this.dgvExistingCustomers.ReadOnly = true;
            this.dgvExistingCustomers.RowHeadersVisible = false;
            this.dgvExistingCustomers.RowHeadersWidth = 51;
            this.dgvExistingCustomers.RowTemplate.Height = 35;
            this.dgvExistingCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExistingCustomers.Size = new System.Drawing.Size(418, 250);
            this.dgvExistingCustomers.TabIndex = 2;
            // 
            // pnlCustomerSearch
            // 
            this.pnlCustomerSearch.Controls.Add(this.btnSearchCustomer);
            this.pnlCustomerSearch.Controls.Add(this.txtCustomerSearch);
            this.pnlCustomerSearch.Location = new System.Drawing.Point(15, 55);
            this.pnlCustomerSearch.Name = "pnlCustomerSearch";
            this.pnlCustomerSearch.Size = new System.Drawing.Size(418, 40);
            this.pnlCustomerSearch.TabIndex = 1;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Location = new System.Drawing.Point(315, 5);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(100, 30);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "🔍 Ara";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // txtCustomerSearch
            // 
            this.txtCustomerSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtCustomerSearch.Location = new System.Drawing.Point(0, 5);
            this.txtCustomerSearch.Name = "txtCustomerSearch";
            this.txtCustomerSearch.Size = new System.Drawing.Size(300, 30);
            this.txtCustomerSearch.TabIndex = 0;
            this.txtCustomerSearch.Text = "Ad, soyad veya TC ile arayın...";
            // 
            // lblExistingCustomersTitle
            // 
            this.lblExistingCustomersTitle.AutoSize = true;
            this.lblExistingCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblExistingCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblExistingCustomersTitle.Location = new System.Drawing.Point(15, 15);
            this.lblExistingCustomersTitle.Name = "lblExistingCustomersTitle";
            this.lblExistingCustomersTitle.Size = new System.Drawing.Size(221, 28);
            this.lblExistingCustomersTitle.TabIndex = 0;
            this.lblExistingCustomersTitle.Text = "👥 Mevcut Müşteriler";
            // 
            // pnlReservationInfo
            // 
            this.pnlReservationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.pnlReservationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservationInfo.Controls.Add(this.lblTotalGuests);
            this.pnlReservationInfo.Controls.Add(this.lblCheckOutDate);
            this.pnlReservationInfo.Controls.Add(this.lblCheckInDate);
            this.pnlReservationInfo.Controls.Add(this.lblRoomNumber);
            this.pnlReservationInfo.Controls.Add(this.lblReservationID);
            this.pnlReservationInfo.Controls.Add(this.lblReservationTitle);
            this.pnlReservationInfo.Location = new System.Drawing.Point(12, 136);
            this.pnlReservationInfo.Name = "pnlReservationInfo";
            this.pnlReservationInfo.Padding = new System.Windows.Forms.Padding(15);
            this.pnlReservationInfo.Size = new System.Drawing.Size(1360, 100);
            this.pnlReservationInfo.TabIndex = 1;
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblTotalGuests.Location = new System.Drawing.Point(740, 55);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(122, 23);
            this.lblTotalGuests.TabIndex = 5;
            this.lblTotalGuests.Text = "Misafir Sayısı: -";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCheckOutDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblCheckOutDate.Location = new System.Drawing.Point(550, 55);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(105, 23);
            this.lblCheckOutDate.TabIndex = 4;
            this.lblCheckOutDate.Text = "Çıkış Tarihi: -";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCheckInDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblCheckInDate.Location = new System.Drawing.Point(360, 55);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(104, 23);
            this.lblCheckInDate.TabIndex = 3;
            this.lblCheckInDate.Text = "Giriş Tarihi: -";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(220, 55);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(86, 23);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "Oda No: -";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReservationID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblReservationID.Location = new System.Drawing.Point(15, 55);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(148, 23);
            this.lblReservationID.TabIndex = 1;
            this.lblReservationID.Text = "Rezervasyon No: -";
            // 
            // lblReservationTitle
            // 
            this.lblReservationTitle.AutoSize = true;
            this.lblReservationTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblReservationTitle.Location = new System.Drawing.Point(15, 15);
            this.lblReservationTitle.Name = "lblReservationTitle";
            this.lblReservationTitle.Size = new System.Drawing.Size(246, 28);
            this.lblReservationTitle.TabIndex = 0;
            this.lblReservationTitle.Text = "📋 Rezervasyon Bilgileri";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 76);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(430, 41);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "🏨 Check-In Misafir Yönetimi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 49);
            this.panel1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1322, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 31);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmCheckInGuestManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckInGuestManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-In Misafir Yönetimi - Güneş Otel";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlMainActions.ResumeLayout(false);
            this.pnlReservationGuests.ResumeLayout(false);
            this.pnlReservationGuests.PerformLayout();
            this.pnlGuestActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservationGuests)).EndInit();
            this.pnlGuestForm.ResumeLayout(false);
            this.pnlGuestForm.PerformLayout();
            this.pnlGuestFields.ResumeLayout(false);
            this.pnlGuestFields.PerformLayout();
            this.pnlCustomerTypeSelection.ResumeLayout(false);
            this.pnlCustomerTypeSelection.PerformLayout();
            this.pnlExistingCustomers.ResumeLayout(false);
            this.pnlExistingCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingCustomers)).EndInit();
            this.pnlCustomerSearch.ResumeLayout(false);
            this.pnlCustomerSearch.PerformLayout();
            this.pnlReservationInfo.ResumeLayout(false);
            this.pnlReservationInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}