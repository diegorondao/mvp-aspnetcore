using Domain.Interfaces;
using MediatR;

namespace Application.Services.Queries.GetCategories
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<GetCategoriesViewModel>>
    {
        private readonly ICategoryRepository _categoryRepository;

        public GetCategoriesQueryHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<List<GetCategoriesViewModel>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = _categoryRepository.GetAll();

            var getCategoriesViewModelList = categories
                .Select(s => new GetCategoriesViewModel(s.Description))
                .ToList();

            return Task.FromResult(getCategoriesViewModelList);
        }
    }
}