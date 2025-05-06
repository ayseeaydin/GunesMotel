using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunesMotel.DataAccess.Interfaces
{
    // IRepository: Generic CRUD işlemlerini temsil eden arayüz
    public interface IRepository<T> where T : class
    {
        // Tüm kayıtları getir
        List<T> GetAll();

        // ID ile tek kayıt getir
        T? GetById(int id);

        // Yeni kayıt ekle
        void Add(T entity);

        // Var olan kaydı güncelle
        void Update(T entity);

        // ID ile kaydı sil
        void Delete(int id);
    }
}
