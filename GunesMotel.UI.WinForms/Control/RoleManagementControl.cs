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
        // GenericRepository sınıfını kullanarak pozisyon verilerini yönetmek için bir değişken tanımlıyoruz:
        private readonly GenericRepository<Roles> _roleRepo;
        public RoleManagementControl()
        {
            InitializeComponent();
            // Repository nesnesi oluşturur ve veritabanı bağlantısını sağlar
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

        private void ClearAndFocus()
        {
            txtRoleName.Clear(); // TextBox'ı temizle
            txtRoleName.Focus(); // TextBox'a odaklan
        }

        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtRoleName.Text))
            {
                MessageBox.Show("Rol adı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoleName.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return;
                
                var newRole = new Roles { RoleName = txtRoleName.Text };

                _roleRepo.Add(newRole); // yeni rolü ekle
                LoadRoles(); // Rolleri yeniden yükle - Listeyi yenile
                txtRoleName.Clear(); // TextBox'ı temizle   
                MessageBox.Show("Rol başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Ekleme", $"Yeni rol eklendi: '{newRole.RoleName}'");
                ClearAndFocus(); // TextBox'ı temizle ve odaklan
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
                if (!IsInputValid()) return;
                
                // seçili satırın ID al
                int selectedID=Convert.ToInt32(dgvRoles.SelectedRows[0].Cells[0].Value); 
                // ID ye göre rolü bul
                var role= _roleRepo.GetById(selectedID); // Seçilen rolü getir
                if (role != null)
                {
                    string oldName = role.RoleName; // eski rol adını al
                    role.RoleName = txtRoleName.Text; // yeni rol adını ata
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
                if (dgvRoles.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silinecek rolü seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dgvRoles.CurrentRow != null)
                {
                    int selectedID = Convert.ToInt32(dgvRoles.SelectedRows[0].Cells[0].Value);
                    string deletedName = dgvRoles.SelectedRows[0].Cells[1].Value.ToString();
                    _roleRepo.Delete(selectedID); // Seçilen rolü sil
                    MessageBox.Show($"'{deletedName}' rolü başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoles(); // Rolleri yeniden yükle
                    LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Silme", $"'{deletedName}' rolü silindi.");
                    ClearAndFocus(); // TextBox'ı temizle ve odaklan
                }
            }
            catch (Exception ex)
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
                ClearAndFocus(); // TextBox'ı temizle ve odaklan
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
                    // Seçili satırın RoleName değerini al ve TextBox'a ata
                    txtRoleName.Text = dgvRoles.SelectedRows[0].Cells[1].Value.ToString();
                    // TextBox a odaklan
                    txtRoleName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rol seçilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.AddLog(CurrentUser.UserID, "Rol Yönetimi", "Hata", "DataGridView tıklama hatası: " + ex.Message);
            }
        }

        private void RoleManagementControl_Load(object sender, EventArgs e)
        {
            dgvRoles.ClearSelection(); // DataGridView'deki seçimi temizle
        }
    }
}
