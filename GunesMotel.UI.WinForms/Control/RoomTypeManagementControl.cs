using GunesMotel.Common;
using GunesMotel.DataAccess.Helpers;
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
    public partial class RoomTypeManagementControl : UserControl
    {
        private bool isFirstLoad = true;

        public RoomTypeManagementControl()
        {
            InitializeComponent();
        }

        private void LoadRoomTypes()
        {
            try
            {
                var roomTypeRepo = new RoomTypeRepository();
                var roomTypes = roomTypeRepo.GetAll();

                dgvRoomTypes.DataSource = roomTypes.Select(rt => new
                {
                    rt.RoomTypeID,
                    rt.TypeName,
                    rt.Feature,
                    rt.Description
                }).ToList();

                dgvRoomTypes.ClearSelection();
                dgvRoomTypes.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda türleri yüklenirken bir hata oluştu:\n\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(0, "Oda Türü Yönetimi", "Hata", "Oda türleri yüklenirken hata: " + ex.Message);
            }
        }
        private void RoomTypeManagementControl_Load(object sender, EventArgs e)
        {
            isFirstLoad = true;
            LoadRoomTypes();
            dgvRoomTypes.ClearSelection();
            dgvRoomTypes.CurrentCell = null;

        }

        private void dgvRoomTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (isFirstLoad)
            {
                dgvRoomTypes.ClearSelection();
                dgvRoomTypes.CurrentCell = null;
                isFirstLoad = false;
                return;
            }

            if (dgvRoomTypes.SelectedRows.Count == 0)
            {
                ClearForm();
                return;
            }

            var selectedRow = dgvRoomTypes.SelectedRows[0];
            txtTypeName.Text = selectedRow.Cells["TypeName"].Value?.ToString();
            txtFeature.Text = selectedRow.Cells["Feature"].Value?.ToString();
            txtDescription.Text = selectedRow.Cells["Description"].Value?.ToString();
        }

        private void ClearForm()
        {
            txtTypeName.Clear();
            txtFeature.Clear();
            txtDescription.Clear();
            dgvRoomTypes.ClearSelection();
            dgvRoomTypes.CurrentCell = null;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTypeName.Text))
                {
                    MessageBox.Show("Lütfen oda türü adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var typeName = txtTypeName.Text.Trim();
                var feature = txtFeature.Text.Trim();
                var description = txtDescription.Text.Trim();

                var repo = new RoomTypeRepository();

                if (repo.TypeNameExists(typeName))
                {
                    MessageBox.Show("Bu oda türü adı zaten mevcut!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newRoomType = new RoomTypes
                {
                    TypeName = typeName,
                    Feature = feature,
                    Description = description
                };

                repo.Add(newRoomType);
                LogHelper.AddLog(CurrentUser.UserID, "Oda Türü Yönetimi", "Ekleme", $"'{typeName}' türü eklendi.");

                LoadRoomTypes();
                ClearForm();

                MessageBox.Show("Oda türü başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? "İç hata yok";
                MessageBox.Show("Ekleme sırasında hata oluştu:\n" + ex.Message + "\n\n" + inner, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(0, "Oda Türü Yönetimi", "Hata", $"Ekleme hatası: {ex.Message} | {inner}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoomTypes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvRoomTypes.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["RoomTypeID"].Value);

                if (string.IsNullOrWhiteSpace(txtTypeName.Text))
                {
                    MessageBox.Show("Lütfen oda türü adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string typeName = txtTypeName.Text.Trim();
                string feature = txtFeature.Text.Trim();
                string description = txtDescription.Text.Trim();

                var repo = new RoomTypeRepository();
                var existing = repo.GetById(id);

                if (existing == null)
                {
                    MessageBox.Show("Seçilen kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                existing.TypeName = typeName;
                existing.Feature = feature;
                existing.Description = description;

                repo.Update(existing);
                LogHelper.AddLog(CurrentUser.UserID, "Oda Türü Yönetimi", "Güncelleme", $"'{typeName}' türü güncellendi.");

                LoadRoomTypes();
                ClearForm();

                MessageBox.Show("Oda türü başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? "İç hata yok";
                MessageBox.Show("Güncelleme sırasında hata oluştu:\n" + ex.Message + "\n\n" + inner, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(0, "Oda Türü Yönetimi", "Hata", $"Güncelleme hatası: {ex.Message} | {inner}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoomTypes.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dgvRoomTypes.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["RoomTypeID"].Value);
                string typeName = selectedRow.Cells["TypeName"].Value?.ToString();

                var dialog = MessageBox.Show($"'{typeName}' adlı oda türünü silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog != DialogResult.Yes)
                    return;

                var repo = new RoomTypeRepository();
                repo.Delete(id);

                LogHelper.AddLog(CurrentUser.UserID, "Oda Türü Yönetimi", "Silme", $"'{typeName}' türü silindi.");

                LoadRoomTypes();
                ClearForm();

                MessageBox.Show("Oda türü başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? "İç hata yok";
                MessageBox.Show("Silme sırasında hata oluştu:\n" + ex.Message + "\n\n" + inner, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(0, "Oda Türü Yönetimi", "Hata", $"Silme hatası: {ex.Message} | {inner}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRoomTypes();
            ClearForm();
        }
    }
}
