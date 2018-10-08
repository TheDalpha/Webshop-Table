using Group13.Webshop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group13.Webshop.Core.Repository
{
    public interface IUserRepository
    {
        User CreateUser(Kart kart);

        void DeleteUser(int id);

        User ReadById(int id);
    }
}
