﻿using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group13.Webshop.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private WebshopAppContext _ctx;

        public ProductRepository(WebshopAppContext ctx)
        {
            _ctx = ctx;
        }

        public Product CreateProduct(Product product)
        {
            var prod = _ctx.Add(product).Entity;
            _ctx.SaveChanges();
            return prod;
        }

        public void DeleteProduct(int id)
        {
            _ctx.Remove(new Product {Id = id});
            _ctx.SaveChanges();
        }

        public Product ReadById(int id)
        {
            return _ctx.Products.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Product> ReadProducts(Filter filter)
        {
            if (filter == null)
            {
                return _ctx.Products;
            }
            return _ctx.Products.Skip((filter.CurrentPage - 1) * filter.ItemsPerPage).Take(filter.ItemsPerPage);
        }

        public void Update(Product oldPro)
        {
            _ctx.Update(oldPro);
            _ctx.SaveChanges();
        }
    }
}
