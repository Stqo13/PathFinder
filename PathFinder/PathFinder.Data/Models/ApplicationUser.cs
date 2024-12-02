using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.UserConstraints;

namespace PathFinder.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Comment("User's first name")]
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Comment("User's last name")]
        [Required]
        [MaxLength(UserLastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Comment("User's date of birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Comment("Use's address")]
        [Required]
        [MaxLength(UserAddressMaxLength)]
        public string Address { get; set; } = null!;

        [Comment("User's reviews")]
        public virtual ICollection<Review> Reviews { get; set; }
            = new List<Review>();

        [Comment("User's jobs")]
        public virtual ICollection<UserJob> UsersJobs { get; set; }
            = new List<UserJob>();

        [Comment("User's courses")]
        public virtual ICollection<UserCourse> UsersCourses { get; set; }
           = new List<UserCourse>();

        [Comment("User's sheres")]
        public virtual ICollection<UserSphere> UsersSpheres { get; set; }
            = new List<UserSphere>();
    }
}
