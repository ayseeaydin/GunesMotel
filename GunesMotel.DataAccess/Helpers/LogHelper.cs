using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GunesMotel.Entities;
using GunesMotel.DataAccess.Contexts;

namespace GunesMotel.DataAccess.Helpers
{
    public static class LogHelper
    {
        /// <summary>
        /// Veritabanına log kaydı ekler.
        /// </summary>
        public static void AddLog(int userId, string module, string action, string description)
        {
            try
            {                
                using (var context = new GunesMotelContext())
                {
                    var log = new Log
                    {
                        UserID = userId,
                        Module = module,
                        Action = action,
                        Description = description,
                        LogDate = DateTime.Now
                    };
                    context.Logs.Add(log);
                    context.SaveChanges();
                }   
            }
            catch(Exception ex)
            {
                // Loglama bile başarısızsa sadece debug'a yazsın, kullanıcıya gösterme
                System.Diagnostics.Debug.WriteLine("Log yazılamadı: " + ex.Message);
            }
        }
    }
}
