using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Repositories
{
    public class AuthRepository
    {
        public Users ValidateUser(string username, string password)
        {
            using (var db = new GunesMotelContext())
            {
                return db.Users
                         .Include("Role")
                         .FirstOrDefault(u => u.Username == username && u.Password == password && u.IsActive);
            }
        }
    }
}
