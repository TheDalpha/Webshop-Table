using Group13.Webshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Service
{
    public interface IUserService
    {
        User Create(Kart kart);

        void Delete(int id);

        User ReadById(int id);

        List<User> GetUsers();
    }
}
