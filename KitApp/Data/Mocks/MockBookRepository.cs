using KitApp.Data.Interfaces;
using KitApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.Data.Mocks
{
    public class MockBookRepository : IBookRepository

    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Book> Books
        {
            get
            {
                return new List<Book>
                {
                    new Book
                    {
                        Id = 1,
                        Name = "The Fellowship of the Ring",
                        Author = "J.R.R. Tolkien",
                        CategoryId = 7,
                        Description = "The opening novel of The Lord of the Rings--the greatest fantasy epic of all time--which continues in The Two Towers and The Return of the King. Nominated as one of America's best-loved novels by PBS's The Great American Read The dark, fearsome Ringwraiths are searching for a Hobbit. Frodo Baggins knows that they are seeking him and the Ring he bears--the Ring of Power that will enable evil Sauron to destroy all that is good in Middle-earth. Now it is up to Frodo and his faithful servant, Sam, with a small band of companions, to carry the Ring to the one place it can be destroyed: Mount Doom, in the very center of Sauron's realm.",
                        Dimensions = "13x20",
                        ImageThumbnailUrl = "~/images/BookThumbnails/lotr1.jpg",
                        ImageUrl = "",
                        InStock = 25,
                        IsPreferredBook = true,
                        Language = "English",
                        PageNumber = "480",
                        Price = 48.00m,
                        PublicationDate = "1989",
                        Publisher = "Random House USA Inc"
                    },
                    new Book
                    {
                        Id = 2,
                        Name = "The Two Towers",
                        Author = "J.R.R. Tolkien",
                        CategoryId = 7,
                        Description = "Building on the story begun in The Hobbit and The Fellowship of the Ring this is the second part of Tolkien's epic masterpiece, The Lord of the Rings, featuring a striking black cover based on Tolkien's own design, the definitive text, and a detailed map of Middle-earth.Frodo and the Companions of the Ring have been beset by danger during their quest to prevent the Ruling Ring from falling into the hands of the Dark Lord by destroying it in the Cracks of Doom.They have lost the wizard,Gandalf, in the battle with an evil spirit in the Mines of Moria; and at the Falls of Rauros, Boromir, seduced by the power of the Ring, tried to seize it by force.While Frodo and Sam made their escape the rest of the company were attacked by Orcs.",
                        Dimensions = "13x20",
                        ImageThumbnailUrl = "~/images/BookThumbnails/lotr2.jpg",
                        ImageUrl = "",
                        InStock = 14,
                        IsPreferredBook = false,
                        Language = "English",
                        PageNumber = "416",
                        Price = 40.50m,
                        PublicationDate = "1991",
                        Publisher = "HarperCollins Publishers"
                    }
                };
            }
            set { }

        }

        public IEnumerable<Book> PreferredBooks { get; set; }

        public Book GetBookById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
