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

        public void Add(Customers customer)
        {
            using (var context = new GunesMotelContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void Update(Customers updated)
        {
            using (var context = new GunesMotelContext())
            {
                var existing = context.Customers.Find(updated.CustomerID);
                if (existing != null)
                {
                    // Sadece güncellenebilir alanlar
                    existing.FullName = updated.FullName;
                    existing.NationalID = updated.NationalID;
                    existing.PassportNo = updated.PassportNo;
                    existing.BirthDate = updated.BirthDate;
                    existing.Gender = updated.Gender;
                    existing.Phone = updated.Phone;
                    existing.Email = updated.Email;
                    existing.Address = updated.Address;
                    existing.Notes = updated.Notes;

                    context.SaveChanges();
                }
            }
        }

        public bool IsNationalIDExists(string nationalID, int excludeCustomerId)
        {
            using var db = new GunesMotelContext();
            return db.Customers.Any(c => c.NationalID == nationalID && c.CustomerID != excludeCustomerId);
        }

        public void Delete(int customerId)
        {
            using (var context = new GunesMotelContext())
            {
                var customer = context.Customers.Find(customerId);
                if (customer != null)
                {
                    context.Customers.Remove(customer);
                    context.SaveChanges();
                }
            }
        }

    }
}
