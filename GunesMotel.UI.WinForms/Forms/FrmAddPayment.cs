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
    public partial class FrmAddPayment : Form
    {
        public decimal PaymentAmount => nudAmount.Value;
        public string PaymentType => cmbPaymentType.SelectedItem?.ToString();
        public string Currency => cmbCurrency.SelectedItem?.ToString();
        public FrmAddPayment()
        {
            InitializeComponent();
            cmbPaymentType.SelectedIndex = 0;
            cmbCurrency.SelectedIndex = 0;
            nudAmount.Value = 1;
        }

        public decimal DefaultAmount
        {
            get => nudAmount.Value;
            set => nudAmount.Value = value;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PaymentAmount <= 0)
            {
                MessageBox.Show("Geçerli bir tutar girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK; // KAYDET
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
