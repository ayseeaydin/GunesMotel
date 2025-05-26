using System;
using System.Windows.Forms;
using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.DataAccess.Helpers;
using GunesMotel.Entities;
using GunesMotel.Common;

namespace GunesMotel.UI.WinForms
{
    public partial class PositionManagementControl : UserControl
    {
        // GenericRepository sınıfını kullanarak pozisyon verilerini yönetmek için bir değişken tanımlıyoruz:
        private GenericRepository<Positions> _repo;

        // Constructor: Kullanıcı kontrolü başlatılır ve pozisyonlar yüklenir
        public PositionManagementControl()
        {
            InitializeComponent();
            // Repository nesnesini oluşturur ve veritabanı bağlantısını sağlar
            _repo= new GenericRepository<Positions>(new GunesMotelContext());
            LoadPositions();
        }

        private void LoadPositions()
        {
            try
            {
                // Dgv ye pozisyon listesini ata:
                dgvPositions.DataSource = _repo.GetAll();

                // Varsayılan olarak hiçbir satırı seçili yapma
                dgvPositions.ClearSelection();
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon yönetimi","Listeleme","Pozisyonlar başarıyla yüklendi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pozisyonlar yüklenirken hata oluştu: " + ex.Message);
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Hata", "Pozisyonlar yüklenemedi: " + ex.Message);
            }
        }

        // TextBox'ı temizleyip odaklanma işlemi
        private void ClearAndFocus()
        {
            txtPositionName.Clear();
            txtPositionName.Focus();
        }

        // Boş alan kontrolü yapma işlemi
        private bool IsInputValid()
        {
            if (string.IsNullOrWhiteSpace(txtPositionName.Text))
            {
                MessageBox.Show("Pozisyon adı boş olamaz.");
                txtPositionName.Focus();
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return;
                // Yeni pozisyon nesnesi oluştur ve kullanıcıdan aldığı veriyi ata:
                var newPosition = new Positions { PositionName = txtPositionName.Text };
                // yeni pozisyonu veritabanına ekle:
                _repo.Add(newPosition);
                // ekleme sonrası listeyi güncelle
                LoadPositions();
                MessageBox.Show("Yeni pozisyon eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Ekleme", $"Yeni pozisyon eklendi: {newPosition.PositionName}");
                ClearAndFocus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pozisyon ekleme hatası: " + ex.Message);
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Hata", "Ekleme hatası: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsInputValid()) return;
                // dgv den seçili satırı kontrol et
                if (dgvPositions.CurrentRow != null)
                {
                    // seçili satırın id al
                    int selectedId = Convert.ToInt32(dgvPositions.SelectedRows[0].Cells[0].Value);
                    // id ye göre pozisyonu bul
                    var position=_repo.GetById(selectedId);
                    if (position != null)
                    {
                        string oldName = position.PositionName; // eski pozisyon adını al
                        // güncellenmiş pozisyon adını textboxdan al
                        position.PositionName = txtPositionName.Text;
                        _repo.Update(position);
                        LoadPositions();
                        txtPositionName.Clear();
                        MessageBox.Show("Pozisyon güncellendi.","Başarılı", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Güncelleme", $"Pozisyon güncellendi: '{oldName}' → '{position.PositionName}'");
                    }
                }
                ClearAndFocus() ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pozisyon güncelleme hatası: " + ex.Message);
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Hata", "Güncelleme hatası: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvPositions.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silinecek rolü seçin.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if(dgvPositions.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(dgvPositions.SelectedRows[0].Cells[0].Value);
                    string deletedName = dgvPositions.SelectedRows[0].Cells[1].Value.ToString();
                    _repo.Delete(selectedId);
                    LoadPositions();
                    MessageBox.Show("Pozisyon silindi.");
                    LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Silme", $"Pozisyon silindi: {deletedName}");
                }
                ClearAndFocus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pozisyon silme hatası: " + ex.Message);
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Hata", "Silme hatası: " + ex.Message);
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadPositions();
                ClearAndFocus();
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Yenileme", "Pozisyonlar yenilendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pozisyon yenileme hatası: " + ex.Message);
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Hata", "Yenileme hatası: " + ex.Message);
            }
        }

        private void dgvPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // eğer herhangi bir satır seçilmişse
                if (dgvPositions.SelectedRows.Count > 0)
                {
                    // Seçili satırın RoleName değerini al ve TextBox'a ata
                    txtPositionName.Text = dgvPositions.SelectedRows[0].Cells[1].Value.ToString();

                    // TextBox'a odaklan
                    txtPositionName.Focus();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("Veriyi yükleme hatası: " + ex.Message);
                LogHelper.AddLog(CurrentUser.UserID, "Pozisyon Yönetimi", "Hata", "Veri yükleme hatası: " + ex.Message);
            }
        }

        private void PositionManagementControl_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde seçimi kaldır
            dgvPositions.ClearSelection();
        }
    }
}
