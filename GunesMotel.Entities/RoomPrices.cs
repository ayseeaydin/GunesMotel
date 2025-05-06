using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class RoomPrices
    {
        public int RoomPriceID { get; set; }
        public int RoomID { get; set; }
        public int SeasonID { get; set; }
        public decimal Price { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
