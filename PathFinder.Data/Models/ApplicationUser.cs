using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.UserConstraints;

namespace PathFinder.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Comment("User's first name")]
        [MaxLength(UserFirstNameMaxLength)]
        public string? FirstName { get; set; }

        [Comment("User's last name")]
        [MaxLength(UserLastNameMaxLength)]
        public string? LastName { get; set; } 

        [Comment("User's date of birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }


        /// <summary>
        /// FORMAT "Country, City, Street"
        /// </summary>
        [Comment("User's address")]
        [MaxLength(UserAddressMaxLength)]
        public string? Address { get; set; }

        [Comment("User's jobs")]
        public virtual ICollection<Job> Jobs { get; set; }
            = new List<Job>();

        [Comment("User's course")]
        public virtual ICollection<Course> Course { get; set; }
            = new List<Course>();

        [Comment("User's reviews")]
        public virtual ICollection<Review> Reviews { get; set; }
            = new List<Review>();

        [Comment("User's jobs")]
        public virtual ICollection<UserJob> UsersJobs { get; set; }
            = new List<UserJob>();

        [Comment("User's courses")]
        public virtual ICollection<UserCourse> UsersCourses { get; set; }
           = new List<UserCourse>();

        [Comment("User's spheres")]
        public virtual ICollection<UserSphere> UsersSpheres { get; set; }
            = new List<UserSphere>();
    }
}
