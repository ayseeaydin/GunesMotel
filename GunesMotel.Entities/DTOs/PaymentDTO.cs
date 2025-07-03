using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.Entities.DTOs
{
    public class PaymentDTO
    {
        public decimal Amount { get; set; }
        public string PaymentType { get; set; }
        public string Currency { get; set; }
        public DateTime PaymentDate { get; set; }
        public string UserName { get; set; }
    }
}
