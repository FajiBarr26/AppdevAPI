using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<UserReview> UserReviews { get; set; } = new List<UserReview>();
    }
}