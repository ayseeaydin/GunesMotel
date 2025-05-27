using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class RoomTypes
    {
        [Key]
        public int RoomTypeID { get; set; }
        public string Feature { get; set; }
        public string TypeName { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
