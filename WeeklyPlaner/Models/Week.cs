using System;

namespace WeeklyPlaner.Models
{
    public class Week
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public Day Thursday { get; set; } = new Day(){ Title = "پنج‌شنبه",};
		public Day Friday { get; set; } = new Day() { Title = "جمعه",};
		public Day Saturday { get; set; } = new Day() { Title = "شنبه" };
        public Day Sunday { get; set; } = new Day() { Title = "یکشنبه" };
        public Day Monday { get; set; } = new Day() { Title = "دوشنبه" };
        public Day Tuesday { get; set; } = new Day() { Title = "سه‌شنبه" };
        public Day Wednesday { get; set; } = new Day() { Title = "چهارشنبه" };
        public string color { get; set; }

        public List<string> Colors { get; } = new List<string>() { "blue", "red", "green", "brown", "orange", "purple", "mustard", "skyblue", "darkblue", "darkpurple", "darkpink" };

        public IEnumerable<Day> GetDays()
        {
			return new List<Day>() { Thursday, Friday, Saturday, Sunday, Monday, Tuesday, Wednesday};

		}

	}
}
