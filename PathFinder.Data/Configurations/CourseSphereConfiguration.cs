using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class CourseSphereConfiguration
        : IEntityTypeConfiguration<CourseSphere>
    {
        public void Configure(EntityTypeBuilder<CourseSphere> builder)
        {
            builder.HasData(this.GenerateCoursesSpheres());
        }

        public IEnumerable<CourseSphere> GenerateCoursesSpheres()
        {
            var coursesSpheres = new HashSet<CourseSphere>
            {
                new () { CourseId = 1, SphereId = 42 }, 
                new () { CourseId = 1, SphereId = 8 }, 
                new () { CourseId = 1, SphereId = 3 },  
                
                new () { CourseId = 2, SphereId = 12 }, 
                new () { CourseId = 2, SphereId = 6 },  
                new () { CourseId = 2, SphereId = 2 }, 
                
                new () { CourseId = 3, SphereId = 2 },  
                new () { CourseId = 3, SphereId = 6 },  
                new () { CourseId = 3, SphereId = 11 },
                new () { CourseId = 3, SphereId = 58 },

                new () { CourseId = 4, SphereId = 2 },  
                new () { CourseId = 4, SphereId = 6 },
                new () { CourseId = 4, SphereId = 46 },
                new () { CourseId = 4, SphereId = 13 },
                new () { CourseId = 4, SphereId = 11 },

                new () { CourseId = 5, SphereId = 4 },  
                new () { CourseId = 5, SphereId = 60 },
                new () { CourseId = 5, SphereId = 61 }, 
                
                new () { CourseId = 6, SphereId = 5 },  
                new () { CourseId = 6, SphereId = 35 }, 
                new () { CourseId = 6, SphereId = 62 },  
                
                new () { CourseId = 7, SphereId = 18 }, 
                new () { CourseId = 7, SphereId = 63 }, 
                new () { CourseId = 7, SphereId = 64 },
                
                new () { CourseId = 8, SphereId = 4 },  
                new () { CourseId = 8, SphereId = 60 }, 
                new () { CourseId = 8, SphereId = 61 }, 
                
                new () { CourseId = 9, SphereId = 5 },  
                new () { CourseId = 9, SphereId = 48 }, 
                new () { CourseId = 9, SphereId = 7 }, 
                
                new () { CourseId = 10, SphereId = 2 }, 
                new () { CourseId = 10, SphereId = 6 }, 
                new () { CourseId = 10, SphereId = 11 }, 
                
                new () { CourseId = 11, SphereId = 9 }, 
                new () { CourseId = 11, SphereId = 5 }, 
                
                new () { CourseId = 12, SphereId = 5 }, 
                new () { CourseId = 12, SphereId = 40 }, 
                new () { CourseId = 12, SphereId = 65 },
                new () { CourseId = 12, SphereId = 66 },
                new () { CourseId = 12, SphereId = 67 },

                new () { CourseId = 13, SphereId = 4 },
                new () { CourseId = 13, SphereId = 58 },

                new () { CourseId = 14, SphereId = 12 },
                new () { CourseId = 14, SphereId = 14 },
                new () { CourseId = 14, SphereId = 7 },
                new () { CourseId = 14, SphereId = 46 },
                new () { CourseId = 14, SphereId = 6 },

                new () { CourseId = 15, SphereId = 2 },
                new () { CourseId = 15, SphereId = 6 },
                new () { CourseId = 15, SphereId = 11 },


                new () { CourseId = 16, SphereId = 2 },
                new () { CourseId = 16, SphereId = 6 },
                new () { CourseId = 16, SphereId = 47 }
            };

            return coursesSpheres;
        }
    }
}
