namespace WeeklyPlaner.Models
{
    public class Meal
    {
        public string Title { get; set; }
        public Food Food { get; set; } = new Food();
        public bool GroceryEditable { get; set; } = false;
        public List<Grocery> Groceries { get; set; }
    }
}
