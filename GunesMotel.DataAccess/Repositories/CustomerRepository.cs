using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Repositories
{
    public class CustomerRepository
    {
        public List<Customers> GetAll()
        {
            using var db = new GunesMotelContext();
            return db.Customers.OrderByDescending(c => c.CustomerID).ToList();
        }
    }
}
