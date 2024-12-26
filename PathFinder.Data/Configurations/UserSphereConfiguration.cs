using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class UserSphereConfiguration
        : IEntityTypeConfiguration<UserSphere>
    {
        public void Configure(EntityTypeBuilder<UserSphere> builder)
        {
            builder.HasData(this.GenerateUsersSpheres());
        }

        public IEnumerable<UserSphere> GenerateUsersSpheres()
        {
            var usersSpheres = new HashSet<UserSphere>
            {
                new () { UserId = "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", SphereId = 60 },
                new () { UserId = "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", SphereId = 61 },
                new () { UserId = "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", SphereId = 2 },

                new () { UserId = "9e547484-9ea8-45e6-a488-d657f6f1c598", SphereId = 5 },
                new () { UserId = "9e547484-9ea8-45e6-a488-d657f6f1c598", SphereId = 7 },
                new () { UserId = "9e547484-9ea8-45e6-a488-d657f6f1c598", SphereId = 11 },

                new () { UserId = "e8d223af-7285-41c5-8c38-9e6989d4410d", SphereId = 13 },
                new () { UserId = "e8d223af-7285-41c5-8c38-9e6989d4410d", SphereId = 12 },
                new () { UserId = "e8d223af-7285-41c5-8c38-9e6989d4410d", SphereId = 15 },

                new () { UserId = "d444522c-71c1-4cc9-b815-4ea25a49f17b", SphereId = 35 },
                new () { UserId = "d444522c-71c1-4cc9-b815-4ea25a49f17b", SphereId = 38 },
                new () { UserId = "d444522c-71c1-4cc9-b815-4ea25a49f17b", SphereId = 40 },

                new () { UserId = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", SphereId = 58 },
                new () { UserId = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", SphereId = 59 },
                new () { UserId = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", SphereId = 60 },

                new () { UserId = "7d089603-dc80-415a-913b-f24b1a90b5f1", SphereId = 61 },
                new () { UserId = "7d089603-dc80-415a-913b-f24b1a90b5f1", SphereId = 64 },
                new () { UserId = "7d089603-dc80-415a-913b-f24b1a90b5f1", SphereId = 66 },

                new () { UserId = "ca145762-b5db-4836-b963-85eff67fb124", SphereId = 61 },
                new () { UserId = "ca145762-b5db-4836-b963-85eff67fb124", SphereId = 15 },
                new () { UserId = "ca145762-b5db-4836-b963-85eff67fb124", SphereId = 52 },

                new () { UserId = "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", SphereId = 13 },
                new () { UserId = "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", SphereId = 15 },
                new () { UserId = "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", SphereId = 62 }
            };

            return usersSpheres;
        }
    }
}
