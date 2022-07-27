using Amazon.DynamoDBv2.DataModel;
using Application.Queries.GetCategories;
using Domain.Entities;
using Infrastructure.Persistence.dynamodb.Model;
using MediatR;

namespace Application.Services.Queries.GetCategories
{
    public class GetDynamoByIdRequestHandler : IRequestHandler<GetDynamoRequest, OutputViewModel>
    {
        private readonly IDynamoDBContext dynamodb;

        public GetDynamoByIdRequestHandler(IDynamoDBContext dynamodb)
        {
            this.dynamodb = dynamodb;
        }

        public async Task<OutputViewModel> Handle(GetDynamoRequest request, CancellationToken cancellationToken)
        {
            return await dynamodb.LoadAsync<OutputViewModel>(request.Id, cancellationToken);
        }
    }
}
