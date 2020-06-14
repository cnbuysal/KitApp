using System;
using KitApp.Models;
using KitApp.Data.Mocks;
using KitApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ShoppingCartTests

    {
        DbContextOptionsBuilder<AppDbContext> dbContext;
        Book book1;
        Book book2;
        ShoppingCartItem shoppingCartItem1;
        ShoppingCartItem shoppingCartItem2;
        ShoppingCart sc;
        AppDbContext _context;

        [SetUp]
        public void SetUp()
        {
            dbContext = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString());
            var bookRepo = new MockBookRepository();
            book1 = bookRepo.Books.FirstOrDefault(i => i.Id == 1);
            book2 = bookRepo.Books.FirstOrDefault(i => i.Id == 2);

            _context = new AppDbContext(dbContext.Options);
            sc = new ShoppingCart(_context);

            shoppingCartItem1 = new ShoppingCartItem() { Book = book1, Quantity = 1, ShoppingCartId = sc.ShoppingCartId };
            shoppingCartItem2 = new ShoppingCartItem() { Book = book2, Quantity = 3, ShoppingCartId = sc.ShoppingCartId };
        }


        [Test]
        public void AddToCart_AddExistingItem_ReturnsThree()
        {
            _context.ShoppingCartItems.Add(new ShoppingCartItem()
            { Book = book1, Quantity = 1, ShoppingCartId = sc.ShoppingCartId });
            _context.SaveChanges();

            sc.AddToCart(book1);
            sc.AddToCart(book1);

            var result = _context.ShoppingCartItems.FirstOrDefault(i => i.Book.Id == 1).Quantity;

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void AddToCart_AddNonExistingItem_ReturnsTwo()
        {
            sc.AddToCart(book1);
            sc.AddToCart(book1);

            var result = _context.ShoppingCartItems.FirstOrDefault(i => i.Book.Id == 1).Quantity;

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void RemoveFromCart_RemoveItemWithQuantityOfTwo_ReturnsOne()
        {
            _context.ShoppingCartItems.Add(new ShoppingCartItem()
            { Book = book1, Quantity = 2, ShoppingCartId = sc.ShoppingCartId });
            _context.SaveChanges();
            sc.RemoveFromCart(book1);

            var result = _context.ShoppingCartItems.FirstOrDefault(i => i.Book.Id == 1).Quantity;

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void RemoveFromCart_RemoveItemWithQuantityOfOne_ReturnsNull()
        {
            _context.ShoppingCartItems.Add(new ShoppingCartItem()
            { Book = book1, Quantity = 1, ShoppingCartId = sc.ShoppingCartId });
            _context.SaveChanges();
            sc.RemoveFromCart(book1);

            var result = _context.ShoppingCartItems.FirstOrDefault(i => i.Book.Id == 1);

            Assert.That(result, Is.Null);
        }

        [Test]
        public void RemoveFromCart_RemoveNoneExistingItem_ReturnsZero()
        {
            var result = sc.RemoveFromCart(book1);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GetShoppingCartItems_ReturnsTwo()
        {
            _context.ShoppingCartItems.Add(shoppingCartItem1);
            _context.ShoppingCartItems.Add(shoppingCartItem2);
            _context.SaveChanges();

            var result = sc.GetShoppingCartItems().Count;

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void ClearCart_ReturnsTrue()
        {
            _context.ShoppingCartItems.Add(shoppingCartItem1);
            _context.ShoppingCartItems.Add(shoppingCartItem2);
            _context.SaveChanges();
            sc.ClearCart();

            var result = _context.ShoppingCartItems.Count();

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GetShoppingCartTotal_ShouldWork()
        {
            _context.ShoppingCartItems.Add(shoppingCartItem1);
            _context.ShoppingCartItems.Add(shoppingCartItem2);
            _context.SaveChanges();

            var result = sc.GetShoppingCartTotal();

            Assert.That(result, Is.EqualTo(169.5));
        }
    }
}
