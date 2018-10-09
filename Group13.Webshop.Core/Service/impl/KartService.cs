using System;
using System.Collections.Generic;
using System.Text;
using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;

namespace Group13.Webshop.Core.Service.impl
{
    public class KartService : IKartService
    {
        private IKartRepository _KartRepo;
        private IUserService _UserService;
        private IProductService _ProductService;

        public KartService (IKartRepository kartRepo, IUserService userService, IProductService productService)
        {
            _KartRepo = kartRepo;
            _UserService = userService;
            _ProductService = productService;
        }

        public void AddProduct(int id, int quant)
        {
            if (_ProductService.ReadById(id).Quantity >= quant)
            {
                _KartRepo.AddProducts(id, quant);
            }
            else { throw new ArgumentException("The selected quantity is higher than what is currently in stock."); }
        }

        public Kart Create(Kart kart)
        {
            Kart kurt = _KartRepo.Create(kart);
            _UserService.Create(kart);

            return kart;
        }

        public void Delete(int id)
        {
            _KartRepo.Delete(id);
        }

        public Kart Get(int id)
        {
            return _KartRepo.Get(id);
        }
    }
}
