﻿// <auto-generated />
using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230724174526_addImageUrlToProduct")]
    partial class addImageUrlToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Programming"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Chess"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Andrew Lock",
                            CategoryId = 2,
                            Description = "ASP.NET Core in Action, Second Edition is a comprehensive guide to creating web applications with ASP.NET Core 5.0. Go from basic HTTP concepts to advanced framework customization. ",
                            ISBN = "1617298301",
                            ImageUrl = "",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "ASP.NET Core in Action"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Jon P Smith",
                            CategoryId = 2,
                            Description = "Using crystal-clear explanations, real-world examples, and around 100 diagrams, Entity Framework Core in Action teaches you how to access and update relational data from .NET applications. You’ll start with a clear breakdown of Entity Framework, long with the mental model behind ORM. Then you’ll discover time-saving patterns and best practices for security, performance tuning, and even unit testing. As you go, you’ll address common data access challenges and learn how to handle them with Entity Framework. ",
                            ISBN = "161729456X",
                            ImageUrl = "",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Entity Framework Core in Action"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Mark Seemann, Steven van Deursen",
                            CategoryId = 2,
                            Description = "Dependency Injection Principles, Practices, and Patterns is a revised and expanded edition of the bestselling classic Dependency Injection in .NET. It teaches you DI from the ground up, featuring relevant examples, patterns, and anti-patterns for creating loosely coupled, well-structured applications. ",
                            ISBN = "161729473X",
                            ImageUrl = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "Dependency Injection Principles, Practices, and Patterns"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Aron Nimzowitsch",
                            CategoryId = 4,
                            Description = "My System describes a theory of chess; it also describes the character and genius of its author. It is a very readable book, for Nimzovich's methods sparkle with humor, pungent originality, and witty explanations.",
                            ISBN = "1880673851",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "My System: 21st Century Edition"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Alexander Kotov",
                            CategoryId = 4,
                            Description = "This is a well-established training manual which encourages the average player to understand how a Grandmaster thinks, and even more important, how he works. Kotov tackles fundamental issues such as knowing how and when to analyze, the tree of analysis, a selection of candidate moves and the factors of success.",
                            ISBN = "0713478853",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Think Like A Grandmaster"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Shea Ernshaw",
                            CategoryId = 1,
                            Description = "From New York Times bestselling author of The Wicked Deep comes a haunting romance perfect for fans of Practical Magic,where dark fairy tales and enchanted folklore collide after a boy, believed to be missing, emerges from the magical woods—and falls in love with the witch determined to unravel his secrets.",
                            ISBN = "1534439412",
                            ImageUrl = "",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Title = "Winterwood"
                        });
                });

            modelBuilder.Entity("Bulky.Models.Product", b =>
                {
                    b.HasOne("Bulky.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
