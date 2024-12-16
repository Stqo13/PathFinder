using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PathFinder.Data.Models;

namespace PathFinder.Data.Configurations
{
    public class ApplicationUserConfiguration
        : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(this.GenerateUsers());
        }

        public IEnumerable<ApplicationUser> GenerateUsers()
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            var users = new HashSet<ApplicationUser>
            {
                #region Institutions

                new ()
                {
                    Id = "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                    FirstName = "SoftSchool",
                    LastName = "AD",
                    Email = "softschool@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0878765781",
                    UserName = "softschool123",
                    NormalizedUserName = "SOFTSCHOOL123",
                    NormalizedEmail = "SOFTSCHOOL@GMAIL.COM",
                    DateOfBirth = new DateTime(2000, 3, 2),
                    Address = "Bulgaria, Sofia, bul. \"Alexandur Malinov\" 78",
                    PasswordHash = passwordHasher.HashPassword(null!, "SoftSchool_123")
                },
                new ()
                {
                    Id = "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                    FirstName = "Telerikikus",
                    LastName = "OD",
                    Email = "telerikikus@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0898769871",
                    UserName = "telerikikus123",
                    NormalizedUserName = "TELERIKIKUS123",
                    NormalizedEmail = "TELERIKIKUS@GMAIL.COM",
                    DateOfBirth = new DateTime(1980, 6, 5),
                    Address = "Bulgaria, Plovdiv, bul. \"Tsar Boris 3ti Obedinitel\"",
                    PasswordHash = passwordHasher.HashPassword(null!, "Telerikikus_123")
                },
                new ()
                {
                    Id = "fa360a62-9355-474a-824d-aaa85d9fbd65",
                    FirstName = "WittMath",
                    LastName = "OOD",
                    Email = "wittmath@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0880796431",
                    UserName = "wittmath123",
                    NormalizedUserName = "WITTMATH123",
                    NormalizedEmail = "WITTMATH@GMAIL.COM",
                    DateOfBirth = new DateTime(2001, 7, 13),
                    Address = "Bulgaria, Stara Zagora, ul. \"Stefan Stambolov\" 38",
                    PasswordHash = passwordHasher.HashPassword(null!, "WittMath_123")
                },

                #endregion

                #region Company

                new ()
                {
                    Id = "e0d6328d-f003-4bb1-8daa-21dcf49db469",
                    FirstName = "Chic Cuts & Styles",
                    LastName = "ET",
                    Email = "chick@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0898769871",
                    UserName = "chic123",
                    NormalizedUserName = "CHIC123",
                    NormalizedEmail = "CHIC@GMAIL.COM",
                    DateOfBirth = new DateTime(2002, 8, 1),
                    Address = "Bulgaria, Pleven, ul. \"Vasil Petleshkov\" 6",
                    PasswordHash = passwordHasher.HashPassword(null!, "CutAndStyles_123")
                },
                new ()
                {
                    Id = "16226cef-b670-447e-99a9-b627cb16ae0b",
                    FirstName = "STTuning",
                    LastName = "OOD",
                    Email = "sttuning@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0876794891",
                    UserName = "sttuning123",
                    NormalizedUserName = "STTUNING123",
                    NormalizedEmail = "STTUNING@GMAIL.COM",
                    DateOfBirth = new DateTime(2016, 6, 5),
                    Address = "Bulgaria, Ruse, уul. \"Rila\" 5",
                    PasswordHash = passwordHasher.HashPassword(null!, "STTuning_123")
                },
                new ()
                {
                    Id = "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
                    FirstName = "CodeCrafters",
                    LastName = "ET",
                    Email = "codecrafters@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0877769431",
                    UserName = "codecrafters123",
                    NormalizedUserName = "CODECRAFTERS123",
                    NormalizedEmail = "CODECRAFTERS@GMAIL.COM",
                    DateOfBirth = new DateTime(1990, 9, 1),
                    Address = "Bulgaria, Ruse, ul. \"Рила\" 5",
                    PasswordHash = passwordHasher.HashPassword(null!, "CodeCrafters_123")
                },

                #endregion

                #region Admins

                new ()
                {
                    Id = "e2041514-c5ce-4e68-8956-f92298aa3b74",
                    FirstName = "Teodora",
                    LastName = "Nedkova",
                    Email = "teodoranedkova@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0879859335",
                    UserName = "teodoranedkova123",
                    NormalizedUserName = "TEODORANEDKOVA123",
                    NormalizedEmail = "TEODORANEDKOVA@GMAIL.COM",
                    DateOfBirth = new DateTime(2004, 12, 13),
                    Address = "Bulgaria, Kazanluk, ul. \"Hemus\" 5",
                    PasswordHash = passwordHasher.HashPassword(null!, "TeodoraNedkova_123")
                },
                 new ()
                {
                    Id = "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0",
                    FirstName = "Stefan",
                    LastName = "Dimitrov",
                    Email = "stefandimitrov@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0890854939",
                    UserName = "stefandimitrov123",
                    NormalizedUserName = "STEFANDIMITROV123",
                    NormalizedEmail = "STEFANDIMITROV@GMAIL.COM",
                    DateOfBirth = new DateTime(2004, 6, 13),
                    Address = "Bulgaria, Kazanluk, ul. \"Petko Stainov\" 6",
                    PasswordHash = passwordHasher.HashPassword(null!, "StefanDimitrov_123")
                },

                #endregion

                #region PHUsers

                new ()
                {
                    Id = "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2",
                    FirstName = "Alex",
                    LastName = "Stefanov",
                    Email = "alexstefanov@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0883856039",
                    UserName = "alexstefanov123",
                    NormalizedUserName = "ALEXSTEFANOV123",
                    NormalizedEmail = "ALEXSTEFANOV@GMAIL.COM",
                    DateOfBirth = new DateTime(2005, 5, 16),
                    Address = "Bulgaria, Kazanluk, ul. \"Dobri Chintulov\" 5",
                    PasswordHash = passwordHasher.HashPassword(null!, "AlexStefanov_123")
                },

                new ()
                {
                    Id = "9e547484-9ea8-45e6-a488-d657f6f1c598",
                    FirstName = "Monika",
                    LastName = "Petrova",
                    Email = "monikapetrova@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0898760394",
                    UserName = "monikapetrova123",
                    NormalizedUserName = "MONIKAPETROVA123",
                    NormalizedEmail = "MONIKAPETROVA@GMAIL.COM",
                    DateOfBirth = new DateTime(2002, 7, 6),
                    Address = "Bulgaria, Kazanluk, ul. \"General Gurko\" 4",
                    PasswordHash = passwordHasher.HashPassword(null!, "MonikaPetrova_123")
                },

                new ()
                {
                    Id = "e8d223af-7285-41c5-8c38-9e6989d4410d",
                    FirstName = "Iliq",
                    LastName = "Milenov",
                    Email = "iliqmilenov@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0895068785",
                    UserName = "iliqmilenov123",
                    NormalizedUserName = "ILIQMILENOV123",
                    NormalizedEmail = "ILIQMILENOV@GMAIL.COM",
                    DateOfBirth = new DateTime(2001, 8, 2),
                    Address = "Bulgaria, Kazanluk, ul. \"General Stoletov\" 3",
                    PasswordHash = passwordHasher.HashPassword(null!, "IliqMilenov_123")
                },

                new ()
                {
                    Id = "d444522c-71c1-4cc9-b815-4ea25a49f17b",
                    FirstName = "Atanas",
                    LastName = "Gudov",
                    Email = "atanasgudov@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0885248739",
                    UserName = "atanasgudov123",
                    NormalizedUserName = "ATANASGUDOV123",
                    NormalizedEmail = "ATANASGUDOV@GMAIL.COM",
                    DateOfBirth = new DateTime(1998, 3, 16),
                    Address = "Bulgaria, Kazanluk, ul. \"Georgi Sava Rakovski\" 7",
                    PasswordHash = passwordHasher.HashPassword(null!, "AtanasGudov_123")
                },

                new ()
                {
                    Id = "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355",
                    FirstName = "Simona",
                    LastName = "Mincheva",
                    Email = "simonamincheva@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0897448199",
                    UserName = "simonamincheva123",
                    NormalizedUserName = "SIMONAMINCHEVA123",
                    NormalizedEmail = "SIMONAMINCHEVA@GMAIL.COM",
                    DateOfBirth = new DateTime(1989, 8, 26),
                    Address = "Bulgaria, Plovdiv, ul. \"Georgi Rakovski\" 7",
                    PasswordHash = passwordHasher.HashPassword(null!, "SimonaMincheva_123")
                },

                new ()
                {
                    Id = "7d089603-dc80-415a-913b-f24b1a90b5f1",
                    FirstName = "Georgi",
                    LastName = "Vasilev",
                    Email = "georgivasilev@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0804442391",
                    UserName = "georgivasilev123",
                    NormalizedUserName = "GEORGIVASILEV123",
                    NormalizedEmail = "GEORGIVASILEV@GMAIL.COM",
                    DateOfBirth = new DateTime(1995, 2, 25),
                    Address = "Bulgaria, Pleven, ul. \"Hadzi Dimitur\" 10",
                    PasswordHash = passwordHasher.HashPassword(null!, "GeorgiVasilev_123")
                },

                new ()
                {
                    Id = "ca145762-b5db-4836-b963-85eff67fb124",
                    FirstName = "Krasimir",
                    LastName = "Draganov",
                    Email = "krasimirdraganov@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0894555391",
                    UserName = "krasimirdraganov123",
                    NormalizedUserName = "KRASIMIRDRAGANOV123",
                    NormalizedEmail = "KRASIMIRDRAGANOV@GMAIL.COM",
                    DateOfBirth = new DateTime(1999, 8, 19),
                    Address = "Bulgaria, Pleven, ul. \"Hristo Botev\" 4",
                    PasswordHash = passwordHasher.HashPassword(null!, "KrasimirDraganov_123")
                },

                new ()
                {
                    Id = "8d0c3b82-be4b-4fdf-834a-8e436176d9bd",
                    FirstName = "Svetlin",
                    LastName = "Georgiev",
                    Email = "svetlingeorgiev@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0894555881",
                    UserName = "svetlingeorgiev123",
                    NormalizedUserName = "SVETLINGEORGIEV123",
                    NormalizedEmail = "SVETLINGEORGIEV@GMAIL.COM",
                    DateOfBirth = new DateTime(1996, 4, 20),
                    Address = "Bulgaria, Pleven, ul. \"Stefan Karadza\" 6",
                    PasswordHash = passwordHasher.HashPassword(null!, "SvetlinGeorgiev_123")
                }

                #endregion
            };
            return users;
        }

    }
}
