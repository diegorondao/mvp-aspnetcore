using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class CategoryRepository: ICategoryRepository
    {
        public void Add(Category student)
        {
            
        }

        public List<Category> GetAll()
        {
            return new List<Category>
            {
                new Category("Diego Rondão tests")
            };
        }
        
    }
}