namespace GunesMotel.UI.WinForms.Control
{
    partial class EmployeeManagementControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.pnlFormRow2 = new System.Windows.Forms.Panel();
            this.txtPassportID = new System.Windows.Forms.TextBox();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.pnlFormRow3 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.pnlFormRow4 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.pnlFormRow5 = new System.Windows.Forms.Panel();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.pnlFormRow6 = new System.Windows.Forms.Panel();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLeaveDate = new System.Windows.Forms.DateTimePicker();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPositionManagement = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlFormRow2.SuspendLayout();
            this.pnlFormRow3.SuspendLayout();
            this.pnlFormRow4.SuspendLayout();
            this.pnlFormRow5.SuspendLayout();
            this.pnlFormRow6.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlMain.Size = new System.Drawing.Size(1556, 978);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.dgvEmployees);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(27, 25);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1502, 928);
            this.pnlContent.TabIndex = 1;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmployees.ColumnHeadersHeight = 50;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.dgvEmployees.Location = new System.Drawing.Point(20, 20);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 40;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(1415, 400);
            this.dgvEmployees.TabIndex = 0;
            this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.cmbGender);
            this.pnlForm.Controls.Add(this.pnlFormRow2);
            this.pnlForm.Controls.Add(this.pnlFormRow3);
            this.pnlForm.Controls.Add(this.cmbPosition);
            this.pnlForm.Controls.Add(this.pnlFormRow4);
            this.pnlForm.Controls.Add(this.pnlFormRow5);
            this.pnlForm.Controls.Add(this.pnlFormRow6);
            this.pnlForm.Location = new System.Drawing.Point(20, 440);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1415, 321);
            this.pnlForm.TabIndex = 1;
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "E",
            "K"});
            this.cmbGender.Location = new System.Drawing.Point(485, 281);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(450, 36);
            this.cmbGender.TabIndex = 0;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(15, 281);
            this.cmbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(450, 36);
            this.cmbPosition.TabIndex = 0;
            // 
            // pnlFormRow2
            // 
            this.pnlFormRow2.Controls.Add(this.txtPassportID);
            this.pnlFormRow2.Controls.Add(this.txtIBAN);
            this.pnlFormRow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow2.Location = new System.Drawing.Point(0, 205);
            this.pnlFormRow2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow2.Name = "pnlFormRow2";
            this.pnlFormRow2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow2.Size = new System.Drawing.Size(1415, 55);
            this.pnlFormRow2.TabIndex = 1;
            // 
            // txtPassportID
            // 
            this.txtPassportID.BackColor = System.Drawing.Color.White;
            this.txtPassportID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassportID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassportID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPassportID.Location = new System.Drawing.Point(15, 10);
            this.txtPassportID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassportID.Multiline = true;
            this.txtPassportID.Name = "txtPassportID";
            this.txtPassportID.Size = new System.Drawing.Size(450, 30);
            this.txtPassportID.TabIndex = 0;
            this.txtPassportID.Text = "Pasaport No";
            this.txtPassportID.Enter += new System.EventHandler(this.txtPassportID_Enter);
            this.txtPassportID.Leave += new System.EventHandler(this.txtPassportID_Leave);
            // 
            // txtIBAN
            // 
            this.txtIBAN.BackColor = System.Drawing.Color.White;
            this.txtIBAN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIBAN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtIBAN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtIBAN.Location = new System.Drawing.Point(485, 10);
            this.txtIBAN.Margin = new System.Windows.Forms.Padding(4);
            this.txtIBAN.Multiline = true;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(450, 30);
            this.txtIBAN.TabIndex = 1;
            this.txtIBAN.Text = "IBAN";
            this.txtIBAN.Enter += new System.EventHandler(this.txtIBAN_Enter);
            this.txtIBAN.Leave += new System.EventHandler(this.txtIBAN_Leave);
            // 
            // pnlFormRow3
            // 
            this.pnlFormRow3.Controls.Add(this.label1);
            this.pnlFormRow3.Controls.Add(this.txtPhone);
            this.pnlFormRow3.Controls.Add(this.dtpBirthDate);
            this.pnlFormRow3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow3.Location = new System.Drawing.Point(0, 135);
            this.pnlFormRow3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow3.Name = "pnlFormRow3";
            this.pnlFormRow3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow3.Size = new System.Drawing.Size(1415, 70);
            this.pnlFormRow3.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPhone.Location = new System.Drawing.Point(485, 25);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(450, 30);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "Telefon";
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(15, 25);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(450, 34);
            this.dtpBirthDate.TabIndex = 1;
            this.dtpBirthDate.Value = new System.DateTime(2025, 6, 8, 0, 0, 0, 0);
            // 
            // pnlFormRow4
            // 
            this.pnlFormRow4.Controls.Add(this.txtEmail);
            this.pnlFormRow4.Controls.Add(this.txtAddress);
            this.pnlFormRow4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow4.Location = new System.Drawing.Point(0, 90);
            this.pnlFormRow4.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow4.Name = "pnlFormRow4";
            this.pnlFormRow4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow4.Size = new System.Drawing.Size(1415, 45);
            this.pnlFormRow4.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtEmail.Location = new System.Drawing.Point(15, 10);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(450, 30);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "E-posta";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtAddress.Location = new System.Drawing.Point(485, 10);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(450, 30);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "Adres";
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // pnlFormRow5
            // 
            this.pnlFormRow5.Controls.Add(this.txtNationalID);
            this.pnlFormRow5.Controls.Add(this.txtFullName);
            this.pnlFormRow5.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow5.Location = new System.Drawing.Point(0, 45);
            this.pnlFormRow5.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow5.Name = "pnlFormRow5";
            this.pnlFormRow5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow5.Size = new System.Drawing.Size(1415, 45);
            this.pnlFormRow5.TabIndex = 4;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BackColor = System.Drawing.Color.White;
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNationalID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtNationalID.Location = new System.Drawing.Point(485, 10);
            this.txtNationalID.Margin = new System.Windows.Forms.Padding(4);
            this.txtNationalID.Multiline = true;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(450, 30);
            this.txtNationalID.TabIndex = 1;
            this.txtNationalID.Text = "T.C. Kimlik No";
            this.txtNationalID.Enter += new System.EventHandler(this.txtNationalID_Enter);
            this.txtNationalID.Leave += new System.EventHandler(this.txtNationalID_Leave);
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFullName.Location = new System.Drawing.Point(15, 10);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(450, 30);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.Text = "Ad Soyad";
            this.txtFullName.Enter += new System.EventHandler(this.txtFullName_Enter);
            this.txtFullName.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // pnlFormRow6
            // 
            this.pnlFormRow6.Controls.Add(this.dtpHireDate);
            this.pnlFormRow6.Controls.Add(this.dtpLeaveDate);
            this.pnlFormRow6.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow6.Location = new System.Drawing.Point(0, 0);
            this.pnlFormRow6.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow6.Name = "pnlFormRow6";
            this.pnlFormRow6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow6.Size = new System.Drawing.Size(1415, 45);
            this.pnlFormRow6.TabIndex = 5;
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpHireDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(15, 10);
            this.dtpHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(450, 34);
            this.dtpHireDate.TabIndex = 0;
            this.dtpHireDate.Value = new System.DateTime(2025, 6, 8, 0, 0, 0, 0);
            // 
            // dtpLeaveDate
            // 
            this.dtpLeaveDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpLeaveDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpLeaveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLeaveDate.Location = new System.Drawing.Point(485, 10);
            this.dtpLeaveDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpLeaveDate.Name = "dtpLeaveDate";
            this.dtpLeaveDate.ShowCheckBox = true;
            this.dtpLeaveDate.Size = new System.Drawing.Size(450, 34);
            this.dtpLeaveDate.TabIndex = 1;
            this.dtpLeaveDate.Value = new System.DateTime(2025, 6, 8, 0, 0, 0, 0);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Controls.Add(this.btnPositionManagement);
            this.pnlButtons.Location = new System.Drawing.Point(35, 769);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1415, 55);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 55);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(220, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 55);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(440, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(660, 0);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 55);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPositionManagement
            // 
            this.btnPositionManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnPositionManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPositionManagement.FlatAppearance.BorderSize = 0;
            this.btnPositionManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPositionManagement.ForeColor = System.Drawing.Color.White;
            this.btnPositionManagement.Location = new System.Drawing.Point(880, 0);
            this.btnPositionManagement.Margin = new System.Windows.Forms.Padding(4);
            this.btnPositionManagement.Name = "btnPositionManagement";
            this.btnPositionManagement.Size = new System.Drawing.Size(395, 55);
            this.btnPositionManagement.TabIndex = 4;
            this.btnPositionManagement.Text = "Pozisyonları Yönet";
            this.btnPositionManagement.UseVisualStyleBackColor = false;
            this.btnPositionManagement.Click += new System.EventHandler(this.btnPositionManagement_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(11, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(31, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "İşe Başlama Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(501, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşten Ayrılma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(11, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pozisyon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(481, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cinsiyet:";
            // 
            // EmployeeManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeManagementControl";
            this.Size = new System.Drawing.Size(1556, 978);
            this.Load += new System.EventHandler(this.EmployeeManagementControl_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlFormRow2.ResumeLayout(false);
            this.pnlFormRow2.PerformLayout();
            this.pnlFormRow3.ResumeLayout(false);
            this.pnlFormRow3.PerformLayout();
            this.pnlFormRow4.ResumeLayout(false);
            this.pnlFormRow4.PerformLayout();
            this.pnlFormRow5.ResumeLayout(false);
            this.pnlFormRow5.PerformLayout();
            this.pnlFormRow6.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Panel pnlFormRow2;
        private System.Windows.Forms.TextBox txtPassportID;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Panel pnlFormRow3;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel pnlFormRow4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlFormRow5;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Panel pnlFormRow6;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpLeaveDate;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPositionManagement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}