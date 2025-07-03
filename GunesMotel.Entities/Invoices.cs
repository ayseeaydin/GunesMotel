using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace GunesMotel.Entities
{
    public class Invoices
    {
        [Key]
        public int InvoiceID { get; set; }
        public int ReservationID { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? CreatedByUserID { get; set; }

        public virtual Reservations Reservation { get; set; }
        // public virtual Users User { get; set; }
        public virtual ICollection<InvoiceItems> InvoiceItems { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }

        public Invoices()
        {
            InvoiceItems = new HashSet<InvoiceItems>();
            Payments = new HashSet<Payments>();
            InvoiceDate = DateTime.Now;
            Status = "Bekliyor";
        }

        // Calculated properties
        public decimal TotalPaid
        {
            get
            {
                return Payments?.Sum(p => p.Amount) ?? 0;
            }
        }

        public decimal RemainingAmount
        {
            get
            {
                return TotalAmount - TotalPaid;
            }
        }

        public bool IsFullyPaid
        {
            get
            {
                return TotalPaid >= TotalAmount;
            }
        }

        public class PaymentsUpdated
        {
            [Key]
            public int PaymentID { get; set; }
            public int InvoiceID { get; set; }
            public decimal Amount { get; set; }
            public string PaymentType { get; set; } // "Nakit", "Kredi Kartı", "Havale", "EFT"
            public string Currency { get; set; } // "TRY", "USD", "EUR"
            public DateTime PaymentDate { get; set; }
            public int ProcessedByUserID { get; set; }

            // Navigation Properties
            public virtual Invoices Invoice { get; set; }
            public virtual Users User { get; set; }

            public PaymentsUpdated()
            {
                PaymentDate = DateTime.Now;
                Currency = "TRY";
            }
        }
    }
}
