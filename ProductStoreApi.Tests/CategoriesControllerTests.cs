using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductStoreApi.Controllers;
using ProductStoreApi.Database;
using ProductStoreApi.Model;
using System.Collections.Generic;
using Xunit;

namespace ProductStoreApi.Tests
{
    public class CategoriesControllerTests
    {
        [Fact]
        public void GetAll_ReturnsOkResult_WithCategories()
        {
            // Arrange: Set up InMemory DB and seed it
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            using var context = new AppDbContext(options);
            context.Categories.Add(new Category { Id = 1, Name = "Test" });
            context.SaveChanges();

            var controller = new CategoriesController(context);

            // Act
            var result = controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnCategories = Assert.IsAssignableFrom<IEnumerable<Category>>(okResult.Value);
            Assert.Single(returnCategories);
        }
    }
}
