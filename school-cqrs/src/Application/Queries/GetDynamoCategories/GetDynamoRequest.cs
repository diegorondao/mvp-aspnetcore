using MediatR;

namespace Application.Queries.GetCategories
{
    public class GetDynamoRequest : IRequest<OutputViewModel>
    {
        public GetDynamoRequest(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

    }
}