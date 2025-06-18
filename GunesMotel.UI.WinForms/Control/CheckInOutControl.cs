using GunesMotel.DataAccess.Repositories;
using GunesMotel.UI.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GunesMotel.UI.WinForms.Forms;
using GunesMotel.Entities;
using GunesMotel.DataAccess.Helpers;
using GunesMotel.Common;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class CheckInOutControl : UserControl
    {
        public CheckInOutControl()
        {
            InitializeComponent();
        }

        private void LoadTodayCheckIns()
        {
            try
            {
                var repo = new ReservationRepository();
                var today = DateTime.Today;

                var checkInList = repo.GetAll()
                    .Where(r => r.CheckInDate.Date == today && r.Status != "Check-in")
                    .Select(r => new
                    {
                        r.ReservationID,
                        Customer = r.Customer.FullName,
                        Room = r.Room.RoomNumber,
                        r.CheckInDate,
                        r.CheckOutDate,
                        r.Status,
                        r.Source
                    })
                    .ToList();

                dgvTodayCheckIns.DataSource = checkInList;
                lblCheckInCount.Text = $"✅ Bugün giriş yapacak: {checkInList.Count} misafir";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check-in listesi yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckInOutControl_Load(object sender, EventArgs e)
        {
            LoadTodayCheckIns();
            LoadTodayCheckOuts();
            LoadCurrentGuests();
            lblDateTime.Text = DateTime.Now.ToString("dd MMMM yyyy dddd");
        }

        private void LoadCurrentGuests()
        {
            try
            {
                var repo = new ReservationRepository();
                var today = DateTime.Today;

                // Şu anda otelde kalan misafirler (Status = "Check-in")
                var currentGuests = repo.GetAll()
                    .Where(r => r.Status == "Check-in")
                    .Select(r => new
                    {
                        r.ReservationID,
                        Customer = r.Customer.FullName,
                        Room = r.Room.RoomNumber,
                        r.CheckInDate,
                        r.CheckOutDate,
                        Kalan_Gun = (r.CheckOutDate.Date - today).Days,
                        Gecen_Gun = (today - r.CheckInDate.Date).Days + 1,
                        r.GuestCount,
                        r.Status
                    })
                    .OrderBy(x => x.Room)
                    .ToList();

                dgvCurrentGuests.DataSource = currentGuests;
                lblCurrentGuestsCount.Text = $"🏨 Oteldeki Misafirler: {currentGuests.Count} rezervasyon";

                // Negatif kalan gün olanları kırmızı yap (check-out tarihi geçmiş)
                foreach (DataGridViewRow row in dgvCurrentGuests.Rows)
                {
                    if (row.Cells["Kalan_Gun"].Value != null)
                    {
                        int kalanGun = Convert.ToInt32(row.Cells["Kalan_Gun"].Value);
                        if (kalanGun < 0)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightCoral;
                        }
                        else if (kalanGun == 0)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Mevcut misafirler yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTodayCheckOuts()
        {
            try
            {
                var repo = new ReservationRepository();
                var today = DateTime.Today;

                var checkOutList = repo.GetAll()
                    .Where(r => r.CheckOutDate.Date == today && r.Status == "Check-in")
                    .Select(r => new
                    {
                        r.ReservationID,
                        Customer = r.Customer.FullName,
                        Room = r.Room.RoomNumber,
                        r.CheckInDate,
                        r.CheckOutDate,
                        r.Status,
                        Gece_Sayisi = (r.CheckOutDate.Date - r.CheckInDate.Date).Days
                    })
                    .ToList();

                dgvTodayCheckOuts.DataSource = checkOutList;
                lblCheckOutCount.Text = $"📤 Bugün çıkış yapacak: {checkOutList.Count} misafir";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check-out listesi yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPerformCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTodayCheckIns.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen check-in yapılacak rezervasyonu seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvTodayCheckIns.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                var reservationRepo = new ReservationRepository();
                var selectedReservation = reservationRepo.GetById(reservationId);

                if (selectedReservation == null)
                {
                    MessageBox.Show("Rezervasyon bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var checkInForm = new FrmCheckInGuestManagement(selectedReservation);
                var result = checkInForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadTodayCheckIns(); // Listeyi yenile
                    MessageBox.Show("Check-in işlemi tamamlandı!", "Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshCheckIn_Click(object sender, EventArgs e)
        {
            LoadTodayCheckIns();
            LoadTodayCheckOuts();
            lblCheckOutCount.Text = $"📤 Bugün çıkış yapacak: {dgvTodayCheckOuts.Rows.Count} misafir";

            MessageBox.Show("Listeler yenilendi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPerformCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTodayCheckOuts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen check-out yapılacak rezervasyonu seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvTodayCheckOuts.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                var reservationRepo = new ReservationRepository();
                var selectedReservation = reservationRepo.GetById(reservationId);

                if (selectedReservation == null)
                {
                    MessageBox.Show("Rezervasyon bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check-out onayı
                var result = MessageBox.Show($"Check-out işlemini onaylıyor musunuz?\n\n" +
                    $"Müşteri: {selectedReservation.Customer?.FullName}\n" +
                    $"Oda: {selectedReservation.Room?.RoomNumber}\n" +
                    $"Giriş: {selectedReservation.CheckInDate:dd.MM.yyyy}\n" +
                    $"Çıkış: {selectedReservation.CheckOutDate:dd.MM.yyyy}",
                    "Check-Out Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PerformCheckOut(selectedReservation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check-out işlemi sırasında hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PerformCheckOut(Reservations reservation)
        {
            try
            {
                using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            // 1. Rezervasyon durumunu güncelle
                            var dbReservation = context.Reservations.Find(reservation.ReservationID);
                            if (dbReservation != null)
                            {
                                dbReservation.Status = "Check-out";
                                context.SaveChanges();
                            }

                            // 2. Oda durumunu güncelle
                            var room = context.Rooms.Find(reservation.RoomID);
                            if (room != null)
                            {
                                room.Status = "Temizlikte"; // Önce temizliğe gider
                                context.SaveChanges();
                            }

                            // 3. Log kaydı
                            GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                                GunesMotel.Common.CurrentUser.UserID,
                                "Check-out",
                                "Tamamlandı",
                                $"Rezervasyon {reservation.ReservationID} için check-out tamamlandı. " +
                                $"Oda: {reservation.Room?.RoomNumber}"
                            );

                            transaction.Commit();

                            MessageBox.Show("Check-out işlemi başarıyla tamamlandı!\n\n" +
                                "Oda 'Temizlikte' durumuna alındı.", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Listeleri yenile
                            LoadTodayCheckIns();
                            LoadTodayCheckOuts();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception($"Check-out işlemi sırasında hata: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check-out işlemi başarıyla tamamlanamadı: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLateCheckOuts_Click(object sender, EventArgs e)
        {
            try
            {
                var repo = new ReservationRepository();
                var today = DateTime.Today;

                // Bugünden önce çıkış yapması gereken ama hala "Check-in" durumunda olanlar
                var lateCheckOuts = repo.GetAll()
                    .Where(r => r.CheckOutDate.Date < today && r.Status == "Check-in")
                    .Select(r => new
                    {
                        r.ReservationID,
                        Customer = r.Customer.FullName,
                        Room = r.Room.RoomNumber,
                        r.CheckInDate,
                        r.CheckOutDate,
                        Gecikme_Gun = (today - r.CheckOutDate.Date).Days,
                        r.Status
                    })
                    .OrderByDescending(x => x.Gecikme_Gun)
                    .ToList();

                if (lateCheckOuts.Count == 0)
                {
                    MessageBox.Show("Geç kalan check-out bulunmamaktadır.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Check-out sekmesinde geç kalanları göster
                dgvTodayCheckOuts.DataSource = lateCheckOuts;

                // Sekmeyi değiştir
                tabMain.SelectedTab = tabTodayCheckOut;

                // Başlığı güncelle
                lblCheckOutCount.Text = $"⚠️ Geç Kalan Check-Out: {lateCheckOuts.Count} misafir";

                MessageBox.Show($"{lateCheckOuts.Count} geç kalan check-out bulundu.\n\n" +
                    "Check-out sekmesinde gösteriliyor.", "Geç Kalanlar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Geç kalanlar yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshGuests_Click(object sender, EventArgs e)
        {
            LoadCurrentGuests();
            MessageBox.Show("Mevcut misafirler listesi yenilendi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEarlyCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCurrentGuests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen erken check-out yapılacak rezervasyonu seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvCurrentGuests.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                var reservationRepo = new ReservationRepository();
                var selectedReservation = reservationRepo.GetById(reservationId);

                if (selectedReservation == null)
                {
                    MessageBox.Show("Rezervasyon bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show($"Erken check-out işlemini onaylıyor musunuz?\n\n" +
                    $"Müşteri: {selectedReservation.Customer?.FullName}\n" +
                    $"Oda: {selectedReservation.Room?.RoomNumber}\n" +
                    $"Planlanan Çıkış: {selectedReservation.CheckOutDate:dd.MM.yyyy}\n" +
                    $"Erken Çıkış: {DateTime.Today:dd.MM.yyyy}",
                    "Erken Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PerformCheckOut(selectedReservation);
                    LoadCurrentGuests(); // Listeyi yenile
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erken check-out işlemi sırasında hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExtendStay_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCurrentGuests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen konaklama süresi uzatılacak rezervasyonu seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvCurrentGuests.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                var reservationRepo = new ReservationRepository();
                var selectedReservation = reservationRepo.GetById(reservationId);

                if (selectedReservation == null)
                {
                    MessageBox.Show("Rezervasyon bulunamadı.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Basit input dialog oluştur
                string input = ShowInputDialog($"Konaklama kaç gün uzatılsın?\n\n" +
                    $"Mevcut Çıkış Tarihi: {selectedReservation.CheckOutDate:dd.MM.yyyy}",
                    "Konaklama Uzat");

                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int extraDays) && extraDays > 0)
                {
                    using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
                    {
                        var dbReservation = context.Reservations.Find(selectedReservation.ReservationID);
                        if (dbReservation != null)
                        {
                            var newCheckOutDate = dbReservation.CheckOutDate.AddDays(extraDays);
                            dbReservation.CheckOutDate = newCheckOutDate;
                            context.SaveChanges();

                            MessageBox.Show($"Konaklama süresi başarıyla uzatıldı!\n\n" +
                                $"Yeni Çıkış Tarihi: {newCheckOutDate:dd.MM.yyyy}",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadCurrentGuests(); // Listeyi yenile
                        }
                    }
                }
                else if (!string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Geçerli bir gün sayısı giriniz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Konaklama uzatma işlemi sırasında hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ShowInputDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 350, Height = 40, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 70, Width = 200, Text = "1" };
            Button confirmation = new Button() { Text = "Tamam", Left = 230, Width = 70, Top = 68, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "İptal", Left = 310, Width = 50, Top = 68, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
