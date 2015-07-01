using BitAbridged.Models;
using BitAbridged.Repository;
using System.Collections.Generic;
using System.Linq;

namespace BitAbridged.Services
{
    public class DbService : IDbService
    {
        private IGenericRepository _repo;

        public DbService()
        {
            this._repo = new GenericRepository();
        }
        public DbService(IGenericRepository repo)
        {
            this._repo = repo;
        }
        public IList<Language> GetLanguages()
        {
            return _repo.Query<Language>().ToList();
        }

        public bool AddLanguage(Language lang)
        {
            _repo.Add(lang);
            _repo.SaveChanges();
            return true;
        }

        public IList<Details> GetDetails()
        {
            return _repo.Query<Details>().ToList();
        }
    }
}