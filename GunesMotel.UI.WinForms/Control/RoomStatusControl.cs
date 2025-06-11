using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using GunesMotel.UI.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class RoomStatusControl : UserControl
    {
        public RoomStatusControl()
        {
            InitializeComponent();
            LoadFloors();
        }

        private void LoadFloors()
        {
            cmbKatlar.Items.Clear(); // eski değerleri temizle

            using (var db = new GunesMotelContext())
            {
                var floors = db.Rooms
                    .Where(r => r.Floor.HasValue)
                    .Select(r => r.Floor.Value)
                    .Distinct()
                    .OrderBy(f => f)
                    .ToList();

                foreach (var floor in floors)
                {
                    cmbKatlar.Items.Add(floor); // doğrudan int ekleniyor
                }

                if (cmbKatlar.Items.Count > 0)
                    cmbKatlar.SelectedIndex = 0; // ilk katı otomatik seç
            }
        }

        public void LoadRooms(int floor)
        {
            flpRooms.Controls.Clear();

            using (var db = new GunesMotelContext())
            {
                var rooms = db.Rooms
                    .Include(r => r.RoomType)
                    .Where(r => r.Floor == floor)
                    .OrderBy(r => r.RoomNumber)
                    .ToList();

                foreach (var room in rooms)
                {
                    var btn = new Button
                    {
                        Width = 100,
                        Height = 60,
                        Text = $"Oda {room.RoomNumber}\n{room.RoomType.TypeName}",
                        BackColor = GetColorByStatus(room.Status),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        Tag = room.RoomID,
                        Margin = new Padding(8)
                    };

                    btn.Click += BtnRoom_Click;

                    flpRooms.Controls.Add(btn);
                }
            }
        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null || btn.Tag == null) return;

            int roomId = (int)btn.Tag;

            using (var db = new GunesMotelContext())
            {
                var room = db.Rooms.Include(r => r.RoomType).FirstOrDefault(r => r.RoomID == roomId);
                if (room == null) return;

                MessageBox.Show(
                        $"Oda: {room.RoomNumber}\n" +
                        $"Durum: {room.Status}\n" +
                        $"Tip: {room.RoomType.TypeName}\n" +
                        $"Özellikler: {room.RoomType.Feature}",
                        "Oda Bilgisi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                );

                // Durum seçme formunu aç
                var statusForm = new FrmChangeRoomStatus(room.Status);
                if (statusForm.ShowDialog() == DialogResult.OK)
                {
                    // Yeni durumu al
                    string newStatus = statusForm.SelectedStatus;
                    room.Status = newStatus;
                    db.SaveChanges();

                    // Güncel görünümü yenile
                    int selectedFloor = (int)cmbKatlar.SelectedItem;
                    LoadRooms(selectedFloor);
                }
            }
        }

        private Color GetColorByStatus(string status)
        {
            if (status == "Boş") return Color.FromArgb(76, 175, 80);        // Yeşil
            if (status == "Dolu") return Color.FromArgb(244, 67, 54);       // Kırmızı
            if (status == "Temizlikte") return Color.FromArgb(255, 193, 7); // Sarı
            return Color.Gray;
        }

        private void cmbKatlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKatlar.SelectedItem != null)
            {
                int selectedFloor = (int)cmbKatlar.SelectedItem;
                LoadRooms(selectedFloor);
            }
        }
    }
}
