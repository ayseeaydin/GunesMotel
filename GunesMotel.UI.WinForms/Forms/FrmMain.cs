using GunesMotel.UI.WinForms.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();            
        }


        private void LoadPositionManagementControl()
        {
            try
            {
                // Paneli temizle
                pnlContent.Controls.Clear();

                // Position UserControl'ünü oluştur
                var roleControl = new RoomManagementControl();
                {
                    Dock = DockStyle.Fill;
                };

                // UserControl'ü panele ekle
                pnlContent.Controls.Add(roleControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Position yönetimi yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadPositionManagementControl();
        }
    }
}
