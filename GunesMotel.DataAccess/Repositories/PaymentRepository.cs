using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace GunesMotel.DataAccess.Repositories
{
    public class PaymentRepository
    {
        public List<Payments> GetAll()
        {
            using (var context = new GunesMotelContext())
            {
                return context.Payments
                              .Include(p => p.Invoice.Reservation.Customer)
                              .Include(p => p.User)
                              .OrderByDescending(p => p.PaymentDate)
                              .ToList();
            }
        }

        public Payments GetById(int paymentId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Payments
                              .Include(p => p.Invoice.Reservation.Customer)
                              .Include(p => p.User)
                              .FirstOrDefault(p => p.PaymentID == paymentId);
            }
        }

        public List<Payments> GetByInvoiceId(int invoiceId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Payments
                    .Include(p => p.User)
                    .Where(p => p.InvoiceID == invoiceId)
                    .OrderBy(p => p.PaymentDate)
                    .ToList();
            }
        }

        public void Add(Payments payment)
        {
            using (var context = new GunesMotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // Ödemeyi ekle
                        context.Payments.Add(payment);
                        context.SaveChanges();

                        // Fatura durumunu güncelle
                        var invoiceRepo = new InvoiceRepository();
                        invoiceRepo.UpdateInvoiceStatus(payment.InvoiceID);

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Update(Payments payment)
        {
            using (var context = new GunesMotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var existing = context.Payments.Find(payment.PaymentID);
                        if (existing != null)
                        {
                            existing.Amount = payment.Amount;
                            existing.PaymentType = payment.PaymentType;
                            existing.Currency = payment.Currency;
                            existing.PaymentDate = payment.PaymentDate;

                            context.SaveChanges();

                            // Fatura durumunu güncelle
                            var invoiceRepo = new InvoiceRepository();
                            invoiceRepo.UpdateInvoiceStatus(existing.InvoiceID);
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Delete(int paymentId)
        {
            using (var context = new GunesMotelContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var payment = context.Payments.Find(paymentId);
                        if (payment != null)
                        {
                            int invoiceId = payment.InvoiceID;
                            context.Payments.Remove(payment);
                            context.SaveChanges();

                            // Fatura durumunu güncelle
                            var invoiceRepo = new InvoiceRepository();
                            invoiceRepo.UpdateInvoiceStatus(invoiceId);
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public decimal GetTotalPaymentsByInvoice(int invoiceId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Payments
                    .Where(p => p.InvoiceID == invoiceId)
                    .Sum(p => (decimal?)p.Amount) ?? 0;
            }
        }

        public List<Payments> GetPaymentsByDateRange(DateTime startDate, DateTime endDate)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Payments
                    .Include(p => p.Invoice.Reservation.Customer)
                    .Include(p => p.User)
                    .Where(p => p.PaymentDate.Date >= startDate.Date && p.PaymentDate.Date <= endDate.Date)
                    .OrderBy(p => p.PaymentDate)
                    .ToList();
            }
        }

        public List<object> GetPaymentSummaryByType(DateTime? startDate = null, DateTime? endDate = null)
        {
            using (var context = new GunesMotelContext())
            {
                var query = context.Payments.AsQueryable();

                if (startDate.HasValue)
                    query = query.Where(p => p.PaymentDate.Date >= startDate.Value.Date);

                if (endDate.HasValue)
                    query = query.Where(p => p.PaymentDate.Date <= endDate.Value.Date);

                return query.GroupBy(p => p.PaymentType)
                           .Select(g => new
                           {
                               PaymentType = g.Key,
                               TotalAmount = g.Sum(p => p.Amount),
                               Count = g.Count()
                           })
                           .OrderByDescending(x => x.TotalAmount)
                           .ToList<object>();
            }
        }

        public List<object> GetDailyPaymentSummary(DateTime? startDate = null, DateTime? endDate = null)
        {
            using (var context = new GunesMotelContext())
            {
                var query = context.Payments.AsQueryable();

                if (startDate.HasValue)
                    query = query.Where(p => p.PaymentDate.Date >= startDate.Value.Date);

                if (endDate.HasValue)
                    query = query.Where(p => p.PaymentDate.Date <= endDate.Value.Date);

                return query.GroupBy(p => System.Data.Entity.DbFunctions.TruncateTime(p.PaymentDate))
                           .Select(g => new
                           {
                               Date = g.Key,
                               TotalAmount = g.Sum(p => p.Amount),
                               Count = g.Count()
                           })
                           .OrderBy(x => x.Date)
                           .ToList<object>();
            }
        }
    }
}
