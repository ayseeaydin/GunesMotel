using System.Drawing;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    partial class ReceptionDashboardContentControl
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
            this.pnlStatsCards = new System.Windows.Forms.Panel();
            this.pnlCheckInCard = new System.Windows.Forms.Panel();
            this.lblCheckInCount = new System.Windows.Forms.Label();
            this.lblCheckInTitle = new System.Windows.Forms.Label();
            this.pnlCheckOutCard = new System.Windows.Forms.Panel();
            this.lblCheckOutCount = new System.Windows.Forms.Label();
            this.lblCheckOutTitle = new System.Windows.Forms.Label();
            this.pnlAvailableCard = new System.Windows.Forms.Panel();
            this.lblAvailableCount = new System.Windows.Forms.Label();
            this.lblAvailableTitle = new System.Windows.Forms.Label();
            this.pnlPendingCard = new System.Windows.Forms.Panel();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();

            this.pnlMiddleSection = new System.Windows.Forms.Panel();
            this.pnlRoomStatus = new System.Windows.Forms.Panel();
            this.lblRoomStatusTitle = new System.Windows.Forms.Label();
            this.pnlRoomGrid = new System.Windows.Forms.Panel();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnYeniRezervasyon = new System.Windows.Forms.Button();
            this.btnEkHizmet = new System.Windows.Forms.Button();

            this.pnlRecentActivities = new System.Windows.Forms.Panel();
            this.lblActivitiesTitle = new System.Windows.Forms.Label();

            this.pnlBottomSection = new System.Windows.Forms.Panel();
            this.pnlTodaySchedule = new System.Windows.Forms.Panel();
            this.lblScheduleTitle = new System.Windows.Forms.Label();
            this.dgvTodaySchedule = new System.Windows.Forms.DataGridView();
            this.pnlQuickNotes = new System.Windows.Forms.Panel();
            this.lblNotesTitle = new System.Windows.Forms.Label();
            this.txtQuickNotes = new System.Windows.Forms.TextBox();

            this.pnlStatsCards.SuspendLayout();
            this.pnlCheckInCard.SuspendLayout();
            this.pnlCheckOutCard.SuspendLayout();
            this.pnlAvailableCard.SuspendLayout();
            this.pnlPendingCard.SuspendLayout();
            this.pnlMiddleSection.SuspendLayout();
            this.pnlRoomStatus.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.pnlRecentActivities.SuspendLayout();
            this.pnlBottomSection.SuspendLayout();
            this.pnlTodaySchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaySchedule)).BeginInit();
            this.pnlQuickNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStatsCards
            // 
            this.pnlStatsCards.Controls.Add(this.pnlCheckInCard);
            this.pnlStatsCards.Controls.Add(this.pnlCheckOutCard);
            this.pnlStatsCards.Controls.Add(this.pnlAvailableCard);
            this.pnlStatsCards.Controls.Add(this.pnlPendingCard);
            this.pnlStatsCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatsCards.Location = new System.Drawing.Point(0, 0);
            this.pnlStatsCards.Name = "pnlStatsCards";
            this.pnlStatsCards.Size = new System.Drawing.Size(1426, 148);
            this.pnlStatsCards.TabIndex = 0;
            // 
            // pnlCheckInCard
            // 
            this.pnlCheckInCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlCheckInCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckInCard.Controls.Add(this.lblCheckInCount);
            this.pnlCheckInCard.Controls.Add(this.lblCheckInTitle);
            this.pnlCheckInCard.Location = new System.Drawing.Point(0, 12);
            this.pnlCheckInCard.Name = "pnlCheckInCard";
            this.pnlCheckInCard.Size = new System.Drawing.Size(290, 123);
            this.pnlCheckInCard.TabIndex = 0;
            // 
            // lblCheckInCount
            // 
            this.lblCheckInCount.AutoSize = true;
            this.lblCheckInCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCheckInCount.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblCheckInCount.Location = new System.Drawing.Point(100, 62);
            this.lblCheckInCount.Name = "lblCheckInCount";
            this.lblCheckInCount.Size = new System.Drawing.Size(35, 41);
            this.lblCheckInCount.TabIndex = 2;
            this.lblCheckInCount.Text = "8";
            // 
            // lblCheckInTitle
            // 
            this.lblCheckInTitle.AutoSize = true;
            this.lblCheckInTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckInTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblCheckInTitle.Location = new System.Drawing.Point(100, 25);
            this.lblCheckInTitle.Name = "lblCheckInTitle";
            this.lblCheckInTitle.Size = new System.Drawing.Size(156, 23);
            this.lblCheckInTitle.TabIndex = 1;
            this.lblCheckInTitle.Text = "Bugünkü Check-in";
            // 
            // pnlCheckOutCard
            // 
            this.pnlCheckOutCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlCheckOutCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckOutCard.Controls.Add(this.lblCheckOutCount);
            this.pnlCheckOutCard.Controls.Add(this.lblCheckOutTitle);
            this.pnlCheckOutCard.Location = new System.Drawing.Point(292, 12);
            this.pnlCheckOutCard.Name = "pnlCheckOutCard";
            this.pnlCheckOutCard.Size = new System.Drawing.Size(290, 123);
            this.pnlCheckOutCard.TabIndex = 1;
            // 
            // lblCheckOutCount
            // 
            this.lblCheckOutCount.AutoSize = true;
            this.lblCheckOutCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutCount.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblCheckOutCount.Location = new System.Drawing.Point(100, 62);
            this.lblCheckOutCount.Name = "lblCheckOutCount";
            this.lblCheckOutCount.Size = new System.Drawing.Size(35, 41);
            this.lblCheckOutCount.TabIndex = 2;
            this.lblCheckOutCount.Text = "5";
            // 
            // lblCheckOutTitle
            // 
            this.lblCheckOutTitle.AutoSize = true;
            this.lblCheckOutTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCheckOutTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblCheckOutTitle.Location = new System.Drawing.Point(100, 25);
            this.lblCheckOutTitle.Name = "lblCheckOutTitle";
            this.lblCheckOutTitle.Size = new System.Drawing.Size(168, 23);
            this.lblCheckOutTitle.TabIndex = 1;
            this.lblCheckOutTitle.Text = "Bugünkü Check-out";
            // 
            // pnlAvailableCard
            // 
            this.pnlAvailableCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlAvailableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailableCard.Controls.Add(this.lblAvailableCount);
            this.pnlAvailableCard.Controls.Add(this.lblAvailableTitle);
            this.pnlAvailableCard.Location = new System.Drawing.Point(584, 12);
            this.pnlAvailableCard.Name = "pnlAvailableCard";
            this.pnlAvailableCard.Size = new System.Drawing.Size(290, 123);
            this.pnlAvailableCard.TabIndex = 2;
            // 
            // lblAvailableCount
            // 
            this.lblAvailableCount.AutoSize = true;
            this.lblAvailableCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblAvailableCount.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblAvailableCount.Location = new System.Drawing.Point(100, 62);
            this.lblAvailableCount.Name = "lblAvailableCount";
            this.lblAvailableCount.Size = new System.Drawing.Size(35, 41);
            this.lblAvailableCount.TabIndex = 2;
            this.lblAvailableCount.Text = "7";
            // 
            // lblAvailableTitle
            // 
            this.lblAvailableTitle.AutoSize = true;
            this.lblAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblAvailableTitle.Location = new System.Drawing.Point(100, 25);
            this.lblAvailableTitle.Name = "lblAvailableTitle";
            this.lblAvailableTitle.Size = new System.Drawing.Size(97, 23);
            this.lblAvailableTitle.TabIndex = 1;
            this.lblAvailableTitle.Text = "Boş Odalar";
            // 
            // pnlPendingCard
            // 
            this.pnlPendingCard.BackColor = System.Drawing.Color.FromArgb(230, 215, 185);
            this.pnlPendingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPendingCard.Controls.Add(this.lblPendingCount);
            this.pnlPendingCard.Controls.Add(this.lblPendingTitle);
            this.pnlPendingCard.Location = new System.Drawing.Point(876, 12);
            this.pnlPendingCard.Name = "pnlPendingCard";
            this.pnlPendingCard.Size = new System.Drawing.Size(290, 123);
            this.pnlPendingCard.TabIndex = 3;
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPendingCount.Location = new System.Drawing.Point(100, 62);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(35, 41);
            this.lblPendingCount.TabIndex = 2;
            this.lblPendingCount.Text = "3";
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblPendingTitle.Location = new System.Drawing.Point(100, 25);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(129, 23);
            this.lblPendingTitle.TabIndex = 1;
            this.lblPendingTitle.Text = "Bekleyen İşlem";
            // 
            // pnlMiddleSection
            // 
            this.pnlMiddleSection.Controls.Add(this.pnlRoomStatus);
            this.pnlMiddleSection.Controls.Add(this.pnlRecentActivities);
            this.pnlMiddleSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMiddleSection.Location = new System.Drawing.Point(0, 148);
            this.pnlMiddleSection.Name = "pnlMiddleSection";
            this.pnlMiddleSection.Size = new System.Drawing.Size(1426, 373);
            this.pnlMiddleSection.TabIndex = 1;
            // 
            // pnlRoomStatus
            // 
            this.pnlRoomStatus.BackColor = System.Drawing.Color.White;
            this.pnlRoomStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRoomStatus.Controls.Add(this.pnlQuickActions);
            this.pnlRoomStatus.Controls.Add(this.lblRoomStatusTitle);
            this.pnlRoomStatus.Controls.Add(this.pnlRoomGrid);
            this.pnlRoomStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlRoomStatus.Name = "pnlRoomStatus";
            this.pnlRoomStatus.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlRoomStatus.Size = new System.Drawing.Size(737, 353);
            this.pnlRoomStatus.TabIndex = 0;
            // 
            // lblRoomStatusTitle
            // 
            this.lblRoomStatusTitle.AutoSize = true;
            this.lblRoomStatusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoomStatusTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblRoomStatusTitle.Location = new System.Drawing.Point(17, 3);
            this.lblRoomStatusTitle.Name = "lblRoomStatusTitle";
            this.lblRoomStatusTitle.Size = new System.Drawing.Size(133, 28);
            this.lblRoomStatusTitle.TabIndex = 1;
            this.lblRoomStatusTitle.Text = "Oda Durumu";
            // 
            // pnlRoomGrid
            // 
            this.pnlRoomGrid.Location = new System.Drawing.Point(20, 35);
            this.pnlRoomGrid.Name = "pnlRoomGrid";
            this.pnlRoomGrid.Size = new System.Drawing.Size(701, 251);
            this.pnlRoomGrid.TabIndex = 2;
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.Controls.Add(this.btnEkHizmet);
            this.pnlQuickActions.Controls.Add(this.btnCheckIn);
            this.pnlQuickActions.Controls.Add(this.btnCheckOut);
            this.pnlQuickActions.Controls.Add(this.btnYeniRezervasyon);
            this.pnlQuickActions.Location = new System.Drawing.Point(22, 294);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(596, 47);
            this.pnlQuickActions.TabIndex = 3;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(139, 106, 66);
            this.btnCheckIn.FlatAppearance.BorderSize = 0;
            this.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(4, 9);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(133, 34);
            this.btnCheckIn.TabIndex = 0;
            this.btnCheckIn.Text = "Check-in";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(139, 106, 66);
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(141, 9);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(133, 34);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Check-out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // btnYeniRezervasyon
            // 
            this.btnYeniRezervasyon.BackColor = System.Drawing.Color.FromArgb(139, 106, 66);
            this.btnYeniRezervasyon.FlatAppearance.BorderSize = 0;
            this.btnYeniRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniRezervasyon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYeniRezervasyon.ForeColor = System.Drawing.Color.White;
            this.btnYeniRezervasyon.Location = new System.Drawing.Point(281, 9);
            this.btnYeniRezervasyon.Name = "btnYeniRezervasyon";
            this.btnYeniRezervasyon.Size = new System.Drawing.Size(133, 34);
            this.btnYeniRezervasyon.TabIndex = 2;
            this.btnYeniRezervasyon.Text = "Rezervasyon";
            this.btnYeniRezervasyon.UseVisualStyleBackColor = false;
            // 
            // btnEkHizmet
            // 
            this.btnEkHizmet.BackColor = System.Drawing.Color.FromArgb(139, 106, 66);
            this.btnEkHizmet.FlatAppearance.BorderSize = 0;
            this.btnEkHizmet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkHizmet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEkHizmet.ForeColor = System.Drawing.Color.White;
            this.btnEkHizmet.Location = new System.Drawing.Point(421, 9);
            this.btnEkHizmet.Name = "btnEkHizmet";
            this.btnEkHizmet.Size = new System.Drawing.Size(133, 34);
            this.btnEkHizmet.TabIndex = 3;
            this.btnEkHizmet.Text = "Ek Hizmet";
            this.btnEkHizmet.UseVisualStyleBackColor = false;
            // 
            // pnlRecentActivities
            // 
            this.pnlRecentActivities.BackColor = System.Drawing.Color.White;
            this.pnlRecentActivities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecentActivities.Controls.Add(this.lblActivitiesTitle);
            this.pnlRecentActivities.Location = new System.Drawing.Point(745, 0);
            this.pnlRecentActivities.Name = "pnlRecentActivities";
            this.pnlRecentActivities.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlRecentActivities.Size = new System.Drawing.Size(662, 353);
            this.pnlRecentActivities.TabIndex = 1;
            // 
            // lblActivitiesTitle
            // 
            this.lblActivitiesTitle.AutoSize = true;
            this.lblActivitiesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblActivitiesTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblActivitiesTitle.Location = new System.Drawing.Point(17, 16);
            this.lblActivitiesTitle.Name = "lblActivitiesTitle";
            this.lblActivitiesTitle.Size = new System.Drawing.Size(153, 28);
            this.lblActivitiesTitle.TabIndex = 1;
            this.lblActivitiesTitle.Text = "Son Hareketler";
            // 
            // pnlBottomSection
            // 
            this.pnlBottomSection.Controls.Add(this.pnlTodaySchedule);
            this.pnlBottomSection.Controls.Add(this.pnlQuickNotes);
            this.pnlBottomSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottomSection.Location = new System.Drawing.Point(0, 521);
            this.pnlBottomSection.Name = "pnlBottomSection";
            this.pnlBottomSection.Size = new System.Drawing.Size(1426, 312);
            this.pnlBottomSection.TabIndex = 2;
            // 
            // pnlTodaySchedule
            // 
            this.pnlTodaySchedule.BackColor = System.Drawing.Color.White;
            this.pnlTodaySchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTodaySchedule.Controls.Add(this.lblScheduleTitle);
            this.pnlTodaySchedule.Controls.Add(this.dgvTodaySchedule);
            this.pnlTodaySchedule.Location = new System.Drawing.Point(0, 20);
            this.pnlTodaySchedule.Name = "pnlTodaySchedule";
            this.pnlTodaySchedule.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlTodaySchedule.Size = new System.Drawing.Size(737, 288);
            this.pnlTodaySchedule.TabIndex = 0;
            // 
            // lblScheduleTitle
            // 
            this.lblScheduleTitle.AutoSize = true;
            this.lblScheduleTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblScheduleTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblScheduleTitle.Location = new System.Drawing.Point(12, 10);
            this.lblScheduleTitle.Name = "lblScheduleTitle";
            this.lblScheduleTitle.Size = new System.Drawing.Size(183, 28);
            this.lblScheduleTitle.TabIndex = 1;
            this.lblScheduleTitle.Text = "Bugünkü Program";
            // 
            // dgvTodaySchedule
            // 
            this.dgvTodaySchedule.AllowUserToAddRows = false;
            this.dgvTodaySchedule.AllowUserToDeleteRows = false;
            this.dgvTodaySchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodaySchedule.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodaySchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTodaySchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodaySchedule.Location = new System.Drawing.Point(17, 42);
            this.dgvTodaySchedule.Name = "dgvTodaySchedule";
            this.dgvTodaySchedule.ReadOnly = true;
            this.dgvTodaySchedule.RowHeadersVisible = false;
            this.dgvTodaySchedule.RowHeadersWidth = 51;
            this.dgvTodaySchedule.Size = new System.Drawing.Size(701, 217);
            this.dgvTodaySchedule.TabIndex = 0;
            // 
            // pnlQuickNotes
            // 
            this.pnlQuickNotes.BackColor = System.Drawing.Color.White;
            this.pnlQuickNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickNotes.Controls.Add(this.lblNotesTitle);
            this.pnlQuickNotes.Controls.Add(this.txtQuickNotes);
            this.pnlQuickNotes.Location = new System.Drawing.Point(745, 20);
            this.pnlQuickNotes.Name = "pnlQuickNotes";
            this.pnlQuickNotes.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlQuickNotes.Size = new System.Drawing.Size(662, 288);
            this.pnlQuickNotes.TabIndex = 1;
            // 
            // lblNotesTitle
            // 
            this.lblNotesTitle.AutoSize = true;
            this.lblNotesTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotesTitle.ForeColor = System.Drawing.Color.FromArgb(93, 64, 55);
            this.lblNotesTitle.Location = new System.Drawing.Point(13, 10);
            this.lblNotesTitle.Name = "lblNotesTitle";
            this.lblNotesTitle.Size = new System.Drawing.Size(122, 28);
            this.lblNotesTitle.TabIndex = 1;
            this.lblNotesTitle.Text = "Hızlı Notlar";
            // 
            // txtQuickNotes
            // 
            this.txtQuickNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.txtQuickNotes.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtQuickNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuickNotes.Location = new System.Drawing.Point(10, 42);
            this.txtQuickNotes.Multiline = true;
            this.txtQuickNotes.Name = "txtQuickNotes";
            this.txtQuickNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuickNotes.Size = new System.Drawing.Size(620, 217);
            this.txtQuickNotes.TabIndex = 0;
            this.txtQuickNotes.Text = "";
            // 
            // ReceptionDashboardContentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBottomSection);
            this.Controls.Add(this.pnlMiddleSection);
            this.Controls.Add(this.pnlStatsCards);
            this.Name = "ReceptionDashboardContentControl";
            this.Size = new System.Drawing.Size(1426, 821);
            this.pnlStatsCards.ResumeLayout(false);
            this.pnlCheckInCard.ResumeLayout(false);
            this.pnlCheckInCard.PerformLayout();
            this.pnlCheckOutCard.ResumeLayout(false);
            this.pnlCheckOutCard.PerformLayout();
            this.pnlAvailableCard.ResumeLayout(false);
            this.pnlAvailableCard.PerformLayout();
            this.pnlPendingCard.ResumeLayout(false);
            this.pnlPendingCard.PerformLayout();
            this.pnlMiddleSection.ResumeLayout(false);
            this.pnlRoomStatus.ResumeLayout(false);
            this.pnlRoomStatus.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlRecentActivities.ResumeLayout(false);
            this.pnlRecentActivities.PerformLayout();
            this.pnlBottomSection.ResumeLayout(false);
            this.pnlTodaySchedule.ResumeLayout(false);
            this.pnlTodaySchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodaySchedule)).EndInit();
            this.pnlQuickNotes.ResumeLayout(false);
            this.pnlQuickNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlStatsCards;
        private System.Windows.Forms.Panel pnlCheckInCard;
        private System.Windows.Forms.Label lblCheckInCount;
        private System.Windows.Forms.Label lblCheckInTitle;
        private System.Windows.Forms.Panel pnlCheckOutCard;
        private System.Windows.Forms.Label lblCheckOutCount;
        private System.Windows.Forms.Label lblCheckOutTitle;
        private System.Windows.Forms.Panel pnlAvailableCard;
        private System.Windows.Forms.Label lblAvailableCount;
        private System.Windows.Forms.Label lblAvailableTitle;
        private System.Windows.Forms.Panel pnlPendingCard;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Panel pnlMiddleSection;
        private System.Windows.Forms.Panel pnlRoomStatus;
        private System.Windows.Forms.Label lblRoomStatusTitle;
        private System.Windows.Forms.Panel pnlRoomGrid;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnYeniRezervasyon;
        private System.Windows.Forms.Button btnEkHizmet;
        private System.Windows.Forms.Panel pnlRecentActivities;
        private System.Windows.Forms.Label lblActivitiesTitle;
        private System.Windows.Forms.Panel pnlBottomSection;
        private System.Windows.Forms.Panel pnlTodaySchedule;
        private System.Windows.Forms.Label lblScheduleTitle;
        private System.Windows.Forms.DataGridView dgvTodaySchedule;
        private System.Windows.Forms.Panel pnlQuickNotes;
        private System.Windows.Forms.Label lblNotesTitle;
        private System.Windows.Forms.TextBox txtQuickNotes;
    }
}
