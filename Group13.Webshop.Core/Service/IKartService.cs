using Group13.Webshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Service
{
    public interface IKartService
    {
        Kart Create(Kart kart);

        void Delete(int id);

        void AddProduct(int id, int quant);

        Kart Get(int id);

        List<Kart> GetKarts();
    }
}
