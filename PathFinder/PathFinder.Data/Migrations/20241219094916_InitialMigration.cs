using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PathFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "User's first name"),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "User's last name"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "User's date of birth"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "User's address"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spheres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Sphere's identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Sphere")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spheres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Course's identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Course's name"),
                    Mode = table.Column<int>(type: "int", nullable: false, comment: "Course's mode(Online/In-person)"),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true, comment: "Course's description"),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false, comment: "Course's duration in minutes"),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Course's location"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Couse's start date"),
                    InstitutionId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Institution's foreign key"),
                    AverageStarRating = table.Column<double>(type: "float", nullable: true, comment: "Course's average star rating"),
                    MonthlyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Course's monthly price")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Job's idetifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Job's title"),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true, comment: "Job's details"),
                    JobType = table.Column<int>(type: "int", nullable: false, comment: "The type of the job"),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Job's location"),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Company's foreign key"),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Job's position"),
                    Requirement = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Job's requiements"),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Job salary"),
                    AverageStarRating = table.Column<double>(type: "float", nullable: true, comment: "Job average star rating")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_AspNetUsers_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersSpheres",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User's foreign key"),
                    SphereId = table.Column<int>(type: "int", nullable: false, comment: "Sphere's foreign key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSpheres", x => new { x.UserId, x.SphereId });
                    table.ForeignKey(
                        name: "FK_UsersSpheres_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Users' spheres");

            migrationBuilder.CreateTable(
                name: "CoursesSpheres",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course's foreign key"),
                    SphereId = table.Column<int>(type: "int", nullable: false, comment: "Sphere's foreign key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesSpheres", x => new { x.CourseId, x.SphereId });
                    table.ForeignKey(
                        name: "FK_CoursesSpheres_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Corses' spheres");

            migrationBuilder.CreateTable(
                name: "UsersCourses",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User's foreign key"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course's foreign key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCourses", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_UsersCourses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsersCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                },
                comment: "Users' courses");

            migrationBuilder.CreateTable(
                name: "JobsSpheres",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false, comment: "Job's foreign key"),
                    SphereId = table.Column<int>(type: "int", nullable: false, comment: "Sphere's foreign key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsSpheres", x => new { x.JobId, x.SphereId });
                    table.ForeignKey(
                        name: "FK_JobsSpheres_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobsSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Jobs' spheres");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Review's idetifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StarRating = table.Column<int>(type: "int", nullable: true, comment: "Review's star rating"),
                    Comment = table.Column<string>(type: "nvarchar(750)", maxLength: 750, nullable: true, comment: "Comment"),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Review's date"),
                    PublisherId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Publisher's foreign key"),
                    JobId = table.Column<int>(type: "int", nullable: true, comment: "Job's foreign key"),
                    CourseId = table.Column<int>(type: "int", nullable: true, comment: "Course's foreign key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UsersJobs",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User's foreign key"),
                    JobId = table.Column<int>(type: "int", nullable: false, comment: "Job's foreign key")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersJobs", x => new { x.UserId, x.JobId });
                    table.ForeignKey(
                        name: "FK_UsersJobs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsersJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                },
                comment: "Users' jobs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a94e9744-895c-4cd0-a450-fb2ca5ea73dc", "eab4d980-d470-4b4b-bb99-6768a6d7a63d", "Admin", "ADMIN" },
                    { "b69f39cc-e6e4-4394-b488-0d24c1d546ff", "9277a98f-3549-49fd-bb18-9810182b5e8d", "Company", "COMPANY" },
                    { "be759a02-939c-4bb6-9063-f25e020d8a56", "5b72d0bc-f750-402f-a330-7ebded6824b3", "Institution", "INSTITUTION" },
                    { "cbd2b782-e4e3-4f79-84aa-5685d13320cb", "4eab5cb1-b6fc-42f3-9f01-93b0625f85b6", "PFUser", "PFUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16226cef-b670-447e-99a9-b627cb16ae0b", 0, "Bulgaria, Ruse, ул. \"Rila\" 5", "2e0f79c5-4509-4f90-b098-37ee95be209f", new DateTime(2016, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sttuning@gmail.com", true, "STTuning", "OOD", false, null, "STTUNING@GMAIL.COM", "STTUNING123", "AQAAAAIAAYagAAAAEKW5ekxD0Twt+/uTe/oyWWJOWQrNfHQpqRPr89yjx1vLgwusoP9sZF/vIY19Dv45Cw==", "0876794891", false, "b9c3b0ab-7138-44a9-8e06-38cfbcf03ede", false, "sttuning123" },
                    { "17585a62-c173-4c68-9e4a-2ba93a419b21", 0, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "35bc0fc4-d730-4937-8c07-9cbb8a0e8602", new DateTime(1986, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "healthcarecentre@gmail.com", true, "HealthCare Center", "OD", false, null, "HEALTHCARECENTRE@GMAIL.COM", "HEALTHCARECENTRE123", "passwordHashPlaceholder", "0870063844", false, "6a076913-349e-4c0d-9154-55d332779758", false, "healthcarecentre123" },
                    { "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0", 0, "Bulgaria, Kazanluk, ul. \"Petko Stainov\" 6", "d7870d1c-9f0d-4696-bc37-df43975a8d7c", new DateTime(2004, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "stefandimitrov@gmail.com", true, "Stefan", "Dimitrov", false, null, "STEFANDIMITROV@GMAIL.COM", "STEFANDIMITROV123", "AQAAAAIAAYagAAAAENxomfu3mXk/i0ygmFWmgE2tVb65RYzj5Nq+d+VOJL9ZSZ9s2jYzbmXjY3S4OH+7ew==", "0890854939", false, "20992870-b1a7-4355-9280-dd18577a8836", false, "stefandimitrov123" },
                    { "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1", 0, "Bulgaria, Varna, ul. \"Oborishte\" 13A", "f59bb90a-3939-4adb-b043-560e619f2e11", new DateTime(1991, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "tastecraftacademy@gmail.com", true, "TasteCraft Academy", "OOD", false, null, "TASTECRAFTACADEMY@GMAIL.COM", "TASTECRAFTACADEMY123", "passwordHashPlaceholder", "0895002619", false, "f11a89c3-9f72-4286-81f4-d8c1252475f3", false, "tastecraftacademy123" },
                    { "3cf3fb4a-235e-4c93-b66f-c1557006e067", 0, "Bulgaria, Plovdiv, bul. \"Tsar Boris 3ti Obedinitel\"", "578ffa94-2a68-4edf-a7e4-40b1d7722eb5", new DateTime(1980, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "telerikikus@gmail.com", true, "Telerikikus", "OD", false, null, "TELERIKIKUS@GMAIL.COM", "TELERIKIKUS123", "AQAAAAIAAYagAAAAEFF1HXdTWtYcV7fLoF5G6geJwTFlXapTT2mFAE4r1Jsbrsgr+Ga0qUVomV6/6Dhcig==", "0898769871", false, "0d6c0fed-952f-4901-9fa6-97a143c356ca", false, "telerikikus123" },
                    { "428bcf46-40f2-47b2-ac4a-a49f570178ad", 0, "Bulgaria, Sofia, bul. \"Alexandur Malinov\" 78", "763c8410-b2c8-455d-b811-75608b2d578f", new DateTime(2000, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "softschool@gmail.com", true, "SoftSchool", "AD", false, null, "SOFTSCHOOL@GMAIL.COM", "SOFTSCHOOL123", "AQAAAAIAAYagAAAAEOSg1EYyg5DJAQPx8auaXmV2YuqvLgJK+utGTpDtZO79q9m2gUbgYlrS7ARJB+CIXg==", "0878765781", false, "3a17de7b-423a-409a-a636-4fc38803e816", false, "softschool123" },
                    { "596c6add-eaae-4890-8d4d-38aa5a0671bd", 0, "Bulgaria, Pleven, ul. \"Ivan Vazov\"", "528d8014-b16a-4a70-87d9-e2822f71362f", new DateTime(1985, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "primaryinovativeschool.com", true, "Primary Inovative School", "ET", false, null, "PRIMARYINOVATIVESCHOOL@GMAIL.COM", "PRIMARYINOVATIVESCHOOL123", "passwordHashPlaceholder", "0890811871", false, "e1be328e-97b8-4445-9304-5e450f8e3b02", false, "primaryinovativeschool123" },
                    { "6a358b17-ffbe-4ac9-8d20-92544e3b739d", 0, "Bulgaria, Ruse, ul. \"Hristo Yasenov\" 7", "c9a96bc0-6bbb-4bda-992e-d923c61f1106", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "artacademy@gmail.com", true, "ArtAcademy", "OOD", false, null, "ARTACADEMY@GMAIL.COM", "ARTACADEMY123", "passwordHashPlaceholder", "0897902119", false, "b2bc4edc-9e2c-40b5-b631-9d6c0a35fe19", false, "artacademy123" },
                    { "723444b3-9434-4465-9044-f7e04fdcca2f", 0, "Bulgaria, Sofia, ul. \"Petar B. Velichkov\" 43", "fa90c755-89f8-453a-bc1f-052c06b5a7d5", new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "marketingacademy@gmail.com", true, "Marketing Academy", "OOD", false, null, "MARKETINGACADEMY@GMAIL.COM", "MARKETINGACADEMY123", "passwordHashPlaceholder", "0877742199", false, "83c6df15-92d1-49e8-be3e-5abd1fef9d67", false, "marketingacademy123" },
                    { "7d089603-dc80-415a-913b-f24b1a90b5f1", 0, "Bulgaria, Pleven, ul. \"Hadzi Dimitur\" 10", "0afe838c-23c1-4aba-8727-332513d99a4b", new DateTime(1995, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "georgivasilev@gmail.com", true, "Georgi", "Vasilev", false, null, "GEORGIVASILEV@GMAIL.COM", "GEORGIVASILEV123", "AQAAAAIAAYagAAAAEBLyJb8Ur40g8Az9prO6x4jYxSXlEE5wzaXQONEDfMxsdRAq1qJp18o9FIsb6khXyw==", "0804442391", false, "7644fe57-6cf0-4030-a17b-ca875d0a4843", false, "georgivasilev123" },
                    { "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", 0, "Bulgaria, Vrana, ul. \"Kozloduy\" 4", "fa38f80b-7823-4914-bd44-f0d86399f44c", new DateTime(2006, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "imaginationacademy@gmail.com", true, "Imagination Academy", "OOD", false, null, "IMAGINATIONACADEMY@GMAIL.COM", "IMAGINATIONACADEMY123", "passwordHashPlaceholder", "0878433392", false, "f66a4796-75eb-4e72-a51a-273d6d04bd23", false, "imaginationacandemy123" },
                    { "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", 0, "Bulgaria, Pleven, ul. \"Stefan Karadza\" 6", "bf3e6d1d-da15-47c0-b465-d6e0ebc335a8", new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "svetlingeorgiev@gmail.com", true, "Svetlin", "Georgiev", false, null, "SVETLINGEORGIEV@GMAIL.COM", "SVETLINGEORGIEV123", "AQAAAAIAAYagAAAAEFBmdDnwYVRoIWu0E+7rL6QEnXzWcyPal4XNtCc38aTKxUSTqkE2KQXuMsEyBVWeUQ==", "0894555881", false, "897696c3-74b7-4375-aa84-c4af7093f778", false, "svetlingeorgiev123" },
                    { "9e547484-9ea8-45e6-a488-d657f6f1c598", 0, "Bulgaria, Kazanluk, ul. \"General Gurko\" 4", "8da6e0e6-2a30-4924-ab0e-e4705f6dfff3", new DateTime(2002, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "monikapetrova@gmail.com", true, "Monika", "Petrova", false, null, "MONIKAPETROVA@GMAIL.COM", "MONIKAPETROVA123", "AQAAAAIAAYagAAAAEPm7hUniDBwNaUSWir1IOwgrj7CH8M5SM/6xvHjFKysxHSabEyXL3Ps4CcfiWMMh4A==", "0898760394", false, "40c3099f-a312-4404-bf65-95b51c290199", false, "monikapetrova123" },
                    { "b3693b0c-9c11-48ee-a3be-db37d5439ab0", 0, "Bulgaria, Ruse, ul. \"Рила\" 5", "da105ec2-3ea1-493a-a8f7-cbe7925bc352", new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "codecrafters@gmail.com", true, "CodeCrafters", "ET", false, null, "CODECRAFTERS@GMAIL.COM", "CODECRAFTERS123", "AQAAAAIAAYagAAAAED+ogfcr3y2oIv5dxd4s3aWW5KA+Bfn6YBXcPmzRfW0sZRIkiczMX+qZMbL5W9Oeug==", "0877769431", false, "e9913c6a-188f-414c-92ef-82421e7eca50", false, "codecrafters123" },
                    { "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", 0, "Bulgaria, Plovdiv, ul. \"Georgi Rakovski\" 7", "b93eb6ce-a637-481e-ae77-ac2d282fb7f8", new DateTime(1989, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "simonamincheva@gmail.com", true, "Simona", "Mincheva", false, null, "SIMONAMINCHEVA@GMAIL.COM", "SIMONAMINCHEVA123", "AQAAAAIAAYagAAAAEJ7dya72DIU5iATHB6BsgQ/Aprn16E6Jdksc3v7wWFcOCws8Ge6GwzF6R6BBK6lZSA==", "0897448199", false, "f027b114-34f6-42dd-8f5f-789dc89af23b", false, "simonamincheva123" },
                    { "ca145762-b5db-4836-b963-85eff67fb124", 0, "Bulgaria, Pleven, ul. \"Hristo Botev\" 4", "8f690dcc-3bc9-4f66-ac89-0c91f075f71a", new DateTime(1999, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "krasimirdraganov@gmail.com", true, "Krasimir", "Draganov", false, null, "KRASIMIRDRAGANOV@GMAIL.COM", "KRASIMIRDRAGANOV123", "AQAAAAIAAYagAAAAEG7kkq0wgJOHsuXPV0NUWaRd3rmQQ/KRMhWdCUk0iW0S73m+y6+RXdr8mYFbWzBiPg==", "0894555391", false, "35f46ebc-d7b5-4c22-8996-dc9da9f2179f", false, "krasimirdraganov123" },
                    { "d444522c-71c1-4cc9-b815-4ea25a49f17b", 0, "Bulgaria, Kazanluk, ul. \"Georgi Sava Rakovski\" 7", "516dd35b-cba3-4073-bbeb-23265c73118b", new DateTime(1998, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "atanasgudov@gmail.com", true, "Atanas", "Gudov", false, null, "ATANASGUDOV@GMAIL.COM", "ATANASGUDOV123", "AQAAAAIAAYagAAAAEPceucJXxTyzIHZFZZGczFK1rrhkfF4UqVDIYTV67XgTTFmleNR/DsVRpe8AobaERg==", "0885248739", false, "476b52f7-ba3c-4277-801b-f4a5bbb3c4e3", false, "atanasgudov123" },
                    { "e0d6328d-f003-4bb1-8daa-21dcf49db469", 0, "Bulgaria, Pleven, ul. \"Vasil Petleshkov\" 6", "54f56a96-2398-4cb8-9f17-c5a587e06f6e", new DateTime(2002, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chick@gmail.com", true, "Chic Cuts & Styles", "ET", false, null, "CHIC@GMAIL.COM", "CHIC123", "AQAAAAIAAYagAAAAEM5Dc2oLiHKtcpPZhQPSNn5pRcZCzM923XDHwiYpIJl3aN28rPRBHUjephWN48l7tw==", "0898769871", false, "208f305f-233d-46fd-a32c-5973137242de", false, "chic123" },
                    { "e2041514-c5ce-4e68-8956-f92298aa3b74", 0, "Bulgaria, Kazanluk, ul. \"Hemus\" 5", "80f1b894-2078-41a6-a94f-99c861dab7f6", new DateTime(2004, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "teodoranedkova@gmail.com", true, "Teodora", "Nedkova", false, null, "TEODORANEDKOVA@GMAIL.COM", "TEODORANEDKOVA123", "AQAAAAIAAYagAAAAEDW0PEjzjs1NAqYdIPoHi9k7AoSguMkfLLVepCCXb4h66H8dP0IXA8FwvgItoa56tw==", "0879859335", false, "6bf7b0b1-9c89-4dc4-9f41-f303c0f69c39", false, "teodoranedkova123" },
                    { "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", 0, "Bulgaria, Kazanluk, ul. \"Dobri Chintulov\" 5", "e7a26d85-6319-4617-9f92-f5eb0bde1ba6", new DateTime(2005, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexstefanov@gmail.com", true, "Alex", "Stefanov", false, null, "ALEXSTEFANOV@GMAIL.COM", "ALEXSTEFANOV123", "AQAAAAIAAYagAAAAECfJU564Lrafc4bJBHDLkYV8zoqxRNe+ugSu7x0Ovx2IMKoyMhxy57s+HmHvtH1hYA==", "0883856039", false, "2aafcdea-9ea5-489c-949e-bd4f1718f0d8", false, "alexstefanov123" },
                    { "e8d223af-7285-41c5-8c38-9e6989d4410d", 0, "Bulgaria, Kazanluk, ul. \"General Stoletov\" 3", "5978acc5-6ebf-4f9f-81af-77cfa1252d31", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "iliqmilenov@gmail.com", true, "Iliq", "Milenov", false, null, "ILIQMILENOV@GMAIL.COM", "ILIQMILENOV123", "AQAAAAIAAYagAAAAEIYL5DTX0X6pVE9HPfAwP1aOzQZ9mz392E7iGlzLouU5WD5kuK9F5+5mgIilPJtxKg==", "0895068785", false, "10b721c6-dad7-4d2a-ab29-705411333c74", false, "iliqmilenov123" },
                    { "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", 0, "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А", "c39a1890-d3ce-46aa-9d3c-9985b32ebee0", new DateTime(2003, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "theurbangrillandbar@gmail.com", true, "The Urban Grill & Bar", "ET", false, null, "THEURBANGRILLANDBAR@GMAIL.COM", "THEURBANGRILLANDBAR123", "passwordHashPlaceholder", "0878439866", false, "014dbe55-e260-44e5-b370-94c00c07aa07", false, "theurbangrillandbar123" },
                    { "fa360a62-9355-474a-824d-aaa85d9fbd65", 0, "Bulgaria, Stara Zagora, ul. \"Stefan Stambolov\" 38", "c8092cba-bc7f-43e0-83b5-7e8c31031a7c", new DateTime(2001, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "wittmath@gmail.com", true, "WittMath", "OOD", false, null, "WITTMATH@GMAIL.COM", "WITTMATH123", "AQAAAAIAAYagAAAAEP1PVmFc/vWMV16nG3KJ3itWGy676GYFo19p/K8CVXJRiyGyP8MTiXXFk/fMxK7QZw==", "0880796431", false, "3fef0d58-d14b-427c-a9e6-f568da50854d", false, "wittmath123" },
                    { "fc7c5678-22b4-4650-af6e-4c5f90fa494d", 0, "Bulgaria, Sofia, ul. \"Tsar Asen\" 112", "035af823-fef9-4c84-8945-c11908e7686c", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "globallingua@gmail.com", true, "GlobalLingua", "OOD", false, null, "GLOBALLINGUA@GMAIL.COM", "GLOBALLINGUA123", "passwordHashPlaceholder", "0897662398", false, "83449ace-7f7b-457a-9773-14332c53904a", false, "globallingua123" }
                });

            migrationBuilder.InsertData(
                table: "Spheres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Healthcare" },
                    { 2, "Technology" },
                    { 3, "Business & Finance" },
                    { 4, "Education" },
                    { 5, "Creative Arts" },
                    { 6, "Computer Science" },
                    { 7, "Graphic Design" },
                    { 8, "Marketing & Management" },
                    { 9, "Architecture" },
                    { 10, "Facility Management" },
                    { 11, "Engineering" },
                    { 12, "Web Development" },
                    { 13, "Back-End Programming" },
                    { 14, "Front-End Programming" },
                    { 15, "Adobe Designing" },
                    { 16, "Beauty and Personal Care Industry" },
                    { 17, "Service Industry" },
                    { 18, "Health and Wellness Industry" },
                    { 19, "Automotive Industry" },
                    { 20, "Mechanical Engineering" },
                    { 21, "Transportation and Logistics" },
                    { 22, "Skilled Trades" },
                    { 23, "Sustainability and Green Technologies" },
                    { 24, "Medical Specialties" },
                    { 25, "Cosmetic Dermatology" },
                    { 26, "Pharmaceutical Industry" },
                    { 27, "STEM Education" },
                    { 28, "Public Sector" },
                    { 29, "Curriculum Development" },
                    { 30, "Non-profit Education" },
                    { 31, "Cleaning and Maintenance" },
                    { 32, "Public Services" },
                    { 33, "Environmental Services" },
                    { 34, "Education Support Services" },
                    { 35, "Food and Beverage Services" },
                    { 36, "Customer Service" },
                    { 37, "Event Management" },
                    { 38, "Nightlife and Entertainment" },
                    { 39, "Tourism and Leisure" },
                    { 40, "Media and Journalism" },
                    { 41, "Marketing & Communications" },
                    { 42, "Digital Marketing" },
                    { 43, "Freelancing" },
                    { 44, "Film Production" },
                    { 45, "Media and Entertainment" },
                    { 46, "Software Development" },
                    { 47, "Security" },
                    { 48, "Visual Arts" },
                    { 49, "Retail Pharmacy" },
                    { 50, "Clinical Care" },
                    { 51, "Reproductive Health" },
                    { 52, "Women’s Health" },
                    { 53, "Cosmetic Surgery" },
                    { 54, "Spa and Wellness" },
                    { 55, "Personal Grooming" },
                    { 56, "Salon Management" },
                    { 57, "Hairdressing and Styling" },
                    { 58, "Mathematics" },
                    { 59, "Restaurant Hospitality" },
                    { 60, "Cultural Studies" },
                    { 61, "Language & Linguistics" },
                    { 62, "Cooking" },
                    { 63, "Physical Education" },
                    { 64, "Fitness and Personal Training" },
                    { 65, "Audio Engineering" },
                    { 66, "Music Composition" },
                    { 67, "Music Technology" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AverageStarRating", "Description", "DurationInMinutes", "InstitutionId", "Location", "Mode", "MonthlyPrice", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 4.0, "Learn the fundamentals of digital marketing, including SEO, PPC, and social media strategies.", 120, "723444b3-9434-4465-9044-f7e04fdcca2f", "Remote", 0, 30m, "Introduction to Digital Marketing", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4.5, "Master the basics of HTML, CSS, and JavaScript in this beginner-friendly web development course.", 150, "428bcf46-40f2-47b2-ac4a-a49f570178ad", "Remote", 0, 35m, "Web Development for Beginners", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4.7999999999999998, "Dive into the world of data science and learn machine learning algorithms using Python and R.", 180, "3cf3fb4a-235e-4c93-b66f-c1557006e067", "Remote", 0, 45m, "Data Science and Machine Learning", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4.7000000000000002, "Gain a foundational understanding of AI, its applications, and how it is changing industries.", 150, "428bcf46-40f2-47b2-ac4a-a49f570178ad", "Remote", 0, 50m, "Introduction to Artificial Intelligence", new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4.5999999999999996, "Master the basics of Spanish, including vocabulary, grammar, and conversational skills, in an engaging and interactive environment.", 90, "fc7c5678-22b4-4650-af6e-4c5f90fa494d", "Bulgaria, Burgas, ul. \"Odrin\" 2", 1, 200m, "Spanish for beginners", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4.7999999999999998, "Learn the basics of cooking techniques, kitchen safety, and food presentation in this hands-on culinary course.", 120, "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1", "Bulgaria, Varna, ul. \"Oborishte\" 13A", 1, 220m, "Introduction to Culinary Arts", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4.5, "Relax, rejuvenate, and learn mindfulness practices along with beginner-friendly yoga postures in this course.", 90, "6a358b17-ffbe-4ac9-8d20-92544e3b739d", "Bulgaria, Pazardzik, ul. \"Nayden Gerov\" 6", 1, 100m, "Yoga and Mindfulness for Beginners", new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4.7000000000000002, "Improve your English language skills in speaking, listening, reading, and writing through practical lessons and exercises.", 180, "fc7c5678-22b4-4650-af6e-4c5f90fa494d", "Bulgaria, Kazanlak, ul. \"Ivan Vazov\" 3", 1, 90m, "English Language Mastery", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4.7999999999999998, "Explore the basics of fine art, including sketching, painting, and sculpting, in a hands-on creative environment.", 240, "6a358b17-ffbe-4ac9-8d20-92544e3b739d", "Bulgaria, Sofia, Vasil Levski Blvd 62", 1, 250m, "Fundamentals of Fine Art", new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4.7999999999999998, "Learn the principles of embedded systems design, microcontrollers, and real-time programming in this comprehensive beginner-friendly course.", 240, "3cf3fb4a-235e-4c93-b66f-c1557006e067", "Remote", 0, 60m, "Introduction to Embedded Systems", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4.7000000000000002, "Master the principles of interior design, space planning, and color theory with hands-on projects.", 180, "6a358b17-ffbe-4ac9-8d20-92544e3b739d", "Bulgaria, Sofia, ul. \"Kapitan Andreev\" 29", 1, 280m, "Interior Design Masterclass", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 4.7999999999999998, "Learn the essentials of music production, including recording, mixing, and mastering, with hands-on studio sessions.", 120, "6a358b17-ffbe-4ac9-8d20-92544e3b739d", "Bulgaria, Plovdiv, ul. \"Ivan Vazov\" 23", 1, 200m, "Music Production Essentials", new DateTime(2025, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 4.9000000000000004, "Deepen your understanding of calculus concepts, including multivariable calculus, differential equations, and real-world applications.", 45, "fa360a62-9355-474a-824d-aaa85d9fbd65", "Bulgaria, Plovdiv, ul. \"Perushtitsa\" 15", 1, 110m, "Advanced Calculus Workshop", new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 4.7999999999999998, "Learn essential front-end technologies like HTML, CSS, JavaScript, and React to build stunning and responsive web applications.", 100, "428bcf46-40f2-47b2-ac4a-a49f570178ad", "Remote", 0, 150m, "Front-End Web Development Bootcamp", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 4.7000000000000002, "Explore the core principles of computer engineering, including hardware design, embedded systems, and software integration.", 160, "3cf3fb4a-235e-4c93-b66f-c1557006e067", "Remote", 0, 300m, "Foundations of Computer Engineering", new DateTime(2025, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 4.7999999999999998, "Get hands-on experience with cybersecurity protocols, encryption techniques, ethical hacking, and network security to protect digital assets.", 260, "428bcf46-40f2-47b2-ac4a-a49f570178ad", "Bulgaria, Plovdiv, ul. \"Zahari Zograf\" 10", 1, 350m, "Cybersecurity Fundamentals", new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AverageStarRating", "CompanyId", "Description", "JobType", "Location", "Position", "Requirement", "Salary", "Title" },
                values: new object[,]
                {
                    { 1, 4.5, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Develop and maintain software solutions.", 0, "Remote", "Junior Developer", "1+ year experience in C# and .NET", 12000m, "Software Developer" },
                    { 2, 3.5, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Create visual designs for marketing materials.", 0, "Remote", "Senior Designer", "Proficiency in Adobe Suite", 14500m, "Graphic Designer" },
                    { 3, 3.2000000000000002, "e0d6328d-f003-4bb1-8daa-21dcf49db469", "Provide hair styling, cutting, and treatment services to clients.", 1, "Bulgaria, Karlovo, ul. \"Dabensko shose\" 2", "Professional Hairdresser", "Certified cosmetologist with 2+ years of experience.", 4000m, "Hairdresser" },
                    { 4, 4.2999999999999998, "16226cef-b670-447e-99a9-b627cb16ae0b", "Perform vehicle inspections, repairs, and routine maintenance tasks.", 1, "Bulgaria, Plovdiv, ul. \"Dimo Hadzhidimov\" 4В", "Automotive Technician", "Basic mechanical skills and willingness to learn. No prior certification required.", 8000m, "Auto Mechanic" },
                    { 5, 4.0, "17585a62-c173-4c68-9e4a-2ba93a419b21", "Diagnose and treat skin conditions, provide expert advice on skincare, and perform dermatological procedures.", 1, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "Certified Dermatologist", "Medical degree with specialization in dermatology. Valid state medical license required.", 12000m, "Dermatologist" },
                    { 6, 2.6000000000000001, "596c6add-eaae-4890-8d4d-38aa5a0671bd", "Teach mathematics to students, prepare lesson plans, and assess student progress.", 1, "Bulgaria, Pleven, ul. \"Ivan Vazov\"", "High School Math Teacher", "Bachelor's degree in Mathematics or Education. Teaching certification preferred.", 5000m, "Math Teacher" },
                    { 7, 4.0999999999999996, "596c6add-eaae-4890-8d4d-38aa5a0671bd", "Maintain cleanliness and orderliness of the school toilets by performing routine cleaning tasks such as sweeping, mopping, and sanitizing surfaces.", 1, "Bulgaria, Pleven, ul. \"Ivan Vazov\"", "Toilet Cleaner", "No prior experience required, but attention to detail and reliability are essential.", 1500m, "School Cleaner" },
                    { 8, 4.0999999999999996, "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", "Prepare and serve alcoholic and non-alcoholic beverages, provide excellent customer service, and maintain a clean and organized bar area to ensure a great experience for guests.", 1, "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А", "Toilet Cleaner", "No prior experience required, but attention to detail and reliability are essential.", 1500m, "Bartender" },
                    { 9, 3.3999999999999999, "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", "Provide excellent customer service by taking orders, serving food and beverages, and ensuring customer satisfaction.", 1, "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А", "Restaurant Waiter", "Good communication skills and a friendly attitude. No prior experience required.", 2000m, "Waiter" },
                    { 10, 4.9000000000000004, "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", "Write engaging articles, blogs, and web content for clients across various industries.", 0, "Remote", "Freelance Writer", "Excellent writing skills and creativity. Portfolio preferred.", 5000m, "Content Writer" },
                    { 11, 3.7000000000000002, "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", "Edit and enhance video content, add transitions, effects, and soundtracks to create high-quality productions.", 0, "Remote", "Freelance Video Editor", "Proficiency in video editing software such as Adobe Premiere Pro, Final Cut Pro, or DaVinci Resolve. Portfolio required.", 6000m, "Video Editor" },
                    { 12, 4.0999999999999996, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Assist in developing, testing, and debugging software applications under the guidance of senior developers.", 2, "Bulgaria, Varna, bul. \"8-mi Primorski polk\" 54", "Software Developer Intern", "Enrolled in a Computer Science or related degree program. Basic knowledge of programming languages such as Python or Java.", 500m, "Software Development Intern" },
                    { 13, 3.7999999999999998, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Assist the design team in creating visual assets, including social media graphics, marketing materials, and presentations.", 2, "Bulgaria, Sofia, ul. \"Munchen\" 14", "Graphic Design Intern", "Enrolled in a Graphic Design or related program. Proficiency in design software such as Adobe Illustrator and Photoshop is preferred.", 700m, "Graphic Design Intern" },
                    { 14, 3.8999999999999999, "17585a62-c173-4c68-9e4a-2ba93a419b21", "Assist pharmacists with dispensing medication, preparing prescriptions, managing inventory, and providing customer service under supervision.", 2, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "Pharmacy Intern", "Currently enrolled in a Pharmacy or Pharmaceutical Sciences program. Strong attention to detail and communication skills.", 900m, "Pharmacy Intern" },
                    { 15, 4.0999999999999996, "17585a62-c173-4c68-9e4a-2ba93a419b21", "Provide medical care related to women's health, including diagnosis, treatment, and prevention of reproductive health issues, as well as conducting gynecological exams and procedures.", 1, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "Certified Gynecologist", "Medical degree with specialization in gynecology. Valid state medical license required.", 13000m, "Gynecologist" }
                });

            migrationBuilder.InsertData(
                table: "UsersSpheres",
                columns: new[] { "SphereId", "UserId" },
                values: new object[,]
                {
                    { 61, "7d089603-dc80-415a-913b-f24b1a90b5f1" },
                    { 64, "7d089603-dc80-415a-913b-f24b1a90b5f1" },
                    { 66, "7d089603-dc80-415a-913b-f24b1a90b5f1" },
                    { 13, "8d0c3b82-be4b-4fdf-834a-8e436176d9bd" },
                    { 15, "8d0c3b82-be4b-4fdf-834a-8e436176d9bd" },
                    { 62, "8d0c3b82-be4b-4fdf-834a-8e436176d9bd" },
                    { 5, "9e547484-9ea8-45e6-a488-d657f6f1c598" },
                    { 7, "9e547484-9ea8-45e6-a488-d657f6f1c598" },
                    { 11, "9e547484-9ea8-45e6-a488-d657f6f1c598" },
                    { 58, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355" },
                    { 59, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355" },
                    { 60, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355" },
                    { 15, "ca145762-b5db-4836-b963-85eff67fb124" },
                    { 52, "ca145762-b5db-4836-b963-85eff67fb124" },
                    { 61, "ca145762-b5db-4836-b963-85eff67fb124" },
                    { 35, "d444522c-71c1-4cc9-b815-4ea25a49f17b" },
                    { 38, "d444522c-71c1-4cc9-b815-4ea25a49f17b" },
                    { 40, "d444522c-71c1-4cc9-b815-4ea25a49f17b" },
                    { 2, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2" },
                    { 60, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2" },
                    { 61, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2" },
                    { 12, "e8d223af-7285-41c5-8c38-9e6989d4410d" },
                    { 13, "e8d223af-7285-41c5-8c38-9e6989d4410d" },
                    { 15, "e8d223af-7285-41c5-8c38-9e6989d4410d" }
                });

            migrationBuilder.InsertData(
                table: "CoursesSpheres",
                columns: new[] { "CourseId", "SphereId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 8 },
                    { 1, 42 },
                    { 2, 2 },
                    { 2, 6 },
                    { 2, 12 },
                    { 3, 2 },
                    { 3, 6 },
                    { 3, 11 },
                    { 3, 58 },
                    { 4, 2 },
                    { 4, 6 },
                    { 4, 11 },
                    { 4, 13 },
                    { 4, 46 },
                    { 5, 4 },
                    { 5, 60 },
                    { 5, 61 },
                    { 6, 5 },
                    { 6, 35 },
                    { 6, 62 },
                    { 7, 18 },
                    { 7, 63 },
                    { 7, 64 },
                    { 8, 4 },
                    { 8, 60 },
                    { 8, 61 },
                    { 9, 5 },
                    { 9, 7 },
                    { 9, 48 },
                    { 10, 2 },
                    { 10, 6 },
                    { 10, 11 },
                    { 11, 5 },
                    { 11, 9 },
                    { 12, 5 },
                    { 12, 40 },
                    { 12, 65 },
                    { 12, 66 },
                    { 12, 67 },
                    { 13, 4 },
                    { 13, 58 },
                    { 14, 6 },
                    { 14, 7 },
                    { 14, 12 },
                    { 14, 14 },
                    { 14, 46 },
                    { 15, 2 },
                    { 15, 6 },
                    { 15, 11 },
                    { 16, 2 },
                    { 16, 6 },
                    { 16, 47 }
                });

            migrationBuilder.InsertData(
                table: "JobsSpheres",
                columns: new[] { "JobId", "SphereId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 6 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 46 },
                    { 2, 5 },
                    { 2, 7 },
                    { 2, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 59 },
                    { 4, 17 },
                    { 4, 19 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 16 },
                    { 5, 18 },
                    { 5, 24 },
                    { 5, 25 },
                    { 5, 50 },
                    { 6, 4 },
                    { 6, 58 },
                    { 7, 17 },
                    { 7, 18 },
                    { 7, 31 },
                    { 8, 17 },
                    { 8, 35 },
                    { 8, 38 },
                    { 9, 17 },
                    { 9, 59 },
                    { 10, 5 },
                    { 10, 36 },
                    { 10, 40 },
                    { 10, 45 },
                    { 11, 2 },
                    { 11, 5 },
                    { 11, 7 },
                    { 11, 36 },
                    { 11, 40 },
                    { 11, 44 },
                    { 11, 45 },
                    { 11, 48 },
                    { 12, 2 },
                    { 12, 6 },
                    { 12, 12 },
                    { 12, 13 },
                    { 13, 5 },
                    { 13, 6 },
                    { 13, 7 },
                    { 13, 12 },
                    { 14, 1 },
                    { 14, 18 },
                    { 14, 24 },
                    { 14, 26 },
                    { 14, 49 },
                    { 15, 1 },
                    { 15, 18 },
                    { 15, 24 },
                    { 15, 50 },
                    { 15, 51 },
                    { 15, 52 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CourseId", "JobId", "PublisherId", "ReviewDate", "StarRating" },
                values: new object[,]
                {
                    { 1, "Working as a gynecologist here has been incredibly rewarding. The medical team is highly supportive, and I feel that my skills are valued. The clinic provides a great work-life balance, and there are plenty of opportunities for professional development.", null, 15, "e8d223af-7285-41c5-8c38-9e6989d4410d", new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 2, "The work environment is stressful, with a high patient load and not enough time to give each patient the attention they deserve. There is little room for advancement, and management is not supportive of new ideas or improvements.", null, 15, "ca145762-b5db-4836-b963-85eff67fb124", new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Working as a hairdresser here has been a fantastic experience. The team is supportive, and I’ve learned so much from the senior stylists. The work environment is welcoming, and there’s plenty of opportunity for professional growth.", null, 3, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 4, "The job can be physically demanding, and the work environment is often chaotic. There’s a lack of clear communication from management, and the hours can be long with not enough time to properly address every vehicle. The pay doesn’t reflect the workload.", null, 4, "7d089603-dc80-415a-913b-f24b1a90b5f1", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "Working as a software developer here has been an incredibly rewarding experience. The company fosters a collaborative work environment, and I’ve had the opportunity to work on cutting-edge technologies. There’s a great work-life balance, and management supports continuous learning.", null, 1, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, "The job is physically demanding, and there is often a lack of support from management. The hours can be inconsistent, and the workload can sometimes feel overwhelming with little recognition. The communication about tasks and expectations could be improved.", null, 7, "9e547484-9ea8-45e6-a488-d657f6f1c598", new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "The English learning course is extremely well-structured. The lessons are engaging, and the instructors are knowledgeable and supportive. It has greatly improved my language skills, and I feel more confident speaking and writing in English.", 8, null, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "The course lacks personalized attention, and the pace can be too fast for beginners. The materials feel outdated, and there aren't enough interactive elements to keep learners engaged. It didn’t meet my expectations.", null, 8, "9e547484-9ea8-45e6-a488-d657f6f1c598", new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, "The web development exceeded my expectations. The curriculum is comprehensive, and the instructors are very knowledgeable. I gained practical coding skills and was able to work on real-world projects. Highly recommended!", null, 2, "e8d223af-7285-41c5-8c38-9e6989d4410d", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 10, "The course was too basic for my expectations. It focused a lot on introductory concepts, with very little in-depth coverage of advanced topics. I also found the pacing to be too slow, and some of the exercises were not as challenging as I had hoped.", null, 4, "9e547484-9ea8-45e6-a488-d657f6f1c598", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "This Fine Art course was amazing! The instructors were incredibly talented and offered personalized feedback. The course covered a variety of techniques and mediums, which really helped me improve my skills. The hands-on approach and creative atmosphere made learning fun and engaging.", null, 9, "ca145762-b5db-4836-b963-85eff67fb124", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "The Spanish class was an incredible experience! The teacher was engaging and patient, making learning enjoyable. The lessons were interactive, and the class size was perfect for personalized attention. I feel much more confident in speaking and understanding Spanish after completing the course.", null, 5, "ca145762-b5db-4836-b963-85eff67fb124", new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "UsersCourses",
                columns: new[] { "CourseId", "UserId" },
                values: new object[,]
                {
                    { 16, "9e547484-9ea8-45e6-a488-d657f6f1c598" },
                    { 5, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2" }
                });

            migrationBuilder.InsertData(
                table: "UsersJobs",
                columns: new[] { "JobId", "UserId" },
                values: new object[,]
                {
                    { 2, "d444522c-71c1-4cc9-b815-4ea25a49f17b" },
                    { 1, "e8d223af-7285-41c5-8c38-9e6989d4410d" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstitutionId",
                table: "Courses",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSpheres_SphereId",
                table: "CoursesSpheres",
                column: "SphereId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompanyId",
                table: "Jobs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsSpheres_SphereId",
                table: "JobsSpheres",
                column: "SphereId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CourseId",
                table: "Reviews",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_JobId",
                table: "Reviews",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PublisherId",
                table: "Reviews",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCourses_CourseId",
                table: "UsersCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersJobs_JobId",
                table: "UsersJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSpheres_SphereId",
                table: "UsersSpheres",
                column: "SphereId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CoursesSpheres");

            migrationBuilder.DropTable(
                name: "JobsSpheres");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "UsersCourses");

            migrationBuilder.DropTable(
                name: "UsersJobs");

            migrationBuilder.DropTable(
                name: "UsersSpheres");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Spheres");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
