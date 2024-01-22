using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OLX.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Category", "City", "ContactInformation", "Description", "Price", "SellerName", "Title" },
                values: new object[,]
                {
                    { 1, "Electronics", "Rivne", "3124324235", "iPhone X for sale in good condition", 750m, "Mark", "iPhone X" },
                    { 2, "Sport", "Kiyv", "3124324235", null, 45.5m, "Katya", "PowerBall" },
                    { 3, "Fashion", "Lviv", "3124324235", null, 189m, "Oleg", "Nike T-Shirt" },
                    { 4, "Electronics", "Kharkiv", "3124324235", "New samsung s23 phone for sale", 600m, "Boris", "Samsung S23" },
                    { 5, "Toys & Hobbies", "Rivne", "3124324235", null, 50m, "Max", "Air Ball" },
                    { 6, "Electronics", "Kiyv", "3124324235", "Used macbook pro 2019 for sale", 1200m, "Anya", "MacBook Pro 2019" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");
        }
    }
}
