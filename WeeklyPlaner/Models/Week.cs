using System;

namespace WeeklyPlaner.Models
{
    public class Week
    {
        static PersianPhrases PersianPhrases = new PersianPhrases();
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public Day Thursday { get; set; } = new Day(){ Title = PersianPhrases.Thursday, };
		public Day Friday { get; set; } = new Day() { Title = PersianPhrases.Friday,};
		public Day Saturday { get; set; } = new Day() { Title = PersianPhrases.Saturday, };
        public Day Sunday { get; set; } = new Day() { Title = PersianPhrases.Sunday, };
        public Day Monday { get; set; } = new Day() { Title = PersianPhrases.Monday, };
        public Day Tuesday { get; set; } = new Day() { Title = PersianPhrases.Tuesday, };
        public Day Wednesday { get; set; } = new Day() { Title = PersianPhrases.Wednesday, };
        public string color { get; set; }

        public Week()
        {
            Id = Guid.NewGuid().ToString();
        }

        public List<string> Colors { get; } = new List<string>() { "skyblue", "darkpink", "darkpurple", "mustard", "orange"};

        public IEnumerable<Day> GetDays()
        {
			return new List<Day>() { Thursday, Friday, Saturday, Sunday, Monday, Tuesday, Wednesday};

		}

        public List<string> GetWeeksTitle()
        {
			return new List<string>() { PersianPhrases.CurrentWeek, PersianPhrases.LastWeek, PersianPhrases.TwoWeeksAgo, PersianPhrases.ThreeWeeksAgo};

		}

	}
}
