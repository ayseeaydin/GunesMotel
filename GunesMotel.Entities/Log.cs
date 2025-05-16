using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class Log
    {
        [Key]
        public int LogID { get; set; }
        public int UserID { get; set; }
        public DateTime LogDate { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
    }
}
