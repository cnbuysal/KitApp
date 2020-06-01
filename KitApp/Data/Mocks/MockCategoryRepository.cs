using KitApp.Data.Interfaces;
using KitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { Id = 1, CategoryName = "Biography" },
                    new Category { Id = 2, CategoryName = "Education" },
                    new Category { Id = 3, CategoryName = "Foreign Languages" },
                    new Category { Id = 4, CategoryName = "Hobby" },
                    new Category { Id = 5, CategoryName = "Poetry" },
                    new Category { Id = 6, CategoryName = "Children's Books" },
                    new Category { Id = 7, CategoryName = "Fantasy" },
                    new Category { Id = 8, CategoryName = "Crime & Thriller" },
                    new Category { Id = 9, CategoryName = "Science Fiction" }
                };
            }
        }
    }
}
