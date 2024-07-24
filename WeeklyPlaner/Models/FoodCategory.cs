using System.Reflection;
using System;
using System.ComponentModel.DataAnnotations;

namespace WeeklyPlaner.Models
{
    public class FoodCategory
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }
        public List<Food> foods { get; set; } = new List<Food>();

        public FoodCategory()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
