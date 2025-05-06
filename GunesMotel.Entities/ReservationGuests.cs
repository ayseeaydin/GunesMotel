using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class ReservationGuests
    {
        public int ID { get; set; }
        public int ReservationID { get; set; }
        public int CustomerID { get; set; }
    }
}
