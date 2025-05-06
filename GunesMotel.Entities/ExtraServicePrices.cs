using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class ExtraServicePrices
    {
        public int PriceID { get; set; }
        public int ServiceID { get; set; }
        public int SeasonID { get; set; }
        public decimal Price { get; set; }
        public DateTime LastUpdated { get; set; }

    }
}
