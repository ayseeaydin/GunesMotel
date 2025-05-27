using GunesMotel.DataAccess.Contexts;
using GunesMotel.DataAccess.Interfaces;
using GunesMotel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace GunesMotel.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<Users>, IUserRepository
    {
        private readonly GunesMotelContext _context;
        public UserRepository(GunesMotelContext context) : base(context)
        {
            _context = context;
        }

        // Kullanıcıları ilişkili tablolarla birlikte getir
        public List<Users> GetUsersWithIncludes()
        {
            return _context.Users
                .Include(u => u.Employee)
                .Include(u => u.Role)
                .OrderBy(u=>u.Username)
                .ToList();
        }

        // belirli bir kullanıcı adı zaten var mı
        public bool UsernameExists(string username)
        {
            return _context.Users.Any(u => u.Username == username);
        }

        public void Add(Users user)
        {
            try
            {
                // Entity'yi context'e ekle
                _context.Users.Add(user);

                // Değişiklikleri kaydet
                _context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
            {
                // Entry'yi detach et
                var entry = _context.Entry(user);
                if (entry != null)
                {
                    entry.State = EntityState.Detached;
                }
                RefreshContext();
                throw new InvalidOperationException("Veri ekleme sırasında bir çakışma oluştu. Lütfen tekrar deneyin.");
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                // Entry'yi detach et
                var entry = _context.Entry(user);
                if (entry != null)
                {
                    entry.State = EntityState.Detached;
                }
                RefreshContext();

                // Daha anlamlı hata mesajları
                if (ex.InnerException?.InnerException?.Message?.Contains("UNIQUE") == true)
                {
                    throw new InvalidOperationException("Bu bilgiler zaten başka bir kayıtta kullanılıyor.");
                }
                else if (ex.InnerException?.InnerException?.Message?.Contains("FK_") == true)
                {
                    throw new InvalidOperationException("Seçilen rol veya çalışan bilgisi geçersiz.");
                }
                throw;
            }
            catch (Exception)
            {
                // Entry'yi detach et
                var entry = _context.Entry(user);
                if (entry != null)
                {
                    entry.State = EntityState.Detached;
                }
                RefreshContext();
                throw;
            }
        }

        // Kullanıcı güncelleme - Concurrency sorununu çöz
        public override void Update(Users user)
        {
            try
            {
                // Önce veritabanından güncel veriyi al
                var existingUser = _context.Users.Find(user.UserID);
                if (existingUser == null)
                {
                    throw new InvalidOperationException("Kullanıcı bulunamadı veya başka bir kullanıcı tarafından silindi.");
                }

                // Değerleri güncelle
                existingUser.Username = user.Username;
                existingUser.Password = user.Password;
                existingUser.FullName = user.FullName;
                existingUser.Email = user.Email;
                existingUser.Phone = user.Phone;
                existingUser.RoleID = user.RoleID;
                existingUser.EmployeeID = user.EmployeeID;
                existingUser.IsActive = user.IsActive;

                _context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
            {
                RefreshContext();
                throw new InvalidOperationException("Bu kayıt başka bir kullanıcı tarafından değiştirildi. Lütfen sayfayı yenileyip tekrar deneyin.");
            }
            catch (Exception)
            {
                RefreshContext();
                throw;
            }
        }

        // ID ile kullanıcı getir - Fresh data
        public override Users GetById(int id)
        {
            try
            {
                RefreshContext();
                return _context.Users.Find(id);
            }
            catch (Exception)
            {
                RefreshContext();
                throw;
            }
        }

        // Context'i yenileme metodu
        private void RefreshContext()
        {
            try
            {
                foreach (var entry in _context.ChangeTracker.Entries())
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                        case EntityState.Deleted:
                            entry.State = EntityState.Detached;
                            break;
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                // Hata durumunda sessizce devam et
                // Context temizlenmiş olacak
            }
        }

        // Override dispose metodu
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // UserRepository'ye özgü temizlik işlemleri burada yapılabilir
            }
            base.Dispose(disposing); // Parent class'ın dispose metodunu çağır
        }
    }
}
