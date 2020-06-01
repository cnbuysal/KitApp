﻿// <auto-generated />
using System;
using KitApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KitApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200508161118_Orders")]
    partial class Orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KitApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimensions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InStock")
                        .HasColumnType("int");

                    b.Property<bool>("IsPreferredBook")
                        .HasColumnType("bit");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PublicationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "J.R.R. Tolkien",
                            CategoryId = 7,
                            Description = "The opening novel of The Lord of the Rings--the greatest fantasy epic of all time--which continues in The Two Towers and The Return of the King. Nominated as one of America's best-loved novels by PBS's The Great American Read The dark, fearsome Ringwraiths are searching for a Hobbit. Frodo Baggins knows that they are seeking him and the Ring he bears--the Ring of Power that will enable evil Sauron to destroy all that is good in Middle-earth. Now it is up to Frodo and his faithful servant, Sam, with a small band of companions, to carry the Ring to the one place it can be destroyed: Mount Doom, in the very center of Sauron's realm.",
                            Dimensions = "13x20",
                            ImageThumbnailUrl = "~/images/BookThumbnails/lotr1.jpg",
                            ImageUrl = "",
                            InStock = 25,
                            IsPreferredBook = true,
                            Language = "English",
                            Name = "The Fellowship of the Ring",
                            PageNumber = "480",
                            Price = 48.00m,
                            PublicationDate = "1989",
                            Publisher = "Random House USA Inc"
                        },
                        new
                        {
                            Id = 2,
                            Author = "J.R.R. Tolkien",
                            CategoryId = 7,
                            Description = "Building on the story begun in The Hobbit and The Fellowship of the Ring this is the second part of Tolkien's epic masterpiece, The Lord of the Rings, featuring a striking black cover based on Tolkien's own design, the definitive text, and a detailed map of Middle-earth.Frodo and the Companions of the Ring have been beset by danger during their quest to prevent the Ruling Ring from falling into the hands of the Dark Lord by destroying it in the Cracks of Doom.They have lost the wizard,Gandalf, in the battle with an evil spirit in the Mines of Moria; and at the Falls of Rauros, Boromir, seduced by the power of the Ring, tried to seize it by force.While Frodo and Sam made their escape the rest of the company were attacked by Orcs.",
                            Dimensions = "13x20",
                            ImageThumbnailUrl = "~/images/BookThumbnails/lotr2.jpg",
                            ImageUrl = "",
                            InStock = 14,
                            IsPreferredBook = false,
                            Language = "English",
                            Name = "The Two Towers",
                            PageNumber = "416",
                            Price = 40.50m,
                            PublicationDate = "1991",
                            Publisher = "HarperCollins Publishers"
                        },
                        new
                        {
                            Id = 3,
                            Author = "J.R.R. Tolkien",
                            CategoryId = 7,
                            Description = "The awesome conclusion to The Lord of the Rings--the greatest fantasy epic of all time--which began in The Fellowship of the Ring and The Two Towers. Nominated as one of America's best-loved novels by PBS's The Great American Read While the evil might of the Dark Lord Sauron swarms out to conquer all Middle-earth, Frodo and Sam struggle deep into Mordor, seat of Sauron's power. To defeat the Dark Lord, the One Ring, ruler of all the accursed Rings of Power, must be destroyed in the fires of Mount Doom. But the way is impossibly hard, and Frodo is weakening. Weighed down by the compulsion of the Ring, he begins finally to despair.",
                            Dimensions = "13x20",
                            ImageThumbnailUrl = "~/images/BookThumbnails/lotr3.jpg",
                            ImageUrl = "",
                            InStock = 19,
                            IsPreferredBook = false,
                            Language = "English",
                            Name = "The Return of the King",
                            PageNumber = "408",
                            Price = 40.50m,
                            PublicationDate = "1993",
                            Publisher = "Del Rey Books"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Cemal Süreya",
                            CategoryId = 5,
                            Description = "Cemal Süreya, ilk kitabı Üvercinka 1958'de çıktığında, 27 yaşında, ilk şiiri (\"Şarkısı Beyaz\") daha beş yıl önce yayımlanmış genç bir şairdi. Bu kitapla çağcıl Türk şiirinin en çok konuşulan, en çok tartışılan akımlarından İkinci Yeni'nin öncülerinden biri olacağını ne kendisi ne de bir başkası bilebilirdi.",
                            ImageThumbnailUrl = "~/images/BookThumbnails/uvercinka.jpg",
                            ImageUrl = "",
                            InStock = 5,
                            IsPreferredBook = false,
                            Language = "Turkish",
                            Name = "Üvercinka",
                            PageNumber = "64",
                            Price = 6m,
                            PublicationDate = "2014",
                            Publisher = "Yapı Kredi Yayınları"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Ali Lidar",
                            CategoryId = 5,
                            Description = "Linç Çağı’nda, Şirintepe Parkı’nda, heybende meleğin emanetleri, çölleri ve karlı ovaları aşacak, yangınlara tanık olacaksın, soyut atların gölgesinde soluklanıp, şirk sınırlarını zorlarken, deliydim geçti de geç.Bu yolculukta en çok kendine tanık olacaksın; ayrılık öfke ve keder yoldaşın olacak, müzevirler dünyanı karartacak. Ali Lidar şiirleriyle seni, sana anlatacak.Dünyanın yükü kendisinden ağırsa, tek çare terazinin kefesine bir tutam adalet koymaktır.Aslında Herkes Haklı, anılardan bir kırkyama…",
                            Dimensions = "13.5x21",
                            ImageThumbnailUrl = "~/images/BookThumbnails/aslindaherkeshakli.jpg",
                            ImageUrl = "",
                            InStock = 48,
                            IsPreferredBook = true,
                            Language = "Turkish",
                            Name = "Aslında Herkes Haklı",
                            PageNumber = "128",
                            Price = 10.22m,
                            PublicationDate = "2018",
                            Publisher = "İthaki Yayınları"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Jean-Christophe Grange",
                            CategoryId = 8,
                            Description = "Kara orman’da son av başladı… ardında hiçbir iz bırakmayan avcı kim? Komiser Niémans,yardımcısı Ivana Bogdović’le Alsace bölgesinde işlenen vahşi bir cinayeti çözmeye gider.Kendi karanlık geçmişlerini de yanlarında götüren iki polis,Kara Orman’da saklanan bir sırrın peşine düşerler.Kızıl Nehirler’in başkahramanı Niémans’ın dönüşünü müjdeleyen Son Av,kökeni Nazi Almanyası’na kadar giden sürprizlerle dolu bir gerilim…",
                            Dimensions = "14x23",
                            ImageThumbnailUrl = "~/images/BookThumbnails/sonav.jpg",
                            ImageUrl = "",
                            InStock = 108,
                            IsPreferredBook = true,
                            Language = "Turkish",
                            Name = "Son Av",
                            PageNumber = "304",
                            Price = 27.36m,
                            PublicationDate = "2020",
                            Publisher = "Doğan Kitap"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Brandon Sanderson",
                            CategoryId = 9,
                            Description = "Spensa's world has been under attack for hundreds of years. An alien race called the Krell leads onslaught after onslaught from the sky in a never-ending campaign to destroy humankind. Humanity's only defense is to take to their ships and fight the enemy in the skies. Pilots have become the heroes of what's left of the human race.Spensa has always dreamed of being one of them; of soaring above Earth and proving her bravery. But her fate is intertwined with her father's - a pilot who was killed years ago when he abruptly deserted his team, placing Spensa's chances of attending flight school somewhere between slim and none.No one will let Spensa forget what her father did, but she is still determined to fly. And the Krell just made that a possibility. They've doubled their fleet, making Spensa's world twice as dangerous. . .but their desperation to survive might just take her skyward. . .",
                            Dimensions = "16x23.8",
                            ImageThumbnailUrl = "~/images/BookThumbnails/skyward.jpg",
                            ImageUrl = "",
                            InStock = 2,
                            IsPreferredBook = true,
                            Language = "English",
                            Name = "Skyward",
                            PageNumber = "528 ",
                            Price = 67.35m,
                            PublicationDate = "2019",
                            Publisher = "Orion Publishing Co"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Kobe Bryant",
                            CategoryId = 1,
                            Description = "The Mamba Mentality: How I Play is Kobe Bryant's personal perspective of his life and career on the basketball court and his exceptional, insightful style of playing the game--a fitting legacy from the late Los Angeles Laker superstar.In the wake of his retirement from professional basketball,Kobe \"The Black Mamba\" Bryant decided to share his vast knowledge and understanding of the game to take readers on an unprecedented journey to the core of the legendary \"Mamba mentality.\" Citing an obligation and an opportunity to teach young players,hardcore fans",
                            Dimensions = " 23.5x28.7",
                            ImageThumbnailUrl = "~/images/BookThumbnails/mamba.jpg",
                            ImageUrl = "",
                            InStock = 22,
                            IsPreferredBook = true,
                            Language = "English",
                            Name = "The Mamba Mentality : How I Play",
                            PageNumber = "208  ",
                            Price = 194.50m,
                            PublicationDate = "2020",
                            Publisher = "Farrar, Straus & Giroux Inc"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Mark Murphy",
                            CategoryId = 2,
                            Description = "Eğitim araştırmacıları çalışmalarında farklı teorisyenlerden faydalanıyor olsalar da, bir kaçının eğitim için daha farklı bir öneme sahip oldukları söylenebilir. Karl Marx, Antonio   Gramsci, John Dewey ve Paulo Freire gibi düşünürler bir önceki nesli etkilerken, daha çağdaş tartışmaların büyük bir kısmı Michel Foucault, Jürgen Habermas, Pierre Bourdieu ve Jacques Derrida gibi düşünürlerin fikirleri etrafında şekillenmektedir. Her ne kadar bu düşünürlerin eğitim araştırmaları üzerindeki etkileri son yıllarda giderek büyüyor olsa da hem orijinal çalışmaları, hem de bu çalışmaların eğitime uygulanması eğitimciler için çeşitli zorlukları beraberinde getirmektedir. Söz konusu bu zorluklar, ileri düzeydeki uygulayıcılara hitap eden uygun okuma materyallerinin eksikliği dolayısıyla daha da derinleşmektedir.",
                            Dimensions = "13,5x21",
                            ImageThumbnailUrl = "~/images/BookThumbnails/sosyalteori.jpg",
                            ImageUrl = "",
                            InStock = 82,
                            IsPreferredBook = false,
                            Language = "Turkish",
                            Name = "Sosyal Teori ve Eğitim",
                            PageNumber = "120  ",
                            Price = 33.25m,
                            PublicationDate = "2018",
                            Publisher = "Eğitim Kitabevi Yayınları"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Ayşen Bakioğlu",
                            CategoryId = 2,
                            Description = "Dünya nüfusunun beşte birini barındıran bir ülke olarak Çin, dünya eğitim kaynaklarının sadece %2'si ile tüm dünyadaki öğrencilerin %26'sına hizmet vermektedir. 1940'larda nüfusunun %80'i eğitimsiz, 1980'lerde 15 yaş üstü nüfusun ortalama eğitim yılı sadece 7.8 yıl iken, günümüzde okuryazarlık oranı %93'ün üstüne çıkmış, farklı kademelerdeki okullarda, yaklaşık 12 milyon öğretmen 250 milyon öğrenciye eğitim vermektedir. 23 milyonluk nüfusu ülkesinin %1'ine, yüzölçümü %0,06'sına denk gelen Şangay ise, tek başına Çin'in toplam gelirinin sekizde birini karşılamakta; ülkenin ihracat ve ithalat hacminin dörtte birini gerçekleştirmektedir. 15 yaşındaki öğrencilerin gerçek yaşam koşullarında bilgilerini ne ölçüde kullanabildiklerini sınayan PISA sınavlarında, ilk yıllarda Finlandiya üst sıralarda yer alırken, 2009 ve 2012 PISA sınavlarında ilk sıralarda Finlandiya'nın yanında tamamı Asyalı Şangay (Çin), Hong Kong (Çin), Güney Kore, Singapur, Tayvan (Çin), Makao (Çin) ve Japonya gibi ülkelerin/ekonomilerin yer alması, 21'inci yüzyıl için “Asya yüzyılı” nitelemesinin pekişmesine yol açmıştır. ",
                            Dimensions = "16x23,5",
                            ImageThumbnailUrl = "~/images/BookThumbnails/cin.jpg",
                            ImageUrl = "",
                            InStock = 13,
                            IsPreferredBook = true,
                            Language = "Turkish",
                            Name = "Çin’de Eğitim",
                            PageNumber = "246  ",
                            Price = 24.64m,
                            PublicationDate = "2017",
                            Publisher = "Nobel Akademik Yayıncılık"
                        },
                        new
                        {
                            Id = 11,
                            Author = "George R. R. Martin",
                            CategoryId = 7,
                            Description = "From the masterly imagination behind A Game of Thrones - one of the greatest fantasy epics of all time and an unmissable HBO hit series - comes a definitive history of Westeros’s past as told by Archmaester Gyldayn.Unravelling events that led to A Song of Ice and Fire,Fire and Blood is the first volume of the definitive two - part history of the Targaryens in Westeros.Revealing long - buried secrets and untold lasting enmity,it sets the scene for the heart-stopping series conclusion, The Winds of Winter.300 years before the events of A Song of Ice and Fire, long before the schism that set the houses of Westeros at each other’s throats, one house ruled supreme and indomitable.House Targaryen, the house of the last remaining dragonlords.",
                            Dimensions = "15.9x24",
                            ImageThumbnailUrl = "~/images/BookThumbnails/fireblood.jpg",
                            ImageUrl = "",
                            InStock = 147,
                            IsPreferredBook = true,
                            Language = "English",
                            Name = "Fire & Blood",
                            PageNumber = "704",
                            Price = 184.72m,
                            PublicationDate = "2018",
                            Publisher = "HarperCollins"
                        },
                        new
                        {
                            Id = 12,
                            Author = "George R. R. Martin",
                            CategoryId = 7,
                            Description = "The never-before-seen history of Westeros and the lands beyond. With hundreds of pages of all-new material from George R.R. Martin.If the past is prologue,then George R.R.Martin's masterwork-the most inventive and entertaining fantasy saga of our time-warrants one hell of an introduction. At long last, it has arrived with THE WORLD OF ICE AND FIRE.George R.R.Martin, in collaboration with Elio M.Garcia,Jr.and Linda Antonsson,has written a comprehensive history of the Seven Kingdoms,featuring the epic battles,bitter rivalries,and daring rebellions that lead up to the events in the bestselling A Song of Ice and Fire series.Collected within this volume is the accumulated knowledge,scholarly speculation,and inherited folk tales of maesters and septons,maegi and singers,including over 170 full - colour illustrations and maps,family trees for the Houses Stark, Lannister and Targaryen, and in-depth explanations of the history and culture of Westeros.",
                            Dimensions = "15.9x24",
                            ImageThumbnailUrl = "~/images/BookThumbnails/icefire.jpg",
                            ImageUrl = "",
                            InStock = 150,
                            IsPreferredBook = true,
                            Language = "English",
                            Name = "The World of Ice and Fire",
                            PageNumber = "336",
                            Price = 246.32m,
                            PublicationDate = "2014",
                            Publisher = "HarperCollins"
                        });
                });

            modelBuilder.Entity("KitApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Biography"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Education"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Foreign Languages"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Hobby"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Poetry"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Novel"
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Fantasy",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Crime & Thriller",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Science Fiction",
                            ParentCategoryId = 6
                        });
                });

            modelBuilder.Entity("KitApp.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KitApp.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("KitApp.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("BookId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("KitApp.Models.Book", b =>
                {
                    b.HasOne("KitApp.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitApp.Models.OrderDetail", b =>
                {
                    b.HasOne("KitApp.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitApp.Models.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KitApp.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("KitApp.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");
                });
#pragma warning restore 612, 618
        }
    }
}
