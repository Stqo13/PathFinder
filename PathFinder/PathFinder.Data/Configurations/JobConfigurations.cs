using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;

namespace PathFinder.Data.Configurations
{
    public class JobConfigurations
        : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData(this.GenerateJob());
        }

        public IEnumerable<Job> GenerateJob()
        {
            var jobs = new HashSet<Job>
            {
                new()
                {
                    Id = 1,
                    Title = "Software Developer",
                    Description = "Develop and maintain software solutions.",
                    JobType = JobType.Online,
                    Location = "Remote",
                    CompanyId = "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
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
                    CompanyId = "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
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
                    CompanyId = "e0d6328d-f003-4bb1-8daa-21dcf49db469",
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
                    CompanyId = "16226cef-b670-447e-99a9-b627cb16ae0b",
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
                    Location = "Bulgaria, Ruse, bul. \"Lipnik\" 8",
                    CompanyId = "17585a62-c173-4c68-9e4a-2ba93a419b21",
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
                    CompanyId = "596c6add-eaae-4890-8d4d-38aa5a0671bd",
                    Position = "High School Math Teacher",
                    Requirement = "Bachelor's degree in Mathematics or Education. Teaching certification preferred.",
                    Salary = 5000,
                    AverageStarRating = 2.6
                },
                new ()
                {
                    Id = 7,
                    Title = "School Cleaner",
                    Description = "Maintain cleanliness and orderliness of the school toilets by performing routine cleaning tasks such as sweeping, mopping, and sanitizing surfaces.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Pleven, ul. \"Ivan Vazov\"",
                    CompanyId = "596c6add-eaae-4890-8d4d-38aa5a0671bd",
                    Position = "Toilet Cleaner",
                    Requirement = "No prior experience required, but attention to detail and reliability are essential.",
                    Salary = 1500,
                    AverageStarRating = 4.1
                },
                new ()
                {
                    Id = 8,
                    Title = "Bartender",
                    Description = "Prepare and serve alcoholic and non-alcoholic beverages, provide excellent customer service, and maintain a clean and organized bar area to ensure a great experience for guests.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А",
                    CompanyId = "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd",
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
                    CompanyId = "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd",
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
                    CompanyId = "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf",
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
                    CompanyId = "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf",
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
                    CompanyId = "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
                    Position = "Software Developer Intern",
                    Requirement = "Enrolled in a Computer Science or related degree program. Basic knowledge of programming languages such as Python or Java.",
                    Salary = 500,
                    AverageStarRating = 4.1
                },
                new ()
                {
                    Id = 13,
                    Title = "Graphic Design Intern",
                    Description = "Assist the design team in creating visual assets, including social media graphics, marketing materials, and presentations.",
                    JobType = JobType.Internship,
                    Location = "Bulgaria, Sofia, ul. \"Munchen\" 14",
                    CompanyId = "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
                    Position = "Graphic Design Intern",
                    Requirement = "Enrolled in a Graphic Design or related program. Proficiency in design software such as Adobe Illustrator and Photoshop is preferred.",
                    Salary = 700,
                    AverageStarRating = 3.8
                },
                new ()
                {
                    Id = 14,
                    Title = "Pharmacy Intern",
                    Description = "Assist pharmacists with dispensing medication, preparing prescriptions, managing inventory, and providing customer service under supervision.",
                    JobType = JobType.Internship,
                    Location = "Bulgaria, Ruse, bul. \"Lipnik\" 8",
                    CompanyId = "17585a62-c173-4c68-9e4a-2ba93a419b21",
                    Position = "Pharmacy Intern",
                    Requirement = "Currently enrolled in a Pharmacy or Pharmaceutical Sciences program. Strong attention to detail and communication skills.",
                    Salary = 900,
                    AverageStarRating = 3.9
                },
                new ()
                {
                    Id = 15,
                    Title = "Gynecologist",
                    Description = "Provide medical care related to women's health, including diagnosis, treatment, and prevention of reproductive health issues, as well as conducting gynecological exams and procedures.",
                    JobType = JobType.InPerson,
                    Location = "Bulgaria, Ruse, bul. \"Lipnik\" 8",
                    CompanyId = "17585a62-c173-4c68-9e4a-2ba93a419b21",
                    Position = "Certified Gynecologist",
                    Requirement = "Medical degree with specialization in gynecology. Valid state medical license required.",
                    Salary = 13000,
                    AverageStarRating = 4.1
                }

            };

            return jobs;
        }
    }
}
