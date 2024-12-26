using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
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
            var jsonFilePath = "D:\\Users\\User\\Desktop\\PathFinder\\PathFinder\\PathFinder.Data\\Data\\spheres.json";
            var json = File.ReadAllText(jsonFilePath);

            var spheres = JsonConvert.DeserializeObject<List<Sphere>>(json)
                ?? throw new Exception("Invalid json file path");

            return spheres;
        }
    }
}
