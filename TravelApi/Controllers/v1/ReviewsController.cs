using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace TravelApi.Controllers.v1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  public class ReviewsController : ControllerBase
  {
    private readonly TravelApiContext _db;

    public ReviewsController(TravelApiContext db)
    {
      _db = db;
    }

    // GET api/reviews
    [HttpGet]
    public async Task<List<Review>> Get(string destination, string city, string country, string userName, int minimumRating, string byRating, int pageNumber, int pageSize)
    {
      IQueryable<Review> query = _db.Reviews.AsQueryable();
      // how do we query by number of reviews without using another model/database join table?

      if (byRating == "true")
      {
        query = query.OrderByDescending(entry => entry.Rating);
      }

      if (destination != null)
      {
        query = query.Where(entry => entry.Destination == destination);
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }

      if (userName != null)
      {
        query = query.Where(entry => entry.UserName == userName);
      }

      if (minimumRating > 0)
      {
        query = query.Where(entry => entry.Rating >= minimumRating);
      }

      if (pageNumber > 0 && pageSize > 0)
      {
        query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize); 
      }

      // query = query.OrderBy(review => review.ReviewId)
      //         .Skip((pageNumber - 1) * pageSize)
      //         .Take(pageSize); 

      return await query.ToListAsync();
    }
  } 
}