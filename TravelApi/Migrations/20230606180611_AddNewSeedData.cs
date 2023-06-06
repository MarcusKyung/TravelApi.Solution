using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class AddNewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Address", "City", "Country", "Date", "Description", "Destination", "Rating", "UserName" },
                values: new object[,]
                {
                    { 6, "456 Coral Ave", "Cairns", "Australia", new DateTime(2022, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "A diver's paradise with stunning coral reefs and diverse marine life.", "Great Barrier Reef", 10, "OceanExplorer" },
                    { 7, "789 Inca Trail", "Cusco", "Peru", new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "A mystical ancient city hidden in the mountains. The hike was challenging but rewarding!", "Machu Picchu", 9, "HistoryBuff2021" },
                    { 8, "101 Sunset Ave", "Thera", "Greece", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathtaking views, delicious food, and stunning sunsets. A romantic getaway!", "Santorini", 9, "IslandDreamer" },
                    { 9, "555 Canyon Road", "Arizona", "United States", new DateTime(2020, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "An awe-inspiring natural wonder. The views from the rim are incredible!", "Grand Canyon", 9, "NatureLover123" },
                    { 10, "222 Magic Way", "Tokyo", "Japan", new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magical experience with exciting rides and delightful characters. A must-visit for Disney lovers!", "Tokyo Disneyland", 8, "DisneyFanatic" },
                    { 11, "321 Canal Street", "Amsterdam", "Netherlands", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beautiful canals lined with picturesque houses. Renting a boat was a fantastic way to explore the city!", "Amsterdam Canals", 9, "CultureExplorer" },
                    { 12, "777 Pyramid Road", "Giza", "Egypt", new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marvelous ancient structures with a rich history. The Sphinx is impressive!", "Pyramids of Giza", 9, "AncientHistoryFan" },
                    { 13, "444 Waterfall Ave", "Puerto Iguazu", "Argentina", new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Absolutely stunning waterfalls surrounded by lush rainforest. A natural wonder!", "Iguazu Falls", 10, "NatureEnthusiast" },
                    { 14, "999 Marina Walk", "Dubai", "United Arab Emirates", new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "A vibrant waterfront area with impressive skyscrapers and luxurious yachts.", "Dubai Marina", 8, "LuxuryTraveler" },
                    { 15, "789 Inca Trail", "Cusco", "Peru", new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "A once-in-a-lifetime experience. The ancient ruins are awe-inspiring!", "Machu Picchu", 9, "Adventurer123" },
                    { 16, "333 Wall Street", "Beijing", "China", new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "An incredible feat of engineering with breathtaking views. Be prepared for a long walk!", "Great Wall of China", 9, "HistoryExplorer" },
                    { 17, "888 Taj Road", "Agra", "India", new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A magnificent mausoleum with stunning architecture. The marble work is exquisite!", "Taj Mahal", 10, "ArchitecturalWonders" },
                    { 18, "777 Safari Drive", "Arusha", "Tanzania", new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "A wildlife enthusiast's dream. Witnessing the Great Migration was an unforgettable experience!", "Serengeti National Park", 10, "WildlifeExplorer" },
                    { 19, "789 Inca Trail", "Cusco", "Peru", new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "A challenging hike to reach the ancient ruins, but the view from the Sun Gate was worth it!", "Machu Picchu", 9, "MountainHiker" },
                    { 20, "555 Canal Grande", "Venice", "Italy", new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navigating the canals on a gondola was a romantic and enchanting experience.", "Venice", 9, "RomanticTraveler" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 20);
        }
    }
}
