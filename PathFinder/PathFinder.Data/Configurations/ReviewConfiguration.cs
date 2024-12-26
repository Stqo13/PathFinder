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
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\reviews.json";
            var json = File.ReadAllText(jsonFilePath);

            var reviews = JsonConvert.DeserializeObject<List<Review>>(json)
                ?? throw new Exception("Invalid json file path");

            return reviews;
        }
    }
}
