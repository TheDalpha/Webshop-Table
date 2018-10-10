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
        private Mock<IProductService> productsServiceMock = new Mock<IProductService>();
        private Mock<IProductService> productsRepoMock = new Mock<IProductService>();
        private Mock<IUserService> usersServiceMock = new Mock<IUserService>();
        private Mock<IUserRepository> usersRepoMock = new Mock<IUserRepository>();

        private List<User> userList = new List<User>();
        private List<Product> productList = new List<Product>();

        public KartServiceTest()
        {
            usersRepoMock.Setup(x => x.CreateUser(It.IsAny<User>(), It.IsAny<Kart>()))
                .Callback<User, Kart>((u, k) => {
                    userList.Add(k.User);
                    u.ShoppingKart = k;
                });

            productsServiceMock.Setup(x => x.ReadById(It.IsAny<int>()))
                .Callback<int>(i => productList.FirstOrDefault(p => p.Id == i));
        }

        [Fact]
        public void CheckForUserCreated()
        {
            IUserService usersService = new UserService(usersRepoMock.Object);
            IKartService kartsService = new KartService(kartsMock.Object, usersService, productsServiceMock.Object);

            Kart kart = new Kart();
            kartsService.Create(kart);
            Assert.True(userList.Count == 1);
            Assert.True(kart.User == userList.LastOrDefault());
        }

        [Theory]
        [InlineData(1, "One Table", 6)]
        [InlineData(2, "Two Table", 5)]
        public void CheckValidAddedProductsAddedToKart(int id, string name, int quant)
        {
            IKartService kartsService = new KartService(kartsMock.Object, usersServiceMock.Object, productsServiceMock.Object);

            Kart kart = new Kart();
            Product product = new Product
            {
                Id = id,
                Name = name,
                Quantity = quant
            };

            kartsService.AddProduct(id, 5);
        }

        [Theory]
        [InlineData(1, "One Table", -1)]
        [InlineData(2, "Two Table", 4)]
        public void CheckInvalidAddedProductsAddedToKart(int id, string name, int quant)
        {
            IKartService kartsService = new KartService(kartsMock.Object, usersServiceMock.Object, productsServiceMock.Object);

            Kart kart = new Kart();
            Product product = new Product
            {
                Id = id,
                Name = name,
                Quantity = quant
            };

            try
            {
                kartsService.AddProduct(id, 5);
                Assert.True(false);
            }
            catch (ArgumentException) { }
        }
    }
}
