using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Interfaces;
using GunesMotel.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Repositories
{
    public class RoleRepository : GenericRepository<Roles>, IRoleRepository
    {
       private readonly GunesMotelContext _context;
        // Constructor DbContext i alır ve base class a gönderir
        public RoleRepository(GunesMotelContext context) : base(context)
        {
            _context = context;
        }

        public List<Roles> GetAllOrdered()
        {
            return _context.Roles.OrderBy(r => r.RoleName).ToList();
        }


    }
}
