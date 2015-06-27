using BitAbridged.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BitAbridged.Controllers.api
{
    public class LanguageController : ApiController
    {
        [Route("api/language/{search}")]
        public IList<Language> Get(string search)
        {
            List<Language> languages = Get();
            return languages.Where(f => f.Name.StartsWith(search, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        [Route("api/language")]
        public List<Language> Get()
        {
            List<Language> languages = new List<Language>()
            {
                new Language{Id = 1, Info = new List<string>(){"Compiled", "Kickass!"}, Name = "C#"},
                new Language{Id = 2,Info = new List<string>(){"Interpreted", "Weird Looking"}, Name = "Python"},
                new Language{Id = 3,Info = new List<string>(){"Functional", "For geniuses only, stay away!"}, Name = "Haskell"}
            };
            return languages;
        }
    }
}
