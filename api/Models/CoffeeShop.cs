using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace api.Models
{
    public class CoffeeShop
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal CeilingPrice { get; set; }
        public decimal FloorPrice { get; set; }
        public TimeOnly OpeningHour { get; set; }
        public decimal OverallRating { get; set; }
        public List<FoodItem> FoodItems { get; set; } = new List<FoodItem>(); // Collection for Food Items
    }
}