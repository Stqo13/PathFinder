using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(this.GenerateUsers());
        }
        public IEnumerable<ApplicationUser> GenerateUsers()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory);
            var json = File.ReadAllText($"{projectDirectory}\\PathFinder.Data\\Data\\users.json");

            var users = JsonConvert.DeserializeObject<List<ApplicationUser>>(json)
                ?? throw new Exception("Invalid json file path");

            var hasher = new PasswordHasher<ApplicationUser>();

            foreach (ApplicationUser user in users)
            {
                if (user.Id == "e0d6328d-f003-4bb1-8daa-21dcf49db469"
                    || user.Id == "16226cef-b670-447e-99a9-b627cb16ae0b"
                    || user.Id == "b3693b0c-9c11-48ee-a3be-db37d5439ab0"
                    || user.Id == "17585a62-c173-4c68-9e4a-2ba93a419b21"
                    || user.Id == "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd"
                    || user.Id == "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf"
                    || user.Id == "596c6add-eaae-4890-8d4d-38aa5a0671bd")
                {
                    user.PasswordHash = hasher.HashPassword(user, "Company_123");
                }
                else if (user.Id == "428bcf46-40f2-47b2-ac4a-a49f570178ad"
                    || user.Id == "3cf3fb4a-235e-4c93-b66f-c1557006e067"
                    || user.Id == "fa360a62-9355-474a-824d-aaa85d9fbd65"
                    || user.Id == "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1"
                    || user.Id == "fc7c5678-22b4-4650-af6e-4c5f90fa494d"
                    || user.Id == "723444b3-9434-4465-9044-f7e04fdcca2f"
                    || user.Id == "6a358b17-ffbe-4ac9-8d20-92544e3b739d")
                {
                    user.PasswordHash = hasher.HashPassword(user, "Institution_123");
                }
                else if (user.Id == "e2041514-c5ce-4e68-8956-f92298aa3b74"
                    || user.Id == "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0")
                {
                    user.PasswordHash = hasher.HashPassword(user, "Admin_123");
                }
                else if (user.Id == "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2"
                    || user.Id == "9e547484-9ea8-45e6-a488-d657f6f1c598"
                    || user.Id == "e8d223af-7285-41c5-8c38-9e6989d4410d"
                    || user.Id == "d444522c-71c1-4cc9-b815-4ea25a49f17b"
                    || user.Id == "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355"
                    || user.Id == "7d089603-dc80-415a-913b-f24b1a90b5f1"
                    || user.Id == "ca145762-b5db-4836-b963-85eff67fb124"
                    || user.Id == "8d0c3b82-be4b-4fdf-834a-8e436176d9bd")
                {
                    user.PasswordHash = hasher.HashPassword(user, "User_123");
                }
            }

            
            return users;
        }
    }
}
