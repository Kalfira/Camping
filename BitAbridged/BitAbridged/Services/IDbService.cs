using BitAbridged.Models;
using System.Collections.Generic;

namespace BitAbridged.Services
{
    public interface IDbService
    {
        IList<Language> GetLanguages();
        IList<Details> GetDetails();
    }
}
