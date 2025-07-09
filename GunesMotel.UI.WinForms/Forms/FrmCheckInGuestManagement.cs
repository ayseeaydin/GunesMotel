using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GunesMotel.Entities;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Helpers;
using GunesMotel.Common;

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
        }

        private void FrmCheckInGuestManagement_Load(object sender, EventArgs e)
        {
            ShowReservationInfo();
            InitializeSearchBox();
            LoadAllCustomers();
            LoadReservationGuests();
        }

        private void ShowReservationInfo()
        {
            lblReservationID.Text = $"Rezervasyon No: {_selectedReservation.ReservationID}";
            lblRoomNumber.Text = $"Oda No: {_selectedReservation.Room?.RoomNumber ?? "N/A"}";
            lblCheckInDate.Text = $"Giriş Tarihi: {_selectedReservation.CheckInDate:dd.MM.yyyy}";
            lblCheckOutDate.Text = $"Çıkış Tarihi: {_selectedReservation.CheckOutDate:dd.MM.yyyy}";
            lblTotalGuests.Text = $"Misafir Sayısı: {_selectedReservation.GuestCount}";
        }

        private void InitializeSearchBox()
        {
            txtCustomerSearch.Text = "Ad, soyad veya TC ile arayın...";
            txtCustomerSearch.ForeColor = System.Drawing.Color.Gray;
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

        private void LoadReservationGuests()
        {
            try
            {
                using (var context = new GunesMotelContext())
                {
                    // Mevcut rezervasyon misafirlerini getir
                    var existingGuests = context.ReservationGuests
                        .Where(rg => rg.ReservationID == _selectedReservation.ReservationID)
                        .ToList();

                    _reservationGuests.Clear();
                    foreach (var guest in existingGuests)
                    {
                        var customer = context.Customers.Find(guest.CustomerID);
                        if (customer != null)
                        {
                            _reservationGuests.Add(customer);
                        }
                    }

                    RefreshReservationGuestsGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Rezervasyon misafirleri yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshReservationGuestsGrid()
        {
            dgvReservationGuests.DataSource = _reservationGuests.Select((c, index) => new
            {
                Sıra = index + 1,
                c.CustomerID,
                Ad_Soyad = c.FullName,
                TC_Pasaport = !string.IsNullOrEmpty(c.NationalID) ? c.NationalID : c.PassportNo,
                Ana_Müşteri = c.CustomerID == _selectedReservation.CustomerID ? "✓" : ""
            }).ToList();

            // CustomerID sütununu gizle
            if (dgvReservationGuests.Columns["CustomerID"] != null)
                dgvReservationGuests.Columns["CustomerID"].Visible = false;

            // Başlığı güncelle
            lblReservationGuestsTitle.Text = $"🛏 Rezervasyon Misafirleri ({_reservationGuests.Count}/{_selectedReservation.GuestCount})";
        }


        #region Event Handlers
        private void txtCustomerSearch_Enter(object sender, EventArgs e)
        {
            if (txtCustomerSearch.Text == "Ad, soyad veya TC ile arayın...")
            {
                txtCustomerSearch.Text = "";
                txtCustomerSearch.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtCustomerSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerSearch.Text))
            {
                txtCustomerSearch.Text = "Ad, soyad veya TC ile arayın...";
                txtCustomerSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtCustomerSearch.Text.Trim();
                if (string.IsNullOrEmpty(searchText) || searchText == "Ad, soyad veya TC ile arayın...")
                {
                    LoadAllCustomers();
                    return;
                }

                var filteredCustomers = _allCustomers.Where(c =>
                    (c.FullName?.ToLower().Contains(searchText.ToLower()) == true) ||
                    (c.NationalID?.Contains(searchText) == true) ||
                    (c.PassportNo?.ToLower().Contains(searchText.ToLower()) == true)
                ).ToList();

                dgvExistingCustomers.DataSource = filteredCustomers.Select(c => new
                {
                    c.CustomerID,
                    Ad_Soyad = c.FullName,
                    TC_Pasaport = !string.IsNullOrEmpty(c.NationalID) ? c.NationalID : c.PassportNo,
                    Telefon = c.Phone,
                    Email = c.Email
                }).ToList();

                if (dgvExistingCustomers.Columns["CustomerID"] != null)
                    dgvExistingCustomers.Columns["CustomerID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExistingCustomers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvExistingCustomers.SelectedRows.Count > 0)
                {
                    var selectedRow = dgvExistingCustomers.SelectedRows[0];
                    int customerId = Convert.ToInt32(selectedRow.Cells["CustomerID"].Value);

                    var selectedCustomer = _allCustomers.FirstOrDefault(c => c.CustomerID == customerId);
                    if (selectedCustomer != null)
                    {
                        // Form alanlarını doldur
                        txtFullName.Text = selectedCustomer.FullName ?? "";
                        txtNationalID.Text = selectedCustomer.NationalID ?? "";
                        txtPassportNo.Text = selectedCustomer.PassportNo ?? "";
                        txtPhone.Text = selectedCustomer.Phone ?? "";
                        txtEmail.Text = selectedCustomer.Email ?? "";
                        txtAddress.Text = selectedCustomer.Address ?? "";

                        if (selectedCustomer.BirthDate.HasValue)
                            dtpBirthDate.Value = selectedCustomer.BirthDate.Value;

                        if (!string.IsNullOrEmpty(selectedCustomer.Gender))
                            cmbGender.SelectedItem = selectedCustomer.Gender;

                        rbExistingCustomer.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri seçimi sırasında hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtFullName.Clear();
            txtNationalID.Clear();
            txtPassportNo.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            dtpBirthDate.Value = new DateTime(1990, 1, 1);
            cmbGender.SelectedIndex = -1;
            rbNewCustomer.Checked = true;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            try
            {
                // Misafir sayısı kontrolü
                if (_reservationGuests.Count >= _selectedReservation.GuestCount)
                {
                    MessageBox.Show($"En fazla {_selectedReservation.GuestCount} misafir ekleyebilirsiniz.",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Form validation
                if (!ValidateGuestForm())
                {
                    return;
                }

                Customers customer = null;

                if (rbExistingCustomer.Checked)
                {
                    // Mevcut müşteri seçimi
                    if (dgvExistingCustomers.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Lütfen mevcut müşterilerden birini seçin.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int customerId = Convert.ToInt32(dgvExistingCustomers.SelectedRows[0].Cells["CustomerID"].Value);
                    customer = _allCustomers.FirstOrDefault(c => c.CustomerID == customerId);

                    // Müşteri zaten eklendi mi kontrol et
                    if (_reservationGuests.Any(g => g.CustomerID == customerId))
                    {
                        MessageBox.Show("Bu müşteri zaten rezervasyona eklenmiş.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    // Yeni müşteri oluştur
                    customer = CreateNewCustomer();
                    if (customer == null) return;
                }

                // Misafiri rezervasyona ekle
                _reservationGuests.Add(customer);
                RefreshReservationGuestsGrid();
                ClearForm();

                MessageBox.Show("Misafir başarıyla eklendi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Misafir eklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservationGuests.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen kaldırılacak misafiri seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int customerId = Convert.ToInt32(dgvReservationGuests.SelectedRows[0].Cells["CustomerID"].Value);

                var result = MessageBox.Show("Seçili misafiri kaldırmak istediğinizden emin misiniz?",
                    "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var guestToRemove = _reservationGuests.FirstOrDefault(g => g.CustomerID == customerId);
                    if (guestToRemove != null)
                    {
                        _reservationGuests.Remove(guestToRemove);
                        RefreshReservationGuestsGrid();
                        MessageBox.Show("Misafir kaldırıldı.", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Misafir kaldırılırken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Minimum 1 misafir kontrolü
                if (_reservationGuests.Count == 0)
                {
                    MessageBox.Show("En az bir misafir eklemelisiniz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show($"Check-in işlemini tamamlamak istediğinizden emin misiniz?\n\n" +
                    $"Rezervasyon: {_selectedReservation.ReservationID}\n" +
                    $"Oda: {_selectedReservation.Room?.RoomNumber}\n" +
                    $"Misafir Sayısı: {_reservationGuests.Count}",
                    "Check-in Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    CompleteCheckInProcess();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check-in tamamlanırken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Check-in işlemini iptal etmek istediğinizden emin misiniz?",
                "İptal Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
        private void rbExistingCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExistingCustomer.Checked)
            {
                ClearForm();
                dgvExistingCustomers.Enabled = true;

            }
            else
            {
                dgvExistingCustomers.ClearSelection();
                dgvExistingCustomers.Enabled = false;
            }
        }

        private void rbNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNewCustomer.Checked)
            {
                ClearForm();
            }
        }
        #endregion

        #region Helper Methods

        private bool ValidateGuestForm()
        {
            // TC veya Pasaport kontrolü
            if (string.IsNullOrWhiteSpace(txtNationalID.Text) && string.IsNullOrWhiteSpace(txtPassportNo.Text))
            {
                MessageBox.Show("TC Kimlik No veya Pasaport No girmelisiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Ad Soyad kontrolü
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Ad Soyad alanı boş olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return false;
            }

            // Telefon kontrolü
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Telefon alanı boş olamaz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            // TC Kimlik format kontrolü
            if (!string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                if (txtNationalID.Text.Length != 11 || !txtNationalID.Text.All(char.IsDigit))
                {
                    MessageBox.Show("TC Kimlik No 11 haneli olmalıdır.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNationalID.Focus();
                    return false;
                }

                // TC kimlik benzersizlik kontrolü (sadece yeni müşteri için)
                if (rbNewCustomer.Checked)
                {
                    if (_allCustomers.Any(c => c.NationalID == txtNationalID.Text))
                    {
                        MessageBox.Show("Bu TC Kimlik No ile kayıtlı müşteri bulunmaktadır.", "Uyarı",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return true;
        }

        private Customers CreateNewCustomer()
        {
            try
            {
                var newCustomer = new Customers
                {
                    FullName = txtFullName.Text.Trim(),
                    NationalID = string.IsNullOrWhiteSpace(txtNationalID.Text) ? null : txtNationalID.Text.Trim(),
                    PassportNo = string.IsNullOrWhiteSpace(txtPassportNo.Text) ? null : txtPassportNo.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                    Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim(),
                    Gender = cmbGender.SelectedItem?.ToString(),
                    BirthDate = dtpBirthDate.Value,
                    RegisterDate = DateTime.Now,
                    Notes = null
                };

                using (var context = new GunesMotelContext())
                {
                    context.Customers.Add(newCustomer);
                    context.SaveChanges();
                }

                // Listeyi güncelle
                _allCustomers.Add(newCustomer);
                LoadAllCustomers();

                return newCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yeni müşteri oluşturulurken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void CompleteCheckInProcess()
        {
            using (var context = new GunesMotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Rezervasyon durumunu güncelle
                        var reservation = context.Reservations.Find(_selectedReservation.ReservationID);
                        if (reservation != null)
                        {
                            reservation.Status = "Check-in";
                            context.SaveChanges();
                        }

                        // 2. Oda durumunu güncelle
                        var room = context.Rooms.Find(_selectedReservation.RoomID);
                        if (room != null)
                        {
                            room.Status = "Dolu";
                            context.SaveChanges();
                        }

                        // 3. Rezervasyon misafirlerini kaydet
                        // Önce mevcut misafirleri temizle
                        var existingGuests = context.ReservationGuests
                            .Where(rg => rg.ReservationID == _selectedReservation.ReservationID);
                        context.ReservationGuests.RemoveRange(existingGuests);

                        // Yeni misafirleri ekle
                        foreach (var guest in _reservationGuests)
                        {
                            var reservationGuest = new ReservationGuests
                            {
                                ReservationID = _selectedReservation.ReservationID,
                                CustomerID = guest.CustomerID
                            };
                            context.ReservationGuests.Add(reservationGuest);
                        }
                        context.SaveChanges();

                        // 4. Log kaydı
                        LogHelper.AddLog(CurrentUser.UserID, "Check-in", "Tamamlandı",
                            $"Rezervasyon {_selectedReservation.ReservationID} için check-in tamamlandı. " +
                            $"Oda: {_selectedReservation.Room?.RoomNumber}, Misafir Sayısı: {_reservationGuests.Count}");

                        transaction.Commit();

                        MessageBox.Show("Check-in işlemi başarıyla tamamlandı!", "Başarılı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception($"Check-in işlemi sırasında hata: {ex.Message}");
                    }
                }
            }
        }

        #endregion


    }
}
