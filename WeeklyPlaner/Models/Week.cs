using System;

namespace WeeklyPlaner.Models
{
    public class Week
    {
        public int Id { get; set; }
        public Day Thursday { get; set; }
        public Day Friday { get; set; }
        public Day Saturday { get; set; }
        public Day Sunday { get; set; }
        public Day Monday { get; set; }
        public Day Tuesday { get; set; }
        public Day Wednesday { get; set; }

        public IEnumerable<string> Colors { get; } = new List<string>() { "blue", "red", "green", "orange", "purple", "mustard", "skyblue" };
        public IEnumerable<Day> Weekdays { get; set; } 

        public IEnumerable<Day> GetDays()
        {
			return Weekdays = new List<Day>() { Thursday, Friday, Saturday, Sunday, Monday, Tuesday, Wednesday};

		}

	}
}
