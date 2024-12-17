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
            builder.HasData(this.GenerateReviews());
        }

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
                    JobId = 15
                },
                new ()
                {
                    Id = 2,
                    StarRating = 2,
                    Comment = "The work environment is stressful, with a high patient load and not enough time to give each patient the attention they deserve. There is little room for advancement, and management is not supportive of new ideas or improvements.",
                    ReviewDate = new DateTime(2024, 11, 12),
                    PublisherId = "ca145762-b5db-4836-b963-85eff67fb124",
                    JobId = 15
                },
                new ()
                {
                    Id = 3,
                    StarRating = 5,
                    Comment = "Working as a hairdresser here has been a fantastic experience. The team is supportive, and I’ve learned so much from the senior stylists. The work environment is welcoming, and there’s plenty of opportunity for professional growth.",
                    ReviewDate = new DateTime(2024, 12, 16),
                    PublisherId = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355",
                    JobId = 3
                },
                new ()
                {
                    Id = 4,
                    StarRating = 2,
                    Comment = "The job can be physically demanding, and the work environment is often chaotic. There’s a lack of clear communication from management, and the hours can be long with not enough time to properly address every vehicle. The pay doesn’t reflect the workload.",
                    ReviewDate = new DateTime(2024, 10, 10),
                    PublisherId = "7d089603-dc80-415a-913b-f24b1a90b5f1",
                    JobId = 4
                },
                new ()
                {
                    Id = 5,
                    StarRating = 5,
                    Comment = "Working as a software developer here has been an incredibly rewarding experience. The company fosters a collaborative work environment, and I’ve had the opportunity to work on cutting-edge technologies. There’s a great work-life balance, and management supports continuous learning.",
                    ReviewDate = new DateTime(2024, 11, 29),
                    PublisherId = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355",
                    JobId = 1
                },
                new ()
                {
                    Id = 6,
                    StarRating = 2,
                    Comment = "The job is physically demanding, and there is often a lack of support from management. The hours can be inconsistent, and the workload can sometimes feel overwhelming with little recognition. The communication about tasks and expectations could be improved.",
                    ReviewDate = new DateTime(2024, 8, 19),
                    PublisherId = "9e547484-9ea8-45e6-a488-d657f6f1c598",
                    JobId = 7
                },

                new ()
                {
                    Id = 7,
                    StarRating = 4,
                    Comment = "The English learning course is extremely well-structured. The lessons are engaging, and the instructors are knowledgeable and supportive. It has greatly improved my language skills, and I feel more confident speaking and writing in English.",
                    ReviewDate = new DateTime(2024, 8, 21),
                    PublisherId = "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2",
                    CourseId = 8
                },
                new ()
                {
                    Id = 8,
                    StarRating = 4,
                    Comment = "The course lacks personalized attention, and the pace can be too fast for beginners. The materials feel outdated, and there aren't enough interactive elements to keep learners engaged. It didn’t meet my expectations.",
                    ReviewDate = new DateTime(2024, 11, 27),
                    PublisherId = "9e547484-9ea8-45e6-a488-d657f6f1c598",
                    JobId = 8
                },
                new ()
                {
                    Id = 9,
                    StarRating = 5,
                    Comment = "The web development exceeded my expectations. The curriculum is comprehensive, and the instructors are very knowledgeable. I gained practical coding skills and was able to work on real-world projects. Highly recommended!",
                    ReviewDate = new DateTime(2024, 8, 1),
                    PublisherId = "e8d223af-7285-41c5-8c38-9e6989d4410d",
                    JobId = 2
                },
                new ()
                {
                    Id = 10,
                    StarRating = 2,
                    Comment = "The course was too basic for my expectations. It focused a lot on introductory concepts, with very little in-depth coverage of advanced topics. I also found the pacing to be too slow, and some of the exercises were not as challenging as I had hoped.",
                    ReviewDate = new DateTime(2024, 2, 11),
                    PublisherId = "9e547484-9ea8-45e6-a488-d657f6f1c598",
                    JobId = 4
                },
                new ()
                {
                    Id = 11,
                    StarRating = 4,
                    Comment = "This Fine Art course was amazing! The instructors were incredibly talented and offered personalized feedback. The course covered a variety of techniques and mediums, which really helped me improve my skills. The hands-on approach and creative atmosphere made learning fun and engaging.",
                    ReviewDate = new DateTime(2024, 6, 6),
                    PublisherId = "ca145762-b5db-4836-b963-85eff67fb124",
                    JobId = 9
                },
                new ()
                {
                    Id = 12,
                    StarRating = 5,
                    Comment = "The Spanish class was an incredible experience! The teacher was engaging and patient, making learning enjoyable. The lessons were interactive, and the class size was perfect for personalized attention. I feel much more confident in speaking and understanding Spanish after completing the course.",
                    ReviewDate = new DateTime(2023, 7, 8),
                    PublisherId = "ca145762-b5db-4836-b963-85eff67fb124",
                    JobId = 5
                }
            };

            return reviews;
        }
    }
}
