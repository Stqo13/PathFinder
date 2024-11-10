using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using PathFinder.Data.Models.Enums;
using static PathFinder.Common.ApplicationConstraints.UserConstraints;
using System.ComponentModel.DataAnnotations.Schema;


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

        [Comment("User's intersests")]
        public virtual ICollection<UserInterest>? Interests { get; set; }
            = new List<UserInterest>();

        [Comment("User's preferred sphere")]
        public Sphere PreferredSphere { get; set; }

        [Comment("Use's address")]
        [Required]
        [MaxLength(UserAddressMaxLength)]
        public string Address { get; set; } = null!;

        public virtual ICollection<Review> Reviews { get; set; }
            = new List<Review>();
            
    }
}
