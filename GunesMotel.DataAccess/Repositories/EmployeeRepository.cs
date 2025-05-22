using GunesMotel.DataAccess.Interfaces;
using GunesMotel.Entities;
using GunesMotel.DataAccess.Contexts;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace GunesMotel.DataAccess.Repositories
{
    // EmployeeRepository sınıfı hem GenericRepository'den miras alıyor (CRUD hazır)
    // hem de IEmployeeRepository arayüzünü uygulayarak özel metotlar tanımlıyor
    public class EmployeeRepository : GenericRepository<Employees>, IEmployeeRepository
    {
        // DbContext nesnesi: veritabanıyla bağlantı kurmak için kullanılır
        private readonly GunesMotelContext _context;

        // Constructor: DI (Dependency Injection) ile context alınır ve base sınıfa gönderilir
        public EmployeeRepository(GunesMotelContext context) : base(context)
        {
            _context = context;
        }
        // Aktif çalışanları ve pozisyonlarını getirir
        public List<Employees> GetActiveEmployeesWithPosition()
        {
            return _context.Employees
                .Include(e => e.Position) // Pozisyon bilgilerini de dahil et
                .Where(e => e.IsActive == true) // Sadece aktif çalışanları al
                .ToList();
        }
    }
}
