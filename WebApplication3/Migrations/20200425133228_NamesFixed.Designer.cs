﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Models;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200425133228_NamesFixed")]
    partial class NamesFixed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("inStock")
                        .HasColumnType("bit");

                    b.Property<bool>("isBookOfTheWeek")
                        .HasColumnType("bit");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978153/9781534451568-l.jpg",
                            ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978153/9781534451568-l.jpg",
                            LongDescription = "Stella Grant likes to be in control—even though her totally out of control lungs have sent her in and out of the hospital most of her life. At this point, what Stella needs to control most is keeping herself away from anyone or anything that might pass along an infection and jeopardize the possibility of a lung transplant. Six feet apart. No exceptions.",
                            Name = "Five Feet Apart",
                            Price = 18.99m,
                            ShortDescription = "Rachael Lippincott",
                            inStock = false,
                            isBookOfTheWeek = false
                        },
                        new
                        {
                            BookId = 2,
                            AllergyInformation = "",
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978148/9781481497404-l.jpg",
                            ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978148/9781481497404-l.jpg",
                            LongDescription = "Sophie Foster is struggling. Grieving. Scrambling. But she knows one thing: she will not be defeated. The Neverseen have had their victories - but the battle is far from over. It’s time to change tactics. Make sacrifices. Reexamine everything. Maybe even time for Sophie to trust her enemies.",
                            Name = "NIGHTFALL",
                            Price = 19.99m,
                            ShortDescription = "Shannon Messenger",
                            inStock = false,
                            isBookOfTheWeek = false
                        },
                        new
                        {
                            BookId = 3,
                            AllergyInformation = "",
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978071/9780718084097-l.jpg",
                            ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978071/9780718084097-l.jpg",
                            LongDescription = "People of all ages and walks of life will enjoy the fresh style of the feature articles, which are directed at helping you approach life with the mind of Christ. You will discover that the Bible is a very practical book, just what is needed to guide you through every day. Featuring abundant sidebar articles and vibrant full-color design, the Apply the Word Study Bible is the perfect companion for everyday living.",
                            Name = "THE WORD STUDY BIBLE",
                            Price = 54.99m,
                            ShortDescription = "Thomas Nelson",
                            inStock = false,
                            isBookOfTheWeek = false
                        },
                        new
                        {
                            BookId = 4,
                            AllergyInformation = "",
                            CategoryId = 4,
                            ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978073/9780736435864-l.jpg",
                            ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978073/9780736435864-l.jpg",
                            LongDescription = "Can Rey, Finn, General Leia, Poe Dameron, and Luke Skywalker save the galaxy from Kylo Ren and the evil First Order? The epic space saga, Star Wars: The Last Jedi, is retold in the iconic Little Golden Book format! Featuring stunning retro illustrations, this book is perfect for Star Wars--and Little Golden Book--fans of all ages!",
                            Name = "THE LAST JEDI",
                            Price = 4.99m,
                            ShortDescription = "Elizabeth Schaefer",
                            inStock = false,
                            isBookOfTheWeek = false
                        },
                        new
                        {
                            BookId = 5,
                            AllergyInformation = "",
                            CategoryId = 5,
                            ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524713843-l.jpg",
                            ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524713843-l.jpg",
                            LongDescription = "Thirteen-year-old twins Vick and Tara have built an incredible machine - a loyal robotic watchdog named Daisy. But, when local crime boss Ms. Alba schemes to add Daisy to her robot army, Vick and Tara must go to great lengths to protect their prized pet. Because Daisy is more than just any robot - she’s their constant protector, and together the three make a great team.",
                            Name = "WATCHDOG",
                            Price = 16.99m,
                            ShortDescription = "Will McIntosh",
                            inStock = false,
                            isBookOfTheWeek = false
                        },
                        new
                        {
                            BookId = 6,
                            AllergyInformation = "",
                            CategoryId = 6,
                            ImageThumbnailUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524797232-l.jpg",
                            ImageUrl = "https://bookdepot-lmwv1z0x2r9fdffrc7q.netdna-ssl.com/covers/large/isbn978152/9781524797232-l.jpg",
                            LongDescription = "This official guide will teach you how to navigate the alien terrain, battle the native mobs and find rare blocks and items. With insider info and tips from the experts at Mojang, this is the definitive guide to survival in the Nether and the End.",
                            Name = "MINECRAFT",
                            Price = 11.99m,
                            ShortDescription = "Del Rey Books",
                            inStock = false,
                            isBookOfTheWeek = false
                        });
                });

            modelBuilder.Entity("WebApplication3.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Bibles"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Sci-Fi"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Games"
                        });
                });

            modelBuilder.Entity("WebApplication3.Models.Book", b =>
                {
                    b.HasOne("WebApplication3.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
