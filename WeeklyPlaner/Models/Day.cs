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
		public string color { get; set; } 

		public IEnumerable<Meal> GetMeals()
		{
			return new List<Meal>() { Braekfast, Lunch, Dinner};

		}
	}
}
