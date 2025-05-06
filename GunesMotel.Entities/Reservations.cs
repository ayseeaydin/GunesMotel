using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class Reservations
    {
        public int ReservationID { get; set; }
        public string CustomerID { get; set; }
        public int RoomID { get; set; }
        public int UserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? Source { get; set; }
        public string? Status { get; set; }
        public int GuestCount { get; set; }
        public string? Notes { get; set; }
    }    
}
