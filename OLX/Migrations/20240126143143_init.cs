using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OLX.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false, defaultValue: 9),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "https://th.bing.com/th/id/OIP.gV1cXI_SNBK_nU1yrE_hcwHaGp?w=196&h=180&c=7&r=0&o=5&pid=1.7")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electronics" },
                    { 2, "Sport" },
                    { 3, "Fashion" },
                    { 4, "Home & Garden" },
                    { 5, "Transport" },
                    { 6, "Toys & Hobbies" },
                    { 7, "Musical Instruments" },
                    { 8, "Art" },
                    { 9, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Vinnytsia" },
                    { 2, "Dnipro" },
                    { 3, "Donetsk" },
                    { 4, "Zhytomyr" },
                    { 5, "Zaporizhzhia" },
                    { 6, "Ivano-Frankivsk" },
                    { 7, "Kyiv" },
                    { 8, "Kropyvnytskyi" },
                    { 9, "Luhansk" },
                    { 10, "Lutsk" },
                    { 11, "Lviv" },
                    { 12, "Mykolaiv" },
                    { 13, "Odesa" },
                    { 14, "Poltava" },
                    { 15, "Rivne" },
                    { 16, "Sumy" },
                    { 17, "Ternopil" },
                    { 18, "Uzhgorod" },
                    { 19, "Kharkiv" },
                    { 20, "Kherson" },
                    { 21, "Khmelnytskyi" },
                    { 22, "Cherkasy" },
                    { 23, "Chernivtsi" },
                    { 24, "Chernihiv" }
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CategoryId", "CityId", "ContactInformation", "Description", "ImageUrl", "Price", "SellerName", "Title" },
                values: new object[] { 1, 1, 15, "3124324235", "iPhone X for sale in good condition", "https://th.bing.com/th/id/OIP.3auup9shWZkERJu29Y4uIQHaFj?w=239&h=180&c=7&r=0&o=5&pid=1.7", 750m, "Mark", "iPhone X" });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CategoryId", "CityId", "ContactInformation", "Description", "Price", "SellerName", "Title" },
                values: new object[,]
                {
                    { 2, 2, 7, "3124324235", null, 45.5m, "Katya", "PowerBall" },
                    { 3, 3, 11, "3124324235", null, 189m, "Oleg", "Nike T-Shirt" }
                });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CategoryId", "CityId", "ContactInformation", "Description", "ImageUrl", "Price", "SellerName", "Title" },
                values: new object[] { 4, 1, 12, "3124324235", "New samsung s23 phone for sale", "https://th.bing.com/th/id/OIP.qPr57iPly0B_1IhUEyYE6QHaHa?w=162&h=180&c=7&r=0&o=5&pid=1.7", 600m, "Boris", "Samsung S23" });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "CategoryId", "CityId", "ContactInformation", "Description", "Price", "SellerName", "Title" },
                values: new object[,]
                {
                    { 5, 2, 15, "3124324235", null, 50m, "Max", "Air Ball" },
                    { 6, 1, 16, "3124324235", "Used macbook pro 2019 for sale", 1200m, "Anya", "MacBook Pro 2019" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CategoryId",
                table: "Announcements",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CityId",
                table: "Announcements",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
