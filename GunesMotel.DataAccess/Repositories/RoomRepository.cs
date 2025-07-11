﻿using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Interfaces;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using GunesMotel.Entities.DTOs;

namespace GunesMotel.DataAccess.Repositories
{
    public class RoomRepository: IRoomRepository
    {
        public void Add(Rooms room)
        {
            using var context = new GunesMotelContext();
            context.Rooms.Add(room);
            context.SaveChanges();
        }

        public void Update(Rooms room)
        {
            using var context = new GunesMotelContext();
            var entity = context.Rooms.Find(room.RoomID);
            if (entity != null)
            {
                entity.RoomNumber = room.RoomNumber;
                entity.RoomTypeID = room.RoomTypeID;
                entity.Status = room.Status;
                entity.Description = room.Description;
                entity.Floor = room.Floor;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using var context = new GunesMotelContext();
            var room = context.Rooms.Find(id);
            if (room != null)
            {
                context.Rooms.Remove(room);
                context.SaveChanges();
            }
        }

        public List<Rooms> GetAll()
        {
            using var context = new GunesMotelContext();
            return context.Rooms.ToList();
        }

        public Rooms GetById(int id)
        {
            using var context = new GunesMotelContext();
            return context.Rooms.Find(id);
        }

        public bool IsRoomNumberExists(string roomNumber)
        {
            using var context = new GunesMotelContext();
            return context.Rooms.Any(r => r.RoomNumber == roomNumber);
        }

        public List<dynamic> GetAllWithRoomType()
        {
            using (var context = new GunesMotelContext())
            {
                var result = (from r in context.Rooms
                              join rt in context.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                              select new
                              {
                                  r.RoomID,
                                  r.RoomNumber,
                                  RoomTypeName = rt.TypeName,
                                  RoomFeature = rt.Feature,
                                  r.Floor,
                                  r.Status,
                                  r.Description
                              })
                              .OrderByDescending(x => x.RoomID)
                              .ToList<dynamic>();

                return result;
            }
        }

        public List<RoomStatusDTO> GetRoomStatuses()
        {
            using var context = new GunesMotelContext();
            var today = DateTime.Today;

            // Bugünkü aktif rezervasyonlara göre dolu odaları al
            var doluOdalar = context.Reservations
                .Where(r => r.CheckInDate <= today && r.CheckOutDate >= today)
                .Select(r => r.RoomID)
                .Distinct()
                .ToList();

            var roomStatuses = context.Rooms
                .Include(r => r.RoomType)
                .Select(r => new RoomStatusDTO
                {
                    RoomID = r.RoomID,
                    RoomNumber = r.RoomNumber,
                    RoomTypeName = r.RoomType.TypeName, // dikkat: RoomTypeName değilse burada TypeName olmalı
                    Floor = r.Floor.HasValue ? r.Floor.Value.ToString() : "Belirtilmemiş",
                    Status = doluOdalar.Contains(r.RoomID) ? "Dolu" : "Boş"
                })
                .OrderBy(r => r.Floor)
                .ThenBy(r => r.RoomNumber)
                .ToList();

            return roomStatuses;
        }
    }
}
