using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class Roles
    {
        [Key] // Bu property Primary Key' dir. 
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
