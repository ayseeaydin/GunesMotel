using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Repositories
{
    public class RolePositionMapRepository : IRolePositionMapRepository
    {
        private readonly GunesMotelContext _context;

        public RolePositionMapRepository()
        {
            _context = new GunesMotelContext();
        }

        public List<int> GetPositionIdsByRoleId(int roleId)
        {
            return _context.RolePositionMap
                           .Where(rpm => rpm.RoleID == roleId)
                           .Select(rpm => rpm.PositionID)
                           .ToList();
        }
    }
}
