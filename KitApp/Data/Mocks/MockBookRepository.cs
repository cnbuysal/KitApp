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
                    },
                    new Book
                    {
                        Id = 3,
                        Name = "The Return of the King",
                        Author = "J.R.R. Tolkien",
                        CategoryId = 7,
                        Description = "The awesome conclusion to The Lord of the Rings--the greatest fantasy epic of all time--which began in The Fellowship of the Ring and The Two Towers. Nominated as one of America's best-loved novels by PBS's The Great American Read While the evil might of the Dark Lord Sauron swarms out to conquer all Middle-earth, Frodo and Sam struggle deep into Mordor, seat of Sauron's power. To defeat the Dark Lord, the One Ring, ruler of all the accursed Rings of Power, must be destroyed in the fires of Mount Doom. But the way is impossibly hard, and Frodo is weakening. Weighed down by the compulsion of the Ring, he begins finally to despair.",
                        Dimensions = "13x20",
                        ImageThumbnailUrl = "~/images/BookThumbnails/lotr3.jpg",
                        ImageUrl = "",
                        InStock = 19,
                        IsPreferredBook = false,
                        Language = "English",
                        PageNumber = "408",
                        Price = 40.50m,
                        PublicationDate = "1993",
                        Publisher = "Del Rey Books"
                    },
                    new Book
                    {
                        Id = 4,
                        Name = "Üvercinka",
                        Author = "Cemal Süreya",
                        CategoryId = 5,
                        Description = "Cemal Süreya, ilk kitabı Üvercinka 1958'de çıktığında, 27 yaşında, ilk şiiri (\"Şarkısı Beyaz\") daha beş yıl önce yayımlanmış genç bir şairdi. Bu kitapla çağcıl Türk şiirinin en çok konuşulan, en çok tartışılan akımlarından İkinci Yeni'nin öncülerinden biri olacağını ne kendisi ne de bir başkası bilebilirdi.",
                        Dimensions = null,
                        ImageThumbnailUrl = "~/images/BookThumbnails/uvercinka.jpg",
                        ImageUrl = "",
                        InStock = 5,
                        IsPreferredBook = false,
                        Language = "Turkish",
                        PageNumber = "64",
                        Price = 6m,
                        PublicationDate = "2014",
                        Publisher = "Yapı Kredi Yayınları"
                    },
                    new Book
                    {
                        Id = 5,
                        Name = "Aslında Herkes Haklı",
                        Author = "Ali Lidar",
                        CategoryId = 5,
                        Description = "Linç Çağı’nda, Şirintepe Parkı’nda, heybende meleğin emanetleri, çölleri ve karlı ovaları aşacak, yangınlara tanık olacaksın, soyut atların gölgesinde soluklanıp, şirk sınırlarını zorlarken, deliydim geçti de geç.Bu yolculukta en çok kendine tanık olacaksın; ayrılık öfke ve keder yoldaşın olacak, müzevirler dünyanı karartacak. Ali Lidar şiirleriyle seni, sana anlatacak.Dünyanın yükü kendisinden ağırsa, tek çare terazinin kefesine bir tutam adalet koymaktır.Aslında Herkes Haklı, anılardan bir kırkyama…",
                        Dimensions = "13.5x21",
                        ImageThumbnailUrl = "~/images/BookThumbnails/aslindaherkeshakli.jpg",
                        ImageUrl = "",
                        InStock = 48,
                        IsPreferredBook = true,
                        Language = "Turkish",
                        PageNumber = "128",
                        Price = 10.22m,
                        PublicationDate = "2018",
                        Publisher = "İthaki Yayınları"
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
