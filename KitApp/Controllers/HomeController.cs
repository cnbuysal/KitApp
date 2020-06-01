using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KitApp.Models;
using KitApp.Data.Interfaces;
using KitApp.ViewModels;

namespace KitApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredBooks = _bookRepository.PreferredBooks
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
