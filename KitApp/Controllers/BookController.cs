using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitApp.Data.Interfaces;
using KitApp.Models;
using KitApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KitApp.Controllers
{
    public class BookController : Controller
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IBookRepository _bookRepository;

        public BookController(ICategoryRepository categoryRepository, IBookRepository bookRepository)
        {
            _categoryRepository = categoryRepository;
            _bookRepository = bookRepository;
        }

        [Route("Book/List/")]
        [Route("Book/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books = _bookRepository.Books;
            IEnumerable<Category> categories = _categoryRepository.Categories;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                books = _bookRepository.Books.OrderBy(c => c.Id);
                currentCategory = "All books";
            }
            else
            {
                foreach (var item in categories)
                {
                    if (string.Equals(item.CategoryName, _category, StringComparison.OrdinalIgnoreCase))
                    {
                        books = _bookRepository.Books.Where(c => c.Category.CategoryName.Equals(item.CategoryName)).OrderBy(c => c.Name);
                    }
                    currentCategory = _category;
                }
            }

            var bookListViewModel = new BookListViewModel
            {
                Books = books,
                CurrentCategory = currentCategory,
                Categories = categories
            };

            return View(bookListViewModel);
        }
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }
        
        public ViewResult Details(int Id)
        {
            var book = _bookRepository.Books.FirstOrDefault(d => d.Id == Id);
            if (book == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(book);
        }
    }
}