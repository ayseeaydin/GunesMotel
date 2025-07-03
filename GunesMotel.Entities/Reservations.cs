using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class Reservations
    {
        [Key]
        public int ReservationID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public int UserID { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime ReservationDate { get; set; }
        public string? Source { get; set; }
        public string? Status { get; set; }
        public int GuestCount { get; set; }
        public string? Notes { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Rooms Room { get; set; }
        public virtual Users User { get; set; }

        public virtual ICollection<ReservationExtras> ReservationExtras { get; set; }
        public virtual ICollection<ReservationGuests> ReservationGuests { get; set; }
        public virtual ICollection<Invoices> Invoices { get; set; }

        public Reservations()
        {
            ReservationExtras = new HashSet<ReservationExtras>();
            ReservationGuests = new HashSet<ReservationGuests>();
            Invoices = new HashSet<Invoices>();
        }
    }    
}
