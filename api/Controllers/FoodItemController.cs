using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.Data;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/fooditem")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public FoodItemController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var foodItems = await _context.FoodItems.ToListAsync();
            return Ok(foodItems);
        }
    }
}