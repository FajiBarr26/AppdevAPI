using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.Data;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/review")]
    [ApiController]
    public class UserReviewController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public UserReviewController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var reviews = await _context.UserReviews.ToListAsync();
            return Ok(reviews);
        }
    }
}