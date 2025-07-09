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

        private void ReservationManagementControl_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadStatuses();
            LoadSources();
            LoadReservations();
            LoadEmptyRooms();
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
            dgvReservations.ClearSelection();
            LoadEmptyRooms();
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

        private void LoadReservations()
        {
            try
            {
                var repo = new ReservationRepository();
                var reservationList = repo.GetAll()
                    .OrderByDescending(r => r.ReservationID)
                    .ToList();

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

        private void LoadEmptyRooms()
        {
            var roomRepo = new RoomRepository();
            var reservationRepo = new ReservationRepository();

            DateTime checkIn = dtpCheckInDate.Value.Date;
            DateTime checkOut = dtpCheckOutDate.Value.Date;

            // Güncellenen rezervasyon varsa, o id hariç tutulacak
            int? currentReservationId = null;
            if (dgvReservations.SelectedRows.Count > 0)
            {
                currentReservationId = Convert.ToInt32(dgvReservations.SelectedRows[0].Cells["ReservationID"].Value);
            }

            var allRooms = roomRepo.GetAll();
            var reservations = reservationRepo.GetAll();

            var occupiedRoomIds = reservations
                .Where(r =>
                    r.Status != "İptal"
                    && (currentReservationId == null || r.ReservationID != currentReservationId)
                    && (
                        (checkIn >= r.CheckInDate && checkIn < r.CheckOutDate) ||
                        (checkOut > r.CheckInDate && checkOut <= r.CheckOutDate) ||
                        (checkIn <= r.CheckInDate && checkOut >= r.CheckOutDate)
                    )
                )
                .Select(r => r.RoomID)
                .Distinct()
                .ToList();

            var emptyRooms = allRooms
                .Where(room => !occupiedRoomIds.Contains(room.RoomID))
                .ToList();

            // Güncellemede, seçili oda dolu ise bile combobox'ta görünsün
            if (currentReservationId.HasValue)
            {
                var selectedRoomId = Convert.ToInt32(cmbRoom.SelectedValue ?? -1);
                if (selectedRoomId > 0 && !emptyRooms.Any(r => r.RoomID == selectedRoomId))
                {
                    var selectedRoom = allRooms.FirstOrDefault(r => r.RoomID == selectedRoomId);
                    if (selectedRoom != null)
                        emptyRooms.Add(selectedRoom);
                }
            }

            cmbRoom.DataSource = emptyRooms.OrderBy(r => r.RoomNumber).ToList();
            cmbRoom.DisplayMember = "RoomNumber";
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
                // Zorunlu alanlar
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
                if (dtpCheckInDate.Value.Date >= dtpCheckOutDate.Value.Date)
                {
                    MessageBox.Show("Giriş tarihi, çıkış tarihinden önce olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Her ihtimale karşı, yine kontrol edelim
                var roomId = Convert.ToInt32(cmbRoom.SelectedValue);
                var checkIn = dtpCheckInDate.Value.Date;
                var checkOut = dtpCheckOutDate.Value.Date;
                if (!IsRoomAvailable(roomId, checkIn, checkOut))
                {
                    MessageBox.Show("Bu oda seçilen tarihlerde zaten rezerve edilmiş. Lütfen başka bir oda veya tarih seçin.", "Oda Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadEmptyRooms();
                    return;
                }

                var newReservation = new Reservations
                {
                    CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue),
                    RoomID = roomId,
                    UserID = CurrentUser.UserID,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    ReservationDate = dtpReservationDate.Value.Date,
                    Source = cmbSource.SelectedItem?.ToString(),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    GuestCount = (int)nudGuestCount.Value,
                    Notes = txtNotes.Text?.Trim()
                };

                var repo = new ReservationRepository();
                repo.Add(newReservation);

                MessageBox.Show("Rezervasyon başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations();
                ClearForm();
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

                var roomId = Convert.ToInt32(cmbRoom.SelectedValue);
                var checkIn = dtpCheckInDate.Value.Date;
                var checkOut = dtpCheckOutDate.Value.Date;

                var selectedRow = dgvReservations.SelectedRows[0];
                int reservationId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);

                // Kendi rezervasyonunu hariç tut!
                if (!IsRoomAvailable(roomId, checkIn, checkOut, reservationId))
                {
                    MessageBox.Show("Bu oda seçilen tarihlerde zaten rezerve edilmiş. Lütfen başka bir oda veya tarih seçin.", "Oda Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadEmptyRooms();
                    return;
                }

                var updated = new Reservations
                {
                    ReservationID = reservationId,
                    CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue),
                    RoomID = roomId,
                    UserID = CurrentUser.UserID,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    ReservationDate = dtpReservationDate.Value.Date,
                    Source = cmbSource.SelectedItem?.ToString(),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    GuestCount = (int)nudGuestCount.Value,
                    Notes = txtNotes.Text?.Trim()
                };

                var repo = new ReservationRepository();
                repo.Update(updated);

                MessageBox.Show("Rezervasyon başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservations();
                ClearForm();
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

            // Güncelleme ekranında oda listesini güncelle
            LoadEmptyRooms();
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
                    LoadReservations();
                    ClearForm();
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Aranacak değeri giriniz...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Aranacak değeri giriniz...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void dtpCheckInDate_ValueChanged(object sender, EventArgs e)
        {
            LoadEmptyRooms(); 
        }

        private void dtpCheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            LoadEmptyRooms();
        }

        private bool IsRoomAvailable(int roomId, DateTime checkIn, DateTime checkOut, int? ignoreReservationId = null)
        {
            var repo = new ReservationRepository();
            var reservations = repo.GetAll();

            var overlapping = reservations
                .Where(r => r.RoomID == roomId && r.Status != "İptal"
                    && (ignoreReservationId == null || r.ReservationID != ignoreReservationId)
                    && (
                        (checkIn >= r.CheckInDate && checkIn < r.CheckOutDate) ||
                        (checkOut > r.CheckInDate && checkOut <= r.CheckOutDate) ||
                        (checkIn <= r.CheckInDate && checkOut >= r.CheckOutDate)
                    ))
                .Any();

            return !overlapping;
        }
    }
}
