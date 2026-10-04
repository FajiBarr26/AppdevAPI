using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class UserReview
    {
        public int Id { get; set; } 
        public string Review { get; set; } = string.Empty;
        public DateTime DateWritten { get; set; } = DateTime.Now;
        public int Rating { get; set; }
        public string FilePath { get; set; } = string.Empty;
        public int? FoodItemId { get; set; } // FK of Food Item
        public FoodItem? FoodItem { get; set; } // Navigation prop to Food Item
        public int? UserId { get; set; } // FK of User
        public User? User { get; set; } // Navigation prop to User
    }
}