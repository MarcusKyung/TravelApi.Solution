using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "City", "Country", "Description", "Rating", "UserName" },
                values: new object[,]
                {
                    { 1, "Honolulu", "United States", "Lovely vacation destination with great weather. No spiders at all!", 9, "Mr_ReviewGuy" },
                    { 2, "San Diego", "United States", "Sunny San Diego offers a perfect blend of beach bliss and urban spiders", 7, "Marcus" },
                    { 3, "Chicago", "United States", "Tons of spiders, I loved it", 10, "Jumping_Spider" },
                    { 4, "Tokyo", "Japan", "Basically the future, they have robot spiders", 8, "Marcus" },
                    { 5, "Honolulu", "United States", "My stay was decent, this place could use some more spiders. I am going to steal the Declaration of Independence.", 6, "Nic_Cage" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);
        }
    }
}
