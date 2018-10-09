using Group13.Webshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Service
{
    public interface IProductService
    {
        Product Create(Product product);

        void Delete(int id);

        Product ReadById(int id);

        List<Product> GetProducts();
    }
}
