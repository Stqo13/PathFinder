﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PathFinder.Data.Models
{
    public class CourseOffer : Course
    {
        //public int CourseId { get; set; }

        //[ForeignKey(nameof(CourseId))]
        //public virtual Course Course { get; set; } = null!;

        //[Comment("Course offer's idetifier")]
        //[Key]
        //public int Id { get; set; }

        //[Comment("Course name")]
        //[Required]
        //[MaxLength(CourseNameMaxLength)]
        //public string Name { get; set; } = null!;


        //[Comment("Course description")]
        //[MaxLength(CourseDescriptionMaxLength)]
        //public string? Description { get; set; }

        //[Comment("Course mode(Online/In-person)")]
        //public Mode Mode { get; set; }

        //[Comment("Course duration in minutes")]
        //[Required]
        //public int DurationInMinutes { get; set; }

        //[Comment("Course location")]
        //[Required]
        //[MaxLength(CourseLocationMaxLength)]
        //public string Location { get; set; } = null!;

        [Comment("Course institution")]
        public string? Institution { get; set; }

        [Comment("Course average star rating")]
        public double? AverageStarRating { get; set; }

        [Comment("Course monthly price")]
        [Required]
        public decimal MonthlyPrice { get; set; }

        [Comment("Course reviews")]
        public virtual ICollection<Review>? Reviews { get; set; }
            = new List<Review>();
    }
}
