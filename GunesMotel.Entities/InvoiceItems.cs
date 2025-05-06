using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class InvoiceItems
    {
        [Key]
        public int ItemID { get; set; }
        public int InvoiceID { get; set; }
        public string ItemType { get; set; } // "Room" veya "Extra"
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;
    }
}
