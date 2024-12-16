using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class ReviewConfiguration
        : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData();
        }

        /// <summary>
        /// TO DO !!!Is it course or job
        /// !!! more seeding
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Review> GenerateReviews()
        {
            
            var reviews = new HashSet<Review>
            {
                new ()
                {
                    Id = 1,
                    StarRating = 5,
                    Comment = "Working as a gynecologist here has been incredibly rewarding. The medical team is highly supportive, and I feel that my skills are valued. The clinic provides a great work-life balance, and there are plenty of opportunities for professional development.",
                    ReviewDate = new DateTime(2024, 12, 16),
                    PublisherId = "e8d223af-7285-41c5-8c38-9e6989d4410d",

                },
                new ()
                {
                    Id = 2,
                    StarRating = 2,
                    Comment = "The work environment is stressful, with a high patient load and not enough time to give each patient the attention they deserve. There is little room for advancement, and management is not supportive of new ideas or improvements.",
                    ReviewDate = new DateTime(2024, 11, 12),
                    PublisherId = "ca145762-b5db-4836-b963-85eff67fb124"
                },
                new ()
                {
                    Id = 3,
                    StarRating = 5,
                    Comment = "Working as a hairdresser here has been a fantastic experience. The team is supportive, and I’ve learned so much from the senior stylists. The work environment is welcoming, and there’s plenty of opportunity for professional growth.",
                    ReviewDate = new DateTime(2024, 12, 16),
                    PublisherId = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355"
                },
                new ()
                {
                    Id = 4,
                    StarRating = 2,
                    Comment = "The job can be physically demanding, and the work environment is often chaotic. There’s a lack of clear communication from management, and the hours can be long with not enough time to properly address every vehicle. The pay doesn’t reflect the workload.",
                    ReviewDate = new DateTime(2024, 10, 10),
                    PublisherId = "7d089603-dc80-415a-913b-f24b1a90b5f1"
                },
                new ()
                {
                    Id = 5,
                    StarRating = 5,
                    Comment = "Working as a software developer here has been an incredibly rewarding experience. The company fosters a collaborative work environment, and I’ve had the opportunity to work on cutting-edge technologies. There’s a great work-life balance, and management supports continuous learning.",
                    ReviewDate = new DateTime(2024, 11, 29),
                    PublisherId = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355"
                },
                new ()
                {
                    Id = 6,
                    StarRating = 2,
                    Comment = "The job is physically demanding, and there is often a lack of support from management. The hours can be inconsistent, and the workload can sometimes feel overwhelming with little recognition. The communication about tasks and expectations could be improved.",
                    ReviewDate = new DateTime(2024, 8, 19),
                    PublisherId = "9e547484-9ea8-45e6-a488-d657f6f1c598"
                }
            };


            return reviews;
        }
    }
}
