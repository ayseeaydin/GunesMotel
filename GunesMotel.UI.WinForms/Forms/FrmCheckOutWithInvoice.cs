using GunesMotel.Common;
using GunesMotel.DataAccess.Contexts;
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

namespace GunesMotel.UI.WinForms.Forms
{
    public partial class FrmCheckOutWithInvoice : Form
    {
        private Reservations _reservation;
        private Invoices _invoice;
        private InvoiceRepository _invoiceRepo;
        private decimal _totalPaid = 0;
        private decimal _remainingAmount = 0;
        public FrmCheckOutWithInvoice(Reservations reservation)
        {
            InitializeComponent();
            _reservation = reservation;
            _invoiceRepo = new InvoiceRepository();
            InitializeForm();
            LoadReservationInfo();
            CreateOrLoadInvoice();
            LoadInvoiceDetails();
        }

        private void InitializeForm()
        {
            this.Text = "Check-Out ve Fatura İşlemleri";
            this.Size = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void LoadReservationInfo()
        {
            // Rezervasyon bilgilerini göster
            lblCustomerName.Text = $"Müşteri: {_reservation.Customer?.FullName}";
            lblRoomNumber.Text = $"Oda: {_reservation.Room?.RoomNumber}";
            lblCheckInDate.Text = $"Giriş: {_reservation.CheckInDate:dd.MM.yyyy}";
            lblCheckOutDate.Text = $"Çıkış: {_reservation.CheckOutDate:dd.MM.yyyy}";
            lblGuestCount.Text = $"Misafir Sayısı: {_reservation.GuestCount}";

            int nights = (_reservation.CheckOutDate.Date - _reservation.CheckInDate.Date).Days;
            lblNights.Text = $"Gece Sayısı: {nights}";
        }

        private void CreateOrLoadInvoice()
        {
            try
            {
                // Rezervasyona ait fatura var mı kontrol et
                _invoice = _invoiceRepo.GetByReservationId(_reservation.ReservationID);

                if (_invoice == null)
                {
                    // Fatura yoksa oluştur
                    _invoice = _invoiceRepo.CreateInvoiceForReservation(
                        _reservation.ReservationID,
                        CurrentUser.UserID
                    );

                    LogHelper.AddLog(CurrentUser.UserID, "Fatura", "Otomatik Oluşturuldu",
                        $"Check-out sırasında Rezervasyon {_reservation.ReservationID} için fatura oluşturuldu. Fatura No: {_invoice.InvoiceID}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura oluşturma hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LoadInvoiceDetails()
        {
            if (_invoice == null) return;

            try
            {
                var invoiceDetail = _invoiceRepo.GetDetailById(_invoice.InvoiceID);

                // Fatura bilgileri
                lblInvoiceNumber.Text = $"Fatura No: {_invoice.InvoiceID}";
                lblInvoiceDate.Text = $"Fatura Tarihi: {_invoice.InvoiceDate:dd.MM.yyyy HH:mm}";
                lblInvoiceStatus.Text = $"Durum: {_invoice.Status}";

                // Fatura kalemlerini göster
                dgvInvoiceItems.DataSource = invoiceDetail.Items;

                // Ödemeleri göster
                dgvPayments.DataSource = invoiceDetail.Payments;

                // Tutarları hesapla
                decimal totalAmount = invoiceDetail.TotalAmount;
                _totalPaid = invoiceDetail.Payments?.Sum(p => p.Amount) ?? 0;
                _remainingAmount = totalAmount - _totalPaid;

                lblTotalAmount.Text = $"Toplam Tutar: {totalAmount:C2}";
                lblTotalPaid.Text = $"Ödenen: {_totalPaid:C2}";
                lblRemainingAmount.Text = $"Kalan: {_remainingAmount:C2}";

                // Kalan borç durumuna göre renklendirme
                if (_remainingAmount <= 0)
                {
                    lblRemainingAmount.ForeColor = Color.Green;
                    lblPaymentStatus.Text = "✓ ÖDEMELİ";
                    lblPaymentStatus.ForeColor = Color.Green;
                    btnAddPayment.Enabled = false;
                }
                else if (_totalPaid > 0)
                {
                    lblRemainingAmount.ForeColor = Color.Orange;
                    lblPaymentStatus.Text = "⚠ KISMİ ÖDEMELİ";
                    lblPaymentStatus.ForeColor = Color.Orange;
                    btnAddPayment.Enabled = true;
                }
                else
                {
                    lblRemainingAmount.ForeColor = Color.Red;
                    lblPaymentStatus.Text = "✗ ÖDEMESİZ";
                    lblPaymentStatus.ForeColor = Color.Red;
                    btnAddPayment.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fatura detayları yüklenirken hata: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            try
            {
                var frmPayment = new FrmAddPayment();
                frmPayment.DefaultAmount = _remainingAmount; // Kalan tutarı varsayılan yap

                if (frmPayment.ShowDialog() == DialogResult.OK)
                {
                    var payment = new Payments
                    {
                        InvoiceID = _invoice.InvoiceID,
                        Amount = frmPayment.PaymentAmount,
                        PaymentType = frmPayment.PaymentType,
                        Currency = frmPayment.Currency,
                        PaymentDate = DateTime.Now,
                        ProcessedByUserID = CurrentUser.UserID
                    };

                    _invoiceRepo.AddPayment(payment);
                    _invoiceRepo.UpdateInvoiceStatus(_invoice.InvoiceID);

                    LogHelper.AddLog(CurrentUser.UserID, "Ödeme", "Eklendi",
                        $"Fatura {_invoice.InvoiceID} için {payment.Amount:C2} ödeme alındı. Tip: {payment.PaymentType}");

                    // Sayfayı yenile
                    LoadInvoiceDetails();

                    MessageBox.Show($"Ödeme başarıyla kaydedildi!\n\nTutar: {payment.Amount:C2}\nTip: {payment.PaymentType}",
                        "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödeme kaydetme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PerformCheckOut()
        {
            try
            {
                using (var context = new GunesMotelContext())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            // 1. Rezervasyon durumunu güncelle
                            var dbReservation = context.Reservations.Find(_reservation.ReservationID);
                            if (dbReservation != null)
                            {
                                dbReservation.Status = "Check-out";
                                context.SaveChanges();
                            }

                            // 2. Oda durumunu güncelle
                            var room = context.Rooms.Find(_reservation.RoomID);
                            if (room != null)
                            {
                                room.Status = "Temizlikte"; // Önce temizliğe gider
                                context.SaveChanges();
                            }

                            // 3. Log kaydı
                            LogHelper.AddLog(CurrentUser.UserID, "Check-out", "Tamamlandı",
                                $"Rezervasyon {_reservation.ReservationID} için check-out tamamlandı. " +
                                $"Oda: {_reservation.Room?.RoomNumber}, " +
                                $"Fatura: {_invoice.InvoiceID}, " +
                                $"Toplam: {_invoice.TotalAmount:C2}, " +
                                $"Ödenen: {_totalPaid:C2}, " +
                                $"Kalan: {_remainingAmount:C2}");

                            transaction.Commit();

                            MessageBox.Show(
                                $"Check-out işlemi başarıyla tamamlandı!\n\n" +
                                $"✅ Oda '{_reservation.Room?.RoomNumber}' temizlikte durumuna alındı\n" +
                                $"📄 Fatura No: {_invoice.InvoiceID}\n" +
                                $"💰 Toplam: {_invoice.TotalAmount:C2}\n" +
                                $"💳 Ödenen: {_totalPaid:C2}\n" +
                                $"💸 Kalan: {_remainingAmount:C2}",
                                "Check-Out Tamamlandı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw new Exception($"Check-out işlemi sırasında veritabanı hatası: {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check-out işlemi başarısız: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompleteCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                // Check-out onayı
                string paymentStatusMessage = "";
                if (_remainingAmount > 0)
                {
                    paymentStatusMessage = $"\n\n⚠️ DİKKAT: {_remainingAmount:C2} borç kalacak!";
                }
                else if (_remainingAmount < 0)
                {
                    paymentStatusMessage = $"\n\n💰 Para üstü: {Math.Abs(_remainingAmount):C2}";
                }
                else
                {
                    paymentStatusMessage = "\n\n✅ Ödemeler tamamlandı";
                }

                var result = MessageBox.Show(
                    $"Check-out işlemini tamamlamak istiyor musunuz?\n\n" +
                    $"Müşteri: {_reservation.Customer?.FullName}\n" +
                    $"Oda: {_reservation.Room?.RoomNumber}\n" +
                    $"Toplam Tutar: {_invoice.TotalAmount:C2}\n" +
                    $"Ödenen: {_totalPaid:C2}" +
                    paymentStatusMessage,
                    "Check-Out Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    PerformCheckOut();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Check-out onay hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                // Basit fatura yazdırma özelliği
                MessageBox.Show("Fatura yazdırma özelliği yakında eklenecek!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Gelecekte PDF export veya yazdırma özelliği eklenebilir
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yazdırma hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
