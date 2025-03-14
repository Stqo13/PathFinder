﻿using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;
using PathFinder.ViewModels.Review;

namespace PathFinder.ViewModels.CourseViewModels
{
    public class CourseDetailsViewModel
    {
        public required int Id { get; set; }

        public required string Name { get; set; } = null!;

        public required string Mode { get; set; }

        public required string? Description { get; set; }

        public required int DurationInMinutes { get; set; }

        public required int CourseDuration { get; set; }

        public required string Location { get; set; } = null!;

        public required DateTime StartDate { get; set; }

        public required DateTime EndDate { get; set; }

        public required double? AverageStarRating { get; set; }

        public required decimal Price { get; set; }

        public List<ReviewInfoViewModel> Reviews { get; set; }
           = new List<ReviewInfoViewModel>();
    }
}
