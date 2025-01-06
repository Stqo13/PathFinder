using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class ReviewConfiguration
        : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(this.GenerateReviews());
        }

        public IEnumerable<Review> GenerateReviews()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}\\PathFinder.Data\\Data\\reviews.json");

            var reviews = JsonConvert.DeserializeObject<List<Review>>(json)
                ?? throw new Exception("Invalid json file path");

            return reviews;
        }
    }
}
