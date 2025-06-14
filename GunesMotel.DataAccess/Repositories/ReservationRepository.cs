using GunesMotel.DataAccess.Contexts;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace GunesMotel.DataAccess.Repositories
{
    public class ReservationRepository
    {
        public List<Reservations> GetAll()
        {
            using (var context = new GunesMotelContext())
            {
                return context.Reservations
                              .Include(r => r.Customer)
                              .Include(r => r.Room)
                              .Include(r => r.User)
                              .OrderByDescending(r => r.ReservationDate)
                              .ToList();
            }
        }

        public Reservations GetById(int reservationId)
        {
            using (var context = new GunesMotelContext())
            {
                return context.Reservations
                              .Include(r => r.Customer)
                              .Include(r => r.Room)
                              .Include(r => r.User)
                              .FirstOrDefault(r => r.ReservationID == reservationId);
            }
        }

        public void Add(Reservations reservation)
        {
            using (var context = new GunesMotelContext())
            {
                context.Reservations.Add(reservation);
                context.SaveChanges();
            }
        }

        public void Update(Reservations reservation)
        {
            using (var context = new GunesMotelContext())
            {
                var existing = context.Reservations.Find(reservation.ReservationID);
                if (existing != null)
                {
                    existing.CustomerID = reservation.CustomerID;
                    existing.RoomID = reservation.RoomID;
                    existing.UserID = reservation.UserID;
                    existing.CheckInDate = reservation.CheckInDate;
                    existing.CheckOutDate = reservation.CheckOutDate;
                    existing.ReservationDate = reservation.ReservationDate;
                    existing.Status = reservation.Status;
                    existing.Source = reservation.Source;
                    existing.GuestCount = reservation.GuestCount;
                    existing.Notes = reservation.Notes;

                    context.SaveChanges();
                }
            }
        }

        public void Delete(int reservationId)
        {
            using (var context = new GunesMotelContext())
            {
                var reservation = context.Reservations.Find(reservationId);
                if (reservation != null)
                {
                    context.Reservations.Remove(reservation);
                    context.SaveChanges();
                }
            }
        }
    }
}
