
using KitApp.Data.Interfaces;
using KitApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.Data.Repositories
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public SQLCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}
