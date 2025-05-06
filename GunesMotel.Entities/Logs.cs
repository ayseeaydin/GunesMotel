using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class Logs
    {
        public int LogID { get; set; }
        public int UserID { get; set; }
        public DateTime LogDate { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public string Description { get; set; }
    }
}
