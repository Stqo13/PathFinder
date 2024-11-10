using System.ComponentModel.DataAnnotations;

namespace PathFinder.Data.Models
{
    public class Interest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;
    }
}
