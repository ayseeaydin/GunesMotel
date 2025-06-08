using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using GunesMotel.Common;
using GunesMotel.DataAccess.Helpers;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class RoomManagementControl : UserControl
    {
        private readonly RoomTypeRepository _roomTypeRepo;
        private readonly RoomRepository _roomRepo;
        private List<dynamic> _roomList;
        private int? SelectedRoomID = null;
        private GunesMotelContext _context;
        private RoomPriceRepository _roomPriceRepo;
        private List<dynamic> _roomPriceList;
        private int? selectedPriceID = null;
        public RoomManagementControl()
        {
            InitializeComponent();

            _roomRepo = new RoomRepository();
            _roomTypeRepo = new RoomTypeRepository();

            dgvRooms.AutoGenerateColumns = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            LoadRoomTypes();
            LoadRooms();
            ClearForm();
            LoadRoomTypeTab();

            _context = new GunesMotelContext();
            _roomPriceRepo = new RoomPriceRepository(_context);

            LoadPrices();
            LoadPriceRooms();
            LoadSeasons();

        }

        private void LoadRoomTypeTab()
        {
            var control = new RoomTypeManagementControl();
            control.Dock = DockStyle.Fill;
            tabRoomTypes.Controls.Add(control);
        }

        private void LoadRoomTypes()
        {
            try
            {
                var types = _roomTypeRepo.GetAll();
                cmbRoomType.DataSource = types;
                cmbRoomType.DisplayMember = "TypeName";       // Gösterilen metin
                cmbRoomType.ValueMember = "RoomTypeID";       // Seçilen ID
                cmbRoomType.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda türleri yüklenirken hata:\n" + ex.Message);
            }
        }
        
        private void LoadRooms()
        {
            try
            {
                _roomList = _roomRepo.GetAllWithRoomType(); // 🔴 BU SATIR OLMALI
                dgvRooms.DataSource = null;
                dgvRooms.DataSource = _roomList;
                dgvRooms.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar yüklenirken bir hata oluştu:\n" + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtRoomNumber.Text = "Oda Numarası";
            txtRoomNumber.ForeColor = Color.Gray;

            txtFloor.Text = "Kat";
            txtFloor.ForeColor = Color.Gray;

            txtDescription.Text = "Açıklama";
            txtDescription.ForeColor = Color.Gray;

            cmbRoomType.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            dgvRooms.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasyonlar
                if (string.IsNullOrWhiteSpace(txtRoomNumber.Text) || txtRoomNumber.Text == "Oda Numarası")
                {
                    MessageBox.Show("Lütfen oda numarasını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbRoomType.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen oda türünü seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFloor.Text) || txtFloor.Text == "Kat" || !int.TryParse(txtFloor.Text, out int floor))
                {
                    MessageBox.Show("Geçerli bir kat değeri giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen oda durumunu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Oda nesnesi oluştur
                var room = new Rooms
                {
                    RoomNumber = txtRoomNumber.Text.Trim(),
                    RoomTypeID = Convert.ToInt32(cmbRoomType.SelectedValue),
                    Floor = floor,
                    Status = cmbStatus.SelectedItem.ToString(),
                    Description = txtDescription.Text != "Açıklama" ? txtDescription.Text.Trim() : null
                };

                _roomRepo.Add(room);

                // Log kaydı (varsa)
                GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                    GunesMotel.Common.CurrentUser.UserID,
                    "Odalar",
                    "Ekle",
                    $"Yeni oda eklendi: {room.RoomNumber}"
                );

                MessageBox.Show("Oda başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda eklenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRooms.SelectedRows.Count>0)
            {
                var row = dgvRooms.SelectedRows[0];

                // ID’yi al
                SelectedRoomID = Convert.ToInt32(row.Cells["colRoomID"].Value);

                // Formu doldur
                txtRoomNumber.Text = row.Cells["colRoomNumber"].Value?.ToString();
                txtFloor.Text = row.Cells["colFloor"].Value?.ToString();
                cmbRoomType.Text = row.Cells["colRoomTypeName"].Value?.ToString();
                cmbStatus.Text = row.Cells["colStatus"].Value?.ToString();
                txtDescription.Text = row.Cells["colDescription"].Value?.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void dgvRooms_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRooms.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedRoomID == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir oda seçiniz.");
                return;
            }

            try
            {
                var room = new Rooms
                {
                    RoomID = SelectedRoomID.Value,
                    RoomNumber = txtRoomNumber.Text.Trim(),
                    RoomTypeID = Convert.ToInt32(cmbRoomType.SelectedValue),
                    Floor = int.Parse(txtFloor.Text),
                    Status = cmbStatus.SelectedItem?.ToString(),
                    Description = txtDescription.Text != "Açıklama" ? txtDescription.Text.Trim() : null
                };

                _roomRepo.Update(room);

                GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                    GunesMotel.Common.CurrentUser.UserID,
                    "Odalar",
                    "Güncelle",
                    $"Oda güncellendi: {room.RoomNumber} (ID: {room.RoomID})"
                );

                MessageBox.Show("Oda başarıyla güncellendi.");
                ClearForm();
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata:\n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRoomID == null)
            {
                MessageBox.Show("Lütfen silinecek bir oda seçiniz.");
                return;
            }

            var result = MessageBox.Show("Bu odayı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes)
                return;

            try
            {
                _roomRepo.Delete(SelectedRoomID.Value);

                GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                    GunesMotel.Common.CurrentUser.UserID,
                    "Odalar",
                    "Sil",
                    $"Oda silindi. ID: {SelectedRoomID}"
                );

                MessageBox.Show("Oda başarıyla silindi.");
                ClearForm();
                LoadRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme sırasında hata:\n" + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_roomList == null) return;

            string searchText = txtSearch.Text.Trim().ToLower();

            var filteredList = _roomList
                .Where(r =>
                    (!string.IsNullOrEmpty(r.RoomNumber) && r.RoomNumber.ToLower().Contains(searchText)) ||
                    (!string.IsNullOrEmpty(r.Status) && r.Status.ToLower().Contains(searchText)) ||
                    (!string.IsNullOrEmpty(r.Description) && r.Description.ToLower().Contains(searchText)) ||
                    (r.RoomType != null &&
                        (
                            (!string.IsNullOrEmpty(r.RoomType.TypeName) && r.RoomType.TypeName.ToLower().Contains(searchText)) ||
                            (!string.IsNullOrEmpty(r.RoomType.Feature) && r.RoomType.Feature.ToLower().Contains(searchText))
                        )
                    )
                )
                .ToList();

            dgvRooms.DataSource = null;
            dgvRooms.DataSource = filteredList;
            dgvRooms.ClearSelection();
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if(txtPrice.Text== "Fiyat (€)")
            {
                txtPrice.Text = "";
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                txtPrice.Text = "Fiyat (€)";
                txtPrice.ForeColor = Color.Gray;
            }
        }

        private void txtPriceSearch_Enter(object sender, EventArgs e)
        {
            if( txtPriceSearch.Text== "Ara (Oda No, Sezon)")
            {
                txtPriceSearch.Text = "";
                txtPriceSearch.ForeColor = Color.Black;
            }
        }

        private void txtPriceSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPriceSearch.Text))
            {
                txtPriceSearch.Text = "Ara (Oda No, Sezon)";
                txtPriceSearch.ForeColor = Color.Gray;
            }
        }

        private void txtRoomNumber_Enter(object sender, EventArgs e)
        {
            if(txtRoomNumber.Text == "Oda Numarası")
            {
                txtRoomNumber.Text = "";
                txtRoomNumber.ForeColor = Color.Black;
            }

        }

        private void txtRoomNumber_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRoomNumber.Text))
            {
                txtRoomNumber.Text = "Oda Numarası";
                txtRoomNumber.ForeColor = Color.Gray;
            }
        }

        private void txtFloor_Enter(object sender, EventArgs e)
        {
            if (txtFloor.Text == "Kat")
            {
                txtFloor.Text = "";
                txtFloor.ForeColor = Color.Black;
            }
        }

        private void txtFloor_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtFloor.Text))
            {
                txtFloor.Text = "Kat";
                txtFloor.ForeColor = Color.Gray;
            }
        }

        private void txtDescription_Enter(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Açıklama")
            {
                txtDescription.Text = "";
                txtDescription.ForeColor = Color.Black;
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDescription.Text))
            {
                txtDescription.Text = "Açıklama";
                txtDescription.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Ara (Oda No, Durum, Açıklama, Oda Türü)")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Ara (Oda No, Durum, Açıklama, Oda Türü)";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void LoadPrices()
        {
            try
            {
                var prices = _roomPriceRepo.GetAll();
                _roomPriceList = prices.Select(p => new
                {
                    RoomPriceID = p.RoomPriceID,
                    RoomNumber = p.Room.RoomNumber,
                    RoomType = p.Room.RoomType.TypeName,
                    SeasonName = p.Season.SeasonName,
                    Price = p.Price,
                    LastUpdated = p.LastUpdated.ToString("dd.MM.yyyy HH:mm")
                }).ToList<dynamic>();

                dgvPrices.DataSource = null;
                dgvPrices.DataSource = _roomPriceList;
                dgvPrices.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyatlar yüklenirken hata:\n" + ex.Message);
            }
        }

        private void LoadPriceRooms()
        {
            var rooms = _roomRepo.GetAll(); // Direkt Rooms listesi
            cmbPriceRoom.DataSource = rooms;
            cmbPriceRoom.DisplayMember = "RoomNumber";
            cmbPriceRoom.ValueMember = "RoomID";
            cmbPriceRoom.SelectedIndex = -1;
        }

        private void LoadSeasons()
        {
            var seasons = _context.Seasons.ToList();
            cmbSeason.DataSource = seasons;
            cmbSeason.DisplayMember = "SeasonName";
            cmbSeason.ValueMember = "SeasonID";
            cmbSeason.SelectedIndex = -1;
        }


        private void ClearPriceForm()
        {
            cmbPriceRoom.SelectedIndex = -1;
            cmbSeason.SelectedIndex = -1;
            txtPrice.Text = "Fiyat (€)";
            txtPrice.ForeColor = Color.Gray;
        }

        private void btnPriceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasyon
                if (cmbPriceRoom.SelectedItem == null || cmbSeason.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen oda ve sezon seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrice.Text) || !decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Lütfen geçerli bir fiyat giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRoom = (Rooms)cmbPriceRoom.SelectedItem;
                var selectedSeason = (Seasons)cmbSeason.SelectedItem;

                var roomPrice = new RoomPrices
                {
                    RoomID = selectedRoom.RoomID,
                    SeasonID = selectedSeason.SeasonID,
                    Price = price,
                    LastUpdated = DateTime.Now
                };

                _roomPriceRepo.Add(roomPrice);

                GunesMotel.DataAccess.Helpers.LogHelper.AddLog(
                    GunesMotel.Common.CurrentUser.UserID,
                    "Fiyat Yönetimi",
                    "Ekleme",
                    $"Oda: {selectedRoom.RoomNumber}, Sezon: {selectedSeason.SeasonName}, Fiyat: {price} eklendi."
                );

                MessageBox.Show("Fiyat başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPrices();
                ClearPriceForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyat eklenirken hata:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPrices.SelectedRows.Count > 0)
            {
                var row = dgvPrices.SelectedRows[0];

                selectedPriceID = Convert.ToInt32(row.Cells["colPriceID"].Value);

                cmbPriceRoom.Text = row.Cells["colPriceRoomNumber"].Value?.ToString();
                cmbSeason.Text = row.Cells["colSeasonName"].Value?.ToString();
                txtPrice.Text = row.Cells["colPrice"].Value?.ToString();
                txtPrice.ForeColor = Color.Black;
            }
        }

        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPriceID == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir fiyat seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (cmbPriceRoom.SelectedItem == null || cmbSeason.SelectedItem == null || string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal parsedPrice))
                {
                    MessageBox.Show("Geçerli bir fiyat girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Güncellenecek fiyatı bul
                var existingPrice = _roomPriceRepo.GetById(selectedPriceID.Value);
                if (existingPrice == null)
                {
                    MessageBox.Show("Fiyat bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Güncellemeleri yap
                existingPrice.RoomID = ((Rooms)cmbPriceRoom.SelectedItem).RoomID;
                existingPrice.SeasonID = ((Seasons)cmbSeason.SelectedItem).SeasonID;
                existingPrice.Price = parsedPrice;

                _roomPriceRepo.Update(existingPrice);

                LogHelper.AddLog(CurrentUser.UserID, "Fiyat Yönetimi", "Güncelleme", $"Fiyat güncellendi. ID: {existingPrice.RoomPriceID}");

                MessageBox.Show("Fiyat başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrices();
                ClearPriceForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyat güncellenirken hata:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPriceDelete_Click(object sender, EventArgs e)
        {
            if (selectedPriceID == null)
            {
                MessageBox.Show("Lütfen silinecek bir fiyat seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show("Seçili fiyatı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes)
                return;

            try
            {
                var priceToDelete = _roomPriceRepo.GetById(selectedPriceID.Value);
                if (priceToDelete == null)
                {
                    MessageBox.Show("Silinecek fiyat bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _roomPriceRepo.Delete(priceToDelete);

                LogHelper.AddLog(CurrentUser.UserID, "Fiyat Yönetimi", "Silme", $"Fiyat silindi. ID: {priceToDelete.RoomPriceID}");

                MessageBox.Show("Fiyat başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPrices();
                ClearPriceForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyat silinirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPriceRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPrices();         // Fiyat listesini güncelle
                ClearPriceForm();     // Form alanlarını temizle

                LogHelper.AddLog(CurrentUser.UserID, "Fiyat Yönetimi", "Yenileme", "Fiyat listesi yenilendi.");
                MessageBox.Show("Fiyat listesi yenilendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyatlar yenilenirken hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPriceSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtPriceSearch.Text.Trim().ToLower();
                var allPrices = _roomPriceRepo.GetAll();  // Tüm fiyatları getir

                var filteredList = allPrices
                    .Where(p =>
                        (p.Room != null && p.Room.RoomNumber.ToLower().Contains(searchText)) ||
                        (p.Room != null && p.Room.RoomType != null && p.Room.RoomType.TypeName.ToLower().Contains(searchText)) ||
                        (p.Season != null && p.Season.SeasonName.ToLower().Contains(searchText)) ||
                        p.Price.ToString().Contains(searchText) ||
                        p.LastUpdated.ToString("dd.MM.yyyy").Contains(searchText)
                    )
                    .Select(p => new
                    {
                        p.RoomPriceID,
                        RoomNumber = p.Room?.RoomNumber ?? "Bilinmiyor",
                        RoomType = p.Room?.RoomType?.TypeName ?? "Bilinmiyor",
                        SeasonName = p.Season?.SeasonName ?? "Bilinmiyor",
                        Price = p.Price,
                        LastUpdated = p.LastUpdated
                    })
                    .ToList();

                dgvPrices.DataSource = filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
