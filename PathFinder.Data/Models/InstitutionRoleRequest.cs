using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.RoleRequestConstraints;

namespace PathFinder.Data.Models
{
    public class InstitutionRoleRequest
    {
        [Comment("Company request identifier")]
        [Key]
        public int Id { get; set; }

        [Comment("Role request sender username")]
        [MaxLength(SenderMaxLength)]
        [Required]
        public string Sender { get; set; } = null!;

        [Comment("Reasoning for the role request")]
        [MaxLength(DescriptionMaxLength)]
        [Required]
        public string Description { get; set; } = null!;

        [Comment("Pending/Accepted/Declined request status")]
        public RequestStatus Status { get; set; }
    }
}
