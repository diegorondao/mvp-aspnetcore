using MediatR;

namespace Application.Queries.GetCategories
{
    public class GetDynamoByIdRequest : IRequest<OutputViewModel>
    {
        public GetDynamoByIdRequest(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

    }
}