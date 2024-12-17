using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class JobSphereConfiguration
        : IEntityTypeConfiguration<JobSphere>
    {
        public void Configure(EntityTypeBuilder<JobSphere> builder)
        {
            builder.HasData(this.GenerateJobsSpheres());
        }

        public IEnumerable<JobSphere> GenerateJobsSpheres()
        {
            var jobsSpheres = new HashSet<JobSphere>
            {
               new ()
               {
                   JobId = 1,
                   SphereId = 2
               },
               new ()
               {
                   JobId = 1,
                   SphereId = 6
               },
               new ()
               {
                   JobId = 1,
                   SphereId = 12
               },
               new ()
               {
                   JobId = 1,
                   SphereId = 13
               },
               new ()
               {
                   JobId = 1,
                   SphereId = 46
               },

               new ()
               {
                   JobId = 2,
                   SphereId = 5
               },
               new ()
               {
                   JobId = 2,
                   SphereId = 7
               },
               new ()
               {
                   JobId = 2,
                   SphereId = 15
               },

               new ()
               {
                   JobId = 3,
                   SphereId = 16
               },
               new ()
               {
                   JobId = 3,
                   SphereId = 17
               },
               new ()
               {
                   JobId = 3,
                   SphereId = 18
               },
               new ()
               {
                   JobId = 3,
                   SphereId = 59
               },

               new ()
               {
                   JobId = 4,
                   SphereId = 17
               },
               new ()
               {
                   JobId = 4,
                   SphereId = 19
               },

               new ()
               {
                   JobId = 5,
                   SphereId = 16
               },
               new ()
               {
                   JobId = 5,
                   SphereId = 1
               },
               new ()
               {
                   JobId = 5,
                   SphereId = 18
               },
               new ()
               {
                   JobId = 5,
                   SphereId = 2
               },
               new ()
               {
                   JobId = 5,
                   SphereId = 24
               },
               new ()
               {
                   JobId = 5,
                   SphereId = 50
               },
               new ()
               {
                   JobId = 5,
                   SphereId = 25
               },

               new ()
               {
                   JobId = 6,
                   SphereId = 4
               },
               new ()
               {
                   JobId = 6,
                   SphereId = 58
               },

               new ()
               {
                   JobId = 7,
                   SphereId = 17
               },
               new ()
               {
                   JobId = 7,
                   SphereId = 18
               },
               new ()
               {
                   JobId = 7,
                   SphereId = 31
               },

               new ()
               {
                   JobId = 8,
                   SphereId = 17
               },
               new ()
               {
                   JobId = 8,
                   SphereId = 35
               },
               new ()
               {
                   JobId = 8,
                   SphereId = 38
               },

               new ()
               {
                   JobId = 9,
                   SphereId = 17
               },
               new ()
               {
                   JobId = 9,
                   SphereId = 59
               },

               new ()
               {
                   JobId = 10,
                   SphereId = 5
               },
               new ()
               {
                   JobId = 10,
                   SphereId = 45
               },
               new ()
               {
                   JobId = 10,
                   SphereId = 40
               },
               new ()
               {
                   JobId = 10,
                   SphereId = 36
               },

               new ()
               {
                   JobId = 11,
                   SphereId = 5
               },
               new ()
               {
                   JobId = 11,
                   SphereId = 7
               },
               new ()
               {
                   JobId = 11,
                   SphereId = 36
               },
               new ()
               {
                   JobId = 11,
                   SphereId = 2
               },
               new ()
               {
                   JobId = 11,
                   SphereId = 40
               },
               new ()
               {
                   JobId = 11,
                   SphereId = 44
               },
               new ()
               {
                   JobId = 11,
                   SphereId = 45
               },
               new ()
               {
                   JobId = 11,
                   SphereId = 48
               },

               new ()
               {
                   JobId = 12,
                   SphereId = 2
               },
               new ()
               {
                   JobId = 12,
                   SphereId = 6
               },
               new ()
               {
                   JobId = 12,
                   SphereId = 12
               },
               new ()
               {
                   JobId = 12,
                   SphereId = 13
               },              

               new ()
               {
                   JobId = 13,
                   SphereId = 5
               },
               new ()
               {
                   JobId = 13,
                   SphereId = 7
               },
               new ()
               {
                   JobId = 13,
                   SphereId = 12
               },
               new ()
               {
                   JobId = 13,
                   SphereId = 6
               },              

               new ()
               {
                   JobId = 14,
                   SphereId = 24
               },
               new ()
               {
                   JobId = 14,
                   SphereId = 18
               },
               new ()
               {
                   JobId = 14,
                   SphereId = 26
               },
               new ()
               {
                   JobId = 14,
                   SphereId = 1
               },
               new ()
               {
                   JobId = 14,
                   SphereId = 49
               },

               new ()
               {
                   JobId = 15,
                   SphereId = 52
               },
               new ()
               {
                   JobId = 15,
                   SphereId = 18
               },
               new ()
               {
                   JobId = 15,
                   SphereId = 50
               },
               new ()
               {
                   JobId = 15,
                   SphereId = 51
               },
               new ()
               {
                   JobId = 15,
                   SphereId = 24
               },
               new ()
               {
                   JobId = 15,
                   SphereId = 1
               }
            };

            return jobsSpheres;
        }
    }
}
