using System;

namespace WeeklyPlaner.Models
{
    public class Week
    {
        static PersianPhrases PersianPhrases = new PersianPhrases();
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public Day Thursday { get; set; } 
		public Day Friday { get; set; } 
		public Day Saturday { get; set; } 
        public Day Sunday { get; set; }
        public Day Monday { get; set; } 
        public Day Tuesday { get; set; } 
        public Day Wednesday { get; set; } 
        public string color { get; set; }

        public Week()
        {
            Id = Guid.NewGuid().ToString();
            Thursday = new Day() { Title = PersianPhrases.Thursday, };
            Friday = new Day() { Title = PersianPhrases.Friday, };
            Saturday = new Day() { Title = PersianPhrases.Saturday, };
            Sunday = new Day() { Title = PersianPhrases.Sunday, };
            Monday = new Day() { Title = PersianPhrases.Monday, };
            Tuesday = new Day() { Title = PersianPhrases.Tuesday, };
            Wednesday = new Day() { Title = PersianPhrases.Wednesday, };
        }

        public List<string> GetColors()
        {
			return new List<string>() { "skyblue", "darkpink", "darkpurple", "mustard", "orange" };

		}

        public IEnumerable<Day> GetDays()
        {
			return new List<Day>() { Thursday, Friday, Saturday, Sunday, Monday, Tuesday, Wednesday};

		}

        public List<string> GetWeeksTitle()
        {
			return new List<string>() { PersianPhrases.NextWeek, PersianPhrases.CurrentWeek, PersianPhrases.LastWeek, PersianPhrases.TwoWeeksAgo, PersianPhrases.ThreeWeeksAgo};

		}

	}
}
