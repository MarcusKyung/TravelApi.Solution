using Microsoft.EntityFrameworkCore;

namespace TravelApi.Models
{
  public class TravelApiContext : DbContext
  {
    public DbSet<Review> Reviews { get; set; }

    public TravelApiContext(DbContextOptions<TravelApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
        .HasData(
          new Review { ReviewId = 1, Destination = "Waikiki Beach", Country = "United States", City = "Honolulu", Address = "123 Beach st", Rating = 9, UserName = "Mr_ReviewGuy", Description = "Lovely vacation destination with great weather. No spiders at all!", Date = new DateTime(2019, 12, 25) },
          new Review { ReviewId = 2, Destination = "Coronado", Country = "United States", City = "San Diego", Rating = 7, UserName = "Marcus", Description = "Sunny San Diego offers a perfect blend of beach bliss and urban spiders", Date = new DateTime(2006, 07, 25) },
          new Review { ReviewId = 3, Destination = "Lou Malnati's Pizzaria", Country = "United States", City = "Chicago", Rating = 10, UserName = "Jumping_Spider", Description = "Tons of spiders, I loved it", Date = new DateTime(2011, 12, 02) },
          new Review { ReviewId = 4, Destination = "マクドナルド", Country = "Japan", City = "Tokyo", Rating = 8, UserName = "Marcus", Description = "Basically the future, they have robot spiders", Date = new DateTime(2009, 09, 13) },
          new Review { ReviewId = 5, Destination = "Alley behind Quiznos", Country = "United States", City = "Honolulu", Rating = 6, UserName = "Nic_Cage", Description = "My stay was decent, this place could use some more spiders. I am going to steal the Declaration of Independence.", Date = new DateTime(2012, 10, 09) },
          new Review { ReviewId = 6, Destination = "Great Barrier Reef", Country = "Australia", City = "Cairns", Address = "456 Coral Ave", Rating = 10, UserName = "OceanExplorer", Description = "A diver's paradise with stunning coral reefs and diverse marine life.", Date = new DateTime(2022, 05, 18) },
          new Review { ReviewId = 7, Destination = "Machu Picchu", Country = "Peru", City = "Cusco", Address = "789 Inca Trail", Rating = 9, UserName = "HistoryBuff2021", Description = "A mystical ancient city hidden in the mountains. The hike was challenging but rewarding!", Date = new DateTime(2021, 09, 02) },
          new Review { ReviewId = 8, Destination = "Santorini", Country = "Greece", City = "Thera", Address = "101 Sunset Ave", Rating = 9, UserName = "IslandDreamer", Description = "Breathtaking views, delicious food, and stunning sunsets. A romantic getaway!", Date = new DateTime(2022, 07, 14) },
          new Review { ReviewId = 9, Destination = "Grand Canyon", Country = "United States", City = "Arizona", Address = "555 Canyon Road", Rating = 9, UserName = "NatureLover123", Description = "An awe-inspiring natural wonder. The views from the rim are incredible!", Date = new DateTime(2020, 06, 30) },
          new Review { ReviewId = 10, Destination = "Tokyo Disneyland", Country = "Japan", City = "Tokyo", Address = "222 Magic Way", Rating = 8, UserName = "DisneyFanatic", Description = "Magical experience with exciting rides and delightful characters. A must-visit for Disney lovers!", Date = new DateTime(2023, 03, 12) },
          new Review { ReviewId = 11, Destination = "Amsterdam Canals", Country = "Netherlands", City = "Amsterdam", Address = "321 Canal Street", Rating = 9, UserName = "CultureExplorer", Description = "Beautiful canals lined with picturesque houses. Renting a boat was a fantastic way to explore the city!", Date = new DateTime(2021, 05, 05) },
          new Review { ReviewId = 12, Destination = "Pyramids of Giza", Country = "Egypt", City = "Giza", Address = "777 Pyramid Road", Rating = 9, UserName = "AncientHistoryFan", Description = "Marvelous ancient structures with a rich history. The Sphinx is impressive!", Date = new DateTime(2022, 02, 22) },
          new Review { ReviewId = 13, Destination = "Iguazu Falls", Country = "Argentina", City = "Puerto Iguazu", Address = "444 Waterfall Ave", Rating = 10, UserName = "NatureEnthusiast", Description = "Absolutely stunning waterfalls surrounded by lush rainforest. A natural wonder!", Date = new DateTime(2023, 01, 08) },
          new Review { ReviewId = 14, Destination = "Dubai Marina", Country = "United Arab Emirates", City = "Dubai", Address = "999 Marina Walk", Rating = 8, UserName = "LuxuryTraveler", Description = "A vibrant waterfront area with impressive skyscrapers and luxurious yachts.", Date = new DateTime(2022, 09, 20) },
          new Review { ReviewId = 15, Destination = "Machu Picchu", Country = "Peru", City = "Cusco", Address = "789 Inca Trail", Rating = 9, UserName = "Adventurer123", Description = "A once-in-a-lifetime experience. The ancient ruins are awe-inspiring!", Date = new DateTime(2023, 05, 30) },
          new Review { ReviewId = 16, Destination = "Great Wall of China", Country = "China", City = "Beijing", Address = "333 Wall Street", Rating = 9, UserName = "HistoryExplorer", Description = "An incredible feat of engineering with breathtaking views. Be prepared for a long walk!", Date = new DateTime(2021, 10, 15) },
          new Review { ReviewId = 17, Destination = "Taj Mahal", Country = "India", City = "Agra", Address = "888 Taj Road", Rating = 10, UserName = "ArchitecturalWonders", Description = "A magnificent mausoleum with stunning architecture. The marble work is exquisite!", Date = new DateTime(2022, 12, 01) },
          new Review { ReviewId = 18, Destination = "Serengeti National Park", Country = "Tanzania", City = "Arusha", Address = "777 Safari Drive", Rating = 10, UserName = "WildlifeExplorer", Description = "A wildlife enthusiast's dream. Witnessing the Great Migration was an unforgettable experience!", Date = new DateTime(2023, 04, 17) },
          new Review { ReviewId = 19, Destination = "Machu Picchu", Country = "Peru", City = "Cusco", Address = "789 Inca Trail", Rating = 9, UserName = "MountainHiker", Description = "A challenging hike to reach the ancient ruins, but the view from the Sun Gate was worth it!", Date = new DateTime(2022, 08, 05) },
          new Review { ReviewId = 20, Destination = "Venice", Country = "Italy", City = "Venice", Address = "555 Canal Grande", Rating = 9, UserName = "RomanticTraveler", Description = "Navigating the canals on a gondola was a romantic and enchanting experience.", Date = new DateTime(2023, 02, 14) }
        );
    }
  }
}