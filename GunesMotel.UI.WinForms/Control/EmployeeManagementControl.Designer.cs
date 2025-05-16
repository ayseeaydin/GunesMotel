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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.dgvEmployees);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.pnlMain.Size = new System.Drawing.Size(1067, 615);
            this.pnlMain.TabIndex = 0;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 155, 180);
            this.lblTitle.Location = new System.Drawing.Point(27, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Personel Yönetimi Paneli";

            // dgvEmployees
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(240, 244, 247);
            this.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 155, 180);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeight = 40;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.EnableHeadersVisualStyles = false;
            this.dgvEmployees.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvEmployees.Location = new System.Drawing.Point(27, 80);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 35;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.Size = new System.Drawing.Size(613, 511);
            this.dgvEmployees.TabIndex = 1;

            // pnlControls
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(240, 244, 247);
            this.pnlControls.Controls.Add(this.lblFullName);
            this.pnlControls.Controls.Add(this.txtFullName);
            this.pnlControls.Controls.Add(this.lblEmail);
            this.pnlControls.Controls.Add(this.txtEmail);
            this.pnlControls.Controls.Add(this.lblPhone);
            this.pnlControls.Controls.Add(this.txtPhone);
            this.pnlControls.Controls.Add(this.lblPosition);
            this.pnlControls.Controls.Add(this.cmbPosition);
            this.pnlControls.Controls.Add(this.chkIsActive);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnRefresh);
            this.pnlControls.Location = new System.Drawing.Point(667, 80);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(20);
            this.pnlControls.Size = new System.Drawing.Size(373, 511);
            this.pnlControls.TabIndex = 2;

            // lblFullName
            this.lblFullName.Text = "Ad Soyad:";
            this.lblFullName.Location = new System.Drawing.Point(20, 20);
            this.txtFullName.Location = new System.Drawing.Point(20, 45);
            this.txtFullName.Size = new System.Drawing.Size(333, 25);

            // lblEmail
            this.lblEmail.Text = "E-Posta:";
            this.lblEmail.Location = new System.Drawing.Point(20, 75);
            this.txtEmail.Location = new System.Drawing.Point(20, 100);
            this.txtEmail.Size = new System.Drawing.Size(333, 25);

            // lblPhone
            this.lblPhone.Text = "Telefon:";
            this.lblPhone.Location = new System.Drawing.Point(20, 130);
            this.txtPhone.Location = new System.Drawing.Point(20, 155);
            this.txtPhone.Size = new System.Drawing.Size(333, 25);

            // lblPosition
            this.lblPosition.Text = "Pozisyon:";
            this.lblPosition.Location = new System.Drawing.Point(20, 185);
            this.cmbPosition.Location = new System.Drawing.Point(20, 210);
            this.cmbPosition.Size = new System.Drawing.Size(333, 25);

            // chkIsActive
            this.chkIsActive.Text = "Aktif";
            this.chkIsActive.Location = new System.Drawing.Point(20, 245);

            // Buttons
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Location = new System.Drawing.Point(20, 275);
            this.btnAdd.Size = new System.Drawing.Size(333, 40);

            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Location = new System.Drawing.Point(20, 325);
            this.btnUpdate.Size = new System.Drawing.Size(333, 40);

            this.btnDelete.Text = "Sil";
            this.btnDelete.Location = new System.Drawing.Point(20, 375);
            this.btnDelete.Size = new System.Drawing.Size(333, 40);

            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Location = new System.Drawing.Point(20, 425);
            this.btnRefresh.Size = new System.Drawing.Size(333, 40);

            // UserControl settings
            this.Controls.Add(this.pnlMain);
            this.Name = "EmployeeManagementControl";
            this.Size = new System.Drawing.Size(1067, 615);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}
