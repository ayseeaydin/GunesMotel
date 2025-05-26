using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    [Table("RolePositionMap")]
    public class RolePositionMap
    {
        [Key]
        public int RolePositionMapID { get; set; }
        public int RoleID { get; set; }
        public int PositionID { get; set; }
        // Navigation properties
        public virtual Roles Role { get; set; }
        public virtual Positions Position { get; set; }
        // Constructor
        public RolePositionMap()
        {
            Role = new Roles();
            Position = new Positions();
        }
    }
}
