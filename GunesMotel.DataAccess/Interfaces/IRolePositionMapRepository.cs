using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Interfaces
{
    public interface IRolePositionMapRepository
    {
        List<int> GetPositionIdsByRoleId(int roleId);
    }
}
