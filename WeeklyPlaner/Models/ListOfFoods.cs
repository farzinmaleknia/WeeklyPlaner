namespace WeeklyPlaner.Models
{
    public class ListOfFoods
    {
        public FoodCategory BreakfastFoods { get; set; } = new FoodCategory() { Title = "صبحانه" };
        public FoodCategory FoodsWithBread { get; set; } = new FoodCategory() { Title = "غذاهای نونی" };
        public FoodCategory FoodsWithRice { get; set; } = new FoodCategory() { Title = "غذاهای برنجی" };
        public FoodCategory FoodsWithVegetables { get; set; } = new FoodCategory() { Title = "غذاهای سبزیجاتی" };
        public FoodCategory FoodsWithBeans { get; set; } = new FoodCategory() { Title = "غذاهای حبوباتی" };
        public FoodCategory FoodWithNothings { get; set; } = new FoodCategory() { Title = "غذاهای نشاسته ای" };
        public FoodCategory FastPreptrationFoods { get; set; } = new FoodCategory() { Title = "غذاهای سریع" };
        public FoodCategory SideFoods { get; set; } = new FoodCategory() { Title = "کنار غذا" };

        public IEnumerable<FoodCategory> GetFoodList()
        {
            return new List<FoodCategory>() { BreakfastFoods, FoodsWithBread, FoodsWithRice, FoodsWithVegetables, FoodsWithBeans, FoodWithNothings, FastPreptrationFoods, SideFoods };

        }
    }
}
