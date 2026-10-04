using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace api.Dtos.User
{
    public class UserDto
    {
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}