namespace WeeklyPlaner.Models
{
    public class Day
    {
        public string Title { get; set; }
        public Meal Braekfast { get; set; }
        public Meal Lunch { get; set; }
        public Meal Dinner { get; set; }

		public IEnumerable<Meal> Meals { get; set;  } 

		public IEnumerable<Meal> GetMeals()
		{
			return Meals = new List<Meal>() { Braekfast, Lunch, Dinner};

		}
	}
}
