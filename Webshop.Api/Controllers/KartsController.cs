using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Webshop.Api.Controllers
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

        // GET: api/Karts
        [HttpGet]
        public ActionResult<IEnumerable<Kart>> Get()
        {
            return _KartService.GetKarts();
        }

        // GET: api/Karts/5
        [HttpGet("{id}")]
        public ActionResult<Kart> Get(int id)
        {
            return null;
        }

        // POST: api/Karts
        [HttpPost]
        public ActionResult<Kart> Post([FromBody] Kart value)
        {
            return null;
        }

        // PUT: api/Karts/5
        [HttpPut("{id}")]
        public ActionResult<Kart> Put(int id, [FromBody] Kart value)
        {
            return null;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Kart> Delete(int id)
        {
            return null;
        }
    }
}
