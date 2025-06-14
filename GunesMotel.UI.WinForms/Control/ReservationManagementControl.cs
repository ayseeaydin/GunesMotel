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
                    r.CustomerID,
                    r.RoomID,
                    r.UserID,
                    CustomerName = r.Customer?.FullName,
                    RoomNumber = r.Room?.RoomNumber,
                    Username = r.User?.Username,
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
            LoadCustomers();
            LoadRooms();
            LoadStatuses();
            LoadSources();
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

        private void LoadCustomers()
        {
            var customerRepo = new CustomerRepository();
            var customers = customerRepo.GetAll();

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            var roomRepo = new RoomRepository();
            var rooms = roomRepo.GetAll();

            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomNumber"; // veya RoomName
            cmbRoom.ValueMember = "RoomID";
            cmbRoom.SelectedIndex = -1;
        }
        private void LoadStatuses()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[]
            {
        "Beklemede", "Onaylandı", "Check-in", "Check-out", "İptal"
            });
            cmbStatus.SelectedIndex = -1;
        }
        private void LoadSources()
        {
            cmbSource.Items.Clear();
            cmbSource.Items.AddRange(new string[]
            {
        "Website", "Telefon", "Email", "Booking.com", "Expedia", "Hotels.com", "Tripadvisor", "Walk-in", "Diğer"
            });
            cmbSource.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Zorunlu alanlar kontrolü
                if (cmbCustomer.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbRoom.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen bir durum seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check-in tarihi Check-out tarihinden büyük olamaz
                if (dtpCheckInDate.Value.Date >= dtpCheckOutDate.Value.Date)
                {
                    MessageBox.Show("Giriş tarihi, çıkış tarihinden önce olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 📌 Rezervasyon oluşturuluyor
                var newReservation = new Reservations
                {
                    CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue),
                    RoomID = Convert.ToInt32(cmbRoom.SelectedValue),
                    UserID = CurrentUser.UserID, // giriş yapan kullanıcı
                    CheckInDate = dtpCheckInDate.Value.Date,
                    CheckOutDate = dtpCheckOutDate.Value.Date,
                    ReservationDate = dtpReservationDate.Value.Date,
                    Source = cmbSource.SelectedItem?.ToString(),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    GuestCount = (int)nudGuestCount.Value,
                    Notes = txtNotes.Text?.Trim()
                };

                var repo = new ReservationRepository();
                repo.Add(newReservation);

                MessageBox.Show("Rezervasyon başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations(); // DataGridView yenile
                ClearForm();        // Formu temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon kaydında hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservations.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Güncellenecek rezervasyonu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvReservations.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                var updated = new Reservations
                {
                    ReservationID = reservationId,
                    CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue),
                    RoomID = Convert.ToInt32(cmbRoom.SelectedValue),
                    UserID = CurrentUser.UserID, // Oturumdaki kullanıcıdan alınıyor
                    CheckInDate = dtpCheckInDate.Value,
                    CheckOutDate = dtpCheckOutDate.Value,
                    ReservationDate = dtpReservationDate.Value,
                    Source = cmbSource.SelectedItem?.ToString(),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    GuestCount = (int)nudGuestCount.Value,
                    Notes = txtNotes.Text.Trim()
                };

                var repo = new ReservationRepository();
                repo.Update(updated);

                MessageBox.Show("Rezervasyon başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations(); // Yeniden listele
                ClearForm();        // Formu temizle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReservations_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0) return;

            var row = dgvReservations.SelectedRows[0];

            cmbCustomer.SelectedValue = Convert.ToInt32(row.Cells["CustomerID"].Value);
            cmbRoom.SelectedValue = Convert.ToInt32(row.Cells["RoomID"].Value);
            cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            cmbSource.SelectedItem = row.Cells["Source"].Value?.ToString();
            dtpCheckInDate.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
            dtpCheckOutDate.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);
            dtpReservationDate.Value = Convert.ToDateTime(row.Cells["ReservationDate"].Value);
            nudGuestCount.Value = Convert.ToInt32(row.Cells["GuestCount"].Value);
            txtNotes.Text = row.Cells["Notes"].Value?.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearForm(); // Formu temizle
            dgvReservations.ClearSelection(); // DataGridView seçimleri kaldır
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservations.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek için bir rezervasyon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvReservations.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                var confirmResult = MessageBox.Show("Seçilen rezervasyonu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    var repo = new ReservationRepository();
                    repo.Delete(reservationId);

                    MessageBox.Show("Rezervasyon başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReservations(); // Listeyi yenile
                    ClearForm();        // Formu temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim().ToLower();

                var repo = new ReservationRepository();
                var reservations = repo.GetAll();

                var filtered = reservations
                    .Where(r =>
                        string.IsNullOrEmpty(searchText) ||
                        (r.Customer != null && r.Customer.FullName.ToLower().Contains(searchText)) ||
                        (r.Room != null && r.Room.RoomNumber.ToString().Contains(searchText)) ||
                        (r.User != null && r.User.Username.ToLower().Contains(searchText)) ||
                        (!string.IsNullOrEmpty(r.Status) && r.Status.ToLower().Contains(searchText)) ||
                        (!string.IsNullOrEmpty(r.Source) && r.Source.ToLower().Contains(searchText)) ||
                        (!string.IsNullOrEmpty(r.Notes) && r.Notes.ToLower().Contains(searchText)) ||
                        r.ReservationDate.ToString("dd.MM.yyyy").Contains(searchText)
                    )
                    .Select(r => new
                    {
                        r.ReservationID,
                        r.CustomerID,
                        r.RoomID,
                        r.UserID,
                        CustomerName = r.Customer?.FullName,
                        RoomNumber = r.Room?.RoomNumber,
                        Username = r.User?.Username,
                        r.CheckInDate,
                        r.CheckOutDate,
                        r.ReservationDate,
                        r.Status,
                        r.Source,
                        r.GuestCount,
                        r.Notes
                    }).ToList();

                dgvReservations.DataSource = filtered;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedDateType = cmbDateType.SelectedItem?.ToString();
                DateTime start = dtpStartDate.Value.Date;
                DateTime end = dtpEndDate.Value.Date;

                var repo = new ReservationRepository();
                var reservations = repo.GetAll();

                var filtered = reservations.Where(r =>
                {
                    DateTime dateToCheck = r.ReservationDate;

                    if (selectedDateType == "Giriş Tarihi")
                        dateToCheck = r.CheckInDate;
                    else if (selectedDateType == "Çıkış Tarihi")
                        dateToCheck = r.CheckOutDate;

                    return dateToCheck >= start && dateToCheck <= end;
                })
                .Select(r => new
                {
                    r.ReservationID,
                    r.CustomerID,
                    r.RoomID,
                    r.UserID,
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
                })
                .ToList();

                dgvReservations.DataSource = filtered;

                dgvReservations.Columns["ReservationID"].Visible = false;
                dgvReservations.Columns["CustomerID"].Visible = false;
                dgvReservations.Columns["RoomID"].Visible = false;
                dgvReservations.Columns["UserID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih filtrelemesi sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadReservations();
            ClearForm();
            dgvReservations.ClearSelection();
        }
    }
}
