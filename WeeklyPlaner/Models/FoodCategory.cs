using System.Reflection;
using System;

namespace WeeklyPlaner.Models
{
    public class FoodCategory
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public List<Food> foods { get; set; } = new List<Food>();

        public IEnumerable<Food> iterFood { get; set; }

        public IEnumerable<Food> GetFoods()
        {
            return  iterFood = foods;

        }

        public FoodCategory()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
