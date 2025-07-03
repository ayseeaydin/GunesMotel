namespace GunesMotel.UI.WinForms.Control
{
    partial class InvoiceManagementControl
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInvoiceList = new System.Windows.Forms.TabPage();
            this.pnlInvoiceActions = new System.Windows.Forms.Panel();
            this.btnRefreshInvoices = new System.Windows.Forms.Button();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.pnlInvoiceFilters = new System.Windows.Forms.Panel();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbInvoiceStatus = new System.Windows.Forms.ComboBox();
            this.txtInvoiceSearch = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearchInvoices = new System.Windows.Forms.Button();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.pnlInvoiceHeader = new System.Windows.Forms.Panel();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.tabInvoiceDetail = new System.Windows.Forms.TabPage();
            this.pnlInvoiceDetailMain = new System.Windows.Forms.Panel();
            this.pnlPaymentHistory = new System.Windows.Forms.Panel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.lblPaymentHistory = new System.Windows.Forms.Label();
            this.pnlInvoiceItems = new System.Windows.Forms.Panel();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.lblInvoiceItems = new System.Windows.Forms.Label();
            this.pnlInvoiceInfo = new System.Windows.Forms.Panel();
            this.lblInvoiceAmount = new System.Windows.Forms.Label();
            this.lblInvoiceStatus = new System.Windows.Forms.Label();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.lblInvoiceDetailTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInvoiceList.SuspendLayout();
            this.pnlInvoiceActions.SuspendLayout();
            this.pnlInvoiceFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.pnlInvoiceHeader.SuspendLayout();
            this.tabInvoiceDetail.SuspendLayout();
            this.pnlInvoiceDetailMain.SuspendLayout();
            this.pnlPaymentHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.pnlInvoiceItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.pnlInvoiceInfo.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1600, 985);
            this.pnlMain.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInvoiceList);
            this.tabControl.Controls.Add(this.tabInvoiceDetail);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1600, 985);
            this.tabControl.TabIndex = 0;
            // 
            // tabInvoiceList
            // 
            this.tabInvoiceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabInvoiceList.Controls.Add(this.pnlInvoiceActions);
            this.tabInvoiceList.Controls.Add(this.pnlInvoiceFilters);
            this.tabInvoiceList.Controls.Add(this.dgvInvoices);
            this.tabInvoiceList.Controls.Add(this.pnlInvoiceHeader);
            this.tabInvoiceList.Location = new System.Drawing.Point(4, 32);
            this.tabInvoiceList.Margin = new System.Windows.Forms.Padding(4);
            this.tabInvoiceList.Name = "tabInvoiceList";
            this.tabInvoiceList.Padding = new System.Windows.Forms.Padding(4);
            this.tabInvoiceList.Size = new System.Drawing.Size(1592, 949);
            this.tabInvoiceList.TabIndex = 0;
            this.tabInvoiceList.Text = "📋 Fatura Listesi";
            // 
            // pnlInvoiceActions
            // 
            this.pnlInvoiceActions.BackColor = System.Drawing.Color.White;
            this.pnlInvoiceActions.Controls.Add(this.btnRefreshInvoices);
            this.pnlInvoiceActions.Controls.Add(this.btnViewInvoice);
            this.pnlInvoiceActions.Controls.Add(this.btnAddPayment);
            this.pnlInvoiceActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInvoiceActions.Location = new System.Drawing.Point(4, 871);
            this.pnlInvoiceActions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInvoiceActions.Name = "pnlInvoiceActions";
            this.pnlInvoiceActions.Size = new System.Drawing.Size(1584, 74);
            this.pnlInvoiceActions.TabIndex = 3;
            // 
            // btnRefreshInvoices
            // 
            this.btnRefreshInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.btnRefreshInvoices.FlatAppearance.BorderSize = 0;
            this.btnRefreshInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshInvoices.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefreshInvoices.ForeColor = System.Drawing.Color.White;
            this.btnRefreshInvoices.Location = new System.Drawing.Point(427, 12);
            this.btnRefreshInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshInvoices.Name = "btnRefreshInvoices";
            this.btnRefreshInvoices.Size = new System.Drawing.Size(160, 49);
            this.btnRefreshInvoices.TabIndex = 2;
            this.btnRefreshInvoices.Text = "🔄 Yenile";
            this.btnRefreshInvoices.UseVisualStyleBackColor = false;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.btnViewInvoice.FlatAppearance.BorderSize = 0;
            this.btnViewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInvoice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.btnViewInvoice.Location = new System.Drawing.Point(227, 12);
            this.btnViewInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(187, 49);
            this.btnViewInvoice.TabIndex = 1;
            this.btnViewInvoice.Text = "👁️ Fatura Detayı";
            this.btnViewInvoice.UseVisualStyleBackColor = false;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.btnAddPayment.FlatAppearance.BorderSize = 0;
            this.btnAddPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.Location = new System.Drawing.Point(27, 12);
            this.btnAddPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(187, 49);
            this.btnAddPayment.TabIndex = 0;
            this.btnAddPayment.Text = "💰 Ödeme Al";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            // 
            // pnlInvoiceFilters
            // 
            this.pnlInvoiceFilters.BackColor = System.Drawing.Color.White;
            this.pnlInvoiceFilters.Controls.Add(this.dtpEndDate);
            this.pnlInvoiceFilters.Controls.Add(this.dtpStartDate);
            this.pnlInvoiceFilters.Controls.Add(this.cmbInvoiceStatus);
            this.pnlInvoiceFilters.Controls.Add(this.txtInvoiceSearch);
            this.pnlInvoiceFilters.Controls.Add(this.lblEndDate);
            this.pnlInvoiceFilters.Controls.Add(this.lblStartDate);
            this.pnlInvoiceFilters.Controls.Add(this.lblStatus);
            this.pnlInvoiceFilters.Controls.Add(this.lblSearch);
            this.pnlInvoiceFilters.Controls.Add(this.btnSearchInvoices);
            this.pnlInvoiceFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceFilters.Location = new System.Drawing.Point(4, 66);
            this.pnlInvoiceFilters.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInvoiceFilters.Name = "pnlInvoiceFilters";
            this.pnlInvoiceFilters.Size = new System.Drawing.Size(1584, 98);
            this.pnlInvoiceFilters.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(507, 55);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ShowCheckBox = true;
            this.dtpEndDate.Size = new System.Drawing.Size(159, 27);
            this.dtpEndDate.TabIndex = 8;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(507, 18);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.ShowCheckBox = true;
            this.dtpStartDate.Size = new System.Drawing.Size(159, 27);
            this.dtpStartDate.TabIndex = 7;
            // 
            // cmbInvoiceStatus
            // 
            this.cmbInvoiceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvoiceStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbInvoiceStatus.FormattingEnabled = true;
            this.cmbInvoiceStatus.Location = new System.Drawing.Point(787, 18);
            this.cmbInvoiceStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInvoiceStatus.Name = "cmbInvoiceStatus";
            this.cmbInvoiceStatus.Size = new System.Drawing.Size(159, 28);
            this.cmbInvoiceStatus.TabIndex = 6;
            // 
            // txtInvoiceSearch
            // 
            this.txtInvoiceSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtInvoiceSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtInvoiceSearch.Location = new System.Drawing.Point(107, 18);
            this.txtInvoiceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtInvoiceSearch.Name = "txtInvoiceSearch";
            this.txtInvoiceSearch.Size = new System.Drawing.Size(265, 27);
            this.txtInvoiceSearch.TabIndex = 5;
            this.txtInvoiceSearch.Text = "Müşteri, fatura no veya oda no...";
            this.txtInvoiceSearch.Enter += new System.EventHandler(this.txtInvoiceSearch_Enter);
            this.txtInvoiceSearch.Leave += new System.EventHandler(this.txtInvoiceSearch_Leave);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEndDate.Location = new System.Drawing.Point(413, 59);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(79, 20);
            this.lblEndDate.TabIndex = 4;
            this.lblEndDate.Text = "Bitiş Tarihi:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStartDate.Location = new System.Drawing.Point(413, 22);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(114, 20);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Başlangıç Tarihi:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.Location = new System.Drawing.Point(720, 22);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Durum:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(27, 22);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(56, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Arama:";
            // 
            // btnSearchInvoices
            // 
            this.btnSearchInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.btnSearchInvoices.FlatAppearance.BorderSize = 0;
            this.btnSearchInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchInvoices.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchInvoices.ForeColor = System.Drawing.Color.White;
            this.btnSearchInvoices.Location = new System.Drawing.Point(1000, 18);
            this.btnSearchInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchInvoices.Name = "btnSearchInvoices";
            this.btnSearchInvoices.Size = new System.Drawing.Size(133, 31);
            this.btnSearchInvoices.TabIndex = 0;
            this.btnSearchInvoices.Text = "🔍 Ara";
            this.btnSearchInvoices.UseVisualStyleBackColor = false;
            this.btnSearchInvoices.Click += new System.EventHandler(this.btnSearchInvoices_Click);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(4, 172);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(1584, 691);
            this.dgvInvoices.TabIndex = 1;
            this.dgvInvoices.SelectionChanged += new System.EventHandler(this.dgvInvoices_SelectionChanged);
            // 
            // pnlInvoiceHeader
            // 
            this.pnlInvoiceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.pnlInvoiceHeader.Controls.Add(this.lblInvoiceTitle);
            this.pnlInvoiceHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceHeader.Location = new System.Drawing.Point(4, 4);
            this.pnlInvoiceHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInvoiceHeader.Name = "pnlInvoiceHeader";
            this.pnlInvoiceHeader.Size = new System.Drawing.Size(1584, 62);
            this.pnlInvoiceHeader.TabIndex = 0;
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceTitle.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceTitle.Location = new System.Drawing.Point(27, 18);
            this.lblInvoiceTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(193, 32);
            this.lblInvoiceTitle.TabIndex = 0;
            this.lblInvoiceTitle.Text = "Fatura Yönetimi";
            // 
            // tabInvoiceDetail
            // 
            this.tabInvoiceDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.tabInvoiceDetail.Controls.Add(this.pnlInvoiceDetailMain);
            this.tabInvoiceDetail.Location = new System.Drawing.Point(4, 32);
            this.tabInvoiceDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tabInvoiceDetail.Name = "tabInvoiceDetail";
            this.tabInvoiceDetail.Padding = new System.Windows.Forms.Padding(4);
            this.tabInvoiceDetail.Size = new System.Drawing.Size(1592, 949);
            this.tabInvoiceDetail.TabIndex = 1;
            this.tabInvoiceDetail.Text = "📄 Fatura Detayı";
            // 
            // pnlInvoiceDetailMain
            // 
            this.pnlInvoiceDetailMain.Controls.Add(this.pnlPaymentHistory);
            this.pnlInvoiceDetailMain.Controls.Add(this.pnlInvoiceItems);
            this.pnlInvoiceDetailMain.Controls.Add(this.pnlInvoiceInfo);
            this.pnlInvoiceDetailMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInvoiceDetailMain.Location = new System.Drawing.Point(4, 4);
            this.pnlInvoiceDetailMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInvoiceDetailMain.Name = "pnlInvoiceDetailMain";
            this.pnlInvoiceDetailMain.Size = new System.Drawing.Size(1584, 941);
            this.pnlInvoiceDetailMain.TabIndex = 0;
            // 
            // pnlPaymentHistory
            // 
            this.pnlPaymentHistory.BackColor = System.Drawing.Color.White;
            this.pnlPaymentHistory.Controls.Add(this.dgvPayments);
            this.pnlPaymentHistory.Controls.Add(this.lblPaymentHistory);
            this.pnlPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentHistory.Location = new System.Drawing.Point(0, 554);
            this.pnlPaymentHistory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPaymentHistory.Name = "pnlPaymentHistory";
            this.pnlPaymentHistory.Size = new System.Drawing.Size(1584, 387);
            this.pnlPaymentHistory.TabIndex = 2;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(0, 49);
            this.dgvPayments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(1584, 338);
            this.dgvPayments.TabIndex = 1;
            // 
            // lblPaymentHistory
            // 
            this.lblPaymentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblPaymentHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPaymentHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentHistory.ForeColor = System.Drawing.Color.White;
            this.lblPaymentHistory.Location = new System.Drawing.Point(0, 0);
            this.lblPaymentHistory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaymentHistory.Name = "lblPaymentHistory";
            this.lblPaymentHistory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblPaymentHistory.Size = new System.Drawing.Size(1584, 49);
            this.lblPaymentHistory.TabIndex = 0;
            this.lblPaymentHistory.Text = "💰 Ödeme Geçmişi";
            this.lblPaymentHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInvoiceItems
            // 
            this.pnlInvoiceItems.BackColor = System.Drawing.Color.White;
            this.pnlInvoiceItems.Controls.Add(this.dgvInvoiceItems);
            this.pnlInvoiceItems.Controls.Add(this.lblInvoiceItems);
            this.pnlInvoiceItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceItems.Location = new System.Drawing.Point(0, 246);
            this.pnlInvoiceItems.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInvoiceItems.Name = "pnlInvoiceItems";
            this.pnlInvoiceItems.Size = new System.Drawing.Size(1584, 308);
            this.pnlInvoiceItems.TabIndex = 1;
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(0, 49);
            this.dgvInvoiceItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowHeadersWidth = 51;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(1584, 259);
            this.dgvInvoiceItems.TabIndex = 1;
            // 
            // lblInvoiceItems
            // 
            this.lblInvoiceItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(215)))), ((int)(((byte)(185)))));
            this.lblInvoiceItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvoiceItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblInvoiceItems.Location = new System.Drawing.Point(0, 0);
            this.lblInvoiceItems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceItems.Name = "lblInvoiceItems";
            this.lblInvoiceItems.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblInvoiceItems.Size = new System.Drawing.Size(1584, 49);
            this.lblInvoiceItems.TabIndex = 0;
            this.lblInvoiceItems.Text = "📋 Fatura Kalemleri";
            this.lblInvoiceItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlInvoiceInfo
            // 
            this.pnlInvoiceInfo.BackColor = System.Drawing.Color.White;
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceAmount);
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceStatus);
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceDate);
            this.pnlInvoiceInfo.Controls.Add(this.lblCustomerName);
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceNumber);
            this.pnlInvoiceInfo.Controls.Add(this.lblInvoiceDetailTitle);
            this.pnlInvoiceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInvoiceInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInvoiceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInvoiceInfo.Name = "pnlInvoiceInfo";
            this.pnlInvoiceInfo.Size = new System.Drawing.Size(1584, 246);
            this.pnlInvoiceInfo.TabIndex = 0;
            // 
            // lblInvoiceAmount
            // 
            this.lblInvoiceAmount.AutoSize = true;
            this.lblInvoiceAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblInvoiceAmount.Location = new System.Drawing.Point(40, 185);
            this.lblInvoiceAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceAmount.Name = "lblInvoiceAmount";
            this.lblInvoiceAmount.Size = new System.Drawing.Size(161, 28);
            this.lblInvoiceAmount.TabIndex = 5;
            this.lblInvoiceAmount.Text = "Toplam: 0.00 TL";
            // 
            // lblInvoiceStatus
            // 
            this.lblInvoiceStatus.AutoSize = true;
            this.lblInvoiceStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceStatus.Location = new System.Drawing.Point(40, 148);
            this.lblInvoiceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceStatus.Name = "lblInvoiceStatus";
            this.lblInvoiceStatus.Size = new System.Drawing.Size(146, 25);
            this.lblInvoiceStatus.TabIndex = 4;
            this.lblInvoiceStatus.Text = "Durum: Bekliyor";
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceDate.Location = new System.Drawing.Point(40, 117);
            this.lblInvoiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(150, 25);
            this.lblInvoiceDate.TabIndex = 3;
            this.lblInvoiceDate.Text = "Tarih: 01.01.2025";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCustomerName.Location = new System.Drawing.Point(40, 86);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(178, 25);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Müşteri: Seçili Değil";
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblInvoiceNumber.Location = new System.Drawing.Point(40, 55);
            this.lblInvoiceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(132, 25);
            this.lblInvoiceNumber.TabIndex = 1;
            this.lblInvoiceNumber.Text = "Fatura No: Yok";
            // 
            // lblInvoiceDetailTitle
            // 
            this.lblInvoiceDetailTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.lblInvoiceDetailTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvoiceDetailTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblInvoiceDetailTitle.ForeColor = System.Drawing.Color.White;
            this.lblInvoiceDetailTitle.Location = new System.Drawing.Point(0, 0);
            this.lblInvoiceDetailTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvoiceDetailTitle.Name = "lblInvoiceDetailTitle";
            this.lblInvoiceDetailTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblInvoiceDetailTitle.Size = new System.Drawing.Size(1584, 43);
            this.lblInvoiceDetailTitle.TabIndex = 0;
            this.lblInvoiceDetailTitle.Text = "📄 Fatura Bilgileri";
            this.lblInvoiceDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InvoiceManagementControl";
            this.Size = new System.Drawing.Size(1600, 985);
            this.Load += new System.EventHandler(this.InvoiceManagementControl_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabInvoiceList.ResumeLayout(false);
            this.pnlInvoiceActions.ResumeLayout(false);
            this.pnlInvoiceFilters.ResumeLayout(false);
            this.pnlInvoiceFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.pnlInvoiceHeader.ResumeLayout(false);
            this.pnlInvoiceHeader.PerformLayout();
            this.tabInvoiceDetail.ResumeLayout(false);
            this.pnlInvoiceDetailMain.ResumeLayout(false);
            this.pnlPaymentHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.pnlInvoiceItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.pnlInvoiceInfo.ResumeLayout(false);
            this.pnlInvoiceInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInvoiceList;
        private System.Windows.Forms.TabPage tabInvoiceDetail;
        private System.Windows.Forms.Panel pnlInvoiceHeader;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Panel pnlInvoiceFilters;
        private System.Windows.Forms.Button btnSearchInvoices;
        private System.Windows.Forms.Panel pnlInvoiceActions;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnViewInvoice;
        private System.Windows.Forms.Button btnRefreshInvoices;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtInvoiceSearch;
        private System.Windows.Forms.ComboBox cmbInvoiceStatus;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Panel pnlInvoiceDetailMain;
        private System.Windows.Forms.Panel pnlInvoiceInfo;
        private System.Windows.Forms.Label lblInvoiceDetailTitle;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceStatus;
        private System.Windows.Forms.Label lblInvoiceAmount;
        private System.Windows.Forms.Panel pnlInvoiceItems;
        private System.Windows.Forms.Label lblInvoiceItems;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Panel pnlPaymentHistory;
        private System.Windows.Forms.Label lblPaymentHistory;
        private System.Windows.Forms.DataGridView dgvPayments;
    }
}
