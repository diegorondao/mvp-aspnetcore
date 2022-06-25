namespace Application.Services.Queries.GetCategories
{
    public class GetCategoriesViewModel
    {
        public GetCategoriesViewModel(string description)
        {
            Description = description;
        }

        public string Description { get; private set; }
        
    }
}