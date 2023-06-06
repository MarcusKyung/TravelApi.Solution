using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class AddInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Destination = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Address", "City", "Country", "Date", "Description", "Destination", "Rating", "UserName" },
                values: new object[,]
                {
                    { 1, "123 Beach st", "Honolulu", "United States", new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lovely vacation destination with great weather. No spiders at all!", "Waikiki Beach", 9, "Mr_ReviewGuy" },
                    { 2, null, "San Diego", "United States", new DateTime(2006, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunny San Diego offers a perfect blend of beach bliss and urban spiders", "Coronado", 7, "Marcus" },
                    { 3, null, "Chicago", "United States", new DateTime(2011, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tons of spiders, I loved it", "Lou Malnati's Pizzaria", 10, "Jumping_Spider" },
                    { 4, null, "Tokyo", "Japan", new DateTime(2009, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Basically the future, they have robot spiders", "マクドナルド", 8, "Marcus" },
                    { 5, null, "Honolulu", "United States", new DateTime(2012, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "My stay was decent, this place could use some more spiders. I am going to steal the Declaration of Independence.", "Alley behind Quiznos", 6, "Nic_Cage" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
