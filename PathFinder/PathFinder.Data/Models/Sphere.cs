using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PathFinder.Data.Models
{
    public class Sphere
    {
        [Comment("Sphere's identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Sphere")]
        [Required]
        public string Name { get; set; } = null!;

        [Comment("Sphere's users")]
        public virtual ICollection<UserSphere> UsersSpheres { get; set; }
            = new List<UserSphere>();

        [Comment("Sphere's courses")]
        public virtual ICollection<CourseSphere> CoursesSpheres { get; set; }
            = new List<CourseSphere>();

        [Comment("Sphere's job")]
        public virtual ICollection<JobSphere> JobsSpheres { get; set; }
            = new List<JobSphere>();
    }
}
