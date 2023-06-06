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
          new Review { ReviewId = 5, Destination = "Alley behind Quiznos", Country = "United States", City = "Honolulu", Rating = 6, UserName = "Nic_Cage", Description = "My stay was decent, this place could use some more spiders. I am going to steal the Declaration of Independence.", Date = new DateTime(2012, 10, 09) }
        );
    }
  }
}