using System;

namespace WeeklyPlaner.Models
{
    public class Week
    {
        static PersianPhrases PersianPhrases = new PersianPhrases();
        static EnglishPhrases EnglishPhrases = new EnglishPhrases();
        public string Id { get; set; }
        public string TitleFa { get; set; }
        public string TitleEn { get; set; }
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

        public Week(string selectedLang)
        {
            Id = Guid.NewGuid().ToString();
            Thursday = new Day(selectedLang) { TitleFa = PersianPhrases.Thursday, TitleEn = EnglishPhrases.Thursday, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Thursday : EnglishPhrases.Thursday, };
            Friday = new Day(selectedLang) { TitleFa = PersianPhrases.Friday, TitleEn = EnglishPhrases.Friday, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Friday : EnglishPhrases.Friday, };
            Saturday = new Day(selectedLang) { TitleFa = PersianPhrases.Saturday, TitleEn = EnglishPhrases.Saturday, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Saturday : EnglishPhrases.Saturday, };
            Sunday = new Day(selectedLang) { TitleFa = PersianPhrases.Sunday, TitleEn = EnglishPhrases.Sunday, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Sunday : EnglishPhrases.Sunday, };
            Monday = new Day(selectedLang) { TitleFa = PersianPhrases.Monday, TitleEn = EnglishPhrases.Monday, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Monday : EnglishPhrases.Monday, };
            Tuesday = new Day(selectedLang) { TitleFa = PersianPhrases.Tuesday, TitleEn = EnglishPhrases.Tuesday, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Tuesday : EnglishPhrases.Tuesday, };
            Wednesday = new Day(selectedLang) { TitleFa = PersianPhrases.Wednesday, TitleEn = EnglishPhrases.Wednesday, Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Wednesday : EnglishPhrases.Wednesday, };
            WeeksStartDay  = new StartDay()
            {
                TitleFa = PersianPhrases.Thursday,
                TitleEn = EnglishPhrases.Thursday,
                Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Thursday : EnglishPhrases.Thursday,
            };
        }

        public List<string> GetColors()
        {
			return new List<string>() { "skyblue", "darkpink", "blue", "mustard", "orange" };

		}

        public List<Day> GetDays()
        {
            var list = new List<Day>() { Thursday, Friday, Saturday, Sunday, Monday, Tuesday, Wednesday };

            if (WeeksStartDay.Title != null)
            {
                while (list[0].Title != WeeksStartDay.Title)
                {
                    var day = list[0];
                    list.RemoveAt(0);
                    list.Insert(list.Count, day);
                }
            }

			return list;
		}

        public List<string> GetWeeksTitleFa()
        {
			return new List<string>() { PersianPhrases.NextWeek, PersianPhrases.CurrentWeek, PersianPhrases.LastWeek, PersianPhrases.TwoWeeksAgo, PersianPhrases.ThreeWeeksAgo};

		}

        public List<string> GetWeeksTitleEn()
        {
			return new List<string>() { EnglishPhrases.NextWeek, EnglishPhrases.CurrentWeek, EnglishPhrases.LastWeek, EnglishPhrases.TwoWeeksAgo, EnglishPhrases.ThreeWeeksAgo};

		}

	}
}
