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
                    Id = "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                    FirstName = "ArtAcademy",
                    LastName = "OOD",
                    Email = "artacademy@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0897902119",
                    UserName = "artacademy123",
                    NormalizedUserName = "ARTACADEMY123",
                    NormalizedEmail = "ARTACADEMY@GMAIL.COM",
                    DateOfBirth = new DateTime(1994, 5, 17),
                    Address = "Bulgaria, Ruse, ul. \"Hristo Yasenov\" 7",
                    PasswordHash = passwordHasher.HashPassword(null!, "ArtAcademy_123")
                },
                new () 
                {
                    Id = "fc7c5678-22b4-4650-af6e-4c5f90fa494d",
                    FirstName = "GlobalLingua",
                    LastName = "OOD",
                    Email = "globallingua@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0897662398",
                    UserName = "globallingua123",
                    NormalizedUserName = "GLOBALLINGUA123",
                    NormalizedEmail = "GLOBALLINGUA@GMAIL.COM",
                    DateOfBirth = new DateTime(1994, 5, 17),
                    Address = "Bulgaria, Sofia, ul. \"Tsar Asen\" 112",
                    PasswordHash = passwordHasher.HashPassword(null!, "GlobalLingua_123")
                },
                new ()
                {
                    Id = "723444b3-9434-4465-9044-f7e04fdcca2f",
                    FirstName = "Marketing Academy",
                    LastName = "OOD",
                    Email = "marketingacademy@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0877742199",
                    UserName = "marketingacademy123",
                    NormalizedUserName = "MARKETINGACADEMY123",
                    NormalizedEmail = "MARKETINGACADEMY@GMAIL.COM",
                    DateOfBirth = new DateTime(1990, 6, 27),
                    Address = "Bulgaria, Sofia, ul. \"Petar B. Velichkov\" 43",
                    PasswordHash = passwordHasher.HashPassword(null!, "MarketingAcademy_123")
                },
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
                new ()
                {
                    Id = "",
                    FirstName = "TasteCraft Academy",
                    LastName = "OOD",
                    Email = "tastecraftacademy@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0895002619",
                    UserName = "tastecraftacademy123",
                    NormalizedUserName = "TASTECRAFTACADEMY123",
                    NormalizedEmail = "TASTECRAFTACADEMY@GMAIL.COM",
                    DateOfBirth = new DateTime(1991, 3, 2),
                    Address = "Bulgaria, Varna, ul. \"Oborishte\" 13A",
                    PasswordHash = passwordHasher.HashPassword(null!, "TasteCraftAcademy_123")
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
                    Id = "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd",
                    FirstName = "The Urban Grill & Bar",
                    LastName = "ET",
                    Email = "theurbangrillandbar@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0878439866",
                    UserName = "theurbangrillandbar123",
                    NormalizedUserName = "THEURBANGRILLANDBAR123",
                    NormalizedEmail = "THEURBANGRILLANDBAR@GMAIL.COM",
                    DateOfBirth = new DateTime(2003, 5, 21),
                    Address = "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А",
                    PasswordHash = passwordHasher.HashPassword(null!, "TheUrbanGrillAndBar_123")
                },
                new ()
                {
                    Id = "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf",
                    FirstName = "Imagination Academy",
                    LastName = "OOD",
                    Email = "imaginationacademy@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0878433392",
                    UserName = "imaginationacandemy123",
                    NormalizedUserName = "IMAGINATIONACADEMY123",
                    NormalizedEmail = "IMAGINATIONACADEMY@GMAIL.COM",
                    DateOfBirth = new DateTime(2006, 1, 2),
                    Address = "Bulgaria, Vrana, ul. \"Kozloduy\" 4",
                    PasswordHash = passwordHasher.HashPassword(null!, "TheUrbanGrillAndBar_123")
                },
                new ()
                {
                    Id = "17585a62-c173-4c68-9e4a-2ba93a419b21",
                    FirstName = "HealthCare Center",
                    LastName = "OD",
                    Email = "healthcarecentre@gmail.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0870063844",
                    UserName = "healthcarecentre123",
                    NormalizedUserName = "HEALTHCARECENTRE123",
                    NormalizedEmail = "HEALTHCARECENTRE@GMAIL.COM",
                    DateOfBirth = new DateTime(1986, 4, 10),
                    Address = "Bulgaria, Ruse, bul. \"Lipnik\" 8",
                    PasswordHash = passwordHasher.HashPassword(null!, "HealthCareCentre_123")
                },
                new ()
                {
                    Id = "596c6add-eaae-4890-8d4d-38aa5a0671bd",
                    FirstName = "Primary Inovative School",
                    LastName = "ET",
                    Email = "primaryinovativeschool.com",
                    EmailConfirmed = true,
                    PhoneNumber = "0890811871",
                    UserName = "primaryinovativeschool123",
                    NormalizedUserName = "PRIMARYINOVATIVESCHOOL123",
                    NormalizedEmail = "PRIMARYINOVATIVESCHOOL@GMAIL.COM",
                    DateOfBirth = new DateTime(1985, 5, 3),
                    Address = "Bulgaria, Pleven, ul. \"Ivan Vazov\"",
                    PasswordHash = passwordHasher.HashPassword(null!, "PrimaryInovativeSchool_123")
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
