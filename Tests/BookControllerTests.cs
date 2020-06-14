using System;
using KitApp.Models;
using KitApp.Data.Mocks;
using KitApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using NUnit.Framework;
using KitApp.Controllers;
using KitApp.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using KitApp.ViewModels;

namespace Tests
{
    [TestFixture]
   public class BookControllerTests
    {
        DbContextOptionsBuilder<AppDbContext> dbContext;
        Category category1;
        AppDbContext _context;
        IBookRepository bookRepo;
        ICategoryRepository categoryRepo;

        [SetUp]
        public void SetUp()
        {
            dbContext = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString());
            bookRepo = new MockBookRepository();

            categoryRepo = new MockCategoryRepository();
            category1 = categoryRepo.Categories.FirstOrDefault(i => i.Id == 7);

            _context = new AppDbContext(dbContext.Options);
        }

        [Test]
        public void List_RetursnViewResult_ReturnsAListOfBooksWithinACategory()
        {
            var bookController = new BookController(categoryRepo, bookRepo);

            var result = bookController.List(category1.CategoryName);
            var model = result.ViewData.Model;

            Assert.That(result, Is.TypeOf(typeof(ViewResult)));
            Assert.That(model, Is.TypeOf(typeof(BookListViewModel)));
        }
    }
}
