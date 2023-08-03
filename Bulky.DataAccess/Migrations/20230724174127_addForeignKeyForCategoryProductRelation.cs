using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyForCategoryProductRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 4, 4, "Chess" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategoryId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Aron Nimzowitsch", 4, "My System describes a theory of chess; it also describes the character and genius of its author. It is a very readable book, for Nimzovich's methods sparkle with humor, pungent originality, and witty explanations.", "1880673851", "My System: 21st Century Edition" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Alexander Kotov", 4, "This is a well-established training manual which encourages the average player to understand how a Grandmaster thinks, and even more important, how he works. Kotov tackles fundamental issues such as knowing how and when to analyze, the tree of analysis, a selection of candidate moves and the factors of success.", "0713478853", "Think Like A Grandmaster" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "Description", "ISBN", "Title" },
                values: new object[] { "Shea Ernshaw", 1, "From New York Times bestselling author of The Wicked Deep comes a haunting romance perfect for fans of Practical Magic,where dark fairy tales and enchanted folklore collide after a boy, believed to be missing, emerges from the magical woods—and falls in love with the witch determined to unravel his secrets.", "1534439412", "Winterwood" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Description", "ISBN", "Title" },
                values: new object[] { "Mike Brind", "ASP.NET Core Razor Pages in Action teaches you how to use Razor Pages to code and scale dynamic ASP.NET Core websites. You’ll learn a new feature in every chapter as you build an interesting vacation-booking application. ", "1617299987", "ASP.NET Core Razor Pages in Action" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Description", "ISBN", "Title" },
                values: new object[] { "Valerio De Sanctis", "Building Web APIs with ASP.NET Coreteaches you how to write safe, maintainable, and performant REST APIs. It’s full of best practices for modern and classic API styles, including REST and GraphQL. You’ll love the groundbreaking Minimal API model that helps you build pro-quality APIs with just a few lines of code. ", "1633439488", "Building Web APIs with ASP.NET Core" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Description", "ISBN", "Title" },
                values: new object[] { "Christian Wenz", "ASP.NET Core Security is a realistic guide to securing your web applications. It starts on the dark side, exploring case studies of cross-site scripting, SQL injection, and other weapons used by hackers. As you go, you’ll learn how to implement countermeasures, activate browser security features, minimize attack damage, and securely store application secrets. ", "1633439984", "ASP.NET Core Security" });
        }
    }
}
