using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using Group13.Webshop.Core.Service;
using Group13.Webshop.Core.Service.impl;
using Moq;
using System;
using Xunit;

namespace Group13.Webshop.xUnitTests.Core.Service.impl
{
    public class UserServiceTest
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

        [Fact]
        public void CreateUser()
        {
            var productRepo = new Mock<IProductRepository>();
            
            IProductService service = new ProductService(productRepo.Object);
            var product = new Product()
            {
                Id = 1,
                Name = "Test",
                Price = 1524,
                Quantity = 2,
                Description = "Tester",
                Height = 45,
                Length = 66,
                Width = 85
            };
            service.Create(product);
            productRepo.Verify(x => x.CreateProduct(It.IsAny<Product>()), Times.Once);
        }
    }
}
