using Amazon.DynamoDBv2.DataModel;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.dynamodb.Model;

namespace Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<Category> GetAll()
        {
            return new List<Category>
            {
                new Category("Diego Rondão tests")
            };
        }

        public Task<Category> GetById(string key)
        {
            throw new NotImplementedException();
        }
    }
}