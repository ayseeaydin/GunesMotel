using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Interfaces
{
    public interface IRoomTypeRepository
    {
        List<RoomTypes> GetAll();
        RoomTypes GetById(int id);
        void Add(RoomTypes roomType);
        void Update(RoomTypes roomType);
        void Delete(int id);
        bool TypeNameExists(string typeName);
    }
}
