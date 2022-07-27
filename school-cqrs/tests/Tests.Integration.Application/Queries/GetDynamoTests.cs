using Amazon.DynamoDBv2.DataModel;
using Application.Queries.GetCategories;
using Application.Services.Queries.GetCategories;
using Domain.Entities;
using Infrastructure.Persistence.dynamodb.Model;
using Infrastructure.Repository;
using Moq;

namespace Tests.Integration.Application.Queries
{
    public class GetDynamoTests
    {
        [Fact]
        public async void Test1()
        {
            //Arrange
            var dynamodb = new Mock<IDynamoDBContext>();
            var request = new GetDynamoRequest("123213-433321-abcd");

            var expected = new OutputViewModel
            {
                Description = "111-1111111001"
            };

            dynamodb.Setup(c => c.LoadAsync<OutputViewModel>(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .Returns(Task.FromResult(expected));

            var getCategoriesQueryHandler = new GetDynamoRequestHandler(dynamodb.Object);

            //Act
            var actual = await getCategoriesQueryHandler.Handle(request, new CancellationToken());

            //Assert
            Assert.Equal(expected.Description, actual.Description);
        }
    }
}