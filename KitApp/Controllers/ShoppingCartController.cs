using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitApp.Data.Interfaces;
using KitApp.Models;
using KitApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KitApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IBookRepository _bookRepository;

        public ShoppingCartController(ShoppingCart shoppingCart, IBookRepository bookRepository)
        {
            _shoppingCart = shoppingCart;
            _bookRepository = bookRepository;
        }
        [Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int Id)
        {
            var selectedBook = _bookRepository.Books.FirstOrDefault(c => c.Id == Id);
            if (selectedBook!=null)
            {
                _shoppingCart.AddToCart(selectedBook);
            }
            return RedirectToAction("List","Book");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int Id)
        {
            var selectedBook = _bookRepository.Books.FirstOrDefault(c => c.Id == Id);
            if (selectedBook != null)
            {
                _shoppingCart.RemoveFromCart(selectedBook);
            }
            return RedirectToAction("Index");
        }
    }
}