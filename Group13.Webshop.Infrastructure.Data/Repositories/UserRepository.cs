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

        public User CreateUser(User user, Kart kart)
        {
            var users = _ctx.Add(user).Entity;
            users.ShoppingKart = kart;
            _ctx.SaveChanges();
            return users;
        }

        public void DeleteUser(int id)
        {
            _ctx.Remove(new User { Id = id });
            _ctx.SaveChanges();
        }

        public IEnumerable<User> GetUsers()
        {
            return _ctx.Users;
        }

        public User ReadById(int id)
        {
            return _ctx.Users.FirstOrDefault(u => u.Id == id);
        }

        public IEnumerable<User> ReadUsers()
        {
            return _ctx.Users;
        }
    }
}
