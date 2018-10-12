using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Entity
{
    public class Kart
    {
        public int Id { get; set; }

        public List<Product> Products { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
    }
}
