using System;
using System.Collections.Generic;
using System.Linq;
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
            User user = _UserRepo.ReadById(id);
            if (user != null && user.Id == id)
            {
                _UserRepo.DeleteUser(id);
            }
            else { throw new ArgumentException("The attempted deleted user does not exist and hasn't been deleted"); }
        }

        public List<User> GetUsers()
        {
            var userList = _UserRepo.GetUsers();
            return userList.ToList();
        }

        public User ReadById(int id)
        {
            User user = _UserRepo.ReadById(id);
            if (user.Id == id)
            {
                return user;
            }
            else { throw new ArgumentException("The user that is trying to be gotten doesn't exist."); }
        }
    }
}
