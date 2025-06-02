using GunesMotel.Entities;
using System.Collections.Generic;

namespace GunesMotel.DataAccess.Interfaces
{
    public interface IRoomRepository
    {
        List<Rooms> GetAll();
        Rooms GetById(int id);
        void Add(Rooms room);
        void Update(Rooms room);
        void Delete(int id);
        bool IsRoomNumberExists(string roomNumber);
    }
}
