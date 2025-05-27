using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GunesMotel.DataAccess.Interfaces;
using GunesMotel.Entities;
using GunesMotel.DataAccess.Contexts;

namespace GunesMotel.DataAccess.Repositories
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        private readonly GunesMotelContext _context;

        public RoomTypeRepository()
        {
            _context = new GunesMotelContext();
        }

        public List<RoomTypes> GetAll()
        {
            return _context.RoomTypes.OrderBy(rt => rt.TypeName).ToList();
        }

        public RoomTypes GetById(int id)
        {
            return _context.RoomTypes.Find(id);
        }

        public void Add(RoomTypes roomType)
        {
            _context.RoomTypes.Add(roomType);
            _context.SaveChanges();
        }

        public void Update(RoomTypes roomType)
        {
            _context.Entry(roomType).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var roomType = _context.RoomTypes.Find(id);
            if (roomType != null)
            {
                _context.RoomTypes.Remove(roomType);
                _context.SaveChanges();
            }
        }

        public bool TypeNameExists(string typeName)
        {
            return _context.RoomTypes.Any(r => r.TypeName.ToLower() == typeName.ToLower());
        }
    }
}

