using System.Reflection;
using System;

namespace WeeklyPlaner.Models
{
    public class FoodCategory
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Food> foods { get; set; } = new List<Food>();

        public FoodCategory()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
