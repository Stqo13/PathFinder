using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Data.Models
{
    [Comment("Users' spheres")]
    [PrimaryKey(nameof(UserId), nameof(SphereId))]
    public class UserSphere
    {
        [Comment("User's foreign key")]
        [Required]
        public string UserId { get; set; } = null!;

        [Comment("User's navigation property")]
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        [Comment("Sphere's foreign key")]
        [Required]
        public int SphereId { get; set; }

        [Comment("Sphere's navigation property")]
        [ForeignKey(nameof(SphereId))]
        public virtual Sphere Sphere { get; set; } = null!;
    }
}
