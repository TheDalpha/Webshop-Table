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
        private Mock<IProductRepository> productsRepoMock = new Mock<IProductRepository>();
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
                .Returns(() => productList.First());
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
        [InlineData(1, 6)]
        [InlineData(2, 5)]
        public void CheckValidAddedProductsAddedToKart(int id, int quant)
        {
            IKartService kartsService = new KartService(kartsMock.Object, usersServiceMock.Object, productsServiceMock.Object);
            
            Product product = new Product
            {
                Id = id,
                Quantity = quant
            };

            productList.Add(product);
            kartsService.AddProduct(id, 5);
        }

        [Theory]
        [InlineData(1, -1)]
        [InlineData(2, 4)]
        public void CheckInvalidAddedProductsAddedToKart(int id, int quant)
        {
            IKartService kartsService = new KartService(kartsMock.Object, usersServiceMock.Object, productsServiceMock.Object);
            
            Product product = new Product
            {
                Id = id,
                Quantity = quant
            };

            productList.Add(product);
            try
            {
                kartsService.AddProduct(id, 5);
                Assert.True(false);
            }
            catch (ArgumentException) { }
        }
    }
}
