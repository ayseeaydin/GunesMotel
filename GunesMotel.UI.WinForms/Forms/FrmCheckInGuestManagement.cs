using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GunesMotel.Entities;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.DataAccess.Contexts;

namespace GunesMotel.UI.WinForms.Forms
{
    public partial class FrmCheckInGuestManagement : Form
    {
        private Reservations _selectedReservation;
        private List<Customers> _allCustomers;
        private List<Customers> _reservationGuests;

        public FrmCheckInGuestManagement(Reservations selectedReservation)
        {
            InitializeComponent();
            _selectedReservation = selectedReservation;
            _allCustomers = new List<Customers>();
            _reservationGuests = new List<Customers>();

            // Event handler'ları bağla
            this.Load += FrmCheckInGuestManagement_Load;
            btnCancel.Click += BtnCancel_Click;
        }

        private void FrmCheckInGuestManagement_Load(object sender, EventArgs e)
        {
            try
            {
                // Rezervasyon bilgilerini göster
                lblReservationID.Text = $"Rezervasyon No: {_selectedReservation.ReservationID}";
                lblRoomNumber.Text = $"Oda No: {_selectedReservation.Room?.RoomNumber ?? "N/A"}";
                lblCheckInDate.Text = $"Giriş Tarihi: {_selectedReservation.CheckInDate:dd.MM.yyyy}";
                lblCheckOutDate.Text = $"Çıkış Tarihi: {_selectedReservation.CheckOutDate:dd.MM.yyyy}";
                lblTotalGuests.Text = $"Misafir Sayısı: {_selectedReservation.GuestCount}";

                // Müşteri listesini yükle
                LoadAllCustomers();

                MessageBox.Show("Form başarıyla yüklendi!", "Test",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllCustomers()
        {
            try
            {
                using (var context = new GunesMotelContext())
                {
                    _allCustomers = context.Customers.OrderBy(c => c.FullName).ToList();

                    dgvExistingCustomers.DataSource = _allCustomers.Select(c => new
                    {
                        c.CustomerID,
                        Ad_Soyad = c.FullName,
                        TC_Pasaport = !string.IsNullOrEmpty(c.NationalID) ? c.NationalID : c.PassportNo,
                        Telefon = c.Phone,
                        Email = c.Email
                    }).ToList();

                    // CustomerID sütununu gizle
                    if (dgvExistingCustomers.Columns["CustomerID"] != null)
                        dgvExistingCustomers.Columns["CustomerID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri listesi yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Formu kapatmak istediğinizden emin misiniz?",
                "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}
