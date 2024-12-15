using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;

namespace PathFinder.Data.Configurations
{
    public class JobOfferConfiguration
        : IEntityTypeConfiguration<JobOffer>
    {
        public void Configure(EntityTypeBuilder<JobOffer> builder)
        {
            builder.HasData(this.GenerateJobOffers());
        }

        public IEnumerable<JobOffer> GenerateJobOffers()
        {
            var jobOffers = new HashSet<JobOffer>
            {
                new()
                {
                    Id = 1,
                    Title = "Software Developer",
                    Description = "Develop and maintain software solutions.",
                    JobType = JobType.Online,
                    Location = "Remote",
                    CompanyName = "TechCorp",
                    Position = "Junior Developer",
                    Requirement = "1+ year experience in C# and .NET",
                    Salary = 12000,
                    AverageStarRating = 4.5
                },
                new()
                {
                    Id = 2,
                    Title = "Graphic Designer",
                    Description = "Create visual designs for marketing materials.",
                    JobType = JobType.Online,
                    Location = "Remote",
                    CompanyName = "Creative Studio",
                    Position = "Senior Designer",
                    Requirement = "Proficiency in Adobe Suite",
                    Salary = 14500,
                    AverageStarRating = 3.5
                },
                new ()
                {
                    Id = 3,
                    Title = "Hairdresser",
                    Description = "Provide hair styling, cutting, and treatment services to clients.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Karlovo, ul. \"Dabensko shose\" 2",
                    CompanyName = "Style Studio",
                    Position = "Professional Hairdresser",
                    Requirement = "Certified cosmetologist with 2+ years of experience.",
                    Salary = 4000,
                    AverageStarRating = 3.2
                },
                new ()
                {
                    Id = 4,
                    Title = "Auto Mechanic",
                    Description = "Perform vehicle inspections, repairs, and routine maintenance tasks.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Plovdiv, ul. \"Dimo Hadzhidimov\" 4В",
                    CompanyName = "DriveFix Garage",
                    Position = "Automotive Technician",
                    Requirement = "Basic mechanical skills and willingness to learn. No prior certification required.",
                    Salary = 8000,
                    AverageStarRating = 4.3,
                },
                new ()
                {
                    Id = 5,
                    Title = "Dermatologist",
                    Description = "Diagnose and treat skin conditions, provide expert advice on skincare, and perform dermatological procedures.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Sofia, Sofia, ul. \"Manastirski Livadi\"",
                    CompanyName = "SkinCare Clinic",
                    Position = "Certified Dermatologist",
                    Requirement = "Medical degree with specialization in dermatology. Valid state medical license required.",
                    Salary = 12000,
                    AverageStarRating = 4
                },
                new ()
                {
                    Id = 6,
                    Title = "Math Teacher",
                    Description = "Teach mathematics to students, prepare lesson plans, and assess student progress.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Pleven, ul. \"Ivan Vazov\"",
                    CompanyName = "Bright Minds Academy",
                    Position = "High School Math Teacher",
                    Requirement = "Bachelor's degree in Mathematics or Education. Teaching certification preferred.",
                    Salary = 5000,
                    AverageStarRating = 2.6
                },
                new ()
                {
                    Id = 7,
                    Title = "Cashier",
                    Description = "Handle customer transactions, operate the cash register, and provide excellent customer service.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Kazanlak, ul. \"Oreshaka\" 51",
                    CompanyName = "SuperMart",
                    Position = "Store Cashier",
                    Requirement = "No prior experience required, but basic math and customer service skills are preferred.",
                    Salary = 1000,
                    AverageStarRating = 2.2
                },
                new ()
                {
                    Id = 8,
                    Title = "Cleaner",
                    Description = "Maintain cleanliness and orderliness of the facility by performing routine cleaning tasks such as sweeping, mopping, and sanitizing surfaces.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Pavel Banya, ul. \"Osvobojdenie\" 3",
                    CompanyName = "Hotel Dianamar",
                    Position = "Toilet Cleaner",
                    Requirement = "No prior experience required, but attention to detail and reliability are essential.",
                    Salary = 1500,
                    AverageStarRating = 4.1
                },
                new ()
                {
                    Id = 9,
                    Title = "Waiter",
                    Description = "Provide excellent customer service by taking orders, serving food and beverages, and ensuring customer satisfaction.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А",
                    CompanyName = "City Bistro",
                    Position = "Restaurant Waiter",
                    Requirement = "Good communication skills and a friendly attitude. No prior experience required.",
                    Salary = 2000,
                    AverageStarRating = 3.4
                },
                new ()
                {
                    Id = 10,
                    Title = "Content Writer",
                    Description = "Write engaging articles, blogs, and web content for clients across various industries.",
                    JobType = JobType.Online,
                    Location = "Remote",
                    CompanyName = "Content Experts Co.",
                    Position = "Freelance Writer",
                    Requirement = "Excellent writing skills and creativity. Portfolio preferred.",
                    Salary = 5000,
                    AverageStarRating = 4.9
                },
                new ()
                {
                    Id = 11,
                    Title = "Video Editor",
                    Description = "Edit and enhance video content, add transitions, effects, and soundtracks to create high-quality productions.",
                    JobType = JobType.Online,
                    Location = "Remote",
                    CompanyName = "Creative Media Solutions",
                    Position = "Freelance Video Editor",
                    Requirement = "Proficiency in video editing software such as Adobe Premiere Pro, Final Cut Pro, or DaVinci Resolve. Portfolio required.",
                    Salary = 6000,
                    AverageStarRating = 3.7
                },
                new ()
                {
                    Id = 12,
                    Title = "Software Development Intern",
                    Description = "Assist in developing, testing, and debugging software applications under the guidance of senior developers.",
                    JobType = JobType.Internship,
                    Location = "Bulgaria, Varna, bul. \"8-mi Primorski polk\" 54",
                    CompanyName = "TechNova Inc.",
                    Position = "Software Developer Intern",
                    Requirement = "Enrolled in a Computer Science or related degree program. Basic knowledge of programming languages such as Python or Java.",
                    Salary = 500,
                    AverageStarRating = 4.1
                },
                new ()
                {
                    Id = 13,
                    Title = "Marketing Intern",
                    Description = "Support the marketing team in creating social media content, conducting market research, and analyzing campaign performance.",
                    JobType = JobType.Internship,
                    Location = "Bulgaria, Sofia, ul. \"Karamfil\"",
                    CompanyName = "Bright Ideas Agency",
                    Position = "Marketing Intern",
                    Requirement = "Enrolled in a Marketing or Business Administration degree program. Familiarity with social media platforms and analytics tools is a plus.",
                    Salary = 800,
                    AverageStarRating = 4.6
                },
                new ()
                {
                    Id = 14,
                    Title = "Graphic Design Intern",
                    Description = "Assist the design team in creating visual assets, including social media graphics, marketing materials, and presentations.",
                    JobType = JobType.Internship,
                    Location = "Bulgaria, Sofia, ul. \"Munchen\" 14",
                    CompanyName = "Visionary Creative Studio",
                    Position = "Graphic Design Intern",
                    Requirement = "Enrolled in a Graphic Design or related program. Proficiency in design software such as Adobe Illustrator and Photoshop is preferred.",
                    Salary = 700,
                    AverageStarRating = 3.8
                },
                new ()
                {
                    Id = 15,
                    Title = "Pharmacy Intern",
                    Description = "Assist pharmacists with dispensing medication, preparing prescriptions, managing inventory, and providing customer service under supervision.",
                    JobType = JobType.Internship,
                    Location = "Bulgaria, Ruse, bul. \"Lipnik\" 8",
                    CompanyName = "HealthCare Pharmacy",
                    Position = "Pharmacy Intern",
                    Requirement = "Currently enrolled in a Pharmacy or Pharmaceutical Sciences program. Strong attention to detail and communication skills.",
                    Salary = 900,
                    AverageStarRating = 3.9
                }
            };

            return jobOffers;
        }
    }
}
