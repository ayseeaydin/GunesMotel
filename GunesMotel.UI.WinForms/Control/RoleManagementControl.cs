using System;
using System.Windows.Forms;
using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.DataAccess.Helpers;
using GunesMotel.Entities;
using GunesMotel.Common;

namespace GunesMotel.UI.WinForms.Control
{    
    public partial class RoleManagementControl : UserControl
    {
        // Generic repository örneği ile rol işlemleri yapılacak
        private readonly GenericRepository<Roles> _roleRepo;
        public RoleManagementControl()
        {
            InitializeComponent();
            _roleRepo = new GenericRepository<Roles>(new GunesMotelContext());
            LoadRoles();
        }

        // Rolleri listeleyen metot:
        private void LoadRoles()
        {
            try
            {
                dgvRoles.DataSource=_roleRepo.GetAll(); // Tüm rolleri getir
                dgvRoles.ClearSelection(); // Seçimi temizle
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Listeleme", "Roller başarıyla yüklendi.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Roller yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Hata", "Roller yüklenemedi: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtRoleName.Text.Trim(); // Kullanıcıdan alınan rol adı   

                if(string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Rol adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Roles newRole = new Roles { RoleName = name };

                _roleRepo.Add(newRole); // Teni rolü ekle
                LoadRoles(); // Rolleri yeniden yükle - Listeyi yenile
                txtRoleName.Clear(); // TextBox'ı temizle   
                MessageBox.Show("Rol başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Ekleme", $"'{name}' rolü eklendi.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Rol eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Hata", "Rol eklenemedi: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Güncellenecek rolü seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int roleId = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells[0].Value); // Seçilen rolün ID'si
                var role = _roleRepo.GetById(roleId); // Rolü bul

                if (role != null)
                {
                    role.RoleName = txtRoleName.Text.Trim(); // TextBox'tan yeni adı al
                    _roleRepo.Update(role); // Rolü güncelle
                    LoadRoles(); // Rolleri yeniden yükle
                    txtRoleName.Clear(); // TextBox'ı temizle
                    MessageBox.Show("Rol başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Güncelleme", $"'{role.RoleName}' rolü güncellendi.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Rol güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Hata", "Rol güncellenemedi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silinecek rolü seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int roleId = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells[0].Value); // Seçilen rolün ID'si
                _roleRepo.Delete(roleId); // Rolü sil
                LoadRoles(); // Rolleri yeniden yükle
                txtRoleName.Clear(); // TextBox'ı temizle
                MessageBox.Show("Rol başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Silme", $"'{roleId}' ID'li rol silindi.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Rol silinirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Hata", "Rol silinemedi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadRoles(); // Rolleri yeniden yükle
                txtRoleName.Clear(); // TextBox'ı temizle
                MessageBox.Show("Liste başarıyla yenilendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Yenileme", "Liste başarıyla yenilendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yenilenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Hata", "Liste yenilenemedi: " + ex.Message);
            }
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dgvRoles.SelectedRows.Count > 0)
                {
                    string roleName=dgvRoles.SelectedRows[0].Cells[1].Value?.ToString(); // Seçilen rolün adı
                    txtRoleName.Text = roleName; // TextBox'a rol adını yaz
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol seçilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Hata", "DataGridView tıklama hatası: " + ex.Message);
            }
        }
    }
}
