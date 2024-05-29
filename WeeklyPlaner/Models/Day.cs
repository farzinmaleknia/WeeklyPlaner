namespace WeeklyPlaner.Models
{
    public class Day
    {
        public string Title { get; set; }
        public Meal Braekfast { get; set; } = new Meal()
		{
			Title = "صبحانه",
		};
        public Meal Lunch { get; set; } = new Meal()
		{
			Title = "ناهار",
		};
		public Meal Dinner { get; set; } = new Meal()
		{
			Title = "شام",
		};

		public IEnumerable<Meal> Meals { get; set;  } 

		public IEnumerable<Meal> GetMeals()
		{
			return Meals = new List<Meal>() { Braekfast, Lunch, Dinner};

		}
	}
}
