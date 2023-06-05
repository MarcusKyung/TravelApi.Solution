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
          new Review { ReviewId = 1, Country = "United States", City = "Honolulu", Rating = 9, UserName = "Mr_ReviewGuy", Description = "Lovely vacation destination with great weather. No spiders at all!" },
          new Review { ReviewId = 2, Country = "United States", City = "San Diego", Rating = 7, UserName = "Marcus", Description = "Sunny San Diego offers a perfect blend of beach bliss and urban spiders" },
          new Review { ReviewId = 3, Country = "United States", City = "Chicago", Rating = 10, UserName = "Jumping_Spider", Description = "Tons of spiders, I loved it" },
          new Review { ReviewId = 4, Country = "Japan", City = "Tokyo", Rating = 8, UserName = "Marcus", Description = "Basically the future, they have robot spiders" },
          new Review { ReviewId = 5, Country = "United States", City = "Honolulu", Rating = 6, UserName = "Nic_Cage", Description = "My stay was decent, this place could use some more spiders. I am going to steal the Declaration of Independence." }
        );
    }
  }
}