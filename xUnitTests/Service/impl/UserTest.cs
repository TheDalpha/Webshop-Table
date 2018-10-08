using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using Group13.Webshop.Core.Service;
using Group13.Webshop.Core.Service.impl;
using Moq;
using System;
using Xunit;

namespace Group13.Webshop.xUnitTests.Service.impl
{
    public class UserTest
    {
        private Mock<IUserRepository> usersMock = new Mock<IUserRepository>();

        [Fact]
        public void CreateUserWhereKartIsNull()
        {
            IUserService userService = new UserService(usersMock.Object);
            
            Kart kart = null;

            try
            {
                userService.Create(kart);
                Assert.True(false);
            }
            catch (ArgumentNullException)
            {

            }
        }
    }
}
