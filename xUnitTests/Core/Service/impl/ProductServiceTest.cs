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

        static string Name = "Name";
        static string Description = "Description";
        static string ImageLink = "Image Link";
        static int IntVar = 1;
        
        Product productCorrectSyntax = new Product
        {
            Name = Name,
            Description = Description,
            ImageLink = ImageLink,
            Length = IntVar,
            Height = IntVar,
            Width = IntVar,
            Quantity = IntVar
        };
        static Product productEmptyName = new Product
        {
            Name = "",
            Description = Description,
            ImageLink = ImageLink,
            Length = IntVar,
            Height = IntVar,
            Width = IntVar,
            Quantity = IntVar
        };
        static Product productNullName = new Product
        {
            Description = Description,
            ImageLink = ImageLink,
            Length = IntVar,
            Height = IntVar,
            Width = IntVar,
            Quantity = IntVar
        };
        static Product productEmptyDescription = new Product
        {
            Name = Name,
            Description = "",
            ImageLink = ImageLink,
            Length = IntVar,
            Height = IntVar,
            Width = IntVar,
            Quantity = IntVar
        };
        static Product productNullDescription = new Product
        {
            Name = Name,
            ImageLink = ImageLink,
            Length = IntVar,
            Height = IntVar,
            Width = IntVar,
            Quantity = IntVar
        };
        static Product productEmptyImageLink = new Product
        {
            Name = Name,
            Description = Description,
            ImageLink = "",
            Length = IntVar,
            Height = IntVar,
            Width = IntVar,
            Quantity = IntVar
        };
        static Product productNullImageLink = new Product
        {
            Name = Name,
            Description = Description,
            Length = IntVar,
            Height = IntVar,
            Width = IntVar,
            Quantity = IntVar
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
            productsRepoMock.Setup(x => x.ReadById(It.IsAny<int>()))
                .Returns(() => productCorrectSyntax);
        }

        [Theory]
        [MemberData(nameof(invalidProductUpdateData))]
        public void CheckForCorrectUpdates(Product product)
        {
            IProductService productService = new ProductService(productsRepoMock.Object);

            Assert.True(product != productService.Update(1, product));
        }
    }
}