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
using System.Data.Entity;

namespace GunesMotel.UI.WinForms.Control
{
    public partial class InvoiceManagementControl : UserControl
    {
        private InvoiceRepository _invoiceRepo;
        private PaymentRepository _paymentRepo;
        private int? _selectedInvoiceId = null;
        public InvoiceManagementControl()
        {
            InitializeComponent();
            _invoiceRepo = new InvoiceRepository();
            _paymentRepo = new PaymentRepository();
        }

        private void InvoiceManagementControl_Load(object sender, EventArgs e)
        {
            LoadInvoiceStatusComboBox();
            SetDefaultDateRange();
            LoadInvoices();
        }

        private void SetDefaultDateRange()
        {
            // Son 30 gün
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Today;
        }

        private void LoadInvoiceStatusComboBox()
        {
            cmbInvoiceStatus.Items.Clear();
            cmbInvoiceStatus.Items.Add("Tümü");
            cmbInvoiceStatus.Items.Add("Bekliyor");
            cmbInvoiceStatus.Items.Add("Kısmi Ödendi");
            cmbInvoiceStatus.Items.Add("Ödendi");
            cmbInvoiceStatus.SelectedIndex = 0; // Tümü
        }

        private void LoadInvoices()
        {
            try
            {
                var invoices = _invoiceRepo.GetAll();

                var invoiceList = invoices.Select(i => new
                {
                    i.InvoiceID,
                    FaturaNo = i.InvoiceID,
                    RezervasyonNo = i.ReservationID,
                    Müşteri = i.Reservation?.Customer?.FullName ?? "N/A",
                    Oda = i.Reservation?.Room?.RoomNumber ?? "N/A",
                    Tarih = i.InvoiceDate.ToString("dd.MM.yyyy"),
                    Tutar = i.TotalAmount.ToString("C2"),
                    Durum = i.Status ?? "Bekliyor"
                }).ToList();

                dgvInvoices.DataSource = invoiceList;

                if (dgvInvoices.Columns["InvoiceID"] != null)
                    dgvInvoices.Columns["InvoiceID"].Visible = false;

                MessageBox.Show($"{invoiceList.Count} fatura listelendi!", "Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata");
            }
        }

        private decimal GetTotalPaymentsByInvoice(int invoiceId)
        {
            try
            {
                using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
                {
                    return context.Payments
                        .Where(p => p.InvoiceID == invoiceId)
                        .Sum(p => (decimal?)p.Amount) ?? 0;
                }
            }
            catch
            {
                return 0;
            }
        }


        private void btnSearchInvoices_Click(object sender, EventArgs e)
        {
            try
            {
                var invoices = _invoiceRepo.GetAll();

                // Tarih filtreleme
                var startDate = dtpStartDate.Value.Date;
                var endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);
                invoices = invoices.Where(i => i.InvoiceDate >= startDate && i.InvoiceDate <= endDate).ToList();

                // Durum filtreleme
                if (cmbInvoiceStatus.SelectedItem.ToString() != "Tümü")
                {
                    var selectedStatus = cmbInvoiceStatus.SelectedItem.ToString();
                    invoices = invoices.Where(i => i.Status == selectedStatus).ToList();
                }

                // Metin arama
                if (!string.IsNullOrWhiteSpace(txtInvoiceSearch.Text) &&
                    txtInvoiceSearch.Text != "Müşteri adı veya fatura no...")
                {
                    string searchText = txtInvoiceSearch.Text.ToLower();
                    invoices = invoices.Where(i =>
                        i.InvoiceID.ToString().Contains(searchText) ||
                        (i.Reservation?.Customer?.FullName?.ToLower().Contains(searchText) == true)
                    ).ToList();
                }

                var filteredList = invoices.Select(i => new
                {
                    i.InvoiceID,
                    FaturaNo = i.InvoiceID,
                    RezervasyonNo = i.ReservationID,
                    Müşteri = i.Reservation?.Customer?.FullName ?? "N/A",
                    Oda = i.Reservation?.Room?.RoomNumber ?? "N/A",
                    Tarih = i.InvoiceDate.ToString("dd.MM.yyyy"),
                    Tutar = i.TotalAmount.ToString("C2"),
                    Durum = i.Status,
                    ÖdenenTutar = _paymentRepo.GetTotalPaymentsByInvoice(i.InvoiceID).ToString("C2"),
                    KalanTutar = (i.TotalAmount - _paymentRepo.GetTotalPaymentsByInvoice(i.InvoiceID)).ToString("C2")
                }).OrderByDescending(x => x.FaturaNo).ToList();

                dgvInvoices.DataSource = filteredList;

                // ID sütununu gizle
                if (dgvInvoices.Columns["InvoiceID"] != null)
                    dgvInvoices.Columns["InvoiceID"].Visible = false;

                MessageBox.Show($"{filteredList.Count} fatura bulundu.", "Arama Sonucu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshInvoices_Click(object sender, EventArgs e)
        {
            LoadInvoices();
            MessageBox.Show("Fatura listesi yenilendi.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoices.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen görüntülenecek faturayı seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int invoiceId = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["InvoiceID"].Value);
                _selectedInvoiceId = invoiceId;

                LoadInvoiceDetails(invoiceId);
                tabControl.SelectedTab = tabInvoiceDetail;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura detayı yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvoiceDetails(int invoiceId)
        {
            try
            {
                var invoice = _invoiceRepo.GetById(invoiceId);
                if (invoice == null)
                {
                    MessageBox.Show("Fatura bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Fatura bilgilerini göster
                lblInvoiceNumber.Text = $"Fatura No: {invoice.InvoiceID}";
                lblCustomerName.Text = $"Müşteri: {invoice.Reservation?.Customer?.FullName ?? "N/A"}";
                lblInvoiceDate.Text = $"Tarih: {invoice.InvoiceDate:dd.MM.yyyy}";
                lblInvoiceStatus.Text = $"Durum: {invoice.Status}";
                lblInvoiceAmount.Text = $"Toplam: {invoice.TotalAmount:C2}";

                // Fatura kalemlerini yükle
                LoadInvoiceItems(invoiceId);

                // Ödeme geçmişini yükle
                LoadPaymentHistory(invoiceId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura detayları yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvoiceItems(int invoiceId)
        {
            try
            {
                using (var context = new GunesMotel.DataAccess.Contexts.GunesMotelContext())
                {
                    var items = context.InvoiceItems.Where(ii => ii.InvoiceID == invoiceId).ToList();

                    var itemList = items.Select(item => new
                    {
                        Tür = item.ItemType == "Room" ? "Oda Ücreti" : "Ekstra Hizmet",
                        Açıklama = item.Description,
                        BirimFiyat = item.UnitPrice.ToString("C2"),
                        Adet = item.Quantity,
                        Toplam = (item.UnitPrice * item.Quantity).ToString("C2")
                    }).ToList();

                    dgvInvoiceItems.DataSource = itemList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura kalemleri yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaymentHistory(int invoiceId)
        {
            try
            {
                var payments = _paymentRepo.GetByInvoiceId(invoiceId);

                var paymentList = payments.Select(p => new
                {
                    Tarih = p.PaymentDate.ToString("dd.MM.yyyy HH:mm"),
                    Tutar = p.Amount.ToString("C2"),
                    Tür = p.PaymentType,
                    ParaBirimi = p.Currency,
                    Kullanıcı = p.User?.FullName ?? "N/A"
                }).ToList();

                dgvPayments.DataSource = paymentList;

                // Toplam ödenen tutarı hesapla
                decimal totalPaid = payments.Sum(p => p.Amount);
                lblPaymentHistory.Text = $"💰 Ödeme Geçmişi (Toplam: {totalPaid:C2})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödeme geçmişi yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvInvoices.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen ödeme alınacak faturayı seçin.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int invoiceId = Convert.ToInt32(dgvInvoices.SelectedRows[0].Cells["InvoiceID"].Value);
                var invoice = _invoiceRepo.GetById(invoiceId);

                if (invoice == null)
                {
                    MessageBox.Show("Fatura bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (invoice.Status == "Ödendi")
                {
                    MessageBox.Show("Bu fatura zaten tamamen ödenmiş.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Basit ödeme alma formu
                ShowSimplePaymentForm(invoice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödeme alma sırasında hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSimplePaymentForm(Invoices invoice)
        {
            // Basit input dialog
            decimal totalPaid = _paymentRepo.GetTotalPaymentsByInvoice(invoice.InvoiceID);
            decimal remainingAmount = invoice.TotalAmount - totalPaid;

            if (remainingAmount <= 0)
            {
                MessageBox.Show("Bu fatura zaten tamamen ödenmiş.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string input = ShowPaymentInputDialog($"Ödeme Tutarı Girin:\n\n" +
                $"Fatura Tutarı: {invoice.TotalAmount:C2}\n" +
                $"Ödenen: {totalPaid:C2}\n" +
                $"Kalan: {remainingAmount:C2}\n\n" +
                $"Ödeme tutarını girin:", "Ödeme Al", remainingAmount.ToString("F2"));

            if (!string.IsNullOrEmpty(input) && decimal.TryParse(input, out decimal paymentAmount) && paymentAmount > 0)
            {
                if (paymentAmount > remainingAmount)
                {
                    MessageBox.Show("Ödeme tutarı kalan tutardan fazla olamaz.", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ödeme kaydı oluştur
                var payment = new Payments
                {
                    InvoiceID = invoice.InvoiceID,
                    Amount = paymentAmount,
                    PaymentType = "Nakit", // Basit versiyon
                    Currency = "TL",
                    PaymentDate = DateTime.Now,
                    ProcessedByUserID = CurrentUser.UserID
                };

                _paymentRepo.Add(payment);

                LogHelper.AddLog(CurrentUser.UserID, "Ödeme", "Alındı",
                    $"Fatura {invoice.InvoiceID} için {paymentAmount:C2} ödeme alındı.");

                MessageBox.Show($"Ödeme başarıyla kaydedildi!\n\nÖdenen: {paymentAmount:C2}", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Listeyi yenile
                LoadInvoices();

                // Eğer detay sekmesindeyse, detayları da yenile
                if (_selectedInvoiceId.HasValue)
                {
                    LoadInvoiceDetails(_selectedInvoiceId.Value);
                }
            }
            else if (!string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Geçerli bir ödeme tutarı giriniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string ShowPaymentInputDialog(string text, string caption, string defaultValue)
        {
            Form prompt = new Form()
            {
                Width = 450,
                Height = 250,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 400, Height = 100, Text = text };
            TextBox textBox = new TextBox() { Left = 20, Top = 130, Width = 200, Text = defaultValue };
            Button confirmation = new Button() { Text = "Ödeme Al", Left = 230, Width = 90, Top = 128, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "İptal", Left = 330, Width = 70, Top = 128, DialogResult = DialogResult.Cancel };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void txtInvoiceSearch_Enter(object sender, EventArgs e)
        {
            if (txtInvoiceSearch.Text == "Müşteri adı veya fatura no...")
            {
                txtInvoiceSearch.Text = "";
                txtInvoiceSearch.ForeColor = Color.Black;
            }
        }

        private void txtInvoiceSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceSearch.Text))
            {
                txtInvoiceSearch.Text = "Müşteri adı veya fatura no...";
                txtInvoiceSearch.ForeColor = Color.Gray;
            }
        }
    }
}
