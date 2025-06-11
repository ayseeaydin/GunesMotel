using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities.DTOs
{
    public class RoomStatusDTO
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomTypeName { get; set; }
        public string Floor { get; set; }
        public string Status { get; set; } // "Boş", "Dolu", "Temizlikte"
    }
}
