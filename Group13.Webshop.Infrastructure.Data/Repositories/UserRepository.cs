using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Group13.Webshop.Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private WebshopAppContext _ctx;

        public UserRepository(WebshopAppContext ctx)
        {
            _ctx = ctx;
        }

        public User CreateUser(User user)
        {
            var users = _ctx.Add(user).Entity;
            _ctx.SaveChanges();
            return users;
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User ReadById(int id)
        {
            return _ctx.Users.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<User> ReadUsers()
        {
            return _ctx.Users;
        }
    }
}
