using System;
using System.Collections.Generic;
using System.Text;
using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;

namespace Group13.Webshop.Core.Service.impl
{
    public class UserService : IUserService
    {
        readonly IUserRepository _UserRepo;

        public UserService(IUserRepository userRepo)
        {
            _UserRepo = userRepo;
        }

        public User Create(Kart kart)
        {
            if (kart == null)
            {
                throw new ArgumentNullException("Kart doesn't exist and temporary user hasn't been created");
            }
            User user = new User
            {
                ShoppingKart = kart
            };
            return _UserRepo.CreateUser(user, kart);
        }

        public void Delete(int id)
        {
            _UserRepo.DeleteUser(id);
        }

        public User ReadById(int id)
        {
            return _UserRepo.ReadById(id);
        }
    }
}
