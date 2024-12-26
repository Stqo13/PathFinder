using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
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
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\userSpheres.json";
            var json = File.ReadAllText(jsonFilePath);

            var userSpheres = JsonConvert.DeserializeObject<List<UserSphere>>(json)
                ?? throw new Exception("Invalid json file path");

            return userSpheres;
        }
    }
}
