using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using Group13.Webshop.Core.Service;
using Group13.Webshop.Core.Service.impl;
using Moq;
using System;
using Xunit;

namespace Group13.Webshop.xUnitTests.Core.Service.impl
{
    public class KartServiceTest
    {
        private Mock<IKartRepository> kartsMock = new Mock<IKartRepository>();

        [Fact]
        public void CreateUserWhereKartIsNull()
        {
            IKartService kartsService = new KartService(kartsMock.Object);

            
        }
    }
}
