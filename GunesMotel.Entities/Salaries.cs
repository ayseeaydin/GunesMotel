using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities
{
    public class Salaries
    {
        public int SalaryID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SalaryAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? Description { get; set; }
    }
}
