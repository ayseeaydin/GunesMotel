namespace GunesMotel.UI.WinForms.Control
{
    partial class SeasonManagementControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvSeasons = new System.Windows.Forms.DataGridView();
            this.colSeasonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeasonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlFormRow1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtSeasonName = new System.Windows.Forms.TextBox();
            this.pnlFormRow2 = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.pnlFormRow3 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeasons)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlFormRow1.SuspendLayout();
            this.pnlFormRow2.SuspendLayout();
            this.pnlFormRow3.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1200, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.pnlContent.Controls.Add(this.dgvSeasons);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Controls.Add(this.pnlButtons);
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContent.Size = new System.Drawing.Size(1200, 800);
            this.pnlContent.TabIndex = 1;
            // 
            // dgvSeasons
            // 
            this.dgvSeasons.AllowUserToAddRows = false;
            this.dgvSeasons.AllowUserToDeleteRows = false;
            this.dgvSeasons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSeasons.BackgroundColor = System.Drawing.Color.White;
            this.dgvSeasons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSeasons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSeasons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSeasons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSeasons.ColumnHeadersHeight = 50;
            this.dgvSeasons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSeasonID,
            this.colSeasonName,
            this.colStartDate,
            this.colEndDate,
            this.colDescription});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSeasons.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSeasons.EnableHeadersVisualStyles = false;
            this.dgvSeasons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.dgvSeasons.Location = new System.Drawing.Point(20, 20);
            this.dgvSeasons.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSeasons.Name = "dgvSeasons";
            this.dgvSeasons.ReadOnly = true;
            this.dgvSeasons.RowHeadersVisible = false;
            this.dgvSeasons.RowHeadersWidth = 51;
            this.dgvSeasons.RowTemplate.Height = 40;
            this.dgvSeasons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeasons.Size = new System.Drawing.Size(1106, 350);
            this.dgvSeasons.TabIndex = 0;
            this.dgvSeasons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeasons_CellClick);
            // 
            // colSeasonID
            // 
            this.colSeasonID.DataPropertyName = "SeasonID";
            this.colSeasonID.FillWeight = 80F;
            this.colSeasonID.HeaderText = "ID";
            this.colSeasonID.MinimumWidth = 6;
            this.colSeasonID.Name = "colSeasonID";
            this.colSeasonID.ReadOnly = true;
            this.colSeasonID.Visible = false;
            // 
            // colSeasonName
            // 
            this.colSeasonName.DataPropertyName = "SeasonName";
            this.colSeasonName.FillWeight = 120F;
            this.colSeasonName.HeaderText = "Sezon Adı";
            this.colSeasonName.MinimumWidth = 6;
            this.colSeasonName.Name = "colSeasonName";
            this.colSeasonName.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.FillWeight = 120F;
            this.colStartDate.HeaderText = "Başlangıç Tarihi";
            this.colStartDate.MinimumWidth = 6;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            this.colEndDate.DataPropertyName = "EndDate";
            this.colEndDate.FillWeight = 120F;
            this.colEndDate.HeaderText = "Bitiş Tarihi";
            this.colEndDate.MinimumWidth = 6;
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
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
            this.pnlForm.Controls.Add(this.pnlFormRow1);
            this.pnlForm.Controls.Add(this.pnlFormRow2);
            this.pnlForm.Controls.Add(this.pnlFormRow3);
            this.pnlForm.Location = new System.Drawing.Point(20, 390);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1106, 190);
            this.pnlForm.TabIndex = 1;
            // 
            // pnlFormRow1
            // 
            this.pnlFormRow1.Controls.Add(this.txtSearch);
            this.pnlFormRow1.Controls.Add(this.txtSeasonName);
            this.pnlFormRow1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow1.Location = new System.Drawing.Point(0, 130);
            this.pnlFormRow1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow1.Name = "pnlFormRow1";
            this.pnlFormRow1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow1.Size = new System.Drawing.Size(1106, 60);
            this.pnlFormRow1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSearch.Location = new System.Drawing.Point(485, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Ara";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // txtSeasonName
            // 
            this.txtSeasonName.BackColor = System.Drawing.Color.White;
            this.txtSeasonName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeasonName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSeasonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.txtSeasonName.Location = new System.Drawing.Point(15, 15);
            this.txtSeasonName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeasonName.Multiline = true;
            this.txtSeasonName.Name = "txtSeasonName";
            this.txtSeasonName.Size = new System.Drawing.Size(450, 30);
            this.txtSeasonName.TabIndex = 0;
            this.txtSeasonName.Text = "Sezon Adı";
            this.txtSeasonName.Enter += new System.EventHandler(this.txtSeasonName_Enter);
            this.txtSeasonName.Leave += new System.EventHandler(this.txtSeasonName_Leave);
            // 
            // pnlFormRow2
            // 
            this.pnlFormRow2.Controls.Add(this.dtpEndDate);
            this.pnlFormRow2.Controls.Add(this.dtpStartDate);
            this.pnlFormRow2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow2.Location = new System.Drawing.Point(0, 70);
            this.pnlFormRow2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow2.Name = "pnlFormRow2";
            this.pnlFormRow2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow2.Size = new System.Drawing.Size(1106, 60);
            this.pnlFormRow2.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(485, 10);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(450, 34);
            this.dtpEndDate.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(15, 10);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(450, 34);
            this.dtpStartDate.TabIndex = 1;
            // 
            // pnlFormRow3
            // 
            this.pnlFormRow3.Controls.Add(this.txtDescription);
            this.pnlFormRow3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormRow3.Location = new System.Drawing.Point(0, 0);
            this.pnlFormRow3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFormRow3.Name = "pnlFormRow3";
            this.pnlFormRow3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlFormRow3.Size = new System.Drawing.Size(1106, 70);
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
            this.txtDescription.Size = new System.Drawing.Size(1076, 40);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "Açıklama";
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnRefresh);
            this.pnlButtons.Location = new System.Drawing.Point(20, 600);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1106, 55);
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
            // SeasonManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SeasonManagementControl";
            this.Size = new System.Drawing.Size(1200, 800);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeasons)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlFormRow1.ResumeLayout(false);
            this.pnlFormRow1.PerformLayout();
            this.pnlFormRow2.ResumeLayout(false);
            this.pnlFormRow3.ResumeLayout(false);
            this.pnlFormRow3.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvSeasons;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlFormRow1;
        private System.Windows.Forms.TextBox txtSeasonName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Panel pnlFormRow2;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel pnlFormRow3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeasonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeasonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
