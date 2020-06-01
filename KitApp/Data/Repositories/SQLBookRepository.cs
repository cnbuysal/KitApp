using KitApp.Data.Interfaces;
using KitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KitApp.Data.Repositories
{
    public class SQLBookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;

        public SQLBookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> Books => _appDbContext.Books;

        public IEnumerable<Book> PreferredBooks => _appDbContext.Books.Where(p => p.IsPreferredBook);
        public Book GetBookById(int BookId) => _appDbContext.Books.FirstOrDefault(i => i.Id == BookId);
    }
    
}
