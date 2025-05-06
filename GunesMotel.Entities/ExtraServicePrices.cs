using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class ExtraServicePrices
    {
        [Key]
        public int PriceID { get; set; }
        public int ServiceID { get; set; }
        public int SeasonID { get; set; }
        public decimal Price { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
