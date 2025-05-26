using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }    
        public string Email { get; set; }
        public string Phone { get; set; }
        public int RoleID { get; set; }
        public int EmployeeID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;

        // Navigation property ler (ilişkili tablo)
        public virtual Employees Employee { get; set; }
        public virtual Roles Role { get; set; }
    }
}
