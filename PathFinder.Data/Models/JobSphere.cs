using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Data.Models
{
    [Comment("Jobs' spheres")]
    [PrimaryKey(nameof(JobId), nameof(SphereId))]
    public class JobSphere
    {
        [Comment("Job's foreign key")]
        public int JobId { get; set; }

        [ForeignKey(nameof(JobId))]
        [Comment("Job's navigation property")]
        public virtual Job Job { get; set; } = null!;

        [Comment("Sphere's foreign key")]
        public int SphereId { get; set; }

        [ForeignKey(nameof(SphereId))]
        [Comment("Sphere's navigation property")]
        public virtual Sphere Sphere { get; set; } = null!;
    }
}
