namespace GunesMotel.UI.WinForms.Forms
{
    partial class FrmCheckOutWithInvoice
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlReservationInfo = new System.Windows.Forms.Panel();
            this.lblReservationTitle = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblGuestCount = new System.Windows.Forms.Label();
            this.lblNights = new System.Windows.Forms.Label();
            this.pnlInvoiceInfo = new System.Windows.Forms.Panel();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.pnlInvoiceItems = new System.Windows.Forms.Panel();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.pnlPayments = new System.Windows.Forms.Panel();
            this.lblPaymentsTitle = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblRemainingAmount = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCompleteCheckOut = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlReservationInfo.SuspendLayout();
            this.pnlInvoiceInfo.SuspendLayout();
            this.pnlInvoiceItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.pnlPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(525, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🏨 CHECK-OUT & FATURA İŞLEMLERİ";
            // 
            // pnlReservationInfo
            // 
            this.pnlReservationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlReservationInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReservationInfo.Controls.Add(this.lblReservationTitle);
            this.pnlReservationInfo.Controls.Add(this.lblCustomerName);
            this.pnlReservationInfo.Controls.Add(this.lblRoomNumber);
            this.pnlReservationInfo.Controls.Add(this.lblCheckInDate);
            this.pnlReservationInfo.Controls.Add(this.lblCheckOutDate);
            this.pnlReservationInfo.Controls.Add(this.lblGuestCount);
            this.pnlReservationInfo.Controls.Add(this.lblNights);
            this.pnlReservationInfo.Location = new System.Drawing.Point(27, 98);
            this.pnlReservationInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlReservationInfo.Name = "pnlReservationInfo";
            this.pnlReservationInfo.Size = new System.Drawing.Size(559, 172);
            this.pnlReservationInfo.TabIndex = 1;
            // 
            // lblReservationTitle
            // 
            this.lblReservationTitle.AutoSize = true;
            this.lblReservationTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblReservationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblReservationTitle.Location = new System.Drawing.Point(13, 12);
            this.lblReservationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationTitle.Name = "lblReservationTitle";
            this.lblReservationTitle.Size = new System.Drawing.Size(186, 28);
            this.lblReservationTitle.TabIndex = 0;
            this.lblReservationTitle.Text = "📋 REZERVASYON";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerName.Location = new System.Drawing.Point(20, 43);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(83, 23);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Müşteri: -";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 68);
            this.lblRoomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(58, 23);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "Oda: -";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCheckInDate.Location = new System.Drawing.Point(20, 92);
            this.lblCheckInDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(59, 23);
            this.lblCheckInDate.TabIndex = 3;
            this.lblCheckInDate.Text = "Giriş: -";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCheckOutDate.Location = new System.Drawing.Point(20, 117);
            this.lblCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(60, 23);
            this.lblCheckOutDate.TabIndex = 4;
            this.lblCheckOutDate.Text = "Çıkış: -";
            // 
            // lblGuestCount
            // 
            this.lblGuestCount.AutoSize = true;
            this.lblGuestCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGuestCount.Location = new System.Drawing.Point(293, 43);
            this.lblGuestCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestCount.Name = "lblGuestCount";
            this.lblGuestCount.Size = new System.Drawing.Size(122, 23);
            this.lblGuestCount.TabIndex = 5;
            this.lblGuestCount.Text = "Misafir Sayısı: -";
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNights.Location = new System.Drawing.Point(293, 68);
            this.lblNights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(110, 23);
            this.lblNights.TabIndex = 6;
            this.lblNights.Text = "Gece Sayısı: -";
            // 
            // pnlInvoiceInfo
            // 
            this.pnlInvoiceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlInvoiceInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceTitle);
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceNumber);
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceDate);
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceStatus);
            this.pnlInvoiceInfo.Location = new System.Drawing.Point(613, 98);
            this.pnlInvoiceInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInvoiceInfo.Name = "pnlInvoiceInfo";
            this.pnlInvoiceInfo.Size = new System.Drawing.Size(559, 172);
            this.pnlInvoiceInfo.TabIndex = 2;
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(13, 12);
            this.lblInvoiceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(121, 28);
            this.lblInvoiceTitle.TabIndex = 0;
            this.lblInvoiceTitle.Text = "📄 FATURA";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInvoiceNumber.Location = new System.Drawing.Point(20, 43);
            this.lblInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(101, 23);
            this.lblInvoiceNumber.TabIndex = 1;
            this.lblInvoiceNumber.Text = "Fatura No: -";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInvoiceDate.Location = new System.Drawing.Point(20, 68);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(118, 23);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Text = "Fatura Tarihi: -";
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.AutoSize = true;
            this.lblInvoiceStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInvoiceStatus.Location = new System.Drawing.Point(20, 92);
            this.lblInvoiceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(79, 23);
            this.lblInvoiceStatus.TabIndex = 3;
            this.lblInvoiceStatus.Text = "Durum: -";
            // 
            // pnlInvoiceItems
            // 
            this.pnlInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInvoiceItems.Controls.Add(this.lblItemsTitle);
            this.pnlInvoiceItems.Controls.Add(this.dgvInvoiceItems);
            this.pnlInvoiceItems.Location = new System.Drawing.Point(27, 295);
            this.pnlInvoiceItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInvoiceItems.Name = "pnlInvoiceItems";
            this.pnlInvoiceItems.Size = new System.Drawing.Size(559, 221);
            this.pnlInvoiceItems.TabIndex = 3;
            // 
            // lblItemsTitle
            // 
            this.lblItemsTitle.AutoSize = true;
            this.lblItemsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblItemsTitle.Location = new System.Drawing.Point(13, 12);
            this.lblItemsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsTitle.Name = "lblItemsTitle";
            this.lblItemsTitle.Size = new System.Drawing.Size(188, 28);
            this.lblItemsTitle.TabIndex = 0;
            this.lblItemsTitle.Text = "🧾 FATURA DETAY";
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(13, 43);
            this.dgvInvoiceItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowHeadersVisible = false;
            this.dgvInvoiceItems.RowHeadersWidth = 51;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(527, 166);
            this.dgvInvoiceItems.TabIndex = 1;
            // 
            // pnlPayments
            // 
            this.pnlPayments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPayments.Controls.Add(this.lblPaymentsTitle);
            this.pnlPayments.Controls.Add(this.dgvPayments);
            this.pnlPayments.Controls.Add(this.btnAddPayment);
            this.pnlPayments.Location = new System.Drawing.Point(613, 295);
            this.pnlPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPayments.Name = "pnlPayments";
            this.pnlPayments.Size = new System.Drawing.Size(559, 221);
            this.pnlPayments.TabIndex = 4;
            // 
            // lblPaymentsTitle
            // 
            this.lblPaymentsTitle.AutoSize = true;
            this.lblPaymentsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblPaymentsTitle.Location = new System.Drawing.Point(13, 12);
            this.lblPaymentsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentsTitle.Name = "lblPaymentsTitle";
            this.lblPaymentsTitle.Size = new System.Drawing.Size(151, 28);
            this.lblPaymentsTitle.TabIndex = 0;
            this.lblPaymentsTitle.Text = "💳 ÖDEMELER";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(13, 43);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(527, 123);
            this.dgvPayments.TabIndex = 1;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnAddPayment.FlatAppearance.BorderSize = 0;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.Location = new System.Drawing.Point(13, 178);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(160, 43);
            this.btnAddPayment.TabIndex = 2;
            this.btnAddPayment.Text = "💰 Ödeme Al";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Controls.Add(this.lblTotalAmount);
            this.pnlSummary.Controls.Add(this.lblTotalPaid);
            this.pnlSummary.Controls.Add(this.lblRemainingAmount);
            this.pnlSummary.Controls.Add(this.lblPaymentStatus);
            this.pnlSummary.Location = new System.Drawing.Point(27, 542);
            this.pnlSummary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(1146, 147);
            this.pnlSummary.TabIndex = 5;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(20, 18);
            this.lblSummaryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(220, 32);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "💰 ÖZET & DURUM";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(27, 62);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(145, 28);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "Toplam: 0,00₺";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.AutoSize = true;
            this.lblTotalPaid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lblTotalPaid.Location = new System.Drawing.Point(27, 92);
            this.lblTotalPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(149, 28);
            this.lblTotalPaid.TabIndex = 2;
            this.lblTotalPaid.Text = "Ödenen: 0,00₺";
            // 
            // lblRemainingAmount
            // 
            this.lblRemainingAmount.AutoSize = true;
            this.lblRemainingAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblRemainingAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblRemainingAmount.Location = new System.Drawing.Point(333, 62);
            this.lblRemainingAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainingAmount.Name = "lblRemainingAmount";
            this.lblRemainingAmount.Size = new System.Drawing.Size(155, 32);
            this.lblRemainingAmount.TabIndex = 3;
            this.lblRemainingAmount.Text = "Kalan: 0,00₺";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lblPaymentStatus.Location = new System.Drawing.Point(335, 92);
            this.lblPaymentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(115, 23);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "✗ ÖDEMESİZ";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCompleteCheckOut);
            this.pnlButtons.Controls.Add(this.btnPrintInvoice);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 714);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1200, 86);
            this.pnlButtons.TabIndex = 6;
            // 
            // btnCompleteCheckOut
            // 
            this.btnCompleteCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCompleteCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCompleteCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteCheckOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompleteCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCompleteCheckOut.Location = new System.Drawing.Point(533, 18);
            this.btnCompleteCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompleteCheckOut.Name = "btnCompleteCheckOut";
            this.btnCompleteCheckOut.Size = new System.Drawing.Size(240, 55);
            this.btnCompleteCheckOut.TabIndex = 0;
            this.btnCompleteCheckOut.Text = "✅ CHECK-OUT YAP";
            this.btnCompleteCheckOut.UseVisualStyleBackColor = false;
            this.btnCompleteCheckOut.Click += new System.EventHandler(this.btnCompleteCheckOut_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnPrintInvoice.FlatAppearance.BorderSize = 0;
            this.btnPrintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Location = new System.Drawing.Point(267, 18);
            this.btnPrintInvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(187, 55);
            this.btnPrintInvoice.TabIndex = 1;
            this.btnPrintInvoice.Text = "🖨️ Fatura Yazdır";
            this.btnPrintInvoice.UseVisualStyleBackColor = false;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(53, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 55);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "❌ İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCheckOutWithInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlPayments);
            this.Controls.Add(this.pnlInvoiceItems);
            this.Controls.Add(this.pnlInvoiceInfo);
            this.Controls.Add(this.pnlReservationInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCheckOutWithInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check-Out & Fatura İşlemleri";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlReservationInfo.ResumeLayout(false);
            this.pnlReservationInfo.PerformLayout();
            this.pnlInvoiceInfo.ResumeLayout(false);
            this.pnlInvoiceInfo.PerformLayout();
            this.pnlInvoiceItems.ResumeLayout(false);
            this.pnlInvoiceItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.pnlPayments.ResumeLayout(false);
            this.pnlPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlReservationInfo;
        private System.Windows.Forms.Label lblReservationTitle;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblGuestCount;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Panel pnlInvoiceInfo;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceStatus;
        private System.Windows.Forms.Panel pnlInvoiceItems;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Panel pnlPayments;
        private System.Windows.Forms.Label lblPaymentsTitle;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblRemainingAmount;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCompleteCheckOut;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnCancel;

    }
}