namespace GunesMotel.UI.WinForms.Control
{
    partial class AdminDashboardContentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlRoomsCard;
        private System.Windows.Forms.Label lblRoomsTotal;
        private System.Windows.Forms.Label lblRoomsTitle;
        private System.Windows.Forms.Panel pnlReservationsCard;
        private System.Windows.Forms.Label lblReservationsTotal;
        private System.Windows.Forms.Label lblReservationsTitle;
        private System.Windows.Forms.Panel pnlCustomersCard;
        private System.Windows.Forms.Label lblCustomersTotal;
        private System.Windows.Forms.Label lblCustomersTitle;
        private System.Windows.Forms.Panel pnlRevenueCard;
        private System.Windows.Forms.Label lblRevenueAmount;
        private System.Windows.Forms.Label lblRevenueTitle;


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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRoomsCard = new System.Windows.Forms.Panel();
            this.lblRoomsTotal = new System.Windows.Forms.Label();
            this.lblRoomsTitle = new System.Windows.Forms.Label();
            this.pnlReservationsCard = new System.Windows.Forms.Panel();
            this.lblReservationsTotal = new System.Windows.Forms.Label();
            this.lblReservationsTitle = new System.Windows.Forms.Label();
            this.pnlCustomersCard = new System.Windows.Forms.Panel();
            this.lblCustomersTotal = new System.Windows.Forms.Label();
            this.lblCustomersTitle = new System.Windows.Forms.Label();
            this.pnlRevenueCard = new System.Windows.Forms.Panel();
            this.lblRevenueAmount = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pnlRoomsCard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlReservationsCard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlCustomersCard, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlRevenueCard, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 148);
            this.tableLayoutPanel1.TabIndex = 0;

            // 
            // pnlRoomsCard
            // 
            this.pnlRoomsCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlRoomsCard.Controls.Add(this.lblRoomsTotal);
            this.pnlRoomsCard.Controls.Add(this.lblRoomsTitle);
            this.pnlRoomsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoomsCard.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnlRoomsCard.Name = "pnlRoomsCard";
            this.pnlRoomsCard.Size = new System.Drawing.Size(284, 128);

            // 
            // lblRoomsTotal
            // 
            this.lblRoomsTotal.AutoSize = true;
            this.lblRoomsTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRoomsTotal.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblRoomsTotal.Location = new System.Drawing.Point(38, 65);
            this.lblRoomsTotal.Name = "lblRoomsTotal";
            this.lblRoomsTotal.Size = new System.Drawing.Size(52, 41);
            this.lblRoomsTotal.TabIndex = 1;
            this.lblRoomsTotal.Text = "10";
            // 
            // lblRoomsTitle
            // 
            this.lblRoomsTitle.AutoSize = true;
            this.lblRoomsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomsTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblRoomsTitle.Location = new System.Drawing.Point(34, 25);
            this.lblRoomsTitle.Name = "lblRoomsTitle";
            this.lblRoomsTitle.Size = new System.Drawing.Size(156, 28);
            this.lblRoomsTitle.TabIndex = 0;
            this.lblRoomsTitle.Text = "Toplam Oda";

            // 
            // pnlReservationsCard
            // 
            this.pnlReservationsCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlReservationsCard.Controls.Add(this.lblReservationsTotal);
            this.pnlReservationsCard.Controls.Add(this.lblReservationsTitle);
            this.pnlReservationsCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReservationsCard.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnlReservationsCard.Name = "pnlReservationsCard";
            this.pnlReservationsCard.Size = new System.Drawing.Size(284, 128);

            // 
            // lblReservationsTotal
            // 
            this.lblReservationsTotal.AutoSize = true;
            this.lblReservationsTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblReservationsTotal.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblReservationsTotal.Location = new System.Drawing.Point(38, 65);
            this.lblReservationsTotal.Name = "lblReservationsTotal";
            this.lblReservationsTotal.Size = new System.Drawing.Size(35, 41);
            this.lblReservationsTotal.TabIndex = 1;
            this.lblReservationsTotal.Text = "3";
            // 
            // lblReservationsTitle
            // 
            this.lblReservationsTitle.AutoSize = true;
            this.lblReservationsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationsTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblReservationsTitle.Location = new System.Drawing.Point(34, 25);
            this.lblReservationsTitle.Name = "lblReservationsTitle";
            this.lblReservationsTitle.Size = new System.Drawing.Size(183, 28);
            this.lblReservationsTitle.TabIndex = 0;
            this.lblReservationsTitle.Text = "Aktif Rezervasyon";

            // 
            // pnlCustomersCard
            // 
            this.pnlCustomersCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlCustomersCard.Controls.Add(this.lblCustomersTotal);
            this.pnlCustomersCard.Controls.Add(this.lblCustomersTitle);
            this.pnlCustomersCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomersCard.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnlCustomersCard.Name = "pnlCustomersCard";
            this.pnlCustomersCard.Size = new System.Drawing.Size(284, 128);

            // 
            // lblCustomersTotal
            // 
            this.lblCustomersTotal.AutoSize = true;
            this.lblCustomersTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCustomersTotal.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblCustomersTotal.Location = new System.Drawing.Point(38, 65);
            this.lblCustomersTotal.Name = "lblCustomersTotal";
            this.lblCustomersTotal.Size = new System.Drawing.Size(52, 41);
            this.lblCustomersTotal.TabIndex = 1;
            this.lblCustomersTotal.Text = "25";
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.AutoSize = true;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblCustomersTitle.Location = new System.Drawing.Point(34, 25);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(172, 28);
            this.lblCustomersTitle.TabIndex = 0;
            this.lblCustomersTitle.Text = "Toplam Müşteri";

            // 
            // pnlRevenueCard
            // 
            this.pnlRevenueCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlRevenueCard.Controls.Add(this.lblRevenueAmount);
            this.pnlRevenueCard.Controls.Add(this.lblRevenueTitle);
            this.pnlRevenueCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRevenueCard.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.pnlRevenueCard.Name = "pnlRevenueCard";
            this.pnlRevenueCard.Size = new System.Drawing.Size(284, 128);

            // 
            // lblRevenueAmount
            // 
            this.lblRevenueAmount.AutoSize = true;
            this.lblRevenueAmount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblRevenueAmount.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblRevenueAmount.Location = new System.Drawing.Point(38, 65);
            this.lblRevenueAmount.Name = "lblRevenueAmount";
            this.lblRevenueAmount.Size = new System.Drawing.Size(161, 41);
            this.lblRevenueAmount.TabIndex = 1;
            this.lblRevenueAmount.Text = "2.500,00 ₺";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblRevenueTitle.Location = new System.Drawing.Point(34, 25);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(144, 28);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Günlük Kazanç";

            // 
            // AdminDashboardContentControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminDashboardContentControl";
            this.Size = new System.Drawing.Size(1200, 220);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlRoomsCard.ResumeLayout(false);
            this.pnlRoomsCard.PerformLayout();
            this.pnlReservationsCard.ResumeLayout(false);
            this.pnlReservationsCard.PerformLayout();
            this.pnlCustomersCard.ResumeLayout(false);
            this.pnlCustomersCard.PerformLayout();
            this.pnlRevenueCard.ResumeLayout(false);
            this.pnlRevenueCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
