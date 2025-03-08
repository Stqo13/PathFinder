using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Data.Models
{
    [Comment("Users' jobs")]
    [PrimaryKey(nameof(UserId), nameof(JobId))]
    public class UserJob
    {
        [Comment("User's foreign key")]
        [Required]
        public string UserId { get; set; } = null!;

        [Comment("User's navigation property")]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        [Comment("Job's foreign key")]
        [Required]
        public int JobId { get; set; }

        [Comment("Job's navigation property")]
        [ForeignKey(nameof(JobId))]
        public virtual Job Job { get; set; } = null!;

        //[Comment("File name, uuid")]
        //public string? FileName { get; set; }
    }
}
