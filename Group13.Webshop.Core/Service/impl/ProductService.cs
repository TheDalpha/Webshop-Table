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

        public List<Product> GetFilteredProducts(Filter filter)
        {
            return _ProductRepo.ReadProducts(filter).ToList();
        }

        public List<Product> GetProducts()
        {
            return _ProductRepo.ReadProducts().ToList();
        }

        public Product ReadById(int id)
        {
            return _ProductRepo.ReadById(id);
        }

        public Product Update(int id, Product value)
        {
            var oldPro = ReadById(id);
            if (value.Name != null)
            {
                oldPro.Name = value.Name;
            }
            if (value.Description != null)
            {
                oldPro.Description = value.Description;
            }
            if (value.ImageLink != null)
            {
                oldPro.ImageLink = value.ImageLink;
            }
            oldPro.Length = value.Length;
            oldPro.Height = value.Height;
            oldPro.Width = value.Width;
            oldPro.Quantity = value.Quantity;

            _ProductRepo.Update(oldPro);
            return oldPro;
        }
    }
}
