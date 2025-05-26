using System;
using GunesMotel.Entities;
using System.Collections.Generic;


namespace GunesMotel.DataAccess.Interfaces
{
    public interface IUserRepository : IRepository<Users>
    {
        List<Users> GetUsersWithIncludes(); // Role + Employee tablosuyla birlikte getirir
        bool UsernameExists(string username);  // Aynı kullanıcı adı var mı kontrol eder

    }
}
