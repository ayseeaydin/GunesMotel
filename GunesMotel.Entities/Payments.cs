using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class Payments
    {
        [Key]
        public int PaymentID { get; set; }
        public int InvoiceID { get; set; }
        public decimal Amount { get; set; }
        public string PaymentType { get; set; } // Nakit, Kredi Kartı, Havale
        public string Currency { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ProcessedByUserID { get; set; }
    }
}
