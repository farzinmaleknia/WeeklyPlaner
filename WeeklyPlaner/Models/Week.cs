using System;

namespace WeeklyPlaner.Models
{
    public class Week
    {
        static PersianPhrases PersianPhrases = new PersianPhrases();
        public string Id { get; set; }
        public string Title { get; set; }
        public StartDay WeeksStartDay { get; set; }
        public Day Thursday { get; set; } 
		public Day Friday { get; set; } 
		public Day Saturday { get; set; } 
        public Day Sunday { get; set; }
        public Day Monday { get; set; } 
        public Day Tuesday { get; set; } 
        public Day Wednesday { get; set; } 
        public string HeaderColor { get; set; }
        public string Color { get; set; }

        public Week()
        {
            Id = Guid.NewGuid().ToString();
            Thursday = new Day() { Title = PersianPhrases.Thursday, TitleEn = "Thursday" };
            Friday = new Day() { Title = PersianPhrases.Friday, TitleEn = "Friday" };
            Saturday = new Day() { Title = PersianPhrases.Saturday, TitleEn = "Saturday" };
            Sunday = new Day() { Title = PersianPhrases.Sunday, TitleEn = "Sunday", };
            Monday = new Day() { Title = PersianPhrases.Monday, TitleEn = "Monday", };
            Tuesday = new Day() { Title = PersianPhrases.Tuesday, TitleEn = "Tuesday", };
            Wednesday = new Day() { Title = PersianPhrases.Wednesday, TitleEn = "Wednesday", };
            WeeksStartDay  = new StartDay()
            {
                Persian = PersianPhrases.Thursday,
                English = "Thursday",
            };
        }

        public List<string> GetColors()
        {
			return new List<string>() { "skyblue", "darkpink", "darkpurple", "mustard", "orange" };

		}

        public List<Day> GetDays()
        {
            var list = new List<Day>() { Thursday, Friday, Saturday, Sunday, Monday, Tuesday, Wednesday };

            if (WeeksStartDay.Persian != null)
            {
                while (list[0].Title != WeeksStartDay.Persian)
                {
                    var day = list[0];
                    list.RemoveAt(0);
                    list.Insert(list.Count, day);
                }
            }

			return list;
		}

        public List<string> GetWeeksTitle()
        {
			return new List<string>() { PersianPhrases.NextWeek, PersianPhrases.CurrentWeek, PersianPhrases.LastWeek, PersianPhrases.TwoWeeksAgo, PersianPhrases.ThreeWeeksAgo};

		}

	}
}
