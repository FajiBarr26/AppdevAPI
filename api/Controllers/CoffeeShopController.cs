using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.Data;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/coffeeshop")]
    [ApiController]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public CoffeeShopController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var coffeeShops = await _context.CoffeeShops.ToListAsync();
            return Ok(coffeeShops);
        }
    }
}
