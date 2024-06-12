using System;

namespace WeeklyPlaner.Models
{
    public class Week : PersianPhrases
    {
        static PersianPhrases PersianPhrases = new PersianPhrases();
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public Day Thursday { get; set; } = new Day(){ Title = PersianPhrases.Thursday, };
		public Day Friday { get; set; } = new Day() { Title = PersianPhrases.Friday,};
		public Day Saturday { get; set; } = new Day() { Title = PersianPhrases.Saturday, };
        public Day Sunday { get; set; } = new Day() { Title = PersianPhrases.Sunday, };
        public Day Monday { get; set; } = new Day() { Title = PersianPhrases.Monday, };
        public Day Tuesday { get; set; } = new Day() { Title = PersianPhrases.Tuesday, };
        public Day Wednesday { get; set; } = new Day() { Title = PersianPhrases.Wednesday, };
        public string color { get; set; }

        public List<string> Colors { get; } = new List<string>() { "blue", "red", "green", "brown", "orange", "purple", "mustard", "skyblue", "darkblue", "darkpurple", "darkpink" };

        public IEnumerable<Day> GetDays()
        {
			return new List<Day>() { Thursday, Friday, Saturday, Sunday, Monday, Tuesday, Wednesday};

		}

	}
}
