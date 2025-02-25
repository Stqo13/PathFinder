using System.ComponentModel.DataAnnotations;

namespace PathFinder.ViewModels.ReviewViewModels
{
    public class ReviewAddViewModel
    {
        [Required]
        public int Id { get; set; }

        public int? StarRating { get; set; }

        [Required]
        public string Comment { get; set; } = null!;

        [Required]
        public DateTime ReviewDate { get; set; } = DateTime.Now;

        [Required]
        public string PublisherId { get; set; } = null!;

        public int? JobId { get; set; }

        public int? CourseId { get; set; }

    }
}
