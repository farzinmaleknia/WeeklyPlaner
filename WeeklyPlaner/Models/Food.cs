namespace WeeklyPlaner.Models
{
    public class Food
    {
        public string Name { get; set; }
        public bool IsEatenRecently { get; set; } = false;

        public Food(string name) 
        {
            Name = name;
        }

        public Food() 
        {
        }
    }
}
