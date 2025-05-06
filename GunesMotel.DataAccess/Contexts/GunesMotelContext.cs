using System;
using System.Data.Entity;
using GunesMotel.Entities;


namespace GunesMotel.DataAccess.Contexts
{
    // Veritabanı bağlantısı ve tabloları temsil eden sınıf
    public class GunesMotelContext : DbContext
    {
        // Constructor: Veritabanı bağlantı cümlesini alır (web.config veya app.config'den)
        public GunesMotelContext(): base("name=GunesMotelContext") { }

        // DbSet<T>: Her tabloyu temsil eder
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; } 
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Salaries>  Salaries { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<RoomTypes> RoomTypes { get; set; }
        public DbSet<Rooms> Rooms { get; set; }
        public DbSet<RoomPrices> RoomPrices { get; set; }
        public DbSet<ExtraServices> ExtraServices { get; set; }
        public DbSet<ExtraServicePrices> ExtraServicePrices { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<ReservationGuests> ReservationGuests { get; set; }
        public DbSet<ReservationExtras> ReservationExtras { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<InvoiceItems> InvoiceItems { get; set; }
        public DbSet<Payments> Payments { get; set; }
    }
}
