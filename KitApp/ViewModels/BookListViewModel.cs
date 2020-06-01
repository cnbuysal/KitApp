using KitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public string CurrentCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
