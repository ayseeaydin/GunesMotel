using GunesMotel.Entities;
using GunesMotel.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GunesMotel.DataAccess.Contexts;
using System.Data.Entity;

namespace GunesMotel.DataAccess.Repositories
{
    public class SeasonRepository: GenericRepository<Seasons>, ISeasonRepository
    {
        private readonly GunesMotelContext _context;
        public SeasonRepository(GunesMotelContext context) : base(context)
        {
            _context = context; // Dependency injection ile alınan context
        }

        public SeasonRepository() : base(new GunesMotelContext())
        {
            _context = new GunesMotelContext();
        }

        // İsteğe bağlı: Sezon ismi kontrolü
        public bool SeasonNameExists(string seasonName)
        {
            return _context.Seasons.Any(s => s.SeasonName == seasonName);
        }
    }
}
