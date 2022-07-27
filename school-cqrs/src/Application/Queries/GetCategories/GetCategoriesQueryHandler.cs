using Domain.Interfaces;
using MediatR;

namespace Application.Queries.GetCategories
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<GetCategoriesViewModel>>
    {
        private readonly ICategoryRepository categoryRepository;

        public GetCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Task<List<GetCategoriesViewModel>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = this.categoryRepository.GetAll();

            var getCategoriesViewModelList = categories
                .Select(s => new GetCategoriesViewModel(s.Description))
                .ToList();

            return Task.FromResult(getCategoriesViewModelList);
        }
    }
}