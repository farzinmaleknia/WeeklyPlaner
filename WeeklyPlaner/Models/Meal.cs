namespace WeeklyPlaner.Models
{
    public class Meal
    {
        public string Title { get; set; }
        public string FoodName { get; set; }
        public bool GroceryEditable { get; set; } = false;
        public List<Grocery> Groceries { get; set; }
    }
}
