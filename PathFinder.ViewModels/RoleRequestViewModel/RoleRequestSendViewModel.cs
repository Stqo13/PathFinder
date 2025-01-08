using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.RoleRequestConstraints;

namespace PathFinder.ViewModels.RoleRequestViewModel
{
    public class RoleRequestSendViewModel
    {
        [Required]
        public int Id { get; set; }

        [MaxLength(SenderMaxLength)]
        [Required]
        public string Sender { get; set; } = null!;

        [MaxLength(DescriptionMaxLength)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string Status { get; set; } = null!;
    }
}
