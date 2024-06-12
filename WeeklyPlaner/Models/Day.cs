namespace WeeklyPlaner.Models
{
    public class Day
    {
		static PersianPhrases PersianPhrases = new PersianPhrases();
        public string Title { get; set; }
        public Meal Braekfast { get; set; } = new Meal()
		{
			Title = PersianPhrases.Breakfast,
		};
        public Meal Lunch { get; set; } = new Meal()
		{
			Title = PersianPhrases.Lunch,
		};
		public Meal Dinner { get; set; } = new Meal()
		{
			Title = PersianPhrases.Dinner,
		};
		public string color { get; set; } 

		public IEnumerable<Meal> GetMeals()
		{
			return new List<Meal>() { Braekfast, Lunch, Dinner};

		}
	}
}
