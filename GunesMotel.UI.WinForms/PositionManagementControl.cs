using System;
using System.Windows.Forms;
using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;

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
                // Tüm pozisyonları getir:
                var positions = _repo.GetAll();
                // Dgv ye pozisyon listesini ata:
                dgvPositions.DataSource = positions;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pozisyonlar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni pozisyon nesnesi oluştur ve kullanıcıdan aldığı veriyi ata:
                var newPosition = new Positions
                {
                    PositionName = txtPositionName.Text
                };
                // yeni pozisyonu veritabanına ekle:
                _repo.Add(newPosition);
                // ekleme sonrası listeyi güncelle
                LoadPositions();
                MessageBox.Show("Yeni pozisyon eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pozisyon ekleme hatası: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // dgv den seçili satırı kontrol et
                if (dgvPositions.CurrentRow != null)
                {
                    // seçili satırın id al
                    int selectedId = Convert.ToInt32(dgvPositions.CurrentRow.Cells["PositionID"].Value);
                    // id ye göre pozisyonu bul
                    var position=_repo.GetById(selectedId);
                    if (position != null)
                    {
                        // güncellenmiş pozisyon adını textboxdan al
                        position.PositionName = txtPositionName.Text;
                        _repo.Update(position);
                        LoadPositions();
                        MessageBox.Show("Pozisyon güncellendi.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pozisyon güncelleme hatası: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvPositions.CurrentRow != null)
                {
                    int selectedId = Convert.ToInt32(dgvPositions.CurrentRow.Cells["PositionID"].Value);
                    _repo.Delete(selectedId);
                    LoadPositions();
                    MessageBox.Show("Pozisyon silindi.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pozisyon silme hatası: " + ex.Message);
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadPositions();
            txtPositionName.Focus();
        }
    }
}
