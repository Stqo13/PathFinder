using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace PathFinder.Data.Models
{
    [Comment("Corses' spheres")]
    [PrimaryKey(nameof(CourseId), nameof(SphereId))]
    public class CourseSphere
    {
        [Comment("Course's foreign key")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [Comment("Course's navigation property")]
        public virtual Course Course { get; set; } = null!;

        [Comment("Sphere's foreign key")]
        public int SphereId { get; set; }

        [ForeignKey(nameof(SphereId))]
        [Comment("Sphere's navigation property")]
        public Sphere Sphere { get; set; } = null!;
    }
}
