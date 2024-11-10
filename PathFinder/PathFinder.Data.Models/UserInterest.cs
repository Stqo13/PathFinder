using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Data.Models
{
    [Comment("User's interests")]
    [PrimaryKey(nameof(InterestId), nameof(UserId))]
    public class UserInterest
    {
        [Comment("Interest foreign key")]
        [Required]
        public int InterestId { get; set; }

        [Comment("Interest navigation property")]
        [ForeignKey(nameof(InterestId))]
        public virtual Interest Interest { get; set; } = null!;

        [Comment("User foreign key")]
        [Required]
        public string UserId { get; set; } = null!;

        [Comment("User navigation property")]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    }
}
