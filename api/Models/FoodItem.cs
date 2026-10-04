using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal OverallRating { get; set; }
        public List<UserReview> UserReviews { get; set; } = new List<UserReview>(); // Collection for User Reviews
        public int? CategoryId { get; set; } // FK for Category 
        public Category? Category { get; set; } // Navigation for Category
        public int? CoffeeShopId { get; set; } // FK for Coffee Shop
        public CoffeeShop? CoffeeShop { get; set; } // Navigation for Coffee Shop

    }
}