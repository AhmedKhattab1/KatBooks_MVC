using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fantasy", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Programming", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 },
				new Category { Id = 4, Name = "Chess", DisplayOrder = 4 }
				);

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tech Solution", StreetAddress="123 Tech St", City="TCity", PostalCode="121212", State="TS", PhoneNumber="0123123123"},
                new Company { Id = 2, Name = "VBooks", StreetAddress = "90 VB St", City = "VCity", PostalCode = "232323", State = "VS", PhoneNumber = "0456456456" },
                new Company { Id = 3, Name = "Reader Club", StreetAddress = "123 RC St", City = "RCity", PostalCode = "565656", State = "RS", PhoneNumber = "0789789789" }
                );

            modelBuilder.Entity<Product>().HasData(
				new Product
				{
					Id = 1,
					Title = "ASP.NET Core in Action",
					Author = "Andrew Lock",
					Description = "ASP.NET Core in Action, Second Edition is a comprehensive guide to creating web applications with ASP.NET Core 5.0. Go from basic HTTP concepts to advanced framework customization. ",
					ISBN = "1617298301",
					ListPrice = 50,
					Price = 47,
					Price50 = 43,
					Price100 = 39,
					CategoryId = 2,
					ImageUrl=""
				},
				new Product
				{
					Id = 2,
					Title = "Entity Framework Core in Action",
					Author = "Jon P Smith",
					Description = "Using crystal-clear explanations, real-world examples, and around 100 diagrams, Entity Framework Core in Action teaches you how to access and update relational data from .NET applications. You’ll start with a clear breakdown of Entity Framework, long with the mental model behind ORM. Then you’ll discover time-saving patterns and best practices for security, performance tuning, and even unit testing. As you go, you’ll address common data access challenges and learn how to handle them with Entity Framework. ",
					ISBN = "161729456X",
					ListPrice = 55,
					Price = 51,
					Price50 = 47,
					Price100 = 42,
					CategoryId = 2,
					ImageUrl = ""
				},
				new Product
				{
					Id = 3,
					Title = "Dependency Injection Principles, Practices, and Patterns",
					Author = "Mark Seemann, Steven van Deursen",
					Description = "Dependency Injection Principles, Practices, and Patterns is a revised and expanded edition of the bestselling classic Dependency Injection in .NET. It teaches you DI from the ground up, featuring relevant examples, patterns, and anti-patterns for creating loosely coupled, well-structured applications. ",
					ISBN = "161729473X",
					ListPrice = 55,
					Price = 50,
					Price50 = 45,
					Price100 = 40,
					CategoryId = 2,
					ImageUrl = ""
				},
				new Product
				{
					Id = 4,
					Title = "My System: 21st Century Edition",
					Author = "Aron Nimzowitsch",
					Description = "My System describes a theory of chess; it also describes the character and genius of its author. It is a very readable book, for Nimzovich's methods sparkle with humor, pungent originality, and witty explanations.",
					ISBN = "1880673851",
					ListPrice = 30,
					Price = 28,
					Price50 = 25,
					Price100 = 21,
					CategoryId = 4,
					ImageUrl = ""
				},
				new Product
				{
					Id = 5,
					Title = "Think Like A Grandmaster",
					Author = "Alexander Kotov",
					Description = "This is a well-established training manual which encourages the average player to understand how a Grandmaster thinks, and even more important, how he works. Kotov tackles fundamental issues such as knowing how and when to analyze, the tree of analysis, a selection of candidate moves and the factors of success.",
					ISBN = "0713478853",
					ListPrice = 27,
					Price = 25,
					Price50 = 23,
					Price100 = 20,
					CategoryId = 4,
					ImageUrl = ""
				},
				new Product
				{
					Id = 6,
					Title = "Winterwood",
					Author = "Shea Ernshaw",
					Description = "From New York Times bestselling author of The Wicked Deep comes a haunting romance perfect for fans of Practical Magic,where dark fairy tales and enchanted folklore collide after a boy, believed to be missing, emerges from the magical woods—and falls in love with the witch determined to unravel his secrets.",
					ISBN = "1534439412",
					ListPrice = 40,
					Price = 37,
					Price50 = 35,
					Price100 = 30,
					CategoryId = 1,
					ImageUrl = ""
				}
				);
		}
    }
}
