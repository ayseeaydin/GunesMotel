using GunesMotel.Common;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class ReservationManagementControl : UserControl
    {
        public ReservationManagementControl()
        {
            InitializeComponent();
        }

        private void LoadReservations()
        {
            try
            {
                var repo = new ReservationRepository();
                var reservationList = repo.GetAll();

                var displayList = reservationList.Select(r => new
                {
                    r.ReservationID,
                    Customer = r.Customer?.FullName,
                    Room = r.Room?.RoomNumber,
                    User = r.User?.Username,
                    r.CheckInDate,
                    r.CheckOutDate,
                    r.ReservationDate,
                    r.Status,
                    r.Source,
                    r.GuestCount,
                    r.Notes
                }).ToList();

                dgvReservations.DataSource = displayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyonlar yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReservationManagementControl_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void ClearForm()
        {
            cmbCustomer.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            dtpCheckInDate.Value = DateTime.Today;
            dtpCheckOutDate.Value = DateTime.Today.AddDays(1);
            cmbStatus.SelectedIndex = -1;
            nudGuestCount.Value = 1;
            cmbSource.SelectedIndex = -1;
            dtpReservationDate.Value = DateTime.Today;
            txtNotes.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasyon kontrolü
                if (cmbCustomer.SelectedItem == null || cmbRoom.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen müşteri ve oda seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpCheckInDate.Value.Date >= dtpCheckOutDate.Value.Date)
                {
                    MessageBox.Show("Giriş tarihi, çıkış tarihinden önce olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Seçilen CustomerID ve RoomID bilgilerini al
                var selectedCustomer = (Customers)cmbCustomer.SelectedItem;
                var selectedRoom = (Rooms)cmbRoom.SelectedItem;

                var newReservation = new Reservations
                {
                    CustomerID = selectedCustomer.CustomerID.ToString(), // CustomerID string tanımlanmıştı
                    RoomID = selectedRoom.RoomID,
                    UserID = CurrentUser.UserID, // Oturum açan kullanıcı
                    CheckInDate = dtpCheckInDate.Value.Date,
                    CheckOutDate = dtpCheckOutDate.Value.Date,
                    ReservationDate = dtpReservationDate.Value.Date,
                    Source = cmbSource.SelectedItem?.ToString(),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    GuestCount = (int)nudGuestCount.Value,
                    Notes = txtNotes.Text.Trim()
                };

                var repo = new ReservationRepository();
                repo.Add(newReservation);

                MessageBox.Show("Yeni rezervasyon başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations(); // Yeniden listele
                ClearForm(); // Formu temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon eklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
