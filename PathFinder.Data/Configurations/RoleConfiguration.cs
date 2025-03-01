using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class RoleConfiguration
        : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(this.GenerateRoles());
        }

        public IEnumerable<IdentityRole> GenerateRoles()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}/PathFinder.Data/Data/roles.json");

            var roles = JsonConvert.DeserializeObject<List<IdentityRole>>(json)
                ?? throw new Exception("Invalid json file path");

            return roles;
        }
    }
}
