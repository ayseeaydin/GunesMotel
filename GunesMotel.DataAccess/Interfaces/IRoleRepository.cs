using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GunesMotel.Entities;

namespace GunesMotel.DataAccess.Interfaces
{
    public interface IRoleRepository : IRepository<Roles>
    {
        List<Roles> GetAllOrdered();
    }
}
