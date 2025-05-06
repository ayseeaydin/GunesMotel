using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class Invoices
    {
        public int InvoiceID { get; set; }
        public int ReservationID { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int? CreatedByUserID { get; set; }
    }
}
