using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();

        Task<Category> GetById(string key);


    }
}