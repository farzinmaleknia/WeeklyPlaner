using System.ComponentModel.DataAnnotations;

namespace WeeklyPlaner.Models
{
    public class Grocery
    {
        [Required]
        public string Name { get; set; }

        public string Amount { get; set; }
    }
}
