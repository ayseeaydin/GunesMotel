using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Repositories
{
    public class ReservationGuestsRepository
    {
        public List<ReservationGuests> GetByReservationId(int reservationId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.ReservationGuests
                    .Where(rg => rg.ReservationID == reservationId)
                    .ToList();
            }
        }

        public void Add(ReservationGuests guest)
        {
            using (var context = new GunesMotelContext())
            {
                context.ReservationGuests.Add(guest);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new GunesMotelContext())
            {
                var entity = context.ReservationGuests.Find(id);
                if (entity != null)
                {
                    context.ReservationGuests.Remove(entity);
                    context.SaveChanges();
                }
            }
        }
    }
}
