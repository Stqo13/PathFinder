using System.ComponentModel.DataAnnotations;
using static PathFinder.Common.ApplicationConstraints.MessageConstraints;

namespace PathFinder.Data.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string SenderId { get; set; } = null!;
        public string ReceiverId { get; set; } = null!;

        [MaxLength(ContentMaxLength)]
        public string Content { get; set; } = null!;
        public DateTime ReceiveDate { get; set; }
        public bool IsRead { get; set; }
    }
}
