using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

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

      // query = query.OrderBy(review => review.ReviewId)
      //         .Skip((pageNumber - 1) * pageSize)
      //         .Take(pageSize); 

      return await query.ToListAsync();
    }

    // GET: api/Reviews/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Review>> GetReview(int id)
    {
      Review review = await _db.Reviews.FindAsync(id);

      if (review == null)
      {
        return NotFound();
      }

      return review;
    }

    [HttpGet("random")]
    public async Task<ActionResult<Review>> GetRandomReview()
    {
      List<Review> reviews = await _db.Reviews.ToListAsync();
      int random = new Random().Next(reviews.Count);
      return reviews[random];
    }

    // [HttpGet("page")]
    // public async Task<ActionResult<List<Review>>> GetReviews(int pageNumber = 1, int pageSize = 5 )
    // {
    //   List<Review> reviews = await _db.Reviews
    //     .OrderBy(review => review.ReviewId)
    //     .Skip((pageNumber - 1) * pageSize)
    //     .Take(pageSize)
    //     .ToListAsync();

    //   return reviews;
    //   // /api/reviews/page?pageNumber=1&pageSize=10
    // }

    // POST: api/reviews
    [HttpPost]
    public async Task<ActionResult<Review>> Post(Review review)
    {
      _db.Reviews.Add(review);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetReview), new { id = review.ReviewId }, review);
    }

    // PUT: api/Reviews/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Review review)
    {
      if (id != review.ReviewId)
      {
        return BadRequest();
      }

      _db.Reviews.Update(review);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ReviewExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool ReviewExists(int id)
    {
      return _db.Reviews.Any(e => e.ReviewId == id);
    }

    // DELETE: api/Reviews/5
    [HttpDelete("{id}")]
    public async Task<IActionResult>DeleteReview(int id)
    {
      Review review = await _db.Reviews.FindAsync(id);
      if (review == null)
      {
        return NotFound();
      }
      _db.Reviews.Remove(review);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  } 
}
