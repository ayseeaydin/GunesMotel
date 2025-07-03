using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities.DTOs
{
    public class InvoiceListDTO
    {
        public int InvoiceID { get; set; }
        public string CustomerName { get; set; }
        public string RoomNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
