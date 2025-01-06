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
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}\\PathFinder.Data\\Data\\spheres.json");

            var spheres = JsonConvert.DeserializeObject<List<Sphere>>(json)
                ?? throw new Exception("Invalid json file path");
            
            return spheres;
        }
    }
}
