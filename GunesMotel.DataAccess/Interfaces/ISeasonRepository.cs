using GunesMotel.Entities;
using System.Collections.Generic;


namespace GunesMotel.DataAccess.Interfaces
{
    public interface ISeasonRepository
    {
        bool SeasonNameExists(string seasonName);
    }
}
