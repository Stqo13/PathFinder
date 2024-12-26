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

        [Comment("User's interests")]
        public virtual ICollection<UserInterest>? UsersInterests { get; set; }
            = new List<UserInterest>();

        [Comment("Use's address")]
        [Required]
        [MaxLength(UserAddressMaxLength)]
        public string Address { get; set; } = null!;

        public virtual ICollection<Review> Reviews { get; set; }
            = new List<Review>();

        public ICollection<UserJob> UsersJobs { get; set; }
            = new List<UserJob>();

        public ICollection<UserCourse> UsersCourses { get; set; }
           = new List<UserCourse>();
    }
}
