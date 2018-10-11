using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webshop.REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KartsController : ControllerBase
    {
        private IKartService _KartService;

        public KartsController(IKartService kartService)
        {
            _KartService = kartService;
        }

        // GET: api/Karts?CurrentPage=int&ItemsPerPage=int
        [HttpGet]
        public ActionResult<IEnumerable<Kart>> Get([FromQuery] Filter filter)
        {
            return _KartService.GetFilteredKarts(filter);
        }

        // GET: api/Karts/5
        [HttpGet("{id}")]
        public ActionResult<Kart> Get(int id)
        {
            return _KartService.Get(id);
        }

        // POST: api/Karts
        [HttpPost]
        public ActionResult<Kart> Post([FromBody] Kart value)
        {
            return _KartService.Create(value);
        }

        // PUT: api/Karts/5
        [HttpPut("{id}")]
        public ActionResult<Kart> Put(int id, [FromBody] Kart value)
        {
            return null;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            _KartService.Delete(id);
            return "Shopping kart with id " + id + " has been deleted.";
        }
    }
}
