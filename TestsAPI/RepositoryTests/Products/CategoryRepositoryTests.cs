using System;
using System.Threading.Tasks;
using Bogus;
using Entities.Models.Products;
using Microsoft.EntityFrameworkCore;
using Moq;
using Repository.Products;
using Repository;
using Xunit;
using Contracts;

namespace TestsAPI.RepositoryTests.Products
{
    public class CategoryRepositoryTests
    {
        [Fact]
        public async Task CreateCategory_ShouldCreateCategoryInDatabase()
        {
            // Arrange
            var fakeCategory = new Faker<Category>()
                //.RuleFor(c => c.CategoryID, f => f.Random.Guid())
                .RuleFor(c => c.Name, f => f.Commerce.ProductName());
                //.RuleFor(c => c.State, f => f.Random.Bool());

            // Configurar el mock del contexto de base de datos
            var dbContextMock = new Mock<RepositoryContext>();

            var dbSetMock = new Mock<DbSet<Category>>();

            dbContextMock.Setup(c => c.Categories).Returns(dbSetMock.Object);

            var repository = new CategoryRepository(dbContextMock.Object);

            var category = fakeCategory.Generate();

            // Act
            repository.CreateCategory(category);

            // Assert
            dbSetMock.Verify(d => d.Add(It.IsAny<Category>()), Times.Once);

            dbContextMock.Verify(d => d.SaveChangesAsync(default(CancellationToken)), Times.Once);
        }
    }
}
