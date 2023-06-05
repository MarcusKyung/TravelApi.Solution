using System.ComponentModel.DataAnnotations;

namespace TravelApi.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    [Required]
    public string Country { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string UserName { get; set; }
    [Required]
    [Range(0, 10, ErrorMessage = "Rating must be on a scale of 1 to 10.")]
    public int Rating { get; set; }
    [Required]
    public string Description { get; set; }
  }
}
