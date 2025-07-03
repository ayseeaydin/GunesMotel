using GunesMotel.Common;
using GunesMotel.DataAccess.Contexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using GunesMotel.UI.WinForms.Control;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities.DTOs;

namespace GunesMotel.UI.WinForms.Forms
{
    public partial class FrmReceptionDashboard : Form
    {
        private RoomStatusControl roomStatusControl;
        public FrmReceptionDashboard()
        {
            InitializeComponent();
        }

        private void FrmReceptionDashboard_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadRoomStatistics();
            LoadFooterStatus();
            // LoadRoomStatus(); // Oda durumunu yükle

            roomStatusControl = new RoomStatusControl();
            roomStatusControl.Dock = DockStyle.Fill;
            pnlRoomGrid.Controls.Add(roomStatusControl);
        }

        private void LoadUserControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        private void LoadUserInfo()
        {
            lblUserName.Text = CurrentUser.Username;
        }

        private void LoadRoomStatistics()
        {
            using(var context = new GunesMotelContext())
            {
                lblCheckInCount.Text = context.Reservations
                    .Count(r => DbFunctions.TruncateTime(r.CheckInDate) == DateTime.Today && r.Status == "Check-in")
                    .ToString();

                lblCheckOutCount.Text = context.Reservations
                    .Count(r => DbFunctions.TruncateTime(r.CheckOutDate) == DateTime.Today && r.Status == "Check-out")
                    .ToString();

                lblAvailableCount.Text = context.Rooms
                    .Count(r => r.Status == "Boş")
                    .ToString();

                lblPendingCount.Text = context.Reservations
                    .Count(r => r.Status == "Beklemede")
                    .ToString();
            }
            
        }

        private void LoadFooterStatus()
        {
            int aktifRezervasyon = 0;
            int bekleyenIslem = 0;

            using (var context = new GunesMotelContext())
            {
                aktifRezervasyon = context.Reservations.Count(r => r.Status == "Check-in");
                bekleyenIslem = context.Reservations.Count(r => r.Status == "Beklemede");
            }

            lblStatus.Text = $"Durum: {aktifRezervasyon} aktif rezervasyon, {bekleyenIslem} bekleyen işlem";
            lblLastUpdate.Text = "Son Güncelleme: " + DateTime.Now.ToString("dd MMMM yyyy, HH:mm");
        }

        private void btnOdaDurumu_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RoomStatusControl());
        }
        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddCustomerControl());
        }
        /*
        private void LoadRoomStatus()
        {
            pnlRoomGrid.Controls.Clear();

            var roomRepo = new RoomRepository();
            var rooms = roomRepo.GetAll(); // RoomType bilgisi istenirse GetAllWithRoomType kullanılabilir

            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            foreach (var room in rooms)
            {
                Button btn = new Button
                {
                    Text = room.RoomNumber,
                    Tag = room.RoomID,
                    Width = 80,
                    Height = 50,
                    Margin = new Padding(5),
                    BackColor = GetColorByStatus(room.Status),
                };

                btn.Click += BtnRoom_Click;
                flp.Controls.Add(btn);
            }

            pnlRoomGrid.Controls.Add(flp);
        }
        */


        private Color GetColorByStatus(string status)
        {
            if (status == "Boş")
                return Color.LightGreen;
            else if (status == "Dolu")
                return Color.LightCoral;
            else if (status == "Temizlikte")
                return Color.LightYellow;
            else if (status == "Arızalı")
                return Color.Gray;
            else
                return Color.White;
        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null || btn.Tag == null) return;

            int roomId = (int)btn.Tag;

            using (var context = new GunesMotelContext())
            {
                var room = context.Rooms.Include(r => r.RoomType).FirstOrDefault(r => r.RoomID == roomId);
                if (room == null) return;

                MessageBox.Show($"Oda {room.RoomNumber} - Durum: {room.Status}", "Oda Detayı");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRezervasyonlar_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ReservationManagementControl());
        }

        private void btnCheckinOut_Click(object sender, EventArgs e)
        {
            LoadUserControl(new CheckInOutControl());
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            FrmReceptionDashboard_Load(sender, e); // Yeniden yükle999
        }
    }
}
