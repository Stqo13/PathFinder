using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Minio;
using PathFinder.Common;
using PathFinder.Data;
using PathFinder.Data.Models;
using PathFinder.Data.Repository.Interfaces;
using PathFinder.Extensions;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;

namespace PathFinder
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<PathFinderDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<PathFinderDbContext>()
            .AddDefaultTokenProviders();

            var clientId = Environment.GetEnvironmentVariable("GMAPS_CLIENT");
            var clientSecret = Environment.GetEnvironmentVariable("GMAPS_CLIENT_SECRET");

            if (clientId == null || clientSecret == null)
            {
                clientId = builder.Configuration["Authentication:Google:Client"]!;
                clientSecret = builder.Configuration["Authentication:Google:ClientSecret"]!;
            }
            
            builder.Services.AddAuthentication()
                .AddCookie()
                .AddGoogle(options =>
                {
                    options.ClientId = clientId;
                    options.ClientSecret = clientSecret;
                });

            builder.Services
                .Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));

            builder.Services.ConfigureApplicationCookie(cfg =>
            {
                cfg.LoginPath = "/Identity/Account/Login";
            });

            builder.Services
                .RegisterUserDefinedServices()
                .RegisterRepositories();

            builder.Services.AddRazorPages();
            builder.Services
                .AddControllersWithViews()
                .AddRazorRuntimeCompilation();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<PathFinderDbContext>();

                try
                {
                    dbContext.Database.Migrate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while migrating the database: {ex.Message}");
                }

                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
                var userRepository = services.GetRequiredService<IRepository<ApplicationUser, string>>();
                await AssignRoles(userManager, roleManager, userRepository);
            }

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=AdminPanel}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
        public static async Task AssignRoles(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IRepository<ApplicationUser, string> userRepository)
        {
            var users = await userRepository.GetAllAsync();
            foreach (var user in users)
            {
                if (user.Id == "e0d6328d-f003-4bb1-8daa-21dcf49db469"
                    || user.Id == "16226cef-b670-447e-99a9-b627cb16ae0b"
                    || user.Id == "b3693b0c-9c11-48ee-a3be-db37d5439ab0"
                    || user.Id == "17585a62-c173-4c68-9e4a-2ba93a419b21"
                    || user.Id == "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd"
                    || user.Id == "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf"
                    || user.Id == "596c6add-eaae-4890-8d4d-38aa5a0671bd")
                {
                    await userManager.AddToRoleAsync(user, "Company");
                }
                else if (user.Id == "428bcf46-40f2-47b2-ac4a-a49f570178ad"
                    || user.Id == "3cf3fb4a-235e-4c93-b66f-c1557006e067"
                    || user.Id == "fa360a62-9355-474a-824d-aaa85d9fbd65"
                    || user.Id == "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1"
                    || user.Id == "fc7c5678-22b4-4650-af6e-4c5f90fa494d"
                    || user.Id == "723444b3-9434-4465-9044-f7e04fdcca2f"
                    || user.Id == "6a358b17-ffbe-4ac9-8d20-92544e3b739d")
                {
                    await userManager.AddToRoleAsync(user, "Institution");
                }
                else if (user.Id == "e2041514-c5ce-4e68-8956-f92298aa3b74"
                    || user.Id == "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0")
                {
                    await userManager.AddToRoleAsync(user, "Admin");
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
                    await userManager.AddToRoleAsync(user, "PFUser");
                }
            }
        }
    }
}
