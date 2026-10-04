using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<FoodItem> FoodItems { get; set; } = new List<FoodItem>(); // Collection for Food Items
    }
}