namespace GunesMotel.UI.WinForms.Control
{
    partial class CheckInOutControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblDateTime;

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabTodayCheckIn;
        private System.Windows.Forms.TabPage tabTodayCheckOut;
        private System.Windows.Forms.TabPage tabCurrentGuests;
        private System.Windows.Forms.TabPage tabSearch;

        // Today Check-In Tab
        private System.Windows.Forms.Panel pnlCheckInHeader;
        private System.Windows.Forms.Label lblCheckInCount;
        private System.Windows.Forms.DataGridView dgvTodayCheckIns;
        private System.Windows.Forms.Panel pnlCheckInActions;
        private System.Windows.Forms.Button btnPerformCheckIn;
        private System.Windows.Forms.Button btnRefreshCheckIn;

        // Today Check-Out Tab  
        private System.Windows.Forms.Panel pnlCheckOutHeader;
        private System.Windows.Forms.Label lblCheckOutCount;
        private System.Windows.Forms.DataGridView dgvTodayCheckOuts;
        private System.Windows.Forms.Panel pnlCheckOutActions;
        private System.Windows.Forms.Button btnPerformCheckOut;
        private System.Windows.Forms.Button btnRefreshCheckOut;
        private System.Windows.Forms.Button btnLateCheckOuts;

        // Current Guests Tab
        private System.Windows.Forms.Panel pnlGuestsHeader;
        private System.Windows.Forms.Label lblCurrentGuestsCount;
        private System.Windows.Forms.DataGridView dgvCurrentGuests;
        private System.Windows.Forms.Panel pnlGuestsActions;
        private System.Windows.Forms.Button btnEarlyCheckOut;
        private System.Windows.Forms.Button btnExtendStay;
        private System.Windows.Forms.Button btnRefreshGuests;

        // Search Tab
        private System.Windows.Forms.Panel pnlSearchFilter;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.DataGridView dgvSearchResults;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabTodayCheckIn = new System.Windows.Forms.TabPage();
            this.dgvTodayCheckIns = new System.Windows.Forms.DataGridView();
            this.pnlCheckInActions = new System.Windows.Forms.Panel();
            this.btnRefreshCheckIn = new System.Windows.Forms.Button();
            this.btnPerformCheckIn = new System.Windows.Forms.Button();
            this.pnlCheckInHeader = new System.Windows.Forms.Panel();
            this.lblCheckInCount = new System.Windows.Forms.Label();
            this.tabTodayCheckOut = new System.Windows.Forms.TabPage();
            this.dgvTodayCheckOuts = new System.Windows.Forms.DataGridView();
            this.pnlCheckOutActions = new System.Windows.Forms.Panel();
            this.btnLateCheckOuts = new System.Windows.Forms.Button();
            this.btnRefreshCheckOut = new System.Windows.Forms.Button();
            this.btnPerformCheckOut = new System.Windows.Forms.Button();
            this.pnlCheckOutHeader = new System.Windows.Forms.Panel();
            this.lblCheckOutCount = new System.Windows.Forms.Label();
            this.tabCurrentGuests = new System.Windows.Forms.TabPage();
            this.dgvCurrentGuests = new System.Windows.Forms.DataGridView();
            this.pnlGuestsActions = new System.Windows.Forms.Panel();
            this.btnRefreshGuests = new System.Windows.Forms.Button();
            this.btnExtendStay = new System.Windows.Forms.Button();
            this.btnEarlyCheckOut = new System.Windows.Forms.Button();
            this.pnlGuestsHeader = new System.Windows.Forms.Panel();
            this.lblCurrentGuestsCount = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.pnlSearchFilter = new System.Windows.Forms.Panel();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabTodayCheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayCheckIns)).BeginInit();
            this.pnlCheckInActions.SuspendLayout();
            this.pnlCheckInHeader.SuspendLayout();
            this.tabTodayCheckOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayCheckOuts)).BeginInit();
            this.pnlCheckOutActions.SuspendLayout();
            this.pnlCheckOutHeader.SuspendLayout();
            this.tabCurrentGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentGuests)).BeginInit();
            this.pnlGuestsActions.SuspendLayout();
            this.pnlGuestsHeader.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.pnlSearchFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tabMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 700);
            this.pnlMain.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabTodayCheckIn);
            this.tabMain.Controls.Add(this.tabTodayCheckOut);
            this.tabMain.Controls.Add(this.tabCurrentGuests);
            this.tabMain.Controls.Add(this.tabSearch);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1200, 700);
            this.tabMain.TabIndex = 1;
            // 
            // tabTodayCheckIn
            // 
            this.tabTodayCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabTodayCheckIn.Controls.Add(this.dgvTodayCheckIns);
            this.tabTodayCheckIn.Controls.Add(this.pnlCheckInActions);
            this.tabTodayCheckIn.Controls.Add(this.pnlCheckInHeader);
            this.tabTodayCheckIn.Location = new System.Drawing.Point(4, 32);
            this.tabTodayCheckIn.Name = "tabTodayCheckIn";
            this.tabTodayCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodayCheckIn.Size = new System.Drawing.Size(1192, 664);
            this.tabTodayCheckIn.TabIndex = 0;
            this.tabTodayCheckIn.Text = "📋 Bugün Check-In (0)";
            // 
            // dgvTodayCheckIns
            // 
            this.dgvTodayCheckIns.AllowUserToAddRows = false;
            this.dgvTodayCheckIns.AllowUserToDeleteRows = false;
            this.dgvTodayCheckIns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayCheckIns.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodayCheckIns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodayCheckIns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTodayCheckIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayCheckIns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayCheckIns.EnableHeadersVisualStyles = false;
            this.dgvTodayCheckIns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTodayCheckIns.Location = new System.Drawing.Point(3, 53);
            this.dgvTodayCheckIns.MultiSelect = false;
            this.dgvTodayCheckIns.Name = "dgvTodayCheckIns";
            this.dgvTodayCheckIns.ReadOnly = true;
            this.dgvTodayCheckIns.RowHeadersVisible = false;
            this.dgvTodayCheckIns.RowHeadersWidth = 51;
            this.dgvTodayCheckIns.RowTemplate.Height = 35;
            this.dgvTodayCheckIns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayCheckIns.Size = new System.Drawing.Size(1186, 548);
            this.dgvTodayCheckIns.TabIndex = 1;
            // 
            // pnlCheckInActions
            // 
            this.pnlCheckInActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlCheckInActions.Controls.Add(this.btnRefreshCheckIn);
            this.pnlCheckInActions.Controls.Add(this.btnPerformCheckIn);
            this.pnlCheckInActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCheckInActions.Location = new System.Drawing.Point(3, 601);
            this.pnlCheckInActions.Name = "pnlCheckInActions";
            this.pnlCheckInActions.Size = new System.Drawing.Size(1186, 60);
            this.pnlCheckInActions.TabIndex = 2;
            // 
            // btnRefreshCheckIn
            // 
            this.btnRefreshCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnRefreshCheckIn.FlatAppearance.BorderSize = 0;
            this.btnRefreshCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCheckIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefreshCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCheckIn.Location = new System.Drawing.Point(190, 10);
            this.btnRefreshCheckIn.Name = "btnRefreshCheckIn";
            this.btnRefreshCheckIn.Size = new System.Drawing.Size(120, 40);
            this.btnRefreshCheckIn.TabIndex = 1;
            this.btnRefreshCheckIn.Text = "🔄 Yenile";
            this.btnRefreshCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnPerformCheckIn
            // 
            this.btnPerformCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(160)))), ((int)(((byte)(71)))));
            this.btnPerformCheckIn.FlatAppearance.BorderSize = 0;
            this.btnPerformCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformCheckIn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPerformCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnPerformCheckIn.Location = new System.Drawing.Point(20, 10);
            this.btnPerformCheckIn.Name = "btnPerformCheckIn";
            this.btnPerformCheckIn.Size = new System.Drawing.Size(150, 40);
            this.btnPerformCheckIn.TabIndex = 0;
            this.btnPerformCheckIn.Text = "✔ Check-In Yap";
            this.btnPerformCheckIn.UseVisualStyleBackColor = false;
            // 
            // pnlCheckInHeader
            // 
            this.pnlCheckInHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.pnlCheckInHeader.Controls.Add(this.lblDateTime);
            this.pnlCheckInHeader.Controls.Add(this.lblCheckInCount);
            this.pnlCheckInHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCheckInHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlCheckInHeader.Name = "pnlCheckInHeader";
            this.pnlCheckInHeader.Size = new System.Drawing.Size(1186, 50);
            this.pnlCheckInHeader.TabIndex = 0;
            // 
            // lblCheckInCount
            // 
            this.lblCheckInCount.AutoSize = true;
            this.lblCheckInCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheckInCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.lblCheckInCount.Location = new System.Drawing.Point(20, 15);
            this.lblCheckInCount.Name = "lblCheckInCount";
            this.lblCheckInCount.Size = new System.Drawing.Size(333, 28);
            this.lblCheckInCount.TabIndex = 0;
            this.lblCheckInCount.Text = "✅ Bugün giriş yapacak: 0 misafir";
            // 
            // tabTodayCheckOut
            // 
            this.tabTodayCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabTodayCheckOut.Controls.Add(this.dgvTodayCheckOuts);
            this.tabTodayCheckOut.Controls.Add(this.pnlCheckOutActions);
            this.tabTodayCheckOut.Controls.Add(this.pnlCheckOutHeader);
            this.tabTodayCheckOut.Location = new System.Drawing.Point(4, 32);
            this.tabTodayCheckOut.Name = "tabTodayCheckOut";
            this.tabTodayCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabTodayCheckOut.Size = new System.Drawing.Size(1192, 664);
            this.tabTodayCheckOut.TabIndex = 1;
            this.tabTodayCheckOut.Text = "📤 Bugün Check-Out (0)";
            // 
            // dgvTodayCheckOuts
            // 
            this.dgvTodayCheckOuts.AllowUserToAddRows = false;
            this.dgvTodayCheckOuts.AllowUserToDeleteRows = false;
            this.dgvTodayCheckOuts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayCheckOuts.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodayCheckOuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodayCheckOuts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTodayCheckOuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayCheckOuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayCheckOuts.EnableHeadersVisualStyles = false;
            this.dgvTodayCheckOuts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTodayCheckOuts.Location = new System.Drawing.Point(3, 53);
            this.dgvTodayCheckOuts.MultiSelect = false;
            this.dgvTodayCheckOuts.Name = "dgvTodayCheckOuts";
            this.dgvTodayCheckOuts.ReadOnly = true;
            this.dgvTodayCheckOuts.RowHeadersVisible = false;
            this.dgvTodayCheckOuts.RowHeadersWidth = 51;
            this.dgvTodayCheckOuts.RowTemplate.Height = 35;
            this.dgvTodayCheckOuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayCheckOuts.Size = new System.Drawing.Size(1186, 548);
            this.dgvTodayCheckOuts.TabIndex = 1;
            // 
            // pnlCheckOutActions
            // 
            this.pnlCheckOutActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlCheckOutActions.Controls.Add(this.btnLateCheckOuts);
            this.pnlCheckOutActions.Controls.Add(this.btnRefreshCheckOut);
            this.pnlCheckOutActions.Controls.Add(this.btnPerformCheckOut);
            this.pnlCheckOutActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCheckOutActions.Location = new System.Drawing.Point(3, 601);
            this.pnlCheckOutActions.Name = "pnlCheckOutActions";
            this.pnlCheckOutActions.Size = new System.Drawing.Size(1186, 60);
            this.pnlCheckOutActions.TabIndex = 2;
            // 
            // btnLateCheckOuts
            // 
            this.btnLateCheckOuts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnLateCheckOuts.FlatAppearance.BorderSize = 0;
            this.btnLateCheckOuts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLateCheckOuts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLateCheckOuts.ForeColor = System.Drawing.Color.White;
            this.btnLateCheckOuts.Location = new System.Drawing.Point(330, 10);
            this.btnLateCheckOuts.Name = "btnLateCheckOuts";
            this.btnLateCheckOuts.Size = new System.Drawing.Size(150, 40);
            this.btnLateCheckOuts.TabIndex = 2;
            this.btnLateCheckOuts.Text = "⚠ Geç Kalanlar";
            this.btnLateCheckOuts.UseVisualStyleBackColor = false;
            // 
            // btnRefreshCheckOut
            // 
            this.btnRefreshCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnRefreshCheckOut.FlatAppearance.BorderSize = 0;
            this.btnRefreshCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCheckOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefreshCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCheckOut.Location = new System.Drawing.Point(190, 10);
            this.btnRefreshCheckOut.Name = "btnRefreshCheckOut";
            this.btnRefreshCheckOut.Size = new System.Drawing.Size(120, 40);
            this.btnRefreshCheckOut.TabIndex = 1;
            this.btnRefreshCheckOut.Text = "🔄 Yenile";
            this.btnRefreshCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnPerformCheckOut
            // 
            this.btnPerformCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnPerformCheckOut.FlatAppearance.BorderSize = 0;
            this.btnPerformCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerformCheckOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPerformCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnPerformCheckOut.Location = new System.Drawing.Point(20, 10);
            this.btnPerformCheckOut.Name = "btnPerformCheckOut";
            this.btnPerformCheckOut.Size = new System.Drawing.Size(150, 40);
            this.btnPerformCheckOut.TabIndex = 0;
            this.btnPerformCheckOut.Text = "📤 Check-Out Yap";
            this.btnPerformCheckOut.UseVisualStyleBackColor = false;
            // 
            // pnlCheckOutHeader
            // 
            this.pnlCheckOutHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.pnlCheckOutHeader.Controls.Add(this.lblCheckOutCount);
            this.pnlCheckOutHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCheckOutHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlCheckOutHeader.Name = "pnlCheckOutHeader";
            this.pnlCheckOutHeader.Size = new System.Drawing.Size(1186, 50);
            this.pnlCheckOutHeader.TabIndex = 0;
            // 
            // lblCheckOutCount
            // 
            this.lblCheckOutCount.AutoSize = true;
            this.lblCheckOutCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(0)))));
            this.lblCheckOutCount.Location = new System.Drawing.Point(20, 15);
            this.lblCheckOutCount.Name = "lblCheckOutCount";
            this.lblCheckOutCount.Size = new System.Drawing.Size(334, 28);
            this.lblCheckOutCount.TabIndex = 0;
            this.lblCheckOutCount.Text = "📤 Bugün çıkış yapacak: 0 misafir";
            // 
            // tabCurrentGuests
            // 
            this.tabCurrentGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabCurrentGuests.Controls.Add(this.dgvCurrentGuests);
            this.tabCurrentGuests.Controls.Add(this.pnlGuestsActions);
            this.tabCurrentGuests.Controls.Add(this.pnlGuestsHeader);
            this.tabCurrentGuests.Location = new System.Drawing.Point(4, 32);
            this.tabCurrentGuests.Name = "tabCurrentGuests";
            this.tabCurrentGuests.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurrentGuests.Size = new System.Drawing.Size(1192, 664);
            this.tabCurrentGuests.TabIndex = 2;
            this.tabCurrentGuests.Text = "🏨 Mevcut Misafirler (0)";
            // 
            // dgvCurrentGuests
            // 
            this.dgvCurrentGuests.AllowUserToAddRows = false;
            this.dgvCurrentGuests.AllowUserToDeleteRows = false;
            this.dgvCurrentGuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentGuests.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrentGuests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrentGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCurrentGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrentGuests.EnableHeadersVisualStyles = false;
            this.dgvCurrentGuests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCurrentGuests.Location = new System.Drawing.Point(3, 53);
            this.dgvCurrentGuests.MultiSelect = false;
            this.dgvCurrentGuests.Name = "dgvCurrentGuests";
            this.dgvCurrentGuests.ReadOnly = true;
            this.dgvCurrentGuests.RowHeadersVisible = false;
            this.dgvCurrentGuests.RowHeadersWidth = 51;
            this.dgvCurrentGuests.RowTemplate.Height = 35;
            this.dgvCurrentGuests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentGuests.Size = new System.Drawing.Size(1186, 548);
            this.dgvCurrentGuests.TabIndex = 1;
            // 
            // pnlGuestsActions
            // 
            this.pnlGuestsActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlGuestsActions.Controls.Add(this.btnRefreshGuests);
            this.pnlGuestsActions.Controls.Add(this.btnExtendStay);
            this.pnlGuestsActions.Controls.Add(this.btnEarlyCheckOut);
            this.pnlGuestsActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGuestsActions.Location = new System.Drawing.Point(3, 601);
            this.pnlGuestsActions.Name = "pnlGuestsActions";
            this.pnlGuestsActions.Size = new System.Drawing.Size(1186, 60);
            this.pnlGuestsActions.TabIndex = 2;
            // 
            // btnRefreshGuests
            // 
            this.btnRefreshGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnRefreshGuests.FlatAppearance.BorderSize = 0;
            this.btnRefreshGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshGuests.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefreshGuests.ForeColor = System.Drawing.Color.White;
            this.btnRefreshGuests.Location = new System.Drawing.Point(360, 10);
            this.btnRefreshGuests.Name = "btnRefreshGuests";
            this.btnRefreshGuests.Size = new System.Drawing.Size(120, 40);
            this.btnRefreshGuests.TabIndex = 2;
            this.btnRefreshGuests.Text = "🔄 Yenile";
            this.btnRefreshGuests.UseVisualStyleBackColor = false;
            // 
            // btnExtendStay
            // 
            this.btnExtendStay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnExtendStay.FlatAppearance.BorderSize = 0;
            this.btnExtendStay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtendStay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExtendStay.ForeColor = System.Drawing.Color.White;
            this.btnExtendStay.Location = new System.Drawing.Point(190, 10);
            this.btnExtendStay.Name = "btnExtendStay";
            this.btnExtendStay.Size = new System.Drawing.Size(150, 40);
            this.btnExtendStay.TabIndex = 1;
            this.btnExtendStay.Text = "📅 Konaklama Uzat";
            this.btnExtendStay.UseVisualStyleBackColor = false;
            // 
            // btnEarlyCheckOut
            // 
            this.btnEarlyCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnEarlyCheckOut.FlatAppearance.BorderSize = 0;
            this.btnEarlyCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEarlyCheckOut.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEarlyCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnEarlyCheckOut.Location = new System.Drawing.Point(20, 10);
            this.btnEarlyCheckOut.Name = "btnEarlyCheckOut";
            this.btnEarlyCheckOut.Size = new System.Drawing.Size(150, 40);
            this.btnEarlyCheckOut.TabIndex = 0;
            this.btnEarlyCheckOut.Text = "🏃 Erken Check-Out";
            this.btnEarlyCheckOut.UseVisualStyleBackColor = false;
            // 
            // pnlGuestsHeader
            // 
            this.pnlGuestsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlGuestsHeader.Controls.Add(this.lblCurrentGuestsCount);
            this.pnlGuestsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGuestsHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlGuestsHeader.Name = "pnlGuestsHeader";
            this.pnlGuestsHeader.Size = new System.Drawing.Size(1186, 50);
            this.pnlGuestsHeader.TabIndex = 0;
            // 
            // lblCurrentGuestsCount
            // 
            this.lblCurrentGuestsCount.AutoSize = true;
            this.lblCurrentGuestsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentGuestsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.lblCurrentGuestsCount.Location = new System.Drawing.Point(20, 15);
            this.lblCurrentGuestsCount.Name = "lblCurrentGuestsCount";
            this.lblCurrentGuestsCount.Size = new System.Drawing.Size(330, 28);
            this.lblCurrentGuestsCount.TabIndex = 0;
            this.lblCurrentGuestsCount.Text = "🏨 Şu anda konaklayan: 0 misafir";
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabSearch.Controls.Add(this.dgvSearchResults);
            this.tabSearch.Controls.Add(this.pnlSearchFilter);
            this.tabSearch.Location = new System.Drawing.Point(4, 32);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1192, 664);
            this.tabSearch.TabIndex = 3;
            this.tabSearch.Text = "🔍 Gelişmiş Arama";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvSearchResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchResults.EnableHeadersVisualStyles = false;
            this.dgvSearchResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSearchResults.Location = new System.Drawing.Point(3, 83);
            this.dgvSearchResults.MultiSelect = false;
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.RowHeadersVisible = false;
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.RowTemplate.Height = 35;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(1186, 578);
            this.dgvSearchResults.TabIndex = 1;
            // 
            // pnlSearchFilter
            // 
            this.pnlSearchFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlSearchFilter.Controls.Add(this.btnClearSearch);
            this.pnlSearchFilter.Controls.Add(this.btnSearch);
            this.pnlSearchFilter.Controls.Add(this.txtSearch);
            this.pnlSearchFilter.Controls.Add(this.cmbSearchType);
            this.pnlSearchFilter.Controls.Add(this.lblSearchBy);
            this.pnlSearchFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlSearchFilter.Name = "pnlSearchFilter";
            this.pnlSearchFilter.Size = new System.Drawing.Size(1186, 80);
            this.pnlSearchFilter.TabIndex = 0;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(106)))), ((int)(((byte)(66)))));
            this.btnClearSearch.FlatAppearance.BorderSize = 0;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearSearch.ForeColor = System.Drawing.Color.White;
            this.btnClearSearch.Location = new System.Drawing.Point(635, 43);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(100, 35);
            this.btnClearSearch.TabIndex = 4;
            this.btnClearSearch.Text = "🗑 Temizle";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(515, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍 Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(195, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Arama yapılacak değeri giriniz...";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Müşteri Adı",
            "Oda Numarası",
            "TC Kimlik No",
            "Telefon",
            "Rezervasyon Tarihi",
            "Tümü"});
            this.cmbSearchType.Location = new System.Drawing.Point(25, 45);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(150, 31);
            this.cmbSearchType.TabIndex = 1;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblSearchBy.Location = new System.Drawing.Point(20, 15);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(149, 25);
            this.lblSearchBy.TabIndex = 0;
            this.lblSearchBy.Text = "🔍 Arama Türü:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.lblDateTime.Location = new System.Drawing.Point(944, 19);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(230, 23);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "15 Haziran 2025 Cumartesi";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckInOutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Name = "CheckInOutControl";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.CheckInOutControl_Load);
            this.pnlMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabTodayCheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayCheckIns)).EndInit();
            this.pnlCheckInActions.ResumeLayout(false);
            this.pnlCheckInHeader.ResumeLayout(false);
            this.pnlCheckInHeader.PerformLayout();
            this.tabTodayCheckOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayCheckOuts)).EndInit();
            this.pnlCheckOutActions.ResumeLayout(false);
            this.pnlCheckOutHeader.ResumeLayout(false);
            this.pnlCheckOutHeader.PerformLayout();
            this.tabCurrentGuests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentGuests)).EndInit();
            this.pnlGuestsActions.ResumeLayout(false);
            this.pnlGuestsHeader.ResumeLayout(false);
            this.pnlGuestsHeader.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.pnlSearchFilter.ResumeLayout(false);
            this.pnlSearchFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
