using GunesMotel.Common;
using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using GunesMotel.Entities.DTOs;
using GunesMotel.UI.WinForms.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class InvoiceManagementControl : UserControl
    {
        private int? selectedInvoiceId = null;
        public InvoiceManagementControl()
        {
            InitializeComponent();            
        }

        private void InvoiceManagementControl_Load(object sender, EventArgs e)
        {
            LoadInvoices();

            // Durum combobox’ı doldur
            cmbInvoiceStatus.Items.Clear();
            cmbInvoiceStatus.Items.Add("Tümü");
            cmbInvoiceStatus.Items.Add("Beklemede");
            cmbInvoiceStatus.Items.Add("Kısmi");
            cmbInvoiceStatus.Items.Add("Ödendi");
            cmbInvoiceStatus.SelectedIndex = 0;

            dtpStartDate.Checked = false; 
            dtpEndDate.Checked = false;

            dtpStartDate.Value = DateTime.Today.AddMonths(-1);
            dtpEndDate.Value = DateTime.Today;

            LoadInvoices();
        }

        private void LoadInvoices()
        {
            try
            {
                var repo = new InvoiceRepository();
                var invoiceList = repo.GetAllForGrid(); // DTO List
                dgvInvoices.DataSource = invoiceList;

                // Grid ayarları ve kolon başlıkları
                dgvInvoices.Columns["InvoiceID"].HeaderText = "Fatura No";
                dgvInvoices.Columns["CustomerName"].HeaderText = "Müşteri";
                dgvInvoices.Columns["RoomNumber"].HeaderText = "Oda";
                dgvInvoices.Columns["InvoiceDate"].HeaderText = "Tarih";
                dgvInvoices.Columns["TotalAmount"].HeaderText = "Tutar";
                dgvInvoices.Columns["Status"].HeaderText = "Durum";

                // Tarih ve tutar formatı
                dgvInvoices.Columns["InvoiceDate"].DefaultCellStyle.Format = "dd.MM.yyyy";
                dgvInvoices.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";

                dgvInvoices.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faturalar yüklenirken hata oluştu!\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchInvoices_Click(object sender, EventArgs e)
        {
            string search = txtInvoiceSearch.Text == "Müşteri, fatura no veya oda no..." ? "" : txtInvoiceSearch.Text.Trim();
            string status = cmbInvoiceStatus.SelectedItem?.ToString() ?? "";
            DateTime? startDate = dtpStartDate.Checked ? dtpStartDate.Value.Date : (DateTime?)null;
            DateTime? endDate = dtpEndDate.Checked ? dtpEndDate.Value.Date : (DateTime?)null;

            var repo = new InvoiceRepository();
            var filteredList = repo.GetFiltered(search, status, startDate, endDate);
            dgvInvoices.DataSource = filteredList;
            dgvInvoices.ClearSelection();
        }

        private void txtInvoiceSearch_Enter(object sender, EventArgs e)
        {
            if (txtInvoiceSearch.Text == "Müşteri, fatura no veya oda no...")
            {
                txtInvoiceSearch.Text = "";
                txtInvoiceSearch.ForeColor = Color.Black;
            }
        }

        private void txtInvoiceSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceSearch.Text))
            {
                txtInvoiceSearch.Text = "Müşteri, fatura no veya oda no...";
                txtInvoiceSearch.ForeColor = Color.Gray;
            }
        }

        private void dgvInvoices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count > 0)
            {
                selectedInvoiceId = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["InvoiceID"].Value);
            }
            else
            {
                selectedInvoiceId = null;
            }
        }

        private void ShowInvoiceDetail(int invoiceId)
        {
            var repo = new InvoiceRepository();
            var detail = repo.GetDetailById(invoiceId);

            if (detail == null)
            {
                MessageBox.Show("Fatura bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Üst bilgiler
            lblInvoiceNumber.Text = "Fatura No: " + detail.InvoiceID;
            lblCustomerName.Text = "Müşteri: " + detail.CustomerName;
            lblInvoiceDate.Text = "Tarih: " + detail.InvoiceDate.ToString("dd.MM.yyyy");
            lblInvoiceStatus.Text = "Durum: " + detail.Status;
            lblInvoiceAmount.Text = "Toplam: " + detail.TotalAmount.ToString("N2") + " TL";

            // Kalemler
            dgvInvoiceItems.DataSource = detail.Items;

            // Ödemeler
            dgvPayments.DataSource = detail.Payments;
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            if (selectedInvoiceId == null)
            {
                MessageBox.Show("Lütfen bir fatura seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ShowInvoiceDetail(selectedInvoiceId.Value);
            tabControl.SelectedTab = tabInvoiceDetail;
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if (selectedInvoiceId == null)
            {
                MessageBox.Show("Lütfen bir fatura seçin!");
                return;
            }

            var repo = new InvoiceRepository();
            var detail = repo.GetDetailById(selectedInvoiceId.Value);

            var frm = new FrmAddPayment();
            frm.DefaultAmount = detail.TotalAmount; // Otomatik olarak fatura tutarını gir

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var payment = new Payments
                {
                    InvoiceID = selectedInvoiceId.Value,
                    Amount = frm.PaymentAmount,
                    PaymentType = frm.PaymentType,
                    Currency = frm.Currency,
                    PaymentDate = DateTime.Now,
                    ProcessedByUserID = CurrentUser.UserID
                };

                repo.AddPayment(payment);
                repo.UpdateInvoiceStatus(selectedInvoiceId.Value);

                ShowInvoiceDetail(selectedInvoiceId.Value);
                LoadInvoices(); // Listeyi de güncelle!
                MessageBox.Show("Ödeme başarıyla kaydedildi!");
            }
        }

        private void btnRefreshInvoices_Click(object sender, EventArgs e)
        {
            txtInvoiceSearch.Text = "Müşteri, fatura no veya oda no...";
            txtInvoiceSearch.ForeColor = Color.Gray;
            cmbInvoiceStatus.SelectedIndex = 0;
            dtpStartDate.Checked = false;
            dtpEndDate.Checked = false;
            dtpStartDate.Value = DateTime.Today.AddMonths(-1);
            dtpEndDate.Value = DateTime.Today;

            LoadInvoices();

            dgvInvoices.ClearSelection();
            selectedInvoiceId = null;

            lblInvoiceNumber.Text = "Fatura No: ";
            lblCustomerName.Text = "Müşteri: ";
            lblInvoiceDate.Text = "Tarih: ";
            lblInvoiceStatus.Text = "Durum: ";
            lblInvoiceAmount.Text = "Toplam: ";
            dgvInvoiceItems.DataSource = null;
            dgvPayments.DataSource = null;
        }
    }
}
