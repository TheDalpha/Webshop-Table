using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group13.Webshop.Infrastructure.Data.Repositories
{
    public class KartRepository : IKartRepository
    {
        private WebshopAppContext _ctx;

        private IProductRepository _productRepo;

        public KartRepository(WebshopAppContext ctx, IProductRepository productRepo)
        {
            _ctx = ctx;
            _productRepo = productRepo;
        }

        public void AddProducts(int id, int quant)
        {
            var kart = _ctx.Karts.LastOrDefault();
            for (int i = 0; i < quant; i++)
            {
                kart.Products.Add(_productRepo.ReadById(id));
            }
        }

        public Kart Create(Kart kart)
        {
            var kurt = _ctx.Add(kart).Entity;
            _ctx.SaveChanges();
            return kurt;
        }

        public void Delete(int id)
        {
            _ctx.Remove(new Kart { Id = id });
            _ctx.SaveChanges();
        }

        public Kart Get(int id)
        {
            var kart = _ctx.Karts.FirstOrDefault(k => k.Id == id);
            return kart;
        }


        public IEnumerable<Kart> ReadKarts()
        {
            return _ctx.Karts;
        }
    }
}
