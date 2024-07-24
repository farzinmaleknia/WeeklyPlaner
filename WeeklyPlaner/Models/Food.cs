using System.ComponentModel.DataAnnotations;

namespace WeeklyPlaner.Models
{
    public class Food
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public bool IsEatenRecently { get; set; } = false;
        public bool IsSelectedForDel { get; set; } = false;

        public Food(string name) 
        {
            Name = name;
            Id = Guid.NewGuid().ToString();
        }

        public Food() 
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
