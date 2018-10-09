using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using Group13.Webshop.Core.Service;
using Group13.Webshop.Core.Service.impl;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Group13.Webshop.xUnitTests.Core.Service.impl
{
    public class KartServiceTest
    {
        private Mock<IKartRepository> kartsMock = new Mock<IKartRepository>();
        private Mock<IProductService> productssMock = new Mock<IProductService>();
        private Mock<IUserRepository> usersRepoMock = new Mock<IUserRepository>();

        private List<User> userList = new List<User>();

        public KartServiceTest()
        {
            usersRepoMock.Setup(x => x.CreateUser(It.IsAny<Kart>())).Callback<Kart>(k => userList.Add(k.User));
        }

        [Fact]
        public void CheckForUserCreated()
        {
            IUserService usersService = new UserService(usersRepoMock.Object);
            IKartService kartsService = new KartService(kartsMock.Object, usersService, productssMock.Object);

            Kart kart = new Kart();
            kartsService.Create(kart);
            Assert.True(userList.Count == 1);
            Assert.True(kart.User == userList.LastOrDefault());
        }
    }
}
