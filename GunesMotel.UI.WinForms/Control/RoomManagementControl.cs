using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class RoomManagementControl : UserControl
    {
        private readonly RoomTypeRepository _roomTypeRepo;
        private readonly RoomRepository _roomRepo;
        private List<dynamic> _roomList;
        private int? SelectedRoomID = null;

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
    }
}
