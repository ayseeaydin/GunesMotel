using GunesMotel.DataAccess.Repositories;
using GunesMotel.Entities;
using GunesMotel.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class InvoiceManagementControl : UserControl
    {
        
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

            // Tarih başlangıcını anlamlı bir değere çekebilirsin (örn. 1 yıl önce)
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
    }
}
