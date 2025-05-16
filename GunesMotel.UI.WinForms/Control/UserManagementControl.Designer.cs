using System;

namespace GunesMotel.UI.WinForms.Control
{
    partial class UserManagementControl
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.colUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.dgvUsers);
            this.pnlMain.Controls.Add(this.pnlControls);
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1067, 615);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 155, 180);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 37);
            this.lblTitle.Text = "Kullanıcı Yönetimi";

            // dgvUsers
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(240, 244, 247);
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersHeight = 40;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(20, 75);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 35;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(620, 500);
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colUserID,
                this.colUsername,
                this.colEmail,
                this.colPhone,
                this.colRole
            });

            // pnlControls
            this.pnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(240, 244, 247);
            this.pnlControls.Controls.Add(this.lblUsername);
            this.pnlControls.Controls.Add(this.txtUsername);
            this.pnlControls.Controls.Add(this.lblEmail);
            this.pnlControls.Controls.Add(this.txtEmail);
            this.pnlControls.Controls.Add(this.lblPhone);
            this.pnlControls.Controls.Add(this.txtPhone);
            this.pnlControls.Controls.Add(this.lblRole);
            this.pnlControls.Controls.Add(this.cmbRole);
            this.pnlControls.Controls.Add(this.chkIsActive);
            this.pnlControls.Controls.Add(this.btnAdd);
            this.pnlControls.Controls.Add(this.btnUpdate);
            this.pnlControls.Controls.Add(this.btnDelete);
            this.pnlControls.Controls.Add(this.btnRefresh);
            this.pnlControls.Location = new System.Drawing.Point(670, 75);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(20);
            this.pnlControls.Size = new System.Drawing.Size(370, 500);

            // Labels and Inputs
            this.lblUsername.Text = "Kullanıcı Adı:";
            this.lblUsername.Location = new System.Drawing.Point(20, 20);
            this.txtUsername.Location = new System.Drawing.Point(20, 45);
            this.txtUsername.Size = new System.Drawing.Size(330, 25);

            this.lblEmail.Text = "E-Posta:";
            this.lblEmail.Location = new System.Drawing.Point(20, 75);
            this.txtEmail.Location = new System.Drawing.Point(20, 100);
            this.txtEmail.Size = new System.Drawing.Size(330, 25);

            this.lblPhone.Text = "Telefon:";
            this.lblPhone.Location = new System.Drawing.Point(20, 130);
            this.txtPhone.Location = new System.Drawing.Point(20, 155);
            this.txtPhone.Size = new System.Drawing.Size(330, 25);

            this.lblRole.Text = "Rol:";
            this.lblRole.Location = new System.Drawing.Point(20, 185);
            this.cmbRole.Location = new System.Drawing.Point(20, 210);
            this.cmbRole.Size = new System.Drawing.Size(330, 25);

            this.chkIsActive.Text = "Aktif";
            this.chkIsActive.Location = new System.Drawing.Point(20, 245);

            // Buttons
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Location = new System.Drawing.Point(20, 275);
            this.btnAdd.Size = new System.Drawing.Size(330, 40);

            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Location = new System.Drawing.Point(20, 325);
            this.btnUpdate.Size = new System.Drawing.Size(330, 40);

            this.btnDelete.Text = "Sil";
            this.btnDelete.Location = new System.Drawing.Point(20, 375);
            this.btnDelete.Size = new System.Drawing.Size(330, 40);

            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Location = new System.Drawing.Point(20, 425);
            this.btnRefresh.Size = new System.Drawing.Size(330, 40);

            // DataGridView Columns
            this.colUserID.DataPropertyName = "UserID";
            this.colUserID.HeaderText = "ID";
            this.colUserID.ReadOnly = true;
            this.colUserID.Width = 50;

            this.colUsername.DataPropertyName = "Username";
            this.colUsername.HeaderText = "Kullanıcı Adı";
            this.colUsername.ReadOnly = true;

            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "E-Posta";
            this.colEmail.ReadOnly = true;

            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Telefon";
            this.colPhone.ReadOnly = true;

            this.colRole.DataPropertyName = "RoleName";
            this.colRole.HeaderText = "Rol";
            this.colRole.ReadOnly = true;

            // UserManagementControl
            this.Controls.Add(this.pnlMain);
            this.Name = "UserManagementControl";
            this.Size = new System.Drawing.Size(1067, 615);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
        }

        private void EndInit()
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
    }
}
