using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GunesMotel.Entities.DTOs;

namespace GunesMotel.DataAccess.Repositories
{
    public class InvoiceRepository
    {
        public void AddPayment(Payments payment)
        {
            using (var context = new GunesMotelContext())
            {
                context.Payments.Add(payment);
                context.SaveChanges();
            }
        }
        public List<InvoiceListDTO> GetAllForGrid()
        {
            using (var context = new GunesMotelContext())
            {
                return context.Invoices
                    .Include(i => i.Reservation)
                        .ThenInclude(r => r.Customer)
                    .Include(i => i.Reservation.Room)
                    .OrderByDescending(i => i.InvoiceID)
                    .Select(i => new InvoiceListDTO
                    {
                        InvoiceID = i.InvoiceID,
                        CustomerName = i.Reservation.Customer.FullName,
                        RoomNumber = i.Reservation.Room.RoomNumber,
                        InvoiceDate = i.InvoiceDate, // DateTime olarak bırak!
                        TotalAmount = i.TotalAmount,
                        Status = i.Status
                    })
                    .ToList();
            }
        }

        public List<InvoiceListDTO> GetFiltered(
                                    string searchText = "",
                                    string status = "",
                                    DateTime? startDate = null,
                                    DateTime? endDate = null)
        {
            using (var context = new GunesMotelContext())
            {
                var query = context.Invoices
                    .Include(i => i.Reservation)
                        .ThenInclude(r => r.Customer)
                    .Include(i => i.Reservation.Room)
                    .Select(i => new InvoiceListDTO
                    {
                        InvoiceID = i.InvoiceID,
                        CustomerName = i.Reservation.Customer.FullName,
                        RoomNumber = i.Reservation.Room.RoomNumber,
                        InvoiceDate = i.InvoiceDate,
                        TotalAmount = i.TotalAmount,
                        Status = i.Status
                    });

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    query = query.Where(i =>
                        i.CustomerName.Contains(searchText) ||
                        i.InvoiceID.ToString().Contains(searchText) ||
                        i.RoomNumber.Contains(searchText));
                }

                if (!string.IsNullOrWhiteSpace(status) && status != "Tümü")
                {
                    query = query.Where(i => i.Status == status);
                }

                if (startDate != null && endDate != null)
                {
                    DateTime start = startDate.Value.Date;
                    DateTime end = endDate.Value.Date.AddDays(1); // Bitiş gününü de dahil et
                    query = query.Where(i => i.InvoiceDate >= start && i.InvoiceDate < end);
                }

                return query.OrderByDescending(i => i.InvoiceID).ToList();
            }
        }

        public InvoiceDetailDTO GetDetailById(int invoiceId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Invoices
                    .Where(i => i.InvoiceID == invoiceId)
                    .Select(i => new InvoiceDetailDTO
                    {
                        InvoiceID = i.InvoiceID,
                        CustomerName = i.Reservation.Customer.FullName,
                        RoomNumber = i.Reservation.Room.RoomNumber,
                        InvoiceDate = i.InvoiceDate,
                        Status = i.Status,
                        TotalAmount = i.TotalAmount,
                        Items = i.InvoiceItems.Select(ii => new InvoiceItemDTO
                        {
                            ItemType = ii.ItemType,
                            Description = ii.Description,
                            Quantity = ii.Quantity,
                            UnitPrice = ii.UnitPrice,
                        }).ToList(),
                        Payments = i.Payments.Select(p => new PaymentDTO
                        {
                            Amount = p.Amount,
                            PaymentType = p.PaymentType,
                            Currency = p.Currency,
                            PaymentDate = p.PaymentDate,
                            UserName = p.User.Username
                        }).ToList()
                    })
                    .FirstOrDefault();
            }
        }


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
                        .ThenInclude(r => r.Customer)
                    .Include(i => i.Reservation.Room)
                    .Include(i => i.InvoiceItems)
                    .Include(i => i.Payments.Select(p => p.User)) // Ödemede kullanıcıyı da çek
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
                    // Tüm ödemeleri topla:
                    var totalPaid = context.Payments
                                           .Where(p => p.InvoiceID == invoiceId)
                                           .Sum(p => (decimal?)p.Amount) ?? 0;

                    if (totalPaid >= invoice.TotalAmount)
                        invoice.Status = "Ödendi";
                    else if (totalPaid > 0)
                        invoice.Status = "Kısmi";
                    else
                        invoice.Status = "Beklemede";

                    context.SaveChanges();
                }
            }
        }
    }
}
