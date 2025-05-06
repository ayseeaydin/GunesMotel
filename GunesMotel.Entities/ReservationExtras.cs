using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class ReservationExtras
    {
        [Key]
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice; // Otomatik hesaplama
    }
}
