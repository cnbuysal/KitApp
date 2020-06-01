using KitApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitApp.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
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
                },
                new Book
                {
                    Id = 6,
                    Name = "Son Av",
                    Author = "Jean-Christophe Grange",
                    CategoryId = 8,
                    Description = "Kara orman’da son av başladı… ardında hiçbir iz bırakmayan avcı kim? Komiser Niémans,yardımcısı Ivana Bogdović’le Alsace bölgesinde işlenen vahşi bir cinayeti çözmeye gider.Kendi karanlık geçmişlerini de yanlarında götüren iki polis,Kara Orman’da saklanan bir sırrın peşine düşerler.Kızıl Nehirler’in başkahramanı Niémans’ın dönüşünü müjdeleyen Son Av,kökeni Nazi Almanyası’na kadar giden sürprizlerle dolu bir gerilim…",
                    Dimensions = "14x23",
                    ImageThumbnailUrl = "~/images/BookThumbnails/sonav.jpg",
                    ImageUrl = "",
                    InStock = 108,
                    IsPreferredBook = true,
                    Language = "Turkish",
                    PageNumber = "304",
                    Price = 27.36m,
                    PublicationDate = "2020",
                    Publisher = "Doğan Kitap"
                },
                new Book
                {
                    Id = 7,
                    Name = "Skyward",
                    Author = "Brandon Sanderson",
                    CategoryId = 9,
                    Description = "Spensa's world has been under attack for hundreds of years. An alien race called the Krell leads onslaught after onslaught from the sky in a never-ending campaign to destroy humankind. Humanity's only defense is to take to their ships and fight the enemy in the skies. Pilots have become the heroes of what's left of the human race.Spensa has always dreamed of being one of them; of soaring above Earth and proving her bravery. But her fate is intertwined with her father's - a pilot who was killed years ago when he abruptly deserted his team, placing Spensa's chances of attending flight school somewhere between slim and none.No one will let Spensa forget what her father did, but she is still determined to fly. And the Krell just made that a possibility. They've doubled their fleet, making Spensa's world twice as dangerous. . .but their desperation to survive might just take her skyward. . .",
                    Dimensions = "16x23.8",
                    ImageThumbnailUrl = "~/images/BookThumbnails/skyward.jpg",
                    ImageUrl = "",
                    InStock = 2,
                    IsPreferredBook = true,
                    Language = "English",
                    PageNumber = "528 ",
                    Price = 67.35m,
                    PublicationDate = "2019",
                    Publisher = "Orion Publishing Co"
                },
                new Book
                {
                    Id = 8,
                    Name = "The Mamba Mentality : How I Play",
                    Author = "Kobe Bryant",
                    CategoryId = 1,
                    Description = "The Mamba Mentality: How I Play is Kobe Bryant's personal perspective of his life and career on the basketball court and his exceptional, insightful style of playing the game--a fitting legacy from the late Los Angeles Laker superstar.In the wake of his retirement from professional basketball,Kobe \"The Black Mamba\" Bryant decided to share his vast knowledge and understanding of the game to take readers on an unprecedented journey to the core of the legendary \"Mamba mentality.\" Citing an obligation and an opportunity to teach young players,hardcore fans",
                    Dimensions = " 23.5x28.7",
                    ImageThumbnailUrl = "~/images/BookThumbnails/mamba.jpg",
                    ImageUrl = "",
                    InStock = 22,
                    IsPreferredBook = true,
                    Language = "English",
                    PageNumber = "208  ",
                    Price = 194.50m,
                    PublicationDate = "2020",
                    Publisher = "Farrar, Straus & Giroux Inc"
                },
                new Book
                {
                    Id = 9,
                    Name = "Sosyal Teori ve Eğitim",
                    Author = "Mark Murphy",
                    CategoryId = 2,
                    Description = "Eğitim araştırmacıları çalışmalarında farklı teorisyenlerden faydalanıyor olsalar da, bir kaçının eğitim için daha farklı bir öneme sahip oldukları söylenebilir. Karl Marx, Antonio   Gramsci, John Dewey ve Paulo Freire gibi düşünürler bir önceki nesli etkilerken, daha çağdaş tartışmaların büyük bir kısmı Michel Foucault, Jürgen Habermas, Pierre Bourdieu ve Jacques Derrida gibi düşünürlerin fikirleri etrafında şekillenmektedir. Her ne kadar bu düşünürlerin eğitim araştırmaları üzerindeki etkileri son yıllarda giderek büyüyor olsa da hem orijinal çalışmaları, hem de bu çalışmaların eğitime uygulanması eğitimciler için çeşitli zorlukları beraberinde getirmektedir. Söz konusu bu zorluklar, ileri düzeydeki uygulayıcılara hitap eden uygun okuma materyallerinin eksikliği dolayısıyla daha da derinleşmektedir.",
                    Dimensions = "13,5x21",
                    ImageThumbnailUrl = "~/images/BookThumbnails/sosyalteori.jpg",
                    ImageUrl = "",
                    InStock = 82,
                    IsPreferredBook = false,
                    Language = "Turkish",
                    PageNumber = "120  ",
                    Price = 33.25m,
                    PublicationDate = "2018",
                    Publisher = "Eğitim Kitabevi Yayınları"
                },
                new Book
                {
                    Id = 10,
                    Name = "Çin’de Eğitim",
                    Author = "Ayşen Bakioğlu",
                    CategoryId = 2,
                    Description = "Dünya nüfusunun beşte birini barındıran bir ülke olarak Çin, dünya eğitim kaynaklarının sadece %2'si ile tüm dünyadaki öğrencilerin %26'sına hizmet vermektedir. 1940'larda nüfusunun %80'i eğitimsiz, 1980'lerde 15 yaş üstü nüfusun ortalama eğitim yılı sadece 7.8 yıl iken, günümüzde okuryazarlık oranı %93'ün üstüne çıkmış, farklı kademelerdeki okullarda, yaklaşık 12 milyon öğretmen 250 milyon öğrenciye eğitim vermektedir. 23 milyonluk nüfusu ülkesinin %1'ine, yüzölçümü %0,06'sına denk gelen Şangay ise, tek başına Çin'in toplam gelirinin sekizde birini karşılamakta; ülkenin ihracat ve ithalat hacminin dörtte birini gerçekleştirmektedir. 15 yaşındaki öğrencilerin gerçek yaşam koşullarında bilgilerini ne ölçüde kullanabildiklerini sınayan PISA sınavlarında, ilk yıllarda Finlandiya üst sıralarda yer alırken, 2009 ve 2012 PISA sınavlarında ilk sıralarda Finlandiya'nın yanında tamamı Asyalı Şangay (Çin), Hong Kong (Çin), Güney Kore, Singapur, Tayvan (Çin), Makao (Çin) ve Japonya gibi ülkelerin/ekonomilerin yer alması, 21'inci yüzyıl için “Asya yüzyılı” nitelemesinin pekişmesine yol açmıştır. ",
                    Dimensions = "16x23,5",
                    ImageThumbnailUrl = "~/images/BookThumbnails/cin.jpg",
                    ImageUrl = "",
                    InStock = 13,
                    IsPreferredBook = true,
                    Language = "Turkish",
                    PageNumber = "246  ",
                    Price = 24.64m,
                    PublicationDate = "2017",
                    Publisher = "Nobel Akademik Yayıncılık"
                },
                new Book
                {
                    Id = 11,
                    Name = "Fire & Blood",
                    Author = "George R. R. Martin",
                    CategoryId = 7,
                    Description = "From the masterly imagination behind A Game of Thrones - one of the greatest fantasy epics of all time and an unmissable HBO hit series - comes a definitive history of Westeros’s past as told by Archmaester Gyldayn.Unravelling events that led to A Song of Ice and Fire,Fire and Blood is the first volume of the definitive two - part history of the Targaryens in Westeros.Revealing long - buried secrets and untold lasting enmity,it sets the scene for the heart-stopping series conclusion, The Winds of Winter.300 years before the events of A Song of Ice and Fire, long before the schism that set the houses of Westeros at each other’s throats, one house ruled supreme and indomitable.House Targaryen, the house of the last remaining dragonlords.",
                    Dimensions = "15.9x24",
                    ImageThumbnailUrl = "~/images/BookThumbnails/fireblood.jpg",
                    ImageUrl = "",
                    InStock = 147,
                    IsPreferredBook = true,
                    Language = "English",
                    PageNumber = "704",
                    Price = 184.72m,
                    PublicationDate = "2018",
                    Publisher = "HarperCollins"
                },
                new Book
                {
                    Id = 12,
                    Name = "The World of Ice and Fire",
                    Author = "George R. R. Martin",
                    CategoryId = 7,
                    Description = "The never-before-seen history of Westeros and the lands beyond. With hundreds of pages of all-new material from George R.R. Martin.If the past is prologue,then George R.R.Martin's masterwork-the most inventive and entertaining fantasy saga of our time-warrants one hell of an introduction. At long last, it has arrived with THE WORLD OF ICE AND FIRE.George R.R.Martin, in collaboration with Elio M.Garcia,Jr.and Linda Antonsson,has written a comprehensive history of the Seven Kingdoms,featuring the epic battles,bitter rivalries,and daring rebellions that lead up to the events in the bestselling A Song of Ice and Fire series.Collected within this volume is the accumulated knowledge,scholarly speculation,and inherited folk tales of maesters and septons,maegi and singers,including over 170 full - colour illustrations and maps,family trees for the Houses Stark, Lannister and Targaryen, and in-depth explanations of the history and culture of Westeros.",
                    Dimensions = "15.9x24",
                    ImageThumbnailUrl = "~/images/BookThumbnails/icefire.jpg",
                    ImageUrl = "",
                    InStock = 150,
                    IsPreferredBook = true,
                    Language = "English",
                    PageNumber = "336",
                    Price = 246.32m,
                    PublicationDate = "2014",
                    Publisher = "HarperCollins"
                },
                new Book
                {
                    Id = 13,
                    Name = "Clock Repairing as a Hobby",
                    Author = "Harold Caleb Kelly",
                    CategoryId = 4,
                    Description = "It covers the theory behind clock movement and design, including the particulars of escapements, pendulums, balance wheels, and even the sheet music for popular chimes. The American striking clock, the 400-day clock, and the alarm clock receive special attention. The in-depth information, including explanations of clock repairing terminology and details on the tools, materials, and supplies that are needed for success, will benefit even skilled enthusiasts.",
                    Dimensions = "14x21",
                    ImageThumbnailUrl = "~/images/BookThumbnails/clock.jpg",
                    ImageUrl = "",
                    InStock = 18,
                    IsPreferredBook = false,
                    Language = "English",
                    PageNumber = "128",
                    Price = 84.99m,
                    PublicationDate = "2007",
                    Publisher = "Skyhorse Publishing"
                },
                new Book
                {
                    Id = 14,
                    Name = "Bluey: Easter Fun! : A Craft Book",
                    Author = "Bluey",
                    CategoryId = 6,
                    Description = "Bluey and Bingo love being creative! Get making with loads of egg-cellent Easter activities for the whole family.Bluey has been a phenomenal success since airing on ABC KIDS in October 2018,amassing legions of dedicated fans and taking the coveted position of being the most watched program ever on ABC iView,with over 200 million plays.It has also topped the Australian iTunes Kids Chart with the series peaking at #1 and consistently remaining in the Top 5.",
                    Dimensions = "14x29.5",
                    ImageThumbnailUrl = "~/images/BookThumbnails/bluey.jpg",
                    ImageUrl = "",
                    InStock = 78,
                    IsPreferredBook = false,
                    Language = "English",
                    PageNumber = "24",
                    Price = 124.32m,
                    PublicationDate = "2020",
                    Publisher = "Penguin Books Australia"
                }

            );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Biography" },
                new Category { Id = 2, CategoryName = "Education" },
                new Category { Id = 3, CategoryName = "Foreign Languages" },
                new Category { Id = 4, CategoryName = "Hobby" },
                new Category { Id = 5, CategoryName = "Poetry" },
                new Category { Id = 6, CategoryName = "Children's Books" },
                new Category { Id = 7, CategoryName = "Fantasy" },
                new Category { Id = 8, CategoryName = "Crime & Thriller" },
                new Category { Id = 9, CategoryName = "Science Fiction" }
            );
        }
    }
}
