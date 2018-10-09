using Group13.Webshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Repository
{
    public interface IKartRepository
    {
        Kart Create(Kart kart);

        void Delete(int id);

        void AddProducts(int id, int quant);

        Kart Get(int id);

        IEnumerable<Kart> ReadKarts();
    }
}
