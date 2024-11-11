using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Data.Models
{
    [Comment("User's courses")]
    [PrimaryKey(nameof(UserId), nameof(CourseId))]
    public class UserCourse
    {
        [Comment("User's foreign key")]
        [Required]
        public int UserId { get; set; }

        [Comment("User's navigation property")]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        [Comment("Course's foreign key")]
        [Required]
        public string CourseId { get; set; } = null!;

        [Comment("Course's navigation property")]
        [ForeignKey(nameof(CourseId))]
        public virtual Course Course { get; set; } = null!;

    }
}
