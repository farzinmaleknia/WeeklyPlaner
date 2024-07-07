namespace WeeklyPlaner.Models
{
    public class Day
    {
		static PersianPhrases PersianPhrases = new PersianPhrases();
        public string Id { get; set; }
        public string Title { get; set; }
        public string TitleEn { get; set; }
        public Meal Braekfast { get; set; } 
        public Meal Lunch { get; set; } 
		public Meal Dinner { get; set; }
        public string color { get; set; }
        public bool IsDayPassed { get; set; }
		public bool IsCreateBtnNeeded { get; set; } = false;
        public bool IsDayCollapsed { get; set; } = false;
        public bool IsDayBlank { get; set; } = false;
        public Day()
        {
            Id = Guid.NewGuid().ToString();
            Braekfast = new Meal(){ Title = PersianPhrases.Breakfast, }; 
			Lunch = new Meal() { Title = PersianPhrases.Lunch, };
            Dinner = new Meal(){ Title = PersianPhrases.Dinner, };
        }

		public IEnumerable<Meal> GetMeals()
		{
			return new List<Meal>() { Braekfast, Lunch, Dinner};

        }
    }
}
