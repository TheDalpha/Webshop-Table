﻿using Group13.Webshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Repository
{
    public interface IProductRepository
    {
        Product CreateProduct(Product product);

        void DeleteProduct(int id);

        Product ReadById(int id);

        void Update(Product oldPro);

        IEnumerable<Product> ReadProducts(Filter filter = null);
    }
}
