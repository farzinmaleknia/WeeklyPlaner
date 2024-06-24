namespace WeeklyPlaner.Models
{
    public class Models
    {
        public string WeekId { get; set; }
        public Day DayModel { get; set; } = new Day();
        public Meal MealModel { get; set; } = new Meal();
        public Grocery GroceryModel { get; set; } = new Grocery();  
        public FoodCategory CategoryModel { get; set; } = new FoodCategory();
        public Food FoodModel { get; set; } = new Food();
        public bool IsForAddMeal { get; set; } = false;
        public bool IsForAddCat { get; set; } = false;
        public bool IsForAddFood { get; set; } = false;
        public bool IsFoodEatenChanged { get; set; } = false;


    }
}
