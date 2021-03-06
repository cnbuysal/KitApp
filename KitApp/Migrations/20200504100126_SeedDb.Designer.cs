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
    [Migration("20200504100126_SeedDb")]
    partial class SeedDb
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
                            CategoryId = 1,
                            Description = "Bir yolculuk, bir büyüme öyküsü; fedakârlık ve dostluk üzerine, hırs ve ihanet üzerine bir roman.",
                            Dimensions = "13x20",
                            ImageThumbnailUrl = "~/images/lotr.jpg",
                            ImageUrl = "~/images/lotr.jpg",
                            InStock = 25,
                            IsPreferredBook = true,
                            Language = "Türkçe",
                            Name = "Yüzük Kardeşliği",
                            PageNumber = "496",
                            Price = 51.20m,
                            PublicationDate = "2000",
                            Publisher = "Metis Yayıncılık"
                        },
                        new
                        {
                            Id = 2,
                            Author = "George R. R. Martin",
                            CategoryId = 1,
                            Description = "Yazların on yıllar, kışların bir insan ömrü sürebildiği diyarda, dehşetli ve soğuk zamanlar yaklaşmaktadır. Kışyarı'nın kuzeyindeki buzul topraklarda, Yedi Krallık'ı koruyan Sur'un ötesinde tehditkâr doğaüstü güçler toplanmaktadır. ",
                            Dimensions = "13x20",
                            ImageThumbnailUrl = "~/images/taht.jpg",
                            ImageUrl = "~/images/taht.jpg",
                            InStock = 14,
                            IsPreferredBook = false,
                            Language = "Türkçe",
                            Name = "Taht Oyunları",
                            PageNumber = "850",
                            Price = 36.75m,
                            PublicationDate = "2011",
                            Publisher = "Epsilon Yayınevi"
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
                            CategoryName = "Edebiyat"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Eğitim"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Foreign Languages"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Hobi"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Şiir",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Roman",
                            ParentCategoryId = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Fantastik",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Polisiye",
                            ParentCategoryId = 6
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Bilim Kurgu",
                            ParentCategoryId = 6
                        });
                });

            modelBuilder.Entity("KitApp.Models.Book", b =>
                {
                    b.HasOne("KitApp.Models.Category", null)
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
