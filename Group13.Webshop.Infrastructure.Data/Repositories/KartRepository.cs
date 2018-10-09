using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Infrastructure.Data.Repositories
{
    public class KartRepository : IKartRepository
    {
        private WebshopAppContext _ctx;

        public KartRepository(WebshopAppContext ctx)
        {
            _ctx = ctx;
        }

        public void AddProducts(int id, int quant)
        {
            
        }

        public Kart Create()
        {
            throw new NotImplementedException();
        }

        public Kart Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Kart Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
