using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class ExtraServices
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<ReservationExtras> ReservationExtras { get; set; }
        public virtual ICollection<ExtraServicePrices> ExtraServicePrices { get; set; }

        public ExtraServices()
        {
            ReservationExtras = new HashSet<ReservationExtras>();
            ExtraServicePrices = new HashSet<ExtraServicePrices>();
        }
    }
}
