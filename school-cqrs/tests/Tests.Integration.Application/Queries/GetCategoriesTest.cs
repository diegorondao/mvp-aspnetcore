using Application.Queries.GetCategories;
using Domain.Entities;
using Domain.Interfaces;
using Moq;

namespace Tests.Integration.Application.Queries;

public class GetCategoriesTest
{
    [Fact]
    public void GetAllCategories_with_sucess()
    {
        //Arrange
        var categoryRepository = new Mock<ICategoryRepository>();
        var getCategoriesRequest = new GetCategoriesQuery();

        var expect = new List<Category>
        {
            new Category("Description 01"),
            new Category("Description 02"),
        };
        categoryRepository.Setup(c => c.GetAll()).Returns(expect);
        var getCategoriesQueryHandler = new GetCategoriesQueryHandler(categoryRepository.Object);

        // Act
        var productResult = getCategoriesQueryHandler.Handle(getCategoriesRequest, new CancellationToken());

        //Assert
        Assert.NotNull(productResult);


    }
}