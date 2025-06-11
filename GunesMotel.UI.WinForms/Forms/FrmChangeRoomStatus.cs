using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Forms
{
    public partial class FrmChangeRoomStatus : Form
    {
        public string SelectedStatus { get; private set; }
        public FrmChangeRoomStatus( string currentStatus)
        {
            InitializeComponent();

            cmbStatus.Items.AddRange(new[] { "Boş", "Dolu", "Temizlikte", "Arızalı" });
            cmbStatus.SelectedItem = currentStatus;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem != null)
            {
                SelectedStatus = cmbStatus.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
