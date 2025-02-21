using Microsoft.EntityFrameworkCore;
using PathFinder.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.ViewModels.Review
{
    public class ReviewInfoViewModel
    {
        public required int Id { get; set; }

        public required int? StarRating { get; set; }

        public required string? Comment { get; set; }

        public required string ReviewDate { get; set; } = null!;

        public required string Publisher { get; set; } = null!;
    }
}
