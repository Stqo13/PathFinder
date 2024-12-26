using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace PathFinder.Data.Models
{
    public class Interest
    {
        [Comment("Interest's idetifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Interest's type")]
        [Required]
        public string InterestType { get; set; } = null!;

        [Comment("User's preferred sphere")]
        public Sphere PreferredSphere { get; set; }

        public ICollection<UserInterest> UsersInterests { get; set; }
            = new List<UserInterest>();
    }
}
