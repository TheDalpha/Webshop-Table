using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Entity
{
    public class User
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public Kart ShoppingKart{ get; set; }
    }
}
