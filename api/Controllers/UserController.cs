using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using api.Data;
using Microsoft.EntityFrameworkCore;
using api.Mapper;

namespace api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _context.Users
            .Select(u => u.ToUserDto())
            .ToListAsync();
            return Ok(users);
        }

         [HttpGet("{id}")]
         public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user == null)
            {
                return NotFound();
            }
            return Ok(user.ToUserDto());
        }
    }
}