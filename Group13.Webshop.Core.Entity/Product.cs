using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Double Price { get; set; }

        public String ImageLink { get; set; }

        public String Description { get; set; }

        public int Quantity { get; set; }

        public Double Height { get; set; }

        public Double Width { get; set; }

        public Double Length { get; set; }
    }
}
