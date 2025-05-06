using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GunesMotel.Entities
{
    public class Employees
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string? NationalID { get; set; }
        public string? PassportID {  get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int PositionID { get; set; }
        public string IBAN { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
