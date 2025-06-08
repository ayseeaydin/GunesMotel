using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace GunesMotel.DataAccess.Repositories
{
    public class RoomPriceRepository
    {
        private readonly GunesMotelContext _context;

        public RoomPriceRepository(GunesMotelContext context)
        {
            _context = context;
        }

        public List<RoomPrices> GetAll()
        {
            return _context.RoomPrices
                .Include(rp => rp.Room)
                .Include(rp => rp.Room.RoomType) // bu da gerekli!
                .Include(rp => rp.Season)
                .ToList();
        }

        public RoomPrices GetById(int id)
        {
            return _context.RoomPrices
                .Include(rp => rp.Room)
                .Include(rp => rp.Season)
                .FirstOrDefault(rp => rp.RoomPriceID == id);
        }

        public void Add(RoomPrices roomPrice)
        {
            roomPrice.LastUpdated = DateTime.Now;
            _context.RoomPrices.Add(roomPrice);
            _context.SaveChanges();
        }

        public void Update(RoomPrices roomPrice)
        {
            roomPrice.LastUpdated = DateTime.Now;
            _context.Entry(roomPrice).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(RoomPrices roomPrice)
        {
            _context.RoomPrices.Remove(roomPrice);
            _context.SaveChanges();
        }

        public List<RoomPrices> Search(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                return GetAll();

            keyword = keyword.ToLower();

            return _context.RoomPrices
                .Include(rp => rp.Room)
                .Include(rp => rp.Season)
                .Where(rp =>
                    rp.Room.RoomNumber.ToLower().Contains(keyword) ||
                    rp.Season.SeasonName.ToLower().Contains(keyword))
                .ToList();
        }

    }
}
