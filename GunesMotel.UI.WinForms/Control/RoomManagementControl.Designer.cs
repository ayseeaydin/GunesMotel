using System.Drawing;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    partial class RoomManagementControl
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.colRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFloor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.Panel();
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlFormRow4.SuspendLayout();
            this.pnlFormRow3.SuspendLayout();
            this.pnlFormRow2.SuspendLayout();
            this.pnlFormRow1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlMain.Size = new System.Drawing.Size(1223, 869);
            this.pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Oda Yönetimi";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.pnlContent.Controls.Add(this.dgvRooms);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Location = new System.Drawing.Point(27, 100);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1169, 744);
            this.pnlContent.TabIndex = 1;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.ColumnHeadersHeight = 50;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRoomID,
            this.colRoomNumber,
            this.colRoomTypeName,
            this.colFloor,
            this.colStatus,
            this.colDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvRooms.Size = new System.Drawing.Size(1129, 400);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_CellClick);
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
            // colFloor
            // 
            this.colFloor.DataPropertyName = "Floor";
            this.colFloor.FillWeight = 80F;
            this.colFloor.HeaderText = "Kat";
            this.colFloor.MinimumWidth = 6;
            this.colFloor.Name = "colFloor";
            this.colFloor.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Durum";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
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
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.Controls.Add(this.pnlFormRow4);
            this.pnlForm.Controls.Add(this.pnlFormRow3);
            this.pnlForm.Controls.Add(this.pnlFormRow2);
            this.pnlForm.Controls.Add(this.pnlFormRow1);
            this.pnlForm.Location = new System.Drawing.Point(20, 440);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1129, 240);
            this.pnlForm.TabIndex = 1;
            // 
            // pnlFormRow4
            // 
            this.pnlFormRow4.Controls.Add(this.txtSearch);
            this.pnlFormRow4.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow4.Location = new System.Drawing.Point(0, 180);
            this.pnlFormRow4.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow4.Name = "pnlFormRow4";
            this.pnlFormRow4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow4.Size = new System.Drawing.Size(1129, 60);
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
            this.txtSearch.Size = new System.Drawing.Size(1099, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Ara (Oda No, Tür, Kat, Durum)";
            // 
            // pnlFormRow3
            // 
            this.pnlFormRow3.Controls.Add(this.txtDescription);
            this.pnlFormRow3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow3.Location = new System.Drawing.Point(0, 120);
            this.pnlFormRow3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow3.Name = "pnlFormRow3";
            this.pnlFormRow3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow3.Size = new System.Drawing.Size(1129, 60);
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
            this.txtDescription.Size = new System.Drawing.Size(1099, 30);
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
            this.pnlFormRow2.Size = new System.Drawing.Size(1129, 60);
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
            this.pnlFormRow1.Size = new System.Drawing.Size(1129, 60);
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
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Location = new System.Drawing.Point(20, 700);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1129, 55);
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
            // RoomManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManagementControl";
            this.Size = new System.Drawing.Size(1223, 869);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlFormRow4.ResumeLayout(false);
            this.pnlFormRow4.PerformLayout();
            this.pnlFormRow3.ResumeLayout(false);
            this.pnlFormRow3.PerformLayout();
            this.pnlFormRow2.ResumeLayout(false);
            this.pnlFormRow2.PerformLayout();
            this.pnlFormRow1.ResumeLayout(false);
            this.pnlFormRow1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlMain;
        private Label lblTitle;
        private Panel pnlContent;
        private DataGridView dgvRooms;
        private DataGridViewTextBoxColumn colRoomID;
        private DataGridViewTextBoxColumn colRoomNumber;
        private DataGridViewTextBoxColumn colRoomTypeName;
        private DataGridViewTextBoxColumn colFloor;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colDescription;
        private Panel pnlForm;
        private Panel pnlFormRow1;
        private TextBox txtRoomNumber;
        private ComboBox cmbRoomType;
        private Panel pnlFormRow2;
        private TextBox txtFloor;
        private ComboBox cmbStatus;
        private Panel pnlFormRow3;
        private TextBox txtDescription;
        private Panel pnlFormRow4;
        private TextBox txtSearch;
        private Panel pnlButtons;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
    }
}
