using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class Positions
    {
        [Key]
        public int PositionID { get; set; }
        public string PositionName { get; set; }
    }
}
