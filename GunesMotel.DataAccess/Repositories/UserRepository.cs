using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Interfaces;
using GunesMotel.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace GunesMotel.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        private readonly GunesMotelContext _context;
        public UserRepository(GunesMotelContext context) : base(context)
        {
            _context = context;
        }

        // Kullanıcıları ilişkili tablolarla birlikte getir
        public List<Users> GetUsersWithIncludes()
        {
            return _context.Users
                .Include(u => u.Employee)
                .Include(u => u.Role)
                .OrderBy(u=>u.Username)
                .ToList();
        }

        // belirli bir kullanıcı adı zaten var mı
        public bool UsernameExists(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }
    }
}
