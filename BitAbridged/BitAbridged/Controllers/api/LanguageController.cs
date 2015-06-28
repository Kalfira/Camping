using BitAbridged.Models;
using BitAbridged.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace BitAbridged.Controllers.api
{
    public class LanguageController : ApiController
    {
        private static IDbService _service;

        public LanguageController()
        {
            _service = new DbService();
        }
        public LanguageController(IDbService service)
        {
            _service = service;
        }
        [HttpGet]
        public IList<Details> Details()
        {
            return _service.GetDetails();
        }

        [Route("api/language")]
        public IList<Language> Get()
        {
            return _service.GetLanguages();
        }
    }
}
