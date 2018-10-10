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
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _ProductService;

        public ProductsController(IProductService productService)
        {
            _ProductService = productService;
        }
        

        // GET api/Products/CurrentPage=int&ItemsPerPage=int
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get([FromQuery] Filter filter)
        {
            return _ProductService.GetFilteredProducts(filter);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return _ProductService.ReadById(id);
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product product)
        {
            return _ProductService.Create(product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public ActionResult<Product> Put(int id, [FromBody] Product value)
        {
            return _ProductService.Update(id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult<String> Delete(int id)
        {
            _ProductService.Delete(id);
            return "Product with id: " + id + "has been deleted.";
        }
    }
}
