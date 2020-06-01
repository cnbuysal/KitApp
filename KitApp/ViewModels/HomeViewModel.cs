using KitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> PreferredBooks { get; set; }
    }
}
