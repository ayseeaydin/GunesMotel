using System.Drawing;
using System.Windows.Forms;
using System;

namespace GunesMotel.UI.WinForms.Control
{
    partial class RoomManagementControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabPage tabRoomTypes;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRoomTypes = new System.Windows.Forms.TabPage();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.pnlRoomContent = new System.Windows.Forms.Panel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomFeature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRoomForm = new System.Windows.Forms.Panel();
            this.pnlFormRow4 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlFormRow3 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlFormRow2 = new System.Windows.Forms.Panel();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.pnlFormRow1 = new System.Windows.Forms.Panel();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.pnlRoomButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabPrices = new System.Windows.Forms.TabPage();
            this.pnlPriceContent = new System.Windows.Forms.Panel();
            this.dgvPrices = new System.Windows.Forms.DataGridView();
            this.colPriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriceRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeasonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPriceForm = new System.Windows.Forms.Panel();
            this.pnlPriceFormRow1 = new System.Windows.Forms.Panel();
            this.cmbPriceRoom = new System.Windows.Forms.ComboBox();
            this.cmbSeason = new System.Windows.Forms.ComboBox();
            this.pnlPriceFormRow2 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPriceSearch = new System.Windows.Forms.TextBox();
            this.pnlPriceButtons = new System.Windows.Forms.Panel();
            this.btnPriceAdd = new System.Windows.Forms.Button();
            this.btnPriceUpdate = new System.Windows.Forms.Button();
            this.btnPriceDelete = new System.Windows.Forms.Button();
            this.btnPriceRefresh = new System.Windows.Forms.Button();
            this.btnBulkPriceUpdate = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabRooms.SuspendLayout();
            this.pnlRoomContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.pnlRoomForm.SuspendLayout();
            this.pnlFormRow4.SuspendLayout();
            this.pnlFormRow3.SuspendLayout();
            this.pnlFormRow2.SuspendLayout();
            this.pnlFormRow1.SuspendLayout();
            this.pnlRoomButtons.SuspendLayout();
            this.tabPrices.SuspendLayout();
            this.pnlPriceContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrices)).BeginInit();
            this.pnlPriceForm.SuspendLayout();
            this.pnlPriceFormRow1.SuspendLayout();
            this.pnlPriceFormRow2.SuspendLayout();
            this.pnlPriceButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tabControl);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlMain.Size = new System.Drawing.Size(1418, 1033);
            this.pnlMain.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRoomTypes);
            this.tabControl.Controls.Add(this.tabRooms);
            this.tabControl.Controls.Add(this.tabPrices);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tabControl.Location = new System.Drawing.Point(0, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1400, 1030);
            this.tabControl.TabIndex = 1;
            // 
            // tabRoomTypes
            // 
            this.tabRoomTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.tabRoomTypes.Location = new System.Drawing.Point(4, 37);
            this.tabRoomTypes.Name = "tabRoomTypes";
            this.tabRoomTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRoomTypes.Size = new System.Drawing.Size(1392, 989);
            this.tabRoomTypes.TabIndex = 0;
            this.tabRoomTypes.Text = "Oda Türü Yönetimi";
            // 
            // tabRooms
            // 
            this.tabRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.tabRooms.Controls.Add(this.pnlRoomContent);
            this.tabRooms.Location = new System.Drawing.Point(4, 37);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(1327, 767);
            this.tabRooms.TabIndex = 0;
            this.tabRooms.Text = "Oda Yönetimi";
            // 
            // pnlRoomContent
            // 
            this.pnlRoomContent.Controls.Add(this.dgvRooms);
            this.pnlRoomContent.Controls.Add(this.pnlRoomForm);
            this.pnlRoomContent.Controls.Add(this.pnlRoomButtons);
            this.pnlRoomContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoomContent.Location = new System.Drawing.Point(3, 3);
            this.pnlRoomContent.Name = "pnlRoomContent";
            this.pnlRoomContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRoomContent.Size = new System.Drawing.Size(1321, 761);
            this.pnlRoomContent.TabIndex = 0;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRooms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvRooms.ColumnHeadersHeight = 50;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomID,
            this.colRoomNumber,
            this.colRoomTypeName,
            this.colRoomFeature,
            this.colStatus,
            this.colFloor,
            this.colDescription});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvRooms.EnableHeadersVisualStyles = false;
            this.dgvRooms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.dgvRooms.Location = new System.Drawing.Point(20, 20);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersVisible = false;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.RowTemplate.Height = 40;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(1115, 350);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
            this.dgvRooms.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRooms_DataBindingComplete);
            // 
            // colRoomID
            // 
            this.colRoomID.DataPropertyName = "RoomID";
            this.colRoomID.FillWeight = 80F;
            this.colRoomID.HeaderText = "ID";
            this.colRoomID.MinimumWidth = 6;
            this.colRoomID.Name = "colRoomID";
            this.colRoomID.ReadOnly = true;
            this.colRoomID.Visible = false;
            // 
            // colRoomNumber
            // 
            this.colRoomNumber.DataPropertyName = "RoomNumber";
            this.colRoomNumber.HeaderText = "Oda No";
            this.colRoomNumber.MinimumWidth = 6;
            this.colRoomNumber.Name = "colRoomNumber";
            this.colRoomNumber.ReadOnly = true;
            // 
            // colRoomTypeName
            // 
            this.colRoomTypeName.DataPropertyName = "RoomTypeName";
            this.colRoomTypeName.FillWeight = 120F;
            this.colRoomTypeName.HeaderText = "Oda Türü";
            this.colRoomTypeName.MinimumWidth = 6;
            this.colRoomTypeName.Name = "colRoomTypeName";
            this.colRoomTypeName.ReadOnly = true;
            // 
            // colRoomFeature
            // 
            this.colRoomFeature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRoomFeature.DataPropertyName = "RoomFeature";
            this.colRoomFeature.HeaderText = "Özellik";
            this.colRoomFeature.MinimumWidth = 6;
            this.colRoomFeature.Name = "colRoomFeature";
            this.colRoomFeature.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Durum";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colFloor
            // 
            this.colFloor.DataPropertyName = "Floor";
            this.colFloor.FillWeight = 80F;
            this.colFloor.HeaderText = "Kat";
            this.colFloor.MinimumWidth = 6;
            this.colFloor.Name = "colFloor";
            this.colFloor.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.FillWeight = 200F;
            this.colDescription.HeaderText = "Açıklama";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // pnlRoomForm
            // 
            this.pnlRoomForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomForm.Controls.Add(this.pnlFormRow4);
            this.pnlRoomForm.Controls.Add(this.pnlFormRow3);
            this.pnlRoomForm.Controls.Add(this.pnlFormRow2);
            this.pnlRoomForm.Controls.Add(this.pnlFormRow1);
            this.pnlRoomForm.Location = new System.Drawing.Point(20, 390);
            this.pnlRoomForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoomForm.Name = "pnlRoomForm";
            this.pnlRoomForm.Size = new System.Drawing.Size(1115, 240);
            this.pnlRoomForm.TabIndex = 1;
            // 
            // pnlFormRow4
            // 
            this.pnlFormRow4.Controls.Add(this.txtSearch);
            this.pnlFormRow4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow4.Location = new System.Drawing.Point(0, 180);
            this.pnlFormRow4.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow4.Name = "pnlFormRow4";
            this.pnlFormRow4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow4.Size = new System.Drawing.Size(1115, 60);
            this.pnlFormRow4.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSearch.Location = new System.Drawing.Point(15, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1085, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Ara (Oda No, Tür, Kat, Durum)";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlFormRow3
            // 
            this.pnlFormRow3.Controls.Add(this.txtDescription);
            this.pnlFormRow3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow3.Location = new System.Drawing.Point(0, 120);
            this.pnlFormRow3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow3.Name = "pnlFormRow3";
            this.pnlFormRow3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow3.Size = new System.Drawing.Size(1115, 60);
            this.pnlFormRow3.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtDescription.Location = new System.Drawing.Point(15, 15);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(1085, 30);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "Açıklama";
            // 
            // pnlFormRow2
            // 
            this.pnlFormRow2.Controls.Add(this.txtFloor);
            this.pnlFormRow2.Controls.Add(this.cmbStatus);
            this.pnlFormRow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow2.Location = new System.Drawing.Point(0, 60);
            this.pnlFormRow2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow2.Name = "pnlFormRow2";
            this.pnlFormRow2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow2.Size = new System.Drawing.Size(1115, 60);
            this.pnlFormRow2.TabIndex = 1;
            // 
            // txtFloor
            // 
            this.txtFloor.BackColor = System.Drawing.Color.White;
            this.txtFloor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFloor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtFloor.Location = new System.Drawing.Point(15, 15);
            this.txtFloor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFloor.Multiline = true;
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(450, 30);
            this.txtFloor.TabIndex = 0;
            this.txtFloor.Text = "Kat";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Boş",
            "Dolu",
            "Servis Dışı"});
            this.cmbStatus.Location = new System.Drawing.Point(485, 15);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(450, 36);
            this.cmbStatus.TabIndex = 1;
            // 
            // pnlFormRow1
            // 
            this.pnlFormRow1.Controls.Add(this.txtRoomNumber);
            this.pnlFormRow1.Controls.Add(this.cmbRoomType);
            this.pnlFormRow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow1.Location = new System.Drawing.Point(0, 0);
            this.pnlFormRow1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow1.Name = "pnlFormRow1";
            this.pnlFormRow1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow1.Size = new System.Drawing.Size(1115, 60);
            this.pnlFormRow1.TabIndex = 0;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.White;
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtRoomNumber.Location = new System.Drawing.Point(15, 15);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNumber.Multiline = true;
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(450, 30);
            this.txtRoomNumber.TabIndex = 0;
            this.txtRoomNumber.Text = "Oda Numarası";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(485, 15);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(450, 36);
            this.cmbRoomType.TabIndex = 1;
            // 
            // pnlRoomButtons
            // 
            this.pnlRoomButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomButtons.Controls.Add(this.btnAdd);
            this.pnlRoomButtons.Controls.Add(this.btnUpdate);
            this.pnlRoomButtons.Controls.Add(this.btnDelete);
            this.pnlRoomButtons.Controls.Add(this.btnRefresh);
            this.pnlRoomButtons.Location = new System.Drawing.Point(20, 650);
            this.pnlRoomButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoomButtons.Name = "pnlRoomButtons";
            this.pnlRoomButtons.Size = new System.Drawing.Size(1115, 55);
            this.pnlRoomButtons.TabIndex = 2;
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
            // 
            // tabPrices
            // 
            this.tabPrices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.tabPrices.Controls.Add(this.pnlPriceContent);
            this.tabPrices.Location = new System.Drawing.Point(4, 37);
            this.tabPrices.Name = "tabPrices";
            this.tabPrices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrices.Size = new System.Drawing.Size(1161, 703);
            this.tabPrices.TabIndex = 1;
            this.tabPrices.Text = "Fiyat Yönetimi";
            // 
            // pnlPriceContent
            // 
            this.pnlPriceContent.Controls.Add(this.dgvPrices);
            this.pnlPriceContent.Controls.Add(this.pnlPriceForm);
            this.pnlPriceContent.Controls.Add(this.pnlPriceButtons);
            this.pnlPriceContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPriceContent.Location = new System.Drawing.Point(3, 3);
            this.pnlPriceContent.Name = "pnlPriceContent";
            this.pnlPriceContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlPriceContent.Size = new System.Drawing.Size(1155, 697);
            this.pnlPriceContent.TabIndex = 0;
            // 
            // dgvPrices
            // 
            this.dgvPrices.AllowUserToAddRows = false;
            this.dgvPrices.AllowUserToDeleteRows = false;
            this.dgvPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrices.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPrices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPrices.ColumnHeadersHeight = 50;
            this.dgvPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPriceID,
            this.colPriceRoomNumber,
            this.colPriceRoomType,
            this.colSeasonName,
            this.colPrice,
            this.colLastUpdated});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrices.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPrices.EnableHeadersVisualStyles = false;
            this.dgvPrices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.dgvPrices.Location = new System.Drawing.Point(20, 20);
            this.dgvPrices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrices.Name = "dgvPrices";
            this.dgvPrices.ReadOnly = true;
            this.dgvPrices.RowHeadersVisible = false;
            this.dgvPrices.RowHeadersWidth = 51;
            this.dgvPrices.RowTemplate.Height = 40;
            this.dgvPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrices.Size = new System.Drawing.Size(1115, 400);
            this.dgvPrices.TabIndex = 0;
            // 
            // colPriceID
            // 
            this.colPriceID.DataPropertyName = "RoomPriceID";
            this.colPriceID.HeaderText = "ID";
            this.colPriceID.MinimumWidth = 6;
            this.colPriceID.Name = "colPriceID";
            this.colPriceID.ReadOnly = true;
            this.colPriceID.Visible = false;
            // 
            // colPriceRoomNumber
            // 
            this.colPriceRoomNumber.DataPropertyName = "RoomNumber";
            this.colPriceRoomNumber.HeaderText = "Oda No";
            this.colPriceRoomNumber.MinimumWidth = 6;
            this.colPriceRoomNumber.Name = "colPriceRoomNumber";
            this.colPriceRoomNumber.ReadOnly = true;
            // 
            // colPriceRoomType
            // 
            this.colPriceRoomType.DataPropertyName = "RoomType";
            this.colPriceRoomType.FillWeight = 120F;
            this.colPriceRoomType.HeaderText = "Oda Türü";
            this.colPriceRoomType.MinimumWidth = 6;
            this.colPriceRoomType.Name = "colPriceRoomType";
            this.colPriceRoomType.ReadOnly = true;
            // 
            // colSeasonName
            // 
            this.colSeasonName.DataPropertyName = "SeasonName";
            this.colSeasonName.FillWeight = 120F;
            this.colSeasonName.HeaderText = "Sezon";
            this.colSeasonName.MinimumWidth = 6;
            this.colSeasonName.Name = "colSeasonName";
            this.colSeasonName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Fiyat (€)";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colLastUpdated
            // 
            this.colLastUpdated.DataPropertyName = "LastUpdated";
            this.colLastUpdated.FillWeight = 120F;
            this.colLastUpdated.HeaderText = "Son Güncelleme";
            this.colLastUpdated.MinimumWidth = 6;
            this.colLastUpdated.Name = "colLastUpdated";
            this.colLastUpdated.ReadOnly = true;
            // 
            // pnlPriceForm
            // 
            this.pnlPriceForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlPriceForm.Controls.Add(this.pnlPriceFormRow1);
            this.pnlPriceForm.Controls.Add(this.pnlPriceFormRow2);
            this.pnlPriceForm.Location = new System.Drawing.Point(20, 440);
            this.pnlPriceForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPriceForm.Name = "pnlPriceForm";
            this.pnlPriceForm.Size = new System.Drawing.Size(1115, 140);
            this.pnlPriceForm.TabIndex = 1;
            // 
            // pnlPriceFormRow1
            // 
            this.pnlPriceFormRow1.Controls.Add(this.cmbPriceRoom);
            this.pnlPriceFormRow1.Controls.Add(this.cmbSeason);
            this.pnlPriceFormRow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPriceFormRow1.Location = new System.Drawing.Point(0, 60);
            this.pnlPriceFormRow1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPriceFormRow1.Name = "pnlPriceFormRow1";
            this.pnlPriceFormRow1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlPriceFormRow1.Size = new System.Drawing.Size(1115, 60);
            this.pnlPriceFormRow1.TabIndex = 0;
            // 
            // cmbPriceRoom
            // 
            this.cmbPriceRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriceRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbPriceRoom.FormattingEnabled = true;
            this.cmbPriceRoom.Location = new System.Drawing.Point(15, 15);
            this.cmbPriceRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPriceRoom.Name = "cmbPriceRoom";
            this.cmbPriceRoom.Size = new System.Drawing.Size(450, 36);
            this.cmbPriceRoom.TabIndex = 0;
            // 
            // cmbSeason
            // 
            this.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeason.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbSeason.FormattingEnabled = true;
            this.cmbSeason.Location = new System.Drawing.Point(485, 15);
            this.cmbSeason.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.Size = new System.Drawing.Size(450, 36);
            this.cmbSeason.TabIndex = 1;
            // 
            // pnlPriceFormRow2
            // 
            this.pnlPriceFormRow2.Controls.Add(this.txtPrice);
            this.pnlPriceFormRow2.Controls.Add(this.txtPriceSearch);
            this.pnlPriceFormRow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPriceFormRow2.Location = new System.Drawing.Point(0, 0);
            this.pnlPriceFormRow2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPriceFormRow2.Name = "pnlPriceFormRow2";
            this.pnlPriceFormRow2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlPriceFormRow2.Size = new System.Drawing.Size(1115, 60);
            this.pnlPriceFormRow2.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPrice.Location = new System.Drawing.Point(15, 15);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(450, 30);
            this.txtPrice.TabIndex = 0;
            this.txtPrice.Text = "Fiyat (€)";
            // 
            // txtPriceSearch
            // 
            this.txtPriceSearch.BackColor = System.Drawing.Color.White;
            this.txtPriceSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPriceSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtPriceSearch.Location = new System.Drawing.Point(485, 15);
            this.txtPriceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceSearch.Multiline = true;
            this.txtPriceSearch.Name = "txtPriceSearch";
            this.txtPriceSearch.Size = new System.Drawing.Size(450, 30);
            this.txtPriceSearch.TabIndex = 1;
            this.txtPriceSearch.Text = "Ara (Oda No, Sezon)";
            // 
            // pnlPriceButtons
            // 
            this.pnlPriceButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlPriceButtons.Controls.Add(this.btnPriceAdd);
            this.pnlPriceButtons.Controls.Add(this.btnPriceUpdate);
            this.pnlPriceButtons.Controls.Add(this.btnPriceDelete);
            this.pnlPriceButtons.Controls.Add(this.btnPriceRefresh);
            this.pnlPriceButtons.Controls.Add(this.btnBulkPriceUpdate);
            this.pnlPriceButtons.Location = new System.Drawing.Point(20, 600);
            this.pnlPriceButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPriceButtons.Name = "pnlPriceButtons";
            this.pnlPriceButtons.Size = new System.Drawing.Size(1115, 55);
            this.pnlPriceButtons.TabIndex = 2;
            // 
            // btnPriceAdd
            // 
            this.btnPriceAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnPriceAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceAdd.FlatAppearance.BorderSize = 0;
            this.btnPriceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPriceAdd.ForeColor = System.Drawing.Color.White;
            this.btnPriceAdd.Location = new System.Drawing.Point(0, 0);
            this.btnPriceAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnPriceAdd.Name = "btnPriceAdd";
            this.btnPriceAdd.Size = new System.Drawing.Size(150, 55);
            this.btnPriceAdd.TabIndex = 0;
            this.btnPriceAdd.Text = "Ekle";
            this.btnPriceAdd.UseVisualStyleBackColor = false;
            // 
            // btnPriceUpdate
            // 
            this.btnPriceUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnPriceUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceUpdate.FlatAppearance.BorderSize = 0;
            this.btnPriceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPriceUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPriceUpdate.Location = new System.Drawing.Point(170, 0);
            this.btnPriceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnPriceUpdate.Name = "btnPriceUpdate";
            this.btnPriceUpdate.Size = new System.Drawing.Size(150, 55);
            this.btnPriceUpdate.TabIndex = 1;
            this.btnPriceUpdate.Text = "Güncelle";
            this.btnPriceUpdate.UseVisualStyleBackColor = false;
            // 
            // btnPriceDelete
            // 
            this.btnPriceDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnPriceDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceDelete.FlatAppearance.BorderSize = 0;
            this.btnPriceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPriceDelete.ForeColor = System.Drawing.Color.White;
            this.btnPriceDelete.Location = new System.Drawing.Point(340, 0);
            this.btnPriceDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPriceDelete.Name = "btnPriceDelete";
            this.btnPriceDelete.Size = new System.Drawing.Size(150, 55);
            this.btnPriceDelete.TabIndex = 2;
            this.btnPriceDelete.Text = "Sil";
            this.btnPriceDelete.UseVisualStyleBackColor = false;
            // 
            // btnPriceRefresh
            // 
            this.btnPriceRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnPriceRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceRefresh.FlatAppearance.BorderSize = 0;
            this.btnPriceRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPriceRefresh.ForeColor = System.Drawing.Color.White;
            this.btnPriceRefresh.Location = new System.Drawing.Point(510, 0);
            this.btnPriceRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnPriceRefresh.Name = "btnPriceRefresh";
            this.btnPriceRefresh.Size = new System.Drawing.Size(150, 55);
            this.btnPriceRefresh.TabIndex = 3;
            this.btnPriceRefresh.Text = "Yenile";
            this.btnPriceRefresh.UseVisualStyleBackColor = false;
            // 
            // btnBulkPriceUpdate
            // 
            this.btnBulkPriceUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(160)))), ((int)(((byte)(23)))));
            this.btnBulkPriceUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBulkPriceUpdate.FlatAppearance.BorderSize = 0;
            this.btnBulkPriceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulkPriceUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBulkPriceUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBulkPriceUpdate.Location = new System.Drawing.Point(680, 0);
            this.btnBulkPriceUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBulkPriceUpdate.Name = "btnBulkPriceUpdate";
            this.btnBulkPriceUpdate.Size = new System.Drawing.Size(200, 55);
            this.btnBulkPriceUpdate.TabIndex = 4;
            this.btnBulkPriceUpdate.Text = "Toplu Fiyat Güncelle";
            this.btnBulkPriceUpdate.UseVisualStyleBackColor = false;
            // 
            // RoomManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManagementControl";
            this.Size = new System.Drawing.Size(1418, 1033);
            this.pnlMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabRooms.ResumeLayout(false);
            this.pnlRoomContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlRoomForm.ResumeLayout(false);
            this.pnlFormRow4.ResumeLayout(false);
            this.pnlFormRow4.PerformLayout();
            this.pnlFormRow3.ResumeLayout(false);
            this.pnlFormRow3.PerformLayout();
            this.pnlFormRow2.ResumeLayout(false);
            this.pnlFormRow2.PerformLayout();
            this.pnlFormRow1.ResumeLayout(false);
            this.pnlFormRow1.PerformLayout();
            this.pnlRoomButtons.ResumeLayout(false);
            this.tabPrices.ResumeLayout(false);
            this.pnlPriceContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrices)).EndInit();
            this.pnlPriceForm.ResumeLayout(false);
            this.pnlPriceFormRow1.ResumeLayout(false);
            this.pnlPriceFormRow2.ResumeLayout(false);
            this.pnlPriceFormRow2.PerformLayout();
            this.pnlPriceButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlMain;
        private Panel pnlContent;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn colPriceType;
        private Panel pnlForm;
        private Panel pnlButtons;
        private TabControl tabControl;
        private TabPage tabRooms;
        private Panel pnlRoomContent;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colRoomID;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomTypeName;
        private DataGridViewTextBoxColumn colRoomFeature;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colFloor;
        private DataGridViewTextBoxColumn colDescription;
        private Panel pnlRoomForm;
        private Panel pnlFormRow4;
        private TextBox txtSearch;
        private Panel pnlFormRow3;
        private TextBox txtDescription;
        private Panel pnlFormRow2;
        private TextBox txtFloor;
        private ComboBox cmbStatus;
        private Panel pnlFormRow1;
        private TextBox txtRoomNumber;
        private ComboBox cmbRoomType;
        private Panel pnlRoomButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private TabPage tabPrices;
        private Panel pnlPriceContent;
        private DataGridView dgvPrices;
        private DataGridViewTextBoxColumn colPriceID;
        private DataGridViewTextBoxColumn colPriceRoomNumber;
        private DataGridViewTextBoxColumn colPriceRoomType;
        private DataGridViewTextBoxColumn colSeasonName;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colLastUpdated;
        private Panel pnlPriceForm;
        private Panel pnlPriceFormRow1;
        private ComboBox cmbPriceRoom;
        private ComboBox cmbSeason;
        private Panel pnlPriceFormRow2;
        private TextBox txtPrice;
        private TextBox txtPriceSearch;
        private Panel pnlPriceButtons;
        private Button btnPriceAdd;
        private Button btnPriceUpdate;
        private Button btnPriceDelete;
        private Button btnPriceRefresh;
        private Button btnBulkPriceUpdate;
    }
}
