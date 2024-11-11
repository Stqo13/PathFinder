using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Data.Models
{
    [Comment("User's jobs")]
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
        public int JobId { get; set; }

        [Comment("Job's navigation property")]
        [ForeignKey(nameof(JobId))]
        public virtual Job Job { get; set; } = null!;
    }
}
