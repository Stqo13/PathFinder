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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsersSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CoursesSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_JobsSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    { "a94e9744-895c-4cd0-a450-fb2ca5ea73dc", "5693d433-58f1-423e-b017-bd2f8aa733a2", "Admin", "ADMIN" },
                    { "b69f39cc-e6e4-4394-b488-0d24c1d546ff", "91fd4469-4d30-4754-a5be-29ff4eb5613a", "Company", "COMPANY" },
                    { "be759a02-939c-4bb6-9063-f25e020d8a56", "04bf9670-b121-4c14-8c82-fc244215188a", "Institution", "INSTITUTION" },
                    { "cbd2b782-e4e3-4f79-84aa-5685d13320cb", "3667e136-1ba3-44a6-8730-0c6445975091", "PFUser", "PFUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "", 0, "Bulgaria, Varna, ul. \"Oborishte\" 13A", "c04f5b25-f65f-4753-ae78-e1f1e01f903d", new DateTime(1991, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "tastecraftacademy@gmail.com", true, "TasteCraft Academy", "OOD", false, null, "TASTECRAFTACADEMY@GMAIL.COM", "TASTECRAFTACADEMY123", "AQAAAAIAAYagAAAAEBDcz0zT8WWBhQQ2gwlnFtVOi7ZhzQP1MWDiuKhCN9ZQ7nNK0Qum0irshBSTVL7OEQ==", "0895002619", false, "5ab317e3-4ea5-491b-a071-45c111188ed3", false, "tastecraftacademy123" },
                    { "16226cef-b670-447e-99a9-b627cb16ae0b", 0, "Bulgaria, Ruse, уul. \"Rila\" 5", "e205105a-a462-40fa-a62a-13fc862ec07b", new DateTime(2016, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sttuning@gmail.com", true, "STTuning", "OOD", false, null, "STTUNING@GMAIL.COM", "STTUNING123", "AQAAAAIAAYagAAAAEBDNePQq1+FtMohi76aITmRnRaxhteFjKP1i4WegjrIjkTMOfQM3giQM6dXkX++OYg==", "0876794891", false, "c9d7f91f-d80b-439e-89bf-b25d9411dc1b", false, "sttuning123" },
                    { "17585a62-c173-4c68-9e4a-2ba93a419b21", 0, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "cf9f7a76-7d60-4ca0-bcac-18f59fb94610", new DateTime(1986, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "healthcarecentre@gmail.com", true, "HealthCare Center", "OD", false, null, "HEALTHCARECENTRE@GMAIL.COM", "HEALTHCARECENTRE123", "AQAAAAIAAYagAAAAEFZ/F8Ko6Pipiih61QTGwURTuoTnHQ9G1iVyX+4hMpvI7fQ/d+r452QnWWa3bZw0Mg==", "0870063844", false, "571e8f52-d463-4463-87b4-03d35f252a48", false, "healthcarecentre123" },
                    { "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0", 0, "Bulgaria, Kazanluk, ul. \"Petko Stainov\" 6", "b7ee3860-9e3a-46e9-b4c5-dd19964f4e71", new DateTime(2004, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "stefandimitrov@gmail.com", true, "Stefan", "Dimitrov", false, null, "STEFANDIMITROV@GMAIL.COM", "STEFANDIMITROV123", "AQAAAAIAAYagAAAAEOT1zkS46ISFxC8KtbvHPZ4c9RenOt1QGfeY+TEMxPrl72nwK5en8KtHfhi5INzCcw==", "0890854939", false, "9c2a3c04-abf1-4ef7-951f-ca4d4ccf0568", false, "stefandimitrov123" },
                    { "3cf3fb4a-235e-4c93-b66f-c1557006e067", 0, "Bulgaria, Plovdiv, bul. \"Tsar Boris 3ti Obedinitel\"", "070a0583-9697-4871-8d8e-28ad37aa9212", new DateTime(1980, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "telerikikus@gmail.com", true, "Telerikikus", "OD", false, null, "TELERIKIKUS@GMAIL.COM", "TELERIKIKUS123", "AQAAAAIAAYagAAAAEJy3nIxqIkyp1OjJRiMqONrmCV7QcQ+yQisuhUGEnoU6VwJFb8Q97j8JztNuTRzKHg==", "0898769871", false, "5f93105e-f6d1-456d-af58-375535cdeff6", false, "telerikikus123" },
                    { "428bcf46-40f2-47b2-ac4a-a49f570178ad", 0, "Bulgaria, Sofia, bul. \"Alexandur Malinov\" 78", "9155708a-92fc-440b-b0b4-91e4f4cca10c", new DateTime(2000, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "softschool@gmail.com", true, "SoftSchool", "AD", false, null, "SOFTSCHOOL@GMAIL.COM", "SOFTSCHOOL123", "AQAAAAIAAYagAAAAEGAgUo/4nswvkAwxqftAMPJhHR2yRKGtodVP44J4/ntVeITNShwyw1auH2I7mJ//5w==", "0878765781", false, "8d860c05-fa23-46cc-8cab-892b613660d4", false, "softschool123" },
                    { "596c6add-eaae-4890-8d4d-38aa5a0671bd", 0, "Bulgaria, Pleven, ul. \"Ivan Vazov\"", "655dccf9-89e6-41bb-9ee7-b417c5c60cf7", new DateTime(1985, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "primaryinovativeschool.com", true, "Primary Inovative School", "ET", false, null, "PRIMARYINOVATIVESCHOOL@GMAIL.COM", "PRIMARYINOVATIVESCHOOL123", "AQAAAAIAAYagAAAAEDBDCIsFhH+SBE5t/HDtz5ufFhZw+FRM5qKKnBr3sxvHGWQc1Rzu03tNfKIJYzOPgA==", "0890811871", false, "e3d7c33b-758d-4b2c-8fc8-1af9692a49bc", false, "primaryinovativeschool123" },
                    { "6a358b17-ffbe-4ac9-8d20-92544e3b739d", 0, "Bulgaria, Ruse, ul. \"Hristo Yasenov\" 7", "e566a92b-ac7b-45aa-94ea-456f8205799d", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "artacademy@gmail.com", true, "ArtAcademy", "OOD", false, null, "ARTACADEMY@GMAIL.COM", "ARTACADEMY123", "AQAAAAIAAYagAAAAEFdIQhvMHUoMA9eQ0WhJc4msI417m+jnRR8RttwYv7YQ8FZflVg726rPMWp8mkUQJg==", "0897902119", false, "859335af-6853-4273-afe6-2e4d6a2709bd", false, "artacademy123" },
                    { "723444b3-9434-4465-9044-f7e04fdcca2f", 0, "Bulgaria, Sofia, ul. \"Petar B. Velichkov\" 43", "55edf5e7-53a7-4c42-8760-713495e8aee2", new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "marketingacademy@gmail.com", true, "Marketing Academy", "OOD", false, null, "MARKETINGACADEMY@GMAIL.COM", "MARKETINGACADEMY123", "AQAAAAIAAYagAAAAELcMH1v/LMBKwb73a3yZf0lgkbcdNNuP8RaoyldSisAVFe8pdnrtql3U8hGLGHetYA==", "0877742199", false, "e3b41c27-eb0a-48d1-be6d-ad795fc69952", false, "marketingacademy123" },
                    { "7d089603-dc80-415a-913b-f24b1a90b5f1", 0, "Bulgaria, Pleven, ul. \"Hadzi Dimitur\" 10", "7f3cf61a-3a74-4277-bf23-cdc2798c1948", new DateTime(1995, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "georgivasilev@gmail.com", true, "Georgi", "Vasilev", false, null, "GEORGIVASILEV@GMAIL.COM", "GEORGIVASILEV123", "AQAAAAIAAYagAAAAEGfzZAKC76C0Ifnucd4bGHynVOwWujHVeMQJnmFs1lX4l9Q3biPpBjNLisJP34TTLQ==", "0804442391", false, "161e595f-553d-410e-a8ea-f08d4c286033", false, "georgivasilev123" },
                    { "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", 0, "Bulgaria, Vrana, ul. \"Kozloduy\" 4", "3ed0a3ac-d1f1-4f44-9bcb-774f7e311767", new DateTime(2006, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "imaginationacademy@gmail.com", true, "Imagination Academy", "OOD", false, null, "IMAGINATIONACADEMY@GMAIL.COM", "IMAGINATIONACADEMY123", "AQAAAAIAAYagAAAAEP9lkl3lqagRQTCHsr43+wi+QAx+8EVwfGy+2bNOHEznuRStLhlXkLIO2iAEHg8Qag==", "0878433392", false, "3d0122b7-ed3b-477e-a6fc-a89470ef0f2e", false, "imaginationacandemy123" },
                    { "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", 0, "Bulgaria, Pleven, ul. \"Stefan Karadza\" 6", "32cab55f-cb6d-4e45-a3ee-177dcffeca32", new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "svetlingeorgiev@gmail.com", true, "Svetlin", "Georgiev", false, null, "SVETLINGEORGIEV@GMAIL.COM", "SVETLINGEORGIEV123", "AQAAAAIAAYagAAAAEG1ztqHLA6gpa5tdqdVDfbCuVzqspG5QrUdMpHHFGjmWTny6z9q2nE5tzM3NBs/8eA==", "0894555881", false, "fb43d0c4-a01b-4d1c-926e-33a6ce4734f6", false, "svetlingeorgiev123" },
                    { "9e547484-9ea8-45e6-a488-d657f6f1c598", 0, "Bulgaria, Kazanluk, ul. \"General Gurko\" 4", "d68f9ba5-af12-4168-87ae-f65f24162e12", new DateTime(2002, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "monikapetrova@gmail.com", true, "Monika", "Petrova", false, null, "MONIKAPETROVA@GMAIL.COM", "MONIKAPETROVA123", "AQAAAAIAAYagAAAAEH9V30PuthRhAIRkiN2GU2cTfIen16oHZC4ApBq2gqFHDo9PWqjkGYwQ5yJU7vCTYg==", "0898760394", false, "180f8e37-5343-410e-a3ed-25300944761e", false, "monikapetrova123" },
                    { "b3693b0c-9c11-48ee-a3be-db37d5439ab0", 0, "Bulgaria, Ruse, ul. \"Рила\" 5", "0ac69c7b-660e-4c13-9a5d-c4f679874dd0", new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "codecrafters@gmail.com", true, "CodeCrafters", "ET", false, null, "CODECRAFTERS@GMAIL.COM", "CODECRAFTERS123", "AQAAAAIAAYagAAAAEKi6NSwVKdzjb/EzS78k2EAVL3jEeHA5CjGKjTyKoJi/3+i1wZA9looI02HTgIPhgw==", "0877769431", false, "4527c61e-59d2-4b49-a4db-1a095b90cffd", false, "codecrafters123" },
                    { "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", 0, "Bulgaria, Plovdiv, ul. \"Georgi Rakovski\" 7", "319568cd-1d1c-40dd-b769-aaefa71d4e78", new DateTime(1989, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "simonamincheva@gmail.com", true, "Simona", "Mincheva", false, null, "SIMONAMINCHEVA@GMAIL.COM", "SIMONAMINCHEVA123", "AQAAAAIAAYagAAAAENFCKo7K2oHZJZIGu8Pb7Fcs2vMZbn69Mfeh8NK7MI2u6I9BXfePn3s5rUfB85x8lg==", "0897448199", false, "ec62b350-1550-4725-ade1-a652aed42924", false, "simonamincheva123" },
                    { "ca145762-b5db-4836-b963-85eff67fb124", 0, "Bulgaria, Pleven, ul. \"Hristo Botev\" 4", "9236a899-c892-4659-8900-bcf7610d6528", new DateTime(1999, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "krasimirdraganov@gmail.com", true, "Krasimir", "Draganov", false, null, "KRASIMIRDRAGANOV@GMAIL.COM", "KRASIMIRDRAGANOV123", "AQAAAAIAAYagAAAAEFccYkpGy8UQApQAQ14cUluNjSIqyFOqlqrN/60RUEfLHDWBTI7XZEK5vYzJWWSOfg==", "0894555391", false, "43584223-edb2-4fca-b5bf-a3a94e199a6c", false, "krasimirdraganov123" },
                    { "d444522c-71c1-4cc9-b815-4ea25a49f17b", 0, "Bulgaria, Kazanluk, ul. \"Georgi Sava Rakovski\" 7", "5945dd19-345d-479d-a5e9-55d95211be15", new DateTime(1998, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "atanasgudov@gmail.com", true, "Atanas", "Gudov", false, null, "ATANASGUDOV@GMAIL.COM", "ATANASGUDOV123", "AQAAAAIAAYagAAAAEF/tPJeikhUmTANVjvHKG8BMa3go83Gt58C5seBof5mjdURB7mkwiGApkSXhdpYKmQ==", "0885248739", false, "da723507-18ba-4a25-9c06-a7d8334f4c89", false, "atanasgudov123" },
                    { "e0d6328d-f003-4bb1-8daa-21dcf49db469", 0, "Bulgaria, Pleven, ul. \"Vasil Petleshkov\" 6", "4b7af896-e43c-41be-bf1b-09da6a75a3d3", new DateTime(2002, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chick@gmail.com", true, "Chic Cuts & Styles", "ET", false, null, "CHIC@GMAIL.COM", "CHIC123", "AQAAAAIAAYagAAAAEB/P6FHSvr32W2XzkRnTj1rccMhO37OX7aIh1V+eJWy1eO/+Zt1hjACoMHEoCAH6SA==", "0898769871", false, "dea9788e-fa67-4b2f-b9f7-cc64209102fc", false, "chic123" },
                    { "e2041514-c5ce-4e68-8956-f92298aa3b74", 0, "Bulgaria, Kazanluk, ul. \"Hemus\" 5", "f793adfc-72bf-47a8-ad0d-2631ab92fdaa", new DateTime(2004, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "teodoranedkova@gmail.com", true, "Teodora", "Nedkova", false, null, "TEODORANEDKOVA@GMAIL.COM", "TEODORANEDKOVA123", "AQAAAAIAAYagAAAAEIbc3BLUMOMuiL5tiQv3CMbHkDS9iKDYULW6RSxJxyazI524v2IzPlZdI3hdp2opuw==", "0879859335", false, "f75f4dd0-f5ad-4c51-a19c-fd7b9e3e2c0c", false, "teodoranedkova123" },
                    { "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", 0, "Bulgaria, Kazanluk, ul. \"Dobri Chintulov\" 5", "16518ab4-e830-4ebc-ab7e-8be1850f0d13", new DateTime(2005, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexstefanov@gmail.com", true, "Alex", "Stefanov", false, null, "ALEXSTEFANOV@GMAIL.COM", "ALEXSTEFANOV123", "AQAAAAIAAYagAAAAEDaqFX5Z2yHn87KhLhictbAq4x033D+iKLvWmYPK3KX5opQafURD0j9AMHYxR5RwZw==", "0883856039", false, "4d6c3c37-154c-4f7e-a69e-98908b9884c5", false, "alexstefanov123" },
                    { "e8d223af-7285-41c5-8c38-9e6989d4410d", 0, "Bulgaria, Kazanluk, ul. \"General Stoletov\" 3", "90e6e85d-2d03-41de-ba7d-0e69c4a775f5", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "iliqmilenov@gmail.com", true, "Iliq", "Milenov", false, null, "ILIQMILENOV@GMAIL.COM", "ILIQMILENOV123", "AQAAAAIAAYagAAAAEF2ORKJt8PTqfsJO+DkOKAvKskv2RPHqf9oKBMp0GNtMwsgCmcgtrhyxQU6rzhgIWA==", "0895068785", false, "9f290e27-fb12-44fa-baf9-15f7c3544735", false, "iliqmilenov123" },
                    { "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", 0, "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А", "6ecdac6b-08a8-42ee-bd76-96bb8291a19e", new DateTime(2003, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "theurbangrillandbar@gmail.com", true, "The Urban Grill & Bar", "ET", false, null, "THEURBANGRILLANDBAR@GMAIL.COM", "THEURBANGRILLANDBAR123", "AQAAAAIAAYagAAAAEPVy79EXGCD7Invy83Tg8MtTWc6w7kXX1xLw/rYl8etgRM/eKK+oBHgKQyuwown/xA==", "0878439866", false, "d5a7f588-5982-4a91-94c4-7da366324a54", false, "theurbangrillandbar123" },
                    { "fa360a62-9355-474a-824d-aaa85d9fbd65", 0, "Bulgaria, Stara Zagora, ul. \"Stefan Stambolov\" 38", "b8b9e76c-9954-41b7-8efe-89440093ef25", new DateTime(2001, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "wittmath@gmail.com", true, "WittMath", "OOD", false, null, "WITTMATH@GMAIL.COM", "WITTMATH123", "AQAAAAIAAYagAAAAEJvNRVqcHlDpXFvnYmrE0NanQGtN9vsgrsjMnBDC9cnnuHcUV4l0VQndWismL7PHRg==", "0880796431", false, "2078c2dc-ab0f-46da-8f32-813347a52d71", false, "wittmath123" },
                    { "fc7c5678-22b4-4650-af6e-4c5f90fa494d", 0, "Bulgaria, Sofia, ul. \"Tsar Asen\" 112", "fcfc163f-b63d-4482-87e1-d4719850d487", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "globallingua@gmail.com", true, "GlobalLingua", "OOD", false, null, "GLOBALLINGUA@GMAIL.COM", "GLOBALLINGUA123", "AQAAAAIAAYagAAAAEBbPFWf+FoSeFPTiTKjLOu587T2XkPjM06UDE8LZVRpI3bhhdakBA+j7eR07nOEtxg==", "0897662398", false, "fc0ac354-4543-4f96-8529-04adabc071cf", false, "globallingua123" }
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
                    { 11, "Engeneering" },
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
                    { 6, 4.7999999999999998, "Learn the basics of cooking techniques, kitchen safety, and food presentation in this hands-on culinary course.", 120, "", "Bulgaria, Varna, ul. \"Oborishte\" 13A", 1, 220m, "Introduction to Culinary Arts", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
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
