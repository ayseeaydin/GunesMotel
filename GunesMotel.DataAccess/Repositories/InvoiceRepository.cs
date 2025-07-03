using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GunesMotel.DataAccess.Repositories
{
    public class InvoiceRepository
    {
        public List<Invoices> GetAll()
        {
            using (var context = new GunesMotelContext())
            {
                return context.Invoices
                    .Include(i => i.Reservation)
                    .Include(i => i.Reservation.Customer)
                    .Include(i => i.Reservation.Room)
                    .OrderByDescending(i => i.InvoiceID)
                    .ToList(); 
            }
        }

        public Invoices GetById(int invoiceId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Invoices
                    .Include(i => i.Reservation)
                    .Include(i => i.Reservation.Customer)
                    .Include(i => i.Reservation.Room)
                    .FirstOrDefault(i => i.InvoiceID == invoiceId);
            }
        }

        public Invoices GetByReservationId(int reservationId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Invoices
                              .Include(i => i.InvoiceItems)
                              .FirstOrDefault(i => i.ReservationID == reservationId);
            }
        }

        public void Add(Invoices invoice)
        {
            using (var context = new GunesMotelContext())
            {
                context.Invoices.Add(invoice);
                context.SaveChanges();
            }
        }

        public void Update(Invoices invoice)
        {
            using (var context = new GunesMotelContext())
            {
                var existing = context.Invoices.Find(invoice.InvoiceID);
                if (existing != null)
                {
                    existing.TotalAmount = invoice.TotalAmount;
                    existing.Status = invoice.Status;
                    existing.InvoiceDate = invoice.InvoiceDate;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(int invoiceId)
        {
            using (var context = new GunesMotelContext())
            {
                var invoice = context.Invoices.Find(invoiceId);
                if (invoice != null)
                {
                    // Önce fatura kalemlerini sil
                    var items = context.InvoiceItems.Where(ii => ii.InvoiceID == invoiceId);
                    context.InvoiceItems.RemoveRange(items);

                    // Sonra faturayı sil
                    context.Invoices.Remove(invoice);
                    context.SaveChanges();
                }
            }
        }

        public decimal CalculateRoomCharges(int reservationId)
        {
            using (var context = new GunesMotelContext())
            {
                var reservation = context.Reservations
                    .Include(r => r.Room.RoomType)
                    .FirstOrDefault(r => r.ReservationID == reservationId);

                if (reservation == null) return 0;

                // Konaklama gün sayısını hesapla
                var nights = (reservation.CheckOutDate.Date - reservation.CheckInDate.Date).Days;
                if (nights <= 0) nights = 1;

                // Basit hesaplama - tek fiyat kullan (sezon entegrasyonu sonra eklenebilir)
                var roomPrice = context.RoomPrices
                    .Where(rp => rp.RoomID == reservation.RoomID)
                    .OrderByDescending(rp => rp.LastUpdated)
                    .FirstOrDefault();

                if (roomPrice != null)
                {
                    return roomPrice.Price * nights;
                }

                // Eğer fiyat bulunamazsa varsayılan fiyat
                return 100 * nights; // 100 TL varsayılan fiyat
            }
        }

        public decimal CalculateExtraCharges(int reservationId)
        {
            using (var context = new GunesMotelContext())
            {
                var reservationExtras = context.ReservationExtras
                    .Where(re => re.ReservationID == reservationId)
                    .ToList();

                decimal totalExtraCharge = 0;

                foreach (var extra in reservationExtras)
                {
                    // UnitPrice zaten ReservationExtras'ta var
                    totalExtraCharge += extra.UnitPrice * extra.Quantity;
                }

                return totalExtraCharge;
            }
        }

        public Invoices CreateInvoiceForReservation(int reservationId, int createdByUserId)
        {
            using (var context = new GunesMotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var reservation = context.Reservations
                            .Include(r => r.Room.RoomType)
                            .Include(r => r.Customer)
                            .FirstOrDefault(r => r.ReservationID == reservationId);

                        if (reservation == null)
                            throw new ArgumentException("Rezervasyon bulunamadı.");

                        // Zaten fatura var mı kontrol et
                        var existingInvoice = context.Invoices
                            .FirstOrDefault(i => i.ReservationID == reservationId);

                        if (existingInvoice != null)
                            throw new InvalidOperationException("Bu rezervasyon için zaten fatura oluşturulmuş.");

                        // Oda ücretlerini hesapla
                        var roomCharges = CalculateRoomCharges(reservationId);
                        var extraCharges = CalculateExtraCharges(reservationId);

                        // Yeni fatura oluştur
                        var invoice = new Invoices
                        {
                            ReservationID = reservationId,
                            TotalAmount = roomCharges + extraCharges,
                            Status = "Bekliyor",
                            InvoiceDate = DateTime.Now,
                            CreatedByUserID = createdByUserId
                        };

                        context.Invoices.Add(invoice);
                        context.SaveChanges(); // InvoiceID'yi almak için

                        // Oda ücretini ekle
                        var nights = (reservation.CheckOutDate.Date - reservation.CheckInDate.Date).Days;
                        if (nights <= 0) nights = 1;

                        var roomItem = new InvoiceItems
                        {
                            InvoiceID = invoice.InvoiceID,
                            ItemType = "Room",
                            Description = $"Oda {reservation.Room.RoomNumber} - {nights} gece konaklama",
                            UnitPrice = roomCharges / nights,
                            Quantity = nights
                        };
                        context.InvoiceItems.Add(roomItem);

                        // Ekstra hizmetleri ekle
                        var reservationExtras = context.ReservationExtras
                            .Where(re => re.ReservationID == reservationId)
                            .ToList();

                        foreach (var extra in reservationExtras)
                        {
                            // ExtraService bilgisini ayrıca al
                            var service = context.ExtraServices
                                .FirstOrDefault(s => s.ServiceID == extra.ServiceID);

                            var extraItem = new InvoiceItems
                            {
                                InvoiceID = invoice.InvoiceID,
                                ItemType = "Extra",
                                Description = service?.ServiceName ?? "Ekstra Hizmet",
                                UnitPrice = extra.UnitPrice,
                                Quantity = extra.Quantity
                            };
                            context.InvoiceItems.Add(extraItem);
                        }

                        context.SaveChanges();
                        transaction.Commit();
                        return invoice;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public List<Invoices> GetUnpaidInvoices()
        {
            using (var context = new GunesMotelContext())
            {
                return context.Invoices
                    .Include(i => i.Reservation.Customer)
                    .Include(i => i.Reservation.Room)
                    .Where(i => i.Status == "Bekliyor" || i.Status == "Kısmi Ödendi")
                    .OrderBy(i => i.InvoiceDate)
                    .ToList();
            }
        }

        public decimal GetTotalPaidAmount(int invoiceId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Payments
                    .Where(p => p.InvoiceID == invoiceId)
                    .Sum(p => (decimal?)p.Amount) ?? 0;
            }
        }

        public void UpdateInvoiceStatus(int invoiceId)
        {
            using (var context = new GunesMotelContext())
            {
                var invoice = context.Invoices.Find(invoiceId);
                if (invoice != null)
                {
                    var totalPaid = GetTotalPaidAmount(invoiceId);

                    if (totalPaid >= invoice.TotalAmount)
                        invoice.Status = "Ödendi";
                    else if (totalPaid > 0)
                        invoice.Status = "Kısmi Ödendi";
                    else
                        invoice.Status = "Bekliyor";

                    context.SaveChanges();
                }
            }
        }
    }
}
