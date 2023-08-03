using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTableAndSeedingProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Andrew Lock", "ASP.NET Core in Action, Second Edition is a comprehensive guide to creating web applications with ASP.NET Core 5.0. Go from basic HTTP concepts to advanced framework customization. ", "1617298301", 99.0, 90.0, 80.0, 85.0, "ASP.NET Core in Action" },
                    { 2, "Jon P Smith", "Using crystal-clear explanations, real-world examples, and around 100 diagrams, Entity Framework Core in Action teaches you how to access and update relational data from .NET applications. You’ll start with a clear breakdown of Entity Framework, long with the mental model behind ORM. Then you’ll discover time-saving patterns and best practices for security, performance tuning, and even unit testing. As you go, you’ll address common data access challenges and learn how to handle them with Entity Framework. ", "161729456X", 40.0, 30.0, 20.0, 25.0, "Entity Framework Core in Action" },
                    { 3, "Mark Seemann, Steven van Deursen", "Dependency Injection Principles, Practices, and Patterns is a revised and expanded edition of the bestselling classic Dependency Injection in .NET. It teaches you DI from the ground up, featuring relevant examples, patterns, and anti-patterns for creating loosely coupled, well-structured applications. ", "161729473X", 55.0, 50.0, 35.0, 40.0, "Dependency Injection Principles, Practices, and Patterns" },
                    { 4, "Mike Brind", "ASP.NET Core Razor Pages in Action teaches you how to use Razor Pages to code and scale dynamic ASP.NET Core websites. You’ll learn a new feature in every chapter as you build an interesting vacation-booking application. ", "1617299987", 70.0, 65.0, 55.0, 60.0, "ASP.NET Core Razor Pages in Action" },
                    { 5, "Valerio De Sanctis", "Building Web APIs with ASP.NET Coreteaches you how to write safe, maintainable, and performant REST APIs. It’s full of best practices for modern and classic API styles, including REST and GraphQL. You’ll love the groundbreaking Minimal API model that helps you build pro-quality APIs with just a few lines of code. ", "1633439488", 30.0, 27.0, 20.0, 25.0, "Building Web APIs with ASP.NET Core" },
                    { 6, "Christian Wenz", "ASP.NET Core Security is a realistic guide to securing your web applications. It starts on the dark side, exploring case studies of cross-site scripting, SQL injection, and other weapons used by hackers. As you go, you’ll learn how to implement countermeasures, activate browser security features, minimize attack damage, and securely store application secrets. ", "1633439984", 25.0, 23.0, 20.0, 22.0, "ASP.NET Core Security" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
