namespace WeeklyPlaner.Models
{
    public class StartDay
    {
        public string TitleFa { get; set; }
        public string TitleEn { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public bool IsStartDayChanged { get; set; } = false;
    }
}
