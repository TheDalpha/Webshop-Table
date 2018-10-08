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

        public User Create()
        {
            return _UserRepo.CreateUser();
        }

        public void Delete(int id)
        {
            _UserRepo.DeleteUser(id);
        }
    }
}
