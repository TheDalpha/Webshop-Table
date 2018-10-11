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
    public class UsersController : ControllerBase
    {
        private IUserService _UserService;

        public UsersController(IUserService userService)
        {
            _UserService = userService;
        }

        // GET api/Users?CurrentPage=int&ItemsPerPage=int
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get([FromQuery] Filter filter)
        {
            return _UserService.GetFilteredUsers(filter);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return _UserService.ReadById(id);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            _UserService.Delete(id);
            return "User with id " + id + " has been deleted.";
        }
    }
}
