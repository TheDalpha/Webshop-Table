using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;

namespace Group13.Webshop.Core.Service.impl
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _ProductRepo;

        public ProductService(IProductRepository productRepository)
        {
            _ProductRepo = productRepository;
        }

        public Product Create(Product product)
        {
            return _ProductRepo.CreateProduct(product);
        }

        public void Delete(int id)
        {
            _ProductRepo.DeleteProduct(id);
        }

        public List<Product> GetProducts()
        {
            var productList = _ProductRepo.ReadProducts();
            return productList.ToList();
        }

        public Product ReadById(int id)
        {
            return _ProductRepo.ReadById(id);
        }
    }
}
