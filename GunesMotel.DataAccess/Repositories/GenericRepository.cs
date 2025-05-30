﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GunesMotel.DataAccess.Interfaces;

namespace GunesMotel.DataAccess.Repositories
{
    // Tüm veri erişim işlemleri için temel generic repository
    public class GenericRepository<T> : IRepository<T>, IDisposable where T : class
    {
        // Sadece bu sınıf içinde değiştirilebilir ama dışarıdan erişilemez
        // Sadece constructor içinde atanabilir, sonradan değiştirilemez
        protected readonly DbContext _context;

        // İlgili tabloyu temsil eder (örneğin: _dbSet = context.Employees)
        protected readonly DbSet<T> _dbSet;

        // Constructor: DbContext dependency injection ile alınır.
        // Constructor: Dışarıdan bir DbContext alır ve DbSet<T>'i hazırlar
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>(); // Tablonun tipi neyse onu alır (örneğin: context.Set<Employee>())
        }

        // Veritabanındaki tüm kayıtları listele (SELECT * FROM ...)
        public virtual List<T> GetAll()
        {
            return _dbSet.ToList(); // IQueryable → List dönüşümü
        }

        // ID'si verilen kaydı getir (primary key üzerinden Find yapılır)
        public virtual T? GetById(int id)
        {
            return _dbSet.Find(id); // Entity Framework Find ile ID'ye göre getirir
        }

        // Yeni kayıt ekle
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);         // DbSet'e yeni nesne eklenir
            _context.SaveChanges();     // Değişiklikler veritabanına kaydedilir
        }

        // Mevcut kaydı güncelle
        public virtual void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified; // Nesneye "değişti" olarak işaret verilir
            _context.SaveChanges(); // Güncelleme işlemi uygulanır
        }

        // Belirtilen ID'li kaydı sil
        public virtual void Delete(int id)
        {
            var entity = _dbSet.Find(id);  // İlk olarak kaydı bul
            if (entity != null)            // Varsa sil
            {
                _dbSet.Remove(entity);     // DbSet'ten çıkar
                _context.SaveChanges();    // Değişiklikleri uygula
            }
        }

        // IDisposable implementation
        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
