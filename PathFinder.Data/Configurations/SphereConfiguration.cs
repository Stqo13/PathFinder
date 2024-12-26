using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class SphereConfiguration
        : IEntityTypeConfiguration<Sphere>
    {
        public void Configure(EntityTypeBuilder<Sphere> builder)
        {
            builder.HasData(this.GenerateSpheres());
        }

        public IEnumerable<Sphere> GenerateSpheres()
        {
            var spheres = new HashSet<Sphere>
            {
                new ()
                {
                    Id = 1,
                    Name = "Healthcare"
                },
                new ()
                {
                    Id = 2,
                    Name = "Technology"
                },
                new ()
                {
                    Id = 3,
                    Name = "Business & Finance"
                },
                new ()
                {
                    Id = 4,
                    Name = "Education"
                },
                new ()
                {
                    Id = 5,
                    Name = "Creative Arts"
                },
                new ()
                {
                    Id = 6,
                    Name = "Computer Science"
                },
                new ()
                {
                    Id = 7,
                    Name = "Graphic Design"
                },
                new ()
                {
                    Id = 8,
                    Name = "Marketing & Management"
                },
                new ()
                {
                    Id = 9,
                    Name = "Architecture"
                },
                new ()
                {
                    Id = 10,
                    Name = "Facility Management"
                },
                new ()
                {
                    Id = 11,
                    Name = "Engeneering"
                },
                new ()
                {
                    Id = 12,
                    Name = "Web Development"
                },
                new ()
                {
                    Id = 13,
                    Name = "Back-End Programming"
                },
                new ()
                {
                    Id = 14,
                    Name = "Front-End Programming"
                },
                new ()
                {
                    Id = 15,
                    Name = "Adobe Designing"
                },
                new ()
                {
                    Id = 16,
                    Name = "Beauty and Personal Care Industry"
                },
                new ()
                {
                    Id = 17,
                    Name = "Service Industry"
                },
                new ()
                {
                    Id = 18,
                    Name = "Health and Wellness Industry"
                },
                new ()
                {
                    Id = 19,
                    Name = "Automotive Industry"
                },
                new ()
                {
                    Id = 20,
                    Name = "Mechanical Engineering"
                },
                new ()
                {
                    Id = 21,
                    Name = "Transportation and Logistics"
                },
                new ()
                {
                    Id = 22,
                    Name = "Skilled Trades"
                },
                new ()
                {
                    Id = 23,
                    Name = "Sustainability and Green Technologies"
                },
                new ()
                {
                    Id = 24,
                    Name = "Medical Specialties"
                },
                new ()
                {
                    Id = 25,
                    Name = "Cosmetic Dermatology"
                },
                new ()
                {
                    Id = 26,
                    Name = "Pharmaceutical Industry"
                },
                new ()
                {
                    Id = 27,
                    Name = "STEM Education"
                },
                new ()
                {
                    Id = 28,
                    Name = "Public Sector"
                },
                new ()
                {
                    Id = 29,
                    Name = "Curriculum Development"
                },
                new ()
                {
                    Id = 30,
                    Name = "Non-profit Education"
                },
                new ()
                {
                    Id = 31,
                    Name = "Cleaning and Maintenance"
                },
                new ()
                {
                    Id = 32,
                    Name = "Public Services"
                },
                new ()
                {
                    Id = 33,
                    Name = "Environmental Services"
                },
                new ()
                {
                    Id = 34,
                    Name = "Education Support Services"
                },
                new ()
                {
                    Id = 35,
                    Name = "Food and Beverage Services"
                },
                new ()
                {
                    Id = 36,
                    Name = "Customer Service"
                },
                new ()
                {
                    Id = 37,
                    Name = "Event Management"
                },
                new ()
                {
                    Id = 38,
                    Name = "Nightlife and Entertainment"
                },
                new ()
                {
                    Id = 39,
                    Name = "Tourism and Leisure"
                },
                new ()
                {
                    Id = 40,
                    Name = "Media and Journalism"
                },
                new ()
                {
                    Id = 41,
                    Name = "Marketing & Communications"
                },
                new ()
                {
                    Id = 42,
                    Name = "Digital Marketing"
                },
                new ()
                {
                    Id = 43,
                    Name = "Freelancing"
                },
                new ()
                {
                    Id = 44,
                    Name = "Film Production"
                },
                new ()
                {
                    Id = 45,
                    Name = "Media and Entertainment"
                },
                new ()
                {
                    Id = 46,
                    Name = "Software Development"
                },
                new ()
                {
                    Id = 47,
                    Name = "Security"
                },
                new ()
                {
                    Id = 48,
                    Name = "Visual Arts"
                },
                new ()
                {
                    Id = 49,
                    Name = "Retail Pharmacy"
                },
                new ()
                {
                    Id = 50,
                    Name = "Clinical Care"
                },
                new ()
                {
                    Id = 51,
                    Name = "Reproductive Health"
                },
                new ()
                {
                    Id = 52,
                    Name = "Women’s Health"
                },
                new ()
                {
                    Id = 53,
                    Name = "Cosmetic Surgery"
                },
                new ()
                {
                    Id = 54,
                    Name = "Spa and Wellness"
                },
                new ()
                {
                    Id = 55,
                    Name = "Personal Grooming"
                },
                new ()
                {
                    Id = 56,
                    Name = "Salon Management"
                },
                new ()
                {
                    Id = 57,
                    Name = "Hairdressing and Styling"
                },
                new ()
                {
                    Id = 58,
                    Name = "Mathematics"
                },
                new ()
                {
                    Id = 59,
                    Name = "Restaurant Hospitality"
                },
                new ()
                {
                    Id = 60,
                    Name = "Cultural Studies"
                },
                new ()
                {
                    Id = 61,
                    Name = "Language & Linguistics"
                },
                new ()
                {
                    Id = 62,
                    Name = "Cooking"
                },
                new ()
                {
                    Id = 63,
                    Name = "Physical Education"
                },
                new ()
                {
                    Id = 64,
                    Name = "Fitness and Personal Training"
                },
                new ()
                {
                    Id = 65,
                    Name = "Audio Engineering"
                },
                new ()
                {
                    Id = 66,
                    Name = "Music Composition"
                },
                new ()
                {
                    Id = 67,
                    Name = "Music Technology"
                }
            };    
            
            return spheres;
        }
    }
}
