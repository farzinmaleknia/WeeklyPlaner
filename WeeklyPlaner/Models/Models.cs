namespace WeeklyPlaner.Models
{
    public class Models
    {
        public string WeekId { get; set; }
        public string InsertedWeek { get; set; }
        public Day DayModel { get; set; } 
        public Meal MealModel { get; set; } = new Meal();
        public Grocery GroceryModel { get; set; } = new Grocery();  
        public FoodCategory CategoryModel { get; set; } = new FoodCategory();
        public Food FoodModel { get; set; } = new Food();
        public StartDay StartDay { get; set; } = new StartDay()
        {
            Persian = "پنجشنبه",
            English = "Thursday",
        };
        public bool IsForAddMeal { get; set; } = false;
        public bool IsForAddCat { get; set; } = false;
        public bool IsForAddFood { get; set; } = false;
        public bool IsFoodEatenChanged { get; set; } = false;
        public bool IsGroceriesShareNextWeek { get; set; } = false;
        public bool IsForNextWeekInsert { get; set; } = false;
        public bool IsForWeeksClear { get; set; } = false;
        public bool IsForFoodsClear { get; set; } = false;

        public Models(string selectedLang)
        {
            DayModel = new Day(selectedLang);
        }
    }
}
