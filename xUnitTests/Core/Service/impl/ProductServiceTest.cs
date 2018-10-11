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
    public class ProductServiceTest
    {

        private Mock<IProductRepository> productsRepoMock = new Mock<IProductRepository>();

        Product productCorrectSyntax = new Product
        {
            Name = "Name",
            Description = "Description",
            ImageLink = "Image Link",
            Length = 1,
            Height = 1,
            Width = 1,
            Quantity = 1
        };
        static Product productEmptyName = new Product
        {
            Name = "",
            Description = "Description",
            ImageLink = "Image Link",
            Length = 1,
            Height = 1,
            Width = 1,
            Quantity = 1
        };
        static Product productNullName = new Product
        {
            Description = "Description",
            ImageLink = "Image Link",
            Length = 1,
            Height = 1,
            Width = 1,
            Quantity = 1
        };
        static Product productEmptyDescription = new Product
        {
            Name = "Name",
            Description = "",
            ImageLink = "Image Link",
            Length = 1,
            Height = 1,
            Width = 1,
            Quantity = 1
        };
        static Product productNullDescription = new Product
        {
            Name = "Name",
            ImageLink = "Image Link",
            Length = 1,
            Height = 1,
            Width = 1,
            Quantity = 1
        };
        static Product productEmptyImageLink = new Product
        {
            Name = "Name",
            Description = "Description",
            ImageLink = "",
            Length = 1,
            Height = 1,
            Width = 1,
            Quantity = 1
        };
        static Product productNullImageLink = new Product
        {
            Name = "Name",
            Description = "Description",
            Length = 1,
            Height = 1,
            Width = 1,
            Quantity = 1
        };

        public static IEnumerable<object[]> invalidProductUpdateData =>
            new List<object[]>
        {
            new object[] {productEmptyName},
            new object[] {productNullName},
            new object[] {productEmptyDescription},
            new object[] {productNullDescription},
            new object[] {productEmptyImageLink},
            new object[] {productNullImageLink}
        };

        public ProductServiceTest()
        {
        }

        [Theory]
        [MemberData(nameof(invalidProductUpdateData))]
        public void CheckForCorrectUpdates(Product product)
        {

        }
    }
}