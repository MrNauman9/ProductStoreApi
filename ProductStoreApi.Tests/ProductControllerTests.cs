using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductStoreApi.Controllers;
using ProductStoreApi.Database;
using ProductStoreApi.Model;

using System.Collections.Generic;
using Xunit;

namespace ProductStoreApi.Tests
{
    public class ProductControllerTests
    {
        private AppDbContext GetInMemoryDb()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;
            return new AppDbContext(options);
        }

        [Fact]
        public void GetProducts_ReturnsCorrectCount()
        {
            // Arrange
            var context = GetInMemoryDb();
            context.Products.Add(new Product { Name = "Item 1", Price = 100 });
            context.Products.Add(new Product { Name = "Item 2", Price = 200 });
            context.SaveChanges();

            var controller = new ProductsController(context);

            // Act
            var result = controller.GetProducts();

            // ✅ FIX: Access .Result to get the actual response object
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var products = Assert.IsType<List<Product>>(okResult.Value);

            // Assert
            Assert.Equal(2, products.Count);
        }

    }
}
