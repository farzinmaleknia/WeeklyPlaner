namespace WeeklyPlaner.Models
{
    public class FoodCategory
    {
        public string Title { get; set; }
        public List<Food> foods { get; set; } = new List<Food>();
    }
}
