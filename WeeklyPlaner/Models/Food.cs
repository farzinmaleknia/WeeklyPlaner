namespace WeeklyPlaner.Models
{
    public class Food
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool IsEatenRecently { get; set; } = false;
        public bool IsSelectedForDel { get; set; } = false;

        public Food(string name) 
        {
            Name = name;
        }

        public Food() 
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
