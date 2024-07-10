using System;

namespace WeeklyPlaner.Models
{
    public class Week
    {
        static PersianPhrases PersianPhrases = new PersianPhrases();
        static EnglishPhrases EnglishPhrases = new EnglishPhrases();
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

        public Week(string selectedLang)
        {
            Id = Guid.NewGuid().ToString();
            Thursday = new Day(selectedLang) { Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Thursday: EnglishPhrases.Thursday, TitleEn = EnglishPhrases.Thursday };
            Friday = new Day(selectedLang) { Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Friday : EnglishPhrases.Friday, TitleEn = EnglishPhrases.Friday };
            Saturday = new Day(selectedLang) { Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Saturday : EnglishPhrases.Saturday, TitleEn = EnglishPhrases.Saturday };
            Sunday = new Day(selectedLang) { Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Sunday : EnglishPhrases.Sunday, TitleEn = EnglishPhrases.Sunday, };
            Monday = new Day(selectedLang) { Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Monday : EnglishPhrases.Monday, TitleEn = EnglishPhrases.Monday, };
            Tuesday = new Day(selectedLang) { Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Tuesday : EnglishPhrases.Tuesday, TitleEn = EnglishPhrases.Tuesday, };
            Wednesday = new Day(selectedLang) { Title = selectedLang == PersianPhrases.Persian ? PersianPhrases.Wednesday : EnglishPhrases.Wednesday, TitleEn = EnglishPhrases.Wednesday, };
            WeeksStartDay  = new StartDay()
            {
                Persian = PersianPhrases.Thursday,
                English = EnglishPhrases.Thursday,
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
