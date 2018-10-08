using Group13.Webshop.Core.Entity;
using Group13.Webshop.Core.Repository;
using Moq;
using System;
using Xunit;

namespace Group13.Webshop.xUnitTests.Service.impl
{
    public class UnitTest1
    {
        [Fact]
        public void UserTest()
        {
            var usersMock = new Mock<IUserRepository>();
        }
    }
}
