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
    public class UsersController : ControllerBase
    {
        private IUserService _UserService;

        public UsersController(IUserService userService)
        {
            _UserService = userService;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return null;
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<User> Get(int id)
        {
            return null;
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<User> Post([FromBody] User value)
        {
            return null;
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] User value)
        {
            return null;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id)
        {
            return null;
        }
    }
}
