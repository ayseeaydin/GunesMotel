using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class RoomTypes
    {
        public int RoomTypeID { get; set; }
        public string Feature { get; set; }
        public string TypeName { get; set; }
        public string? Description { get; set; }
    }
}
