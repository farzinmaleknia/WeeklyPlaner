namespace WeeklyPlaner.Models
{
    public class Meal
    {
        public string Id { get; set; }
        public string TitleFa { get; set; }
        public string TitleEn { get; set; }
        public string Title { get; set; }
        public List<Food> Foods { get; set; } = new List<Food>();
        public bool GroceryEditable { get; set; } = false;
        public bool IsMealPassed { get; set; }
        public bool IsMealCollapsed { get; set; } = false;
        public bool IsFoodsEatenRecently { get; set; } = false;
        public bool IsMoreFoodNeeded { get; set; } = false;
        public List<Grocery> Groceries { get; set; }

        public Meal()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

}
