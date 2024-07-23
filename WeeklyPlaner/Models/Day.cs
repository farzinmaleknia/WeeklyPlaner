namespace WeeklyPlaner.Models
{
    public class Day
    {
		static PersianPhrases PersianPhrases = new PersianPhrases();
		static EnglishPhrases EnglishPhrases = new EnglishPhrases();
        public string Id { get; set; }
        public string TitleFa { get; set; }
        public string TitleEn { get; set; }
        public string Title { get; set; }
        public Meal Braekfast { get; set; } 
        public Meal Lunch { get; set; } 
		public Meal Dinner { get; set; }
        public string color { get; set; }
        public bool IsDayPassed { get; set; }
		public bool IsCreateBtnNeeded { get; set; } = false;
        public bool IsDayCollapsed { get; set; } = false;
        public bool IsDayBlank { get; set; } = false;
        public Day(string selectedLang)
        {
            Id = Guid.NewGuid().ToString();
            Braekfast = new Meal(){ TitleFa = PersianPhrases.Breakfast, TitleEn = EnglishPhrases.Breakfast, Title = selectedLang == PersianPhrases.Persian? PersianPhrases.Breakfast : EnglishPhrases.Breakfast, }; 
			Lunch = new Meal() { TitleFa = PersianPhrases.Lunch, TitleEn = EnglishPhrases.Lunch, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Lunch : EnglishPhrases.Lunch, };
            Dinner = new Meal(){ TitleFa = PersianPhrases.Dinner, TitleEn = EnglishPhrases.Dinner, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Dinner : EnglishPhrases.Dinner, };
        }

		public IEnumerable<Meal> GetMeals()
		{
			return new List<Meal>() { Braekfast, Lunch, Dinner};

        }
    }
}
