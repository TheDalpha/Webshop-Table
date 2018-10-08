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
    public class ProductsController : ControllerBase
    {
        private IProductService _ProductService;

        public ProductsController(IProductService productService)
        {
            _ProductService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return null;
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Product> Get(int id)
        {
            return null;
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product value)
        {
            return null;
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product value)
        {
            return null;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<Product> Delete(int id)
        {
            return null;
        }
    }
}
