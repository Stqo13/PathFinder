using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;
using PathFinder.Data.Models.Enums;

namespace PathFinder.Data.Configurations
{
    public class CourseConfiguration
        : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(this.GenerateCourses());
        }

        public IEnumerable<Course> GenerateCourses()
        {
            var courses = new HashSet<Course>
            {
                new()
                {
                    Id = 1,
                    Name = "Introduction to Digital Marketing",
                    Mode = Mode.Online,
                    Description = "Learn the fundamentals of digital marketing, including SEO, PPC, and social media strategies.",
                    DurationInMinutes = 120,
                    Location = "Remote",
                    StartDate = new DateTime(2025, 01, 15),
                    InstitutionId = "723444b3-9434-4465-9044-f7e04fdcca2f",
                    AverageStarRating = 4,
                    MonthlyPrice = 30
                },
                new ()
                {
                    Id = 2,
                    Name = "Web Development for Beginners",
                    Mode = Mode.Online,
                    Description = "Master the basics of HTML, CSS, and JavaScript in this beginner-friendly web development course.",
                    DurationInMinutes = 150,
                    Location = "Remote",
                    StartDate = new DateTime(2025, 2, 1),
                    InstitutionId = "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                    AverageStarRating = 4.5,
                    MonthlyPrice = 35
                },
                new ()
                {
                    Id = 3,
                    Name = "Data Science and Machine Learning",
                    Mode = Mode.Online,
                    Description = "Dive into the world of data science and learn machine learning algorithms using Python and R.",
                    DurationInMinutes = 180,
                    Location = "Remote",
                    StartDate = new DateTime(2025, 3, 1),
                    InstitutionId = "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                    AverageStarRating = 4.8,
                    MonthlyPrice = 45
                },
                new ()
                {
                    Id = 4,
                    Name = "Introduction to Artificial Intelligence",
                    Mode = Mode.Online,
                    Description = "Gain a foundational understanding of AI, its applications, and how it is changing industries.",
                    DurationInMinutes = 150,
                    Location = "Remote",
                    StartDate = new DateTime(2025, 4, 1),
                    InstitutionId = "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                    AverageStarRating = 4.7,
                    MonthlyPrice = 50
                },
                new()
                {
                    Id = 5,
                    Name = "Spanish for beginners",
                    Mode = Mode.InPerson,
                    Description = "Master the basics of Spanish, including vocabulary, grammar, and conversational skills, in an engaging and interactive environment.",
                    DurationInMinutes = 90,
                    Location = "Bulgaria, Burgas, ul. \"Odrin\" 2",
                    StartDate = new DateTime(2025, 2, 15),
                    InstitutionId = "fc7c5678-22b4-4650-af6e-4c5f90fa494d",
                    AverageStarRating = 4.6,
                    MonthlyPrice = 200
                },
                new ()
                {
                    Id = 6,
                    Name = "Introduction to Culinary Arts",
                    Mode = Mode.InPerson,
                    Description = "Learn the basics of cooking techniques, kitchen safety, and food presentation in this hands-on culinary course.",
                    DurationInMinutes = 120,
                    Location = "Bulgaria, Varna, ul. \"Oborishte\" 13A",
                    StartDate = new DateTime(2025, 5, 1),
                    InstitutionId = "",
                    AverageStarRating = 4.8,
                    MonthlyPrice = 220
                },
                new ()
                {
                    Id = 7,
                    Name = "Yoga and Mindfulness for Beginners",
                    Mode = Mode.InPerson,
                    Description = "Relax, rejuvenate, and learn mindfulness practices along with beginner-friendly yoga postures in this course.",
                    DurationInMinutes = 90,
                    Location = "Bulgaria, Pazardzik, ul. \"Nayden Gerov\" 6",
                    StartDate = new DateTime(2025, 2, 25),
                    InstitutionId = "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                    AverageStarRating = 4.5,
                    MonthlyPrice = 100
                },
                new ()
                {
                    Id = 8,
                    Name = "English Language Mastery",
                    Mode = Mode.InPerson,
                    Description = "Improve your English language skills in speaking, listening, reading, and writing through practical lessons and exercises.",
                    DurationInMinutes = 180,
                    Location = "Bulgaria, Kazanlak, ul. \"Ivan Vazov\" 3",
                    StartDate = new DateTime(2025, 3, 20),
                    InstitutionId = "fc7c5678-22b4-4650-af6e-4c5f90fa494d",
                    AverageStarRating = 4.7,
                    MonthlyPrice = 90
                },
                new ()
                {
                    Id =  9,
                    Name = "Fundamentals of Fine Art",
                    Mode = Mode.InPerson,
                    Description = "Explore the basics of fine art, including sketching, painting, and sculpting, in a hands-on creative environment.",
                    DurationInMinutes = 240,
                    Location = "Bulgaria, Sofia, Vasil Levski Blvd 62",
                    StartDate = new DateTime(2025, 4, 10),
                    InstitutionId = "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                    AverageStarRating = 4.8,
                    MonthlyPrice = 250
                },
                new ()
                {
                    Id = 10,
                    Name = "Introduction to Embedded Systems",
                    Mode = Mode.Online,
                    Description = "Learn the principles of embedded systems design, microcontrollers, and real-time programming in this comprehensive beginner-friendly course.",
                    DurationInMinutes = 240,
                    Location = "Remote",
                    StartDate = new DateTime(2025, 6, 1),
                    InstitutionId = "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                    AverageStarRating = 4.8,
                    MonthlyPrice = 60
                },
                new ()
                {
                    Id = 11,
                    Name = "Interior Design Masterclass",
                    Mode = Mode.InPerson,
                    Description = "Master the principles of interior design, space planning, and color theory with hands-on projects.",
                    DurationInMinutes = 180,
                    Location = "Bulgaria, Sofia, ul. \"Kapitan Andreev\" 29",
                    StartDate = new DateTime(2025, 8, 5),
                    InstitutionId = "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                    AverageStarRating = 4.7,
                    MonthlyPrice = 280
                },
                new ()
                {
                    Id = 12,
                    Name = "Music Production Essentials",
                    Mode = Mode.InPerson,
                    Description = "Learn the essentials of music production, including recording, mixing, and mastering, with hands-on studio sessions.",
                    DurationInMinutes = 120,
                    Location = "Bulgaria, Plovdiv, ul. \"Ivan Vazov\" 23",
                    StartDate = new DateTime(2025, 5, 15),
                    InstitutionId = "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                    AverageStarRating = 4.8,
                    MonthlyPrice = 200
                },
                new ()
                {
                    Id = 13,
                    Name = "Advanced Calculus Workshop",
                    Mode = Mode.InPerson,
                    Description = "Deepen your understanding of calculus concepts, including multivariable calculus, differential equations, and real-world applications.",
                    DurationInMinutes = 45,
                    Location = "Bulgaria, Plovdiv, ul. \"Perushtitsa\" 15",
                    StartDate = new DateTime(2025, 7, 10),
                    InstitutionId = "fa360a62-9355-474a-824d-aaa85d9fbd65",
                    AverageStarRating = 4.9,
                    MonthlyPrice = 110
                },
                new ()
                {
                    Id = 14,
                    Name = "Front-End Web Development Bootcamp",
                    Mode = Mode.Online,
                    Description = "Learn essential front-end technologies like HTML, CSS, JavaScript, and React to build stunning and responsive web applications.",
                    DurationInMinutes = 100,
                    Location = "Remote",
                    StartDate = new DateTime(2025, 6, 15),
                    InstitutionId = "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                    AverageStarRating = 4.8,
                    MonthlyPrice = 150
                },
                new ()
                {
                    Id = 15,
                    Name = "Foundations of Computer Engineering",
                    Mode = Mode.Online,
                    Description = "Explore the core principles of computer engineering, including hardware design, embedded systems, and software integration.",
                    DurationInMinutes = 160,
                    Location = "Remote",
                    StartDate = new DateTime(2025, 7, 20),
                    InstitutionId = "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                    AverageStarRating = 4.7,
                    MonthlyPrice = 300
                },
                new ()
                {
                    Id = 16,
                    Name = "Cybersecurity Fundamentals",
                    Mode = Mode.InPerson,
                    Description = "Get hands-on experience with cybersecurity protocols, encryption techniques, ethical hacking, and network security to protect digital assets.",
                    DurationInMinutes = 260,
                    Location = "Bulgaria, Plovdiv, ul. \"Zahari Zograf\" 10",
                    StartDate = new DateTime(2025, 7, 15),
                    InstitutionId = "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                    AverageStarRating = 4.8,
                    MonthlyPrice = 350
                }
            };

            return courses;
        }
    }
}
