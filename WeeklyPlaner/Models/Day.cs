namespace WeeklyPlaner.Models
{
    public class Day
    {
		static PersianPhrases PersianPhrases = new PersianPhrases();
        public string Id { get; set; }
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
		public bool IsDayPassed { get; set; }
		public bool IsCreateBtnNeeded { get; set; } = false;
        public Day()
        {
            Id = Guid.NewGuid().ToString();
        }

		public IEnumerable<Meal> GetMeals()
		{
			return new List<Meal>() { Braekfast, Lunch, Dinner};

        }
    }
}
