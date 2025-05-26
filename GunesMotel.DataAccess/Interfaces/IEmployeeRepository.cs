using System;
using System.Collections.Generic;
using GunesMotel.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employees> GetActiveEmployeesWithPosition();
        List<Employees> GetAvailableEmployeesByPositionIDs(List<int> positionIds);

    }
}