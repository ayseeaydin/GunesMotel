using GunesMotel.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class ReceptionDashboardContentControl : UserControl
    {
        public ReceptionDashboardContentControl()
        {
            InitializeComponent();
        }

        private void LoadStats()
        {
            using (var context = new GunesMotelContext())
            {
                int todayCheckIn = context.Reservations
                    .Count(r => DbFunctions.TruncateTime(r.CheckInDate) == DateTime.Today && r.Status == "Check-in");

                int todayCheckOut = context.Reservations
                    .Count(r => DbFunctions.TruncateTime(r.CheckOutDate) == DateTime.Today && r.Status == "Check-out");

                int availableRooms = context.Rooms.Count(r => r.Status == "Boş");
                int pending = context.Reservations.Count(r => r.Status == "Beklemede");

                lblCheckInCount.Text = todayCheckIn.ToString();
                lblCheckOutCount.Text = todayCheckOut.ToString();
                lblAvailableCount.Text = availableRooms.ToString();
                lblPendingCount.Text = pending.ToString();
            }
        }

        private void LoadTodaySchedule()
        {
            using (var context = new GunesMotelContext())
            {
                var today = DateTime.Today;

                // Bugünkü Check-in ve Check-out listesi
                var programList = context.Reservations
                    .Where(r =>
                        DbFunctions.TruncateTime(r.CheckInDate) == today ||
                        DbFunctions.TruncateTime(r.CheckOutDate) == today)
                    .Select(r => new
                    {
                        Oda = r.Room.RoomNumber,
                        Müşteri = r.Customer.FullName,
                        Giriş = r.CheckInDate,
                        Çıkış = r.CheckOutDate,
                        Durum = r.Status
                    })
                    .OrderBy(r => r.Giriş)
                    .ToList();

                dgvTodaySchedule.DataSource = programList;

                dgvTodaySchedule.ClearSelection();
                dgvTodaySchedule.Columns["Giriş"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dgvTodaySchedule.Columns["Çıkış"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }
        }

        private void LoadQuickNotes()
        {
            txtQuickNotes.Text =
                "• 103 numaralı odada klima arızası var\n" +
                "• Yarın sabah erken check-in talebi (Oda 201)\n" +
                "• Özel diyet menüsü talebi (Oda 105)\n" +
                "• Ekstra yatak talebi (Oda 301)\n" +
                "• Geç check-out onayı (Oda 102 - 15:00)";
        }

        private void LoadRoomStatus()
        {
            pnlRoomGrid.Controls.Clear();
            var roomStatusControl = new RoomStatusControl();
            roomStatusControl.Dock = DockStyle.Fill;
            pnlRoomGrid.Controls.Add(roomStatusControl);
        }

        private void ReceptionDashboardContentControl_Load(object sender, EventArgs e)
        {
            LoadStats();
            LoadTodaySchedule();
            LoadRoomStatus();
            LoadQuickNotes();
        }
    }
}
