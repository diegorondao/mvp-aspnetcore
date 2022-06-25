using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category
    {
        public Category(string description)
        {
            Description = description;
        }

        public Guid Uuid { get; private set; }
        public string Description { get; private set; }

    }
}