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
                    FirstName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true, comment: "User's first name"),
                    LastName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true, comment: "User's last name"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "User's date of birth"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "User's address"),
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
                name: "CompanyRoleRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Company request identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Role request sender username"),
                    SenderId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Role request sender id"),
                    Description = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, comment: "Reasoning for the role request"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Pending/Accepted/Declined request status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRoleRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionRoleRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Company request identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Role request sender username"),
                    SenderId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Role request sender id"),
                    Description = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, comment: "Reasoning for the role request"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "Pending/Accepted/Declined request status")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionRoleRequests", x => x.Id);
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
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false, comment: "Course's lesson duration in minutes"),
                    CourseDuration = table.Column<int>(type: "int", nullable: false, comment: "Course's duration in weeks"),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Course's location"),
                    Coordinates = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Longtitude and Latitude for the course's location"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Couse's start date"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Couse's end date"),
                    InstitutionId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Institution's foreign key"),
                    AverageStarRating = table.Column<double>(type: "float", nullable: true, comment: "Course's average star rating"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Course's monthly price"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    Title = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false, comment: "Job's title"),
                    Description = table.Column<string>(type: "nvarchar(800)", maxLength: 800, nullable: true, comment: "Job's details"),
                    JobType = table.Column<int>(type: "int", nullable: false, comment: "The type of the job"),
                    Location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, comment: "Job's location"),
                    Coordinates = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Longtitude and Latitude for the job's location"),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Company's foreign key"),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Job's position"),
                    Requirement = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Job's requiements"),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Job salary"),
                    AverageStarRating = table.Column<double>(type: "float", nullable: true, comment: "Job average star rating"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    SphereId = table.Column<int>(type: "int", nullable: false, comment: "Sphere's foreign key"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SphereId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSpheres", x => new { x.UserId, x.SphereId });
                    table.ForeignKey(
                        name: "FK_UsersSpheres_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersSpheres_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersSpheres_Spheres_SphereId1",
                        column: x => x.SphereId1,
                        principalTable: "Spheres",
                        principalColumn: "Id");
                },
                comment: "Users' spheres");

            migrationBuilder.CreateTable(
                name: "CoursesSpheres",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course's foreign key"),
                    SphereId = table.Column<int>(type: "int", nullable: false, comment: "Sphere's foreign key"),
                    CourseId1 = table.Column<int>(type: "int", nullable: true),
                    SphereId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesSpheres", x => new { x.CourseId, x.SphereId });
                    table.ForeignKey(
                        name: "FK_CoursesSpheres_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CoursesSpheres_Courses_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CoursesSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CoursesSpheres_Spheres_SphereId1",
                        column: x => x.SphereId1,
                        principalTable: "Spheres",
                        principalColumn: "Id");
                },
                comment: "Corses' spheres");

            migrationBuilder.CreateTable(
                name: "UsersCourses",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User's foreign key"),
                    CourseId = table.Column<int>(type: "int", nullable: false, comment: "Course's foreign key"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CourseId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersCourses", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_UsersCourses_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersCourses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersCourses_Courses_CourseId1",
                        column: x => x.CourseId1,
                        principalTable: "Courses",
                        principalColumn: "Id");
                },
                comment: "Users' courses");

            migrationBuilder.CreateTable(
                name: "JobsSpheres",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false, comment: "Job's foreign key"),
                    SphereId = table.Column<int>(type: "int", nullable: false, comment: "Sphere's foreign key"),
                    JobId1 = table.Column<int>(type: "int", nullable: true),
                    SphereId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsSpheres", x => new { x.JobId, x.SphereId });
                    table.ForeignKey(
                        name: "FK_JobsSpheres_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobsSpheres_Jobs_JobId1",
                        column: x => x.JobId1,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobsSpheres_Spheres_SphereId",
                        column: x => x.SphereId,
                        principalTable: "Spheres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JobsSpheres_Spheres_SphereId1",
                        column: x => x.SphereId1,
                        principalTable: "Spheres",
                        principalColumn: "Id");
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
                    JobId = table.Column<int>(type: "int", nullable: false, comment: "Job's foreign key"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "File name, uuid"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    JobId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersJobs", x => new { x.UserId, x.JobId });
                    table.ForeignKey(
                        name: "FK_UsersJobs_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersJobs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersJobs_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UsersJobs_Jobs_JobId1",
                        column: x => x.JobId1,
                        principalTable: "Jobs",
                        principalColumn: "Id");
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
                    { "16226cef-b670-447e-99a9-b627cb16ae0b", 0, "Bulgaria, Ruse, ул. \"Rila\" 5", "eadbed2f-fde9-4578-a92a-b2a9d3aa3e17", new DateTime(2016, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sttuning@gmail.com", true, "STTuning", "OOD", false, null, "STTUNING@GMAIL.COM", "STTUNING123", "AQAAAAIAAYagAAAAEAkoObNSg0sdnHi4+T9uWfUCXyJV7CmjYVQCoRqdWQztpokQYvys4MfoAHn8WOhsFA==", "0876794891", true, "409f8885-51f9-4742-a6b9-c310d4c5c0d3", true, "sttuning123" },
                    { "17585a62-c173-4c68-9e4a-2ba93a419b21", 0, "България, Русе, бул. \"Липник\" 8", "e4994542-4ba3-4db4-a787-adcf3d41f5c0", new DateTime(1986, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "healthcarecentre@gmail.com", true, "HealthCare Center", "OD", false, null, "HEALTHCARECENTRE@GMAIL.COM", "HEALTHCARECENTRE123", "AQAAAAIAAYagAAAAEAAVAGgdRgQGf2lFnhx34NEGE5URcetC/1Xs1AexCPRum1ut8TelUCVDKICxSmXYDg==", "0870063844", true, "ad46e0b1-2a8b-4941-9053-7903b1c3eaa5", true, "healthcarecentre123" },
                    { "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0", 0, "България, Казанлък, ул. \"Петко Стайнов\" 6", "531995b4-0776-44ab-8a43-c003ff4fc0e5", new DateTime(2004, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "stefandimitrov@gmail.com", true, "Стефан", "Димитров", false, null, "STEFANDIMITROV@GMAIL.COM", "STEFANDIMITROV123", "AQAAAAIAAYagAAAAEJQIgzId7YGd5DZ7HrlFdY1FpIYq+6JS5bao7RTl7weAg39gEUZL2ZeLZRybAvWKcg==", "0890854939", true, "4bde8698-92a7-45f7-bd95-c9149c67ecaa", true, "stefandimitrov123" },
                    { "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1", 0, "България, Варна, ул. \"Оборище\" 13А", "138e5f57-e040-4ccc-8770-93a717fac258", new DateTime(1991, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "tastecraftacademy@gmail.com", true, "TasteCraft Academy", "OOD", false, null, "TASTECRAFTACADEMY@GMAIL.COM", "TASTECRAFTACADEMY123", "AQAAAAIAAYagAAAAEESOFPa0mgI/fHgMLoTrBeXNUR2rajRR0Y2oorp5pm09L1eV/o81c2mkEusA/E6faA==", "0895002619", true, "707409f0-ecac-40f9-9948-0020dc52bddd", true, "tastecraftacademy123" },
                    { "3cf3fb4a-235e-4c93-b66f-c1557006e067", 0, "България, Пловдив, бул. \"Цар Борис 3ти Обединител\"", "3c612700-6ea7-4f3d-be04-0555b6fff08a", new DateTime(1980, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "telerikikus@gmail.com", true, "Telerikikus", "OD", false, null, "TELERIKIKUS@GMAIL.COM", "TELERIKIKUS123", "AQAAAAIAAYagAAAAEGvi8GltJaBEw51rOAjyCwYKGCLjiz+JV/h2y5CxkToQ97jHVA7/VyMZA/k88b9Mdg==", "0898769871", true, "089c2e3b-1457-400b-b72b-e4626286ab3b", true, "telerikikus123" },
                    { "428bcf46-40f2-47b2-ac4a-a49f570178ad", 0, "България, София, бул. \"Александър Малинов\" 78", "d1d9a93c-db04-495e-9a82-64fa838fccdb", new DateTime(2000, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "softschool@gmail.com", true, "SoftSchool", "AD", false, null, "SOFTSCHOOL@GMAIL.COM", "SOFTSCHOOL123", "AQAAAAIAAYagAAAAEMNZJH9q+v2MElkY+fQNsitXKdrc5N6ryxKg7CGGzi6+lW2p3NYTP0vBR9kol6jbCw==", "0878765781", true, "3916ec47-9332-449c-bbd6-3fcce6c18c21", true, "softschool123" },
                    { "596c6add-eaae-4890-8d4d-38aa5a0671bd", 0, "България, Плевен, ул. \"Иван Вазов\"", "414e9486-2878-4700-89c1-bcde9e39e374", new DateTime(1985, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "primaryinovativeschool.com", true, "Primary Inovative School", "ET", false, null, "PRIMARYINOVATIVESCHOOL@GMAIL.COM", "PRIMARYINOVATIVESCHOOL123", "AQAAAAIAAYagAAAAEBL0zPrrnwGN9q7pS5JosK8NtqQ2QPgzz++EiDEfF+xAZHpP6Fka/eSKh6t9o610Sw==", "0890811871", true, "556fee06-471d-4f06-9711-da8953791dd8", true, "primaryinovativeschool123" },
                    { "6a358b17-ffbe-4ac9-8d20-92544e3b739d", 0, "България, Русе, ул. \"Христо Ясенов\" 7", "614cbdd9-7eb1-493c-9b0d-84d7ce478bdf", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "artacademy@gmail.com", true, "ArtAcademy", "OOD", false, null, "ARTACADEMY@GMAIL.COM", "ARTACADEMY123", "AQAAAAIAAYagAAAAEOtIjSVxUD5GSThPeVFpLCQ6QHAkVaIGZzQQ4KbRMlrA2Rfhi6GABj83HF5Tnu9yXQ==", "0897902119", true, "274f9fb5-caa1-483c-a263-5bd30dfa3e69", true, "artacademy123" },
                    { "723444b3-9434-4465-9044-f7e04fdcca2f", 0, "България, София, ул. \"Петър Б. Величков\" 43", "de6b3677-9906-4791-87d2-a1c410152a89", new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "marketingacademy@gmail.com", true, "Marketing Academy", "OOD", false, null, "MARKETINGACADEMY@GMAIL.COM", "MARKETINGACADEMY123", "AQAAAAIAAYagAAAAEInMD1qRWQyLwvCGKA9r0SHEKuktG6v9udMGuunNLKgVB/KbNTOo81oai53BY7KPvw==", "0877742199", true, "44e77b04-e9e7-4606-8fd7-d97a8ea61bd0", true, "marketingacademy123" },
                    { "7d089603-dc80-415a-913b-f24b1a90b5f1", 0, "България, Плевен, ул. \"Хаджи Димитър\" 10", "6456bfa6-d250-4e37-87ef-8187045d7f27", new DateTime(1995, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "georgivasilev@gmail.com", true, "Георги", "Василев", false, null, "GEORGIVASILEV@GMAIL.COM", "GEORGIVASILEV123", "AQAAAAIAAYagAAAAELXj9Lj7La0perng5ewoR2N+YjDlQ1gl76mhYpbPVM7adMbIoGI8JYdzLequnXONfw==", "0804442391", true, "2cd87fe5-45ef-4994-bd1e-7eabba512184", true, "georgivasilev123" },
                    { "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", 0, "България, Врана, ул. \"Козлодуй\" 4", "a90cac23-ba20-4f79-9eb0-b0a6a439c105", new DateTime(2006, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "imaginationacademy@gmail.com", true, "Imagination Academy", "OOD", false, null, "IMAGINATIONACADEMY@GMAIL.COM", "IMAGINATIONACADEMY123", "AQAAAAIAAYagAAAAEHe4upXYwKvKBEf0lvj5fQo+2+8swcTrhK7E0b4TKy0gRQWY/Lzjk/ffKDqk9gVk3w==", "0878433392", true, "910a4510-373b-4473-b484-2456a5122843", true, "imaginationacandemy123" },
                    { "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", 0, "България, Плевен, ул. \"Стефан Караджа\" 6", "bdbd7dea-8a23-4986-97a3-ff69816cd628", new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "svetlingeorgiev@gmail.com", true, "Светлин", "Георгиев", false, null, "SVETLINGEORGIEV@GMAIL.COM", "SVETLINGEORGIEV123", "AQAAAAIAAYagAAAAEFXbttdwhzDfoIZdNOyVrXdT7DHxAUJS0otLA+JkDfu8Bl9JV1FkWNuqE9Pqg6YHCQ==", "0894555881", true, "7b8fbe16-3151-483d-9bcf-ccbf4a2bfba0", true, "svetlingeorgiev123" },
                    { "9e547484-9ea8-45e6-a488-d657f6f1c598", 0, "България, Казанлък, ул. \"Генерал Гурко\" 4", "d36fa800-7b8c-49cb-ae48-6c817bafb2b4", new DateTime(2002, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "monikapetrova@gmail.com", true, "Моника", "Петрова", false, null, "MONIKAPETROVA@GMAIL.COM", "MONIKAPETROVA123", "AQAAAAIAAYagAAAAELCCjzmu39epRkctkmysz9Yq37k/inrwWES7JLFbE+5hEUeVL6m9ZlB4hGgC394h+g==", "0898760394", true, "46690ce7-54ac-4f03-84d0-22388d4effa9", true, "monikapetrova123" },
                    { "b3693b0c-9c11-48ee-a3be-db37d5439ab0", 0, "България, Русе, ул. \"Рила\" 5", "2d91fc2e-165a-41d9-b181-173b4f35b079", new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "codecrafters@gmail.com", true, "CodeCrafters", "ET", false, null, "CODECRAFTERS@GMAIL.COM", "CODECRAFTERS123", "AQAAAAIAAYagAAAAEGmJQ7KOJ8T1OL8kT1Ed20Ki1qZxq+6JjeAVZeF+/A0GURbxPWtH20z/KZh0IJmV2g==", "0877769431", true, "c62d877f-b39c-4bc9-a6b7-9ecfe1a737a1", true, "codecrafters123" },
                    { "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", 0, "България, Пловдив, ул. \"Георги Раковски\" 7", "e5814efc-7373-4756-a43d-54c1d086273d", new DateTime(1989, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "simonamincheva@gmail.com", true, "Симона", "Минчева", false, null, "SIMONAMINCHEVA@GMAIL.COM", "SIMONAMINCHEVA123", "AQAAAAIAAYagAAAAENp1GcFk4cCKPHiNfKScmw3dirsegteo5m1dXwfDJw66gn3qokyzu6qzDAzmZpjstw==", "0897448199", true, "7805b60c-3c82-47fe-9003-32e9c480f591", true, "simonamincheva123" },
                    { "ca145762-b5db-4836-b963-85eff67fb124", 0, "България, Плевен, ул. \"Христо Ботев\" 4", "e92a18fb-f2b3-4f92-8f9d-bf61b68c2f64", new DateTime(1999, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "krasimirdraganov@gmail.com", true, "Krasimir", "Draganov", false, null, "KRASIMIRDRAGANOV@GMAIL.COM", "KRASIMIRDRAGANOV123", "AQAAAAIAAYagAAAAEIhPtNQwjGTvrBWEyiJdaAlXBkVy2WE+BMuGlBzB1dI8voprN2+CCZHLLdalTJChDw==", "0894555391", true, "3707dd7f-1712-4fa8-b58c-927557b0a350", true, "krasimirdraganov123" },
                    { "d444522c-71c1-4cc9-b815-4ea25a49f17b", 0, "България, Казанлък, ул. \"Георги Сава Раковски\" 7", "1a507103-d8a3-4503-9354-b6b3c4ce3b48", new DateTime(1998, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "atanasgudov@gmail.com", true, "Атанас", "Гудов", false, null, "ATANASGUDOV@GMAIL.COM", "ATANASGUDOV123", "AQAAAAIAAYagAAAAEGxWWXUTK4oeBpVC3DcY00V9Uo/qd7hl5lqlNyhCy5B/X7SWiIfGivFKMwQE0Q5wzA==", "0885248739", true, "ca34f682-2530-49c0-8e33-223b54a4b54c", true, "atanasgudov123" },
                    { "e0d6328d-f003-4bb1-8daa-21dcf49db469", 0, "България, Плевен, ул. \"Васил Петлешков\" 6", "c88abb71-5643-4114-bc0c-f49f93fc8a88", new DateTime(2002, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chick@gmail.com", true, "Chic Cuts & Styles", "ET", false, null, "CHIC@GMAIL.COM", "CHIC123", "AQAAAAIAAYagAAAAEMabKzvUXu2ZfJrT247+/MzptLeamfbtEbRCq+t2VbcEY7xSrtEUYRryO64j9pfe5Q==", "0898769871", true, "3edf29d6-3392-4592-b54e-ee7e39b88189", true, "chic123" },
                    { "e2041514-c5ce-4e68-8956-f92298aa3b74", 0, "България, Казанлък, ул. \"Хемус\" 5", "e30b19b7-8557-4336-9dbf-e56aab344e9b", new DateTime(2004, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "teodoranedkova@gmail.com", true, "Теодора", "Недкова", false, null, "TEODORANEDKOVA@GMAIL.COM", "TEODORANEDKOVA123", "AQAAAAIAAYagAAAAEAkmDkEj0fton9/LpBt2BMxpKmNcI8rTUD+pXmP0seIQV8ddV8gNAugXfYZWqlW23w==", "0879859335", true, "1f4e1f28-7202-499b-af70-e4be99af32f4", true, "teodoranedkova123" },
                    { "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", 0, "България, Казанлък, ул. \"Добри Чинтулов\" 5", "e2cac73f-cafa-4421-8bad-1d74b78ace3b", new DateTime(2005, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexstefanov@gmail.com", true, "Алекс", "Стефанов", false, null, "ALEXSTEFANOV@GMAIL.COM", "ALEXSTEFANOV123", "AQAAAAIAAYagAAAAEMPiEWMYGcVu3mH0wa7e0tYzMGBzPgJvQsVqqWmNvt8FNQ/Q9GEWODNaxmU67zGLIw==", "0883856039", true, "e77b4775-b411-44a7-af30-08fd34930f7f", true, "alexstefanov123" },
                    { "e8d223af-7285-41c5-8c38-9e6989d4410d", 0, "България, Казанлък, ул. \"Генерал Стоянов\" 3", "f223506f-60dc-481a-b845-e2a71ddd1707", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "iliqmilenov@gmail.com", true, "Илия", "Миленов", false, null, "ILIQMILENOV@GMAIL.COM", "ILIQMILENOV123", "AQAAAAIAAYagAAAAEKyoEplcedox0JM7dtk0TdbUWZrSCHSiOB+0sxaq2sekaqX3kV2T2A7/UQOBdRLZRA==", "0895068785", true, "d957f805-1435-47ff-99b4-098a4f4a91a8", true, "iliqmilenov123" },
                    { "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", 0, "България, Сливен, бул. \"Цар Освободител\" 15А", "23a83c11-b649-475f-b8ed-0f09650da05e", new DateTime(2003, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "theurbangrillandbar@gmail.com", true, "The Urban Grill & Bar", "ET", false, null, "THEURBANGRILLANDBAR@GMAIL.COM", "THEURBANGRILLANDBAR123", "AQAAAAIAAYagAAAAEHYoB+u4uJlF6pW3LgfTxnXYqT07gbJhtmFkXAEl5RtJPqiMAyQuOWuiwkOssaKatw==", "0878439866", true, "a5426a1f-9903-4929-82a3-6da3d042d16e", true, "theurbangrillandbar123" },
                    { "fa360a62-9355-474a-824d-aaa85d9fbd65", 0, "България, Стара Загора, ул. \"Стефан Стамболов\" 38", "a97072ac-4d7d-454f-b6e8-850356b88f9a", new DateTime(2001, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "wittmath@gmail.com", true, "WittMath", "OOD", false, null, "WITTMATH@GMAIL.COM", "WITTMATH123", "AQAAAAIAAYagAAAAEP7mo6pMPIMgo35faOYMZm2peYXYp0VCyY0OmyiMnUJlZsRpEsSelx0uRKi5HubmqQ==", "0880796431", true, "032593bb-1a16-45c7-828b-d7ba99f2d1f2", true, "wittmath123" },
                    { "fc7c5678-22b4-4650-af6e-4c5f90fa494d", 0, "България, София, ул. \"Цар Асен\" 112", "dc4631a1-074e-4f9f-a820-1b34e62a2162", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "globallingua@gmail.com", true, "GlobalLingua", "OOD", false, null, "GLOBALLINGUA@GMAIL.COM", "GLOBALLINGUA123", "AQAAAAIAAYagAAAAEEV9WraVk92dd/gaco6JfSk6DxMioGEppX+YQ7Wc7RMFDjmjmP/oMLTH7iLit2OrOQ==", "0897662398", true, "7acf9de3-1083-4e6d-94d6-e789d9653f3c", true, "globallingua123" }
                });

            migrationBuilder.InsertData(
                table: "Spheres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Здравеопазване" },
                    { 2, "Технологии" },
                    { 3, "Бизнес и финанси" },
                    { 4, "Образование" },
                    { 5, "Творчески изкуства" },
                    { 6, "Компютърни науки" },
                    { 7, "Графичен дизайн" },
                    { 8, "Маркетинг и управление" },
                    { 9, "Архитектура" },
                    { 10, "Управление на съоръжения" },
                    { 11, "Инженерство" },
                    { 12, "Уеб разработка" },
                    { 13, "Back-End програмиране" },
                    { 14, "Front-End програмиране" },
                    { 15, "Adobe дизайн" },
                    { 16, "Индустрия за красота и лична грижа" },
                    { 17, "Услуги" },
                    { 18, "Здраве и социални грижи" },
                    { 19, "Автомобилна индустрия" },
                    { 20, "Механично инженерство" },
                    { 21, "Транспорт и логистика" },
                    { 22, "Квалифицирани занаяти" },
                    { 23, "Устойчивост и зелени технологии" },
                    { 24, "Медицински специалности" },
                    { 25, "Естетична дерматология" },
                    { 26, "Фармация" },
                    { 27, "STEM образование" },
                    { 28, "Публичен сектор" },
                    { 29, "Разработка на учебни програми" },
                    { 30, "Неправителствено образование" },
                    { 31, "Почистване и поддръжка" },
                    { 32, "Обществени услуги" },
                    { 33, "Екологични услуги" },
                    { 34, "Образователни услуги" },
                    { 35, "Хранителни и напиткови услуги" },
                    { 36, "Обслужване на клиенти" },
                    { 37, "Управление на събития" },
                    { 38, "Нощен живот и развлекателна индустрия" },
                    { 39, "Туризъм и отдих" },
                    { 40, "Медии и журналистика" },
                    { 41, "Маркетинг и комуникации" },
                    { 42, "Цифров маркетинг" },
                    { 43, "Фрилансинг" },
                    { 44, "Продукция на филми" },
                    { 45, "Медии" },
                    { 46, "Разработка на софтуер" },
                    { 47, "Сигурност" },
                    { 48, "Визуални изкуства" },
                    { 49, "Търговия с лекарства" },
                    { 50, "Клинични грижи" },
                    { 51, "Репродуктивно здраве" },
                    { 52, "Женско здраве" },
                    { 53, "Козметична хирургия" },
                    { 54, "СПА и уелнес" },
                    { 55, "Лични грижи" },
                    { 56, "Управление на салони" },
                    { 57, "Козметика и фризьорство" },
                    { 58, "Математика" },
                    { 59, "Хотелиерство и ресторантьорство" },
                    { 60, "Културни изследвания" },
                    { 61, "Езици и лингвистика" },
                    { 62, "Готварство" },
                    { 63, "Физическо възпитание" },
                    { 64, "Фитнес и лични тренировки" },
                    { 65, "Аудио инженерство" },
                    { 66, "Музикална композиция" },
                    { 67, "Музикални технологии" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "AverageStarRating", "Coordinates", "CourseDuration", "Description", "DurationInMinutes", "EndDate", "InstitutionId", "IsDeleted", "Location", "Mode", "Name", "Price", "StartDate" },
                values: new object[,]
                {
                    { 1, 4.0, null, 6, "Научете основите на дигиталния маркетинг, включително SEO, PPC и стратегии за социални медии.", 120, new DateTime(2027, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "723444b3-9434-4465-9044-f7e04fdcca2f", false, "Отдалечено", 0, "Въведение в дигиталния маркетинг", 1900m, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4.5, null, 8, "Овладейте основите на HTML, CSS и JavaScript в този курс за начинаещи.", 150, new DateTime(2028, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "Отдалечено", 0, "Уеб разработка за начинаещи", 1350m, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4.7999999999999998, null, 4, "Запознайте се с науката за данни и научете алгоритмите на машинното обучение с Python и R.", 180, new DateTime(2029, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cf3fb4a-235e-4c93-b66f-c1557006e067", false, "Отдалечено", 0, "Наука за данни и машинно обучение", 450m, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4.7000000000000002, null, 7, "Получете основни познания за изкуствения интелект, неговите приложения и как променя индустриите.", 150, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "Отдалечено", 0, "Въведение в изкуствения интелект", 1500m, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4.5999999999999996, "42.505681,27.458591", 9, "Овладейте основите на испанския език, включително лексика, граматика и разговорни умения в ангажираща и интерактивна среда.", 90, new DateTime(2030, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc7c5678-22b4-4650-af6e-4c5f90fa494d", false, "България, Бургас, ул. \"Одрин\" 2", 1, "Испански за начинаещи", 2000m, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4.7999999999999998, "43.210532,27.907042", 10, "Научете основите на кулинарни техники, безопасност в кухнята и представяне на храна в този курс.", 120, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1", false, "България, Варна, ул. \"Оборище\" 13А", 1, "Въведение в кулинарните изкуства", 2200m, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4.5, "42.195356,24.329969", 7, "Отпуснете се, възстановете и научете практики на осъзнатост заедно с йога пози за начинаещи в този курс.", 90, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "България, Пазарджик, ул. \"Найден Геров\" 6", 1, "Йога и осъзнатост за начинаещи", 1000m, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4.7000000000000002, "42.61825,25.392292", 4, "Подобрете своите умения в английския език по говорене, слушане, четене и писане чрез практически уроци и упражнения.", 180, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc7c5678-22b4-4650-af6e-4c5f90fa494d", false, "България, Казанлък, ул. \"Иван Вазов\" 3", 1, "Майсторство в английския език", 900m, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4.7999999999999998, "42.687535,23.328508", 17, "Изследвайте основите на изящното изкуство, включително скициране, рисуване и скулптиране, в креативна работна среда.", 240, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "България, София, бул. Васил Левски 62", 1, "Основи на изящното изкуство", 2500m, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4.7999999999999998, null, 9, "Научете принципите на проектиране на вградени системи, микроконтролери и програмиране в реално време в този цялостен курс за начинаещи.", 240, new DateTime(2031, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cf3fb4a-235e-4c93-b66f-c1557006e067", false, "Отдалечено", 0, "Въведение в вградените системи", 1600m, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4.7000000000000002, "42.680441,23.322253", 13, "Овладейте принципите на интериорния дизайн, планиране на пространство и теория на цветовете с практически проекти.", 180, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "България, София, ул. \"Капитан Андреев\" 29", 1, "Магистърски курс по интериорен дизайн", 2200m, new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 4.7999999999999998, "42.139492,24.748373", 10, "Научете основите на музикалната продукция, включително запис, смесване и мастеринг, с практически сесии в студио.", 120, new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "България, Пловдив, ул. \"Иван Вазов\" 23", 1, "Основи на музикалната продукция", 2000m, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 4.9000000000000004, "42.140365,24.718849", 15, "Задълбочете своите познания по математическите концепции, включително многомерен калкулус, диференциални уравнения и реални приложения.", 45, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa360a62-9355-474a-824d-aaa85d9fbd65", false, "България, Пловдив, ул. \"Перущица\" 15", 1, "Работилница по напреднала математика", 1100m, new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 4.7999999999999998, null, 8, "Научете основни технологии за фронтенд като HTML, CSS, JavaScript и React за изграждане на впечатляващи и отзивчиви уеб приложения.", 100, new DateTime(2027, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "Отдалечено", 0, "Буткемп по фронтенд уеб разработка", 1500m, new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 4.7000000000000002, null, 12, "Изследвайте основните принципи на компютърното инженерство, включително проектиране на хардуер, вградени системи и софтуерна интеграция.", 160, new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cf3fb4a-235e-4c93-b66f-c1557006e067", false, "Отдалечено", 0, "Основи на компютърното инженерство", 1000m, new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 4.7999999999999998, "42.150184,24.760268", 11, "Получете практически опит с протоколи за киберсигурност, техники за криптиране, етично хакерство и мрежова сигурност за защита на дигитални активи.", 260, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "България, Пловдив, ул. \"Захари Зограф\" 10", 1, "Основи на киберсигурността", 1399m, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AverageStarRating", "CompanyId", "Coordinates", "Description", "IsDeleted", "JobType", "Location", "Position", "Requirement", "Salary", "Title" },
                values: new object[,]
                {
                    { 1, 4.5, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", null, "Разработване и поддръжка на софтуерни решения.", false, 0, "Отдалечено", "Младши разработчик", "1+ година опит с C# и .NET", 12000m, "Софтурен разработчик" },
                    { 2, 3.5, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", null, "Създаване на визуални дизайни за маркетингови материали.", false, 0, "Отдалечено", "Старши дизайнер", "Производителност с Adobe Suite", 14500m, "Графичен дизайнер" },
                    { 3, 3.2000000000000002, "e0d6328d-f003-4bb1-8daa-21dcf49db469", "42.642328,24.79907", "Предоставяне на услуги по стайлинг, подстригване и лечение на коса на клиенти.", false, 1, "България, Карлово, ул. \"Дъбенско шосе\" 2", "Професионален фризьор", "Сертифициран козметолог с 2+ години опит.", 4000m, "Фризьор" },
                    { 4, 4.2999999999999998, "16226cef-b670-447e-99a9-b627cb16ae0b", "42.119481,24.730979", "Извършване на инспекции, ремонти и редовна поддръжка на превозни средства.", false, 1, "България, Пловдив, ул. \"Димо Хаджидимов\" 4В", "Автомобилен техник", "Основни механични умения и желание за учене. Не се изисква предишна сертификация.", 8000m, "Автомеханик" },
                    { 5, 4.0, "17585a62-c173-4c68-9e4a-2ba93a419b21", "42.118114,24.729677", "Диагностициране и лечение на кожни заболявания, предоставяне на експертни съвети за грижа за кожата и извършване на дерматологични процедури.", false, 1, "България, Русе, бул. \"Липник\" 8", "Сертифициран дерматолог", "Медицинска степен със специализация по дерматология. Изисква се валидна медицинска лицензия.", 12000m, "Дерматолог" },
                    { 6, 2.6000000000000001, "596c6add-eaae-4890-8d4d-38aa5a0671bd", "43.412509,24.622857", "Преподаване на математика на ученици, подготовка на уроци и оценяване на напредъка на учениците.", false, 1, "България, Плевен, ул. \"Иван Вазов\"", "Учител по математика в гимназия", "Бакалавърска степен по математика или образование. Преподавателска сертификация се предпочита.", 5000m, "Учител по математика" },
                    { 7, 4.0999999999999996, "596c6add-eaae-4890-8d4d-38aa5a0671bd", "43.412509,24.622857", "Поддържане на чистотата и реда в училищните тоалетни чрез извършване на рутинни почистващи задачи като метене, миене и дезинфекция на повърхности.", false, 1, "България, Плевен, ул. \"Иван Вазов\"", "Почистващ персонал в тоалетни", "Не се изисква опит, но внимание към детайлите и надеждност са от съществено значение.", 1500m, "Учител по почистване на училище" },
                    { 8, 4.0999999999999996, "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", "42.680454,26.320009", "Приготвяне и сервиране на алкохолни и безалкохолни напитки, предоставяне на отлично обслужване на клиенти и поддържане на чистота и организация на бара.", false, 1, "България, Сливен, бул. \"Цар Освободител\" 15А", "Барман", "Не се изисква опит, но внимание към детайлите и надеждност са от съществено значение.", 1500m, "Барман" },
                    { 9, 3.3999999999999999, "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", "42.680454,26.320009", "Предоставяне на отлично обслужване на клиентите чрез приемане на поръчки, сервиране на храна и напитки и осигуряване на удовлетвореността на клиентите.", false, 1, "България, Сливен, бул. \"Цар Освободител\" 15А", "Сервитьор в ресторант", "Добри комуникационни умения и приятелско отношение. Не се изисква опит.", 2000m, "Сервитьор" },
                    { 10, 4.9000000000000004, "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", null, "Писане на ангажиращи статии, блогове и уеб съдържание за клиенти от различни индустрии.", false, 0, "Отдалечено", "Фриланс писател", "Отлични писателски умения и креативност. Портфолио се предпочита.", 5000m, "Копирайтър" },
                    { 11, 3.7000000000000002, "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", null, "Редактиране и подобряване на видео съдържание, добавяне на преходи, ефекти и звукови тракове за създаване на висококачествени продукции.", false, 0, "Отдалечено", "Фриланс видеоредактор", "Производителност с видео редакторски софтуер като Adobe Premiere Pro, Final Cut Pro или DaVinci Resolve. Портфолио се изисква.", 6000m, "Видеоредактор" },
                    { 12, 4.0999999999999996, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "43.207564,27.918225", "Помощ при разработване, тестване и отстраняване на грешки в софтуерни приложения под ръководството на старши разработчици.", false, 2, "България, Варна, бул. \"8-ми Приморски полк\" 54", "Стажант разработчик", "Записан в програма за компютърни науки или свързана специалност. Основни познания по програмни езици като Python или Java.", 500m, "Стажант по софтуерно разработване" },
                    { 13, 3.7999999999999998, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "42.659204,23.414001", "Помощ на дизайнерския екип при създаване на визуални активи, включително графики за социални медии, маркетингови материали и презентации.", false, 2, "България, София, ул. \"Мюнхен\" 14", "Стажант графичен дизайнер", "Записан в програма за графичен дизайн или свързана специалност. Производителност с дизайнерски софтуер като Adobe Illustrator и Photoshop се предпочита.", 700m, "Стажант графичен дизайнер" },
                    { 14, 3.8999999999999999, "17585a62-c173-4c68-9e4a-2ba93a419b21", "43.84582,25.966291", "Помощ на фармацевти при разпределяне на лекарства, приготвяне на рецепти, управление на инвентар и предоставяне на обслужване на клиенти под наблюдение.", false, 2, "България, Русе, бул. \"Липник\" 8", "Стажант фармацевт", "Записан в програма за фармацевтика или фармацевтични науки. Добро внимание към детайлите и комуникационни умения.", 900m, "Стажант в аптека" },
                    { 15, 4.0999999999999996, "17585a62-c173-4c68-9e4a-2ba93a419b21", "43.84582,25.966291", "Предоставяне на медицинска грижа, свързана с женското здраве, включително диагностика, лечение и профилактика на репродуктивни здравословни проблеми, както и извършване на гинекологични прегледи и процедури.", false, 1, "България, Русе, бул. \"Липник\" 8", "Сертифициран гинеколог", "Медицинска степен със специализация по гинекология. Изисква се валидна медицинска лицензия.", 13000m, "Гинеколог" }
                });

            migrationBuilder.InsertData(
                table: "UsersSpheres",
                columns: new[] { "SphereId", "UserId", "ApplicationUserId", "SphereId1" },
                values: new object[,]
                {
                    { 61, "7d089603-dc80-415a-913b-f24b1a90b5f1", null, null },
                    { 64, "7d089603-dc80-415a-913b-f24b1a90b5f1", null, null },
                    { 66, "7d089603-dc80-415a-913b-f24b1a90b5f1", null, null },
                    { 13, "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", null, null },
                    { 15, "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", null, null },
                    { 62, "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", null, null },
                    { 5, "9e547484-9ea8-45e6-a488-d657f6f1c598", null, null },
                    { 7, "9e547484-9ea8-45e6-a488-d657f6f1c598", null, null },
                    { 11, "9e547484-9ea8-45e6-a488-d657f6f1c598", null, null },
                    { 58, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", null, null },
                    { 59, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", null, null },
                    { 60, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", null, null },
                    { 15, "ca145762-b5db-4836-b963-85eff67fb124", null, null },
                    { 52, "ca145762-b5db-4836-b963-85eff67fb124", null, null },
                    { 61, "ca145762-b5db-4836-b963-85eff67fb124", null, null },
                    { 35, "d444522c-71c1-4cc9-b815-4ea25a49f17b", null, null },
                    { 38, "d444522c-71c1-4cc9-b815-4ea25a49f17b", null, null },
                    { 40, "d444522c-71c1-4cc9-b815-4ea25a49f17b", null, null },
                    { 2, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", null, null },
                    { 60, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", null, null },
                    { 61, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", null, null },
                    { 12, "e8d223af-7285-41c5-8c38-9e6989d4410d", null, null },
                    { 13, "e8d223af-7285-41c5-8c38-9e6989d4410d", null, null },
                    { 15, "e8d223af-7285-41c5-8c38-9e6989d4410d", null, null }
                });

            migrationBuilder.InsertData(
                table: "CoursesSpheres",
                columns: new[] { "CourseId", "SphereId", "CourseId1", "SphereId1" },
                values: new object[,]
                {
                    { 1, 3, null, null },
                    { 1, 8, null, null },
                    { 1, 42, null, null },
                    { 2, 2, null, null },
                    { 2, 6, null, null },
                    { 2, 12, null, null },
                    { 3, 2, null, null },
                    { 3, 6, null, null },
                    { 3, 11, null, null },
                    { 3, 58, null, null },
                    { 4, 2, null, null },
                    { 4, 6, null, null },
                    { 4, 11, null, null },
                    { 4, 13, null, null },
                    { 4, 46, null, null },
                    { 5, 4, null, null },
                    { 5, 60, null, null },
                    { 5, 61, null, null },
                    { 6, 5, null, null },
                    { 6, 35, null, null },
                    { 6, 62, null, null },
                    { 7, 18, null, null },
                    { 7, 63, null, null },
                    { 7, 64, null, null },
                    { 8, 4, null, null },
                    { 8, 60, null, null },
                    { 8, 61, null, null },
                    { 9, 5, null, null },
                    { 9, 7, null, null },
                    { 9, 48, null, null },
                    { 10, 2, null, null },
                    { 10, 6, null, null },
                    { 10, 11, null, null },
                    { 11, 5, null, null },
                    { 11, 9, null, null },
                    { 12, 5, null, null },
                    { 12, 40, null, null },
                    { 12, 65, null, null },
                    { 12, 66, null, null },
                    { 12, 67, null, null },
                    { 13, 4, null, null },
                    { 13, 58, null, null },
                    { 14, 6, null, null },
                    { 14, 7, null, null },
                    { 14, 12, null, null },
                    { 14, 14, null, null },
                    { 14, 46, null, null },
                    { 15, 2, null, null },
                    { 15, 6, null, null },
                    { 15, 11, null, null },
                    { 16, 2, null, null },
                    { 16, 6, null, null },
                    { 16, 47, null, null }
                });

            migrationBuilder.InsertData(
                table: "JobsSpheres",
                columns: new[] { "JobId", "SphereId", "JobId1", "SphereId1" },
                values: new object[,]
                {
                    { 1, 2, null, null },
                    { 1, 6, null, null },
                    { 1, 12, null, null },
                    { 1, 13, null, null },
                    { 1, 46, null, null },
                    { 2, 5, null, null },
                    { 2, 7, null, null },
                    { 2, 15, null, null },
                    { 3, 16, null, null },
                    { 3, 17, null, null },
                    { 3, 18, null, null },
                    { 3, 59, null, null },
                    { 4, 17, null, null },
                    { 4, 19, null, null },
                    { 5, 1, null, null },
                    { 5, 2, null, null },
                    { 5, 16, null, null },
                    { 5, 18, null, null },
                    { 5, 24, null, null },
                    { 5, 25, null, null },
                    { 5, 50, null, null },
                    { 6, 4, null, null },
                    { 6, 58, null, null },
                    { 7, 17, null, null },
                    { 7, 18, null, null },
                    { 7, 31, null, null },
                    { 8, 17, null, null },
                    { 8, 35, null, null },
                    { 8, 38, null, null },
                    { 9, 17, null, null },
                    { 9, 59, null, null },
                    { 10, 5, null, null },
                    { 10, 36, null, null },
                    { 10, 40, null, null },
                    { 10, 45, null, null },
                    { 11, 2, null, null },
                    { 11, 5, null, null },
                    { 11, 7, null, null },
                    { 11, 36, null, null },
                    { 11, 40, null, null },
                    { 11, 44, null, null },
                    { 11, 45, null, null },
                    { 11, 48, null, null },
                    { 12, 2, null, null },
                    { 12, 6, null, null },
                    { 12, 12, null, null },
                    { 12, 13, null, null },
                    { 13, 5, null, null },
                    { 13, 6, null, null },
                    { 13, 7, null, null },
                    { 13, 12, null, null },
                    { 14, 1, null, null },
                    { 14, 18, null, null },
                    { 14, 24, null, null },
                    { 14, 26, null, null },
                    { 14, 49, null, null },
                    { 15, 1, null, null },
                    { 15, 18, null, null },
                    { 15, 24, null, null },
                    { 15, 50, null, null },
                    { 15, 51, null, null },
                    { 15, 52, null, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CourseId", "JobId", "PublisherId", "ReviewDate", "StarRating" },
                values: new object[,]
                {
                    { 1, "Работата като гинеколог тук беше невероятно удовлетворяваща. Медицинският екип е много подкрепящ, и чувствам, че уменията ми се ценят. Клиниката осигурява отличен баланс между работа и личен живот и има много възможности за професионално развитие.", null, 15, "e8d223af-7285-41c5-8c38-9e6989d4410d", new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 2, "Работната среда е стресираща, с много пациенти и недостатъчно време, за да се обърне внимание на всеки. Няма много възможности за напредък, а управлението не подкрепя новите идеи или подобрения.", null, 15, "ca145762-b5db-4836-b963-85eff67fb124", new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "Работата като фризьор тук беше фантастично изживяване. Екипът е подкрепящ, а аз научих толкова много от старшите стилисти. Работната среда е приветлива, а възможностите за професионално развитие са много.", null, 3, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 4, "Работата може да бъде физически изтощителна и работната среда често е хаотична. Липсва ясна комуникация от управлението, а часовете могат да бъдат дълги с недостатъчно време за адекватно обслужване на всеки автомобил. Заплатата не отразява натоварването.", null, 4, "7d089603-dc80-415a-913b-f24b1a90b5f1", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 5, "Работата като софтуерен разработчик тук беше изключително удовлетворяваща. Компанията насърчава сътрудничеството, а аз имах възможност да работя с иновативни технологии. Осигурен е добър баланс между работа и личен живот, а управлението подкрепя непрекъснатото учене.", null, 1, "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, "Работата е физически изтощителна, а често липсва подкрепа от управлението. Часовете могат да бъдат неравномерни, а натоварването понякога е непосилно с малко признание. Комуникацията за задачите и очакванията трябва да се подобри.", null, 7, "9e547484-9ea8-45e6-a488-d657f6f1c598", new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "Курсът по английски език е изключително добре структуриран. Уроците са ангажиращи, а преподавателите са компетентни и подкрепящи. Курсът значително подобри езиковите ми умения, и сега се чувствам по-сигурен в говоренето и писането на английски.", 8, null, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 8, "Курсът липсва персонализирано внимание, а темпото може да е твърде бързо за начинаещи. Материалите изглеждат остарели, а няма достатъчно интерактивни елементи, за да се запази интересът на ученик. Не отговори на моите очаквания.", null, 8, "9e547484-9ea8-45e6-a488-d657f6f1c598", new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, "Курсът по уеб разработка надмина очакванията ми. Учебният план е изчерпателен, а преподавателите са много компетентни. Научих практични умения по програмиране и имах възможност да работя по реални проекти. Горещо препоръчвам!", null, 2, "e8d223af-7285-41c5-8c38-9e6989d4410d", new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 10, "Курсът беше твърде базов за моите очаквания. Той се съсредоточаваше много върху въведение в концепциите, с много малко задълбочено покритие на напреднали теми. Също така темпото беше твърде бавно, а някои упражнения не бяха толкова предизвикателни, колкото очаквах.", null, 4, "9e547484-9ea8-45e6-a488-d657f6f1c598", new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Този курс по изобразително изкуство беше невероятен! Преподавателите бяха изключително талантливи и предложиха персонализирана обратна връзка. Курсът обхвана различни техники и медии, които наистина ми помогнаха да подобря уменията си. Практическото обучение и творческата атмосфера направиха ученето забавно и ангажиращо.", null, 9, "ca145762-b5db-4836-b963-85eff67fb124", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 12, "Курсът по испански език беше невероятно преживяване! Преподавателят беше ангажиращ и търпелив, което направи ученето приятно. Уроците бяха интерактивни, а размерът на класа беше идеален за персонализирано внимание. Сега се чувствам много по-сигурен в говоренето и разбирането на испански след завършването на курса.", null, 5, "ca145762-b5db-4836-b963-85eff67fb124", new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 }
                });

            migrationBuilder.InsertData(
                table: "UsersCourses",
                columns: new[] { "CourseId", "UserId", "ApplicationUserId", "CourseId1" },
                values: new object[,]
                {
                    { 16, "9e547484-9ea8-45e6-a488-d657f6f1c598", null, null },
                    { 5, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", null, null }
                });

            migrationBuilder.InsertData(
                table: "UsersJobs",
                columns: new[] { "JobId", "UserId", "ApplicationUserId", "FileName", "JobId1" },
                values: new object[,]
                {
                    { 2, "d444522c-71c1-4cc9-b815-4ea25a49f17b", null, null, null },
                    { 1, "e8d223af-7285-41c5-8c38-9e6989d4410d", null, null, null }
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
                name: "IX_CoursesSpheres_CourseId1",
                table: "CoursesSpheres",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSpheres_SphereId",
                table: "CoursesSpheres",
                column: "SphereId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesSpheres_SphereId1",
                table: "CoursesSpheres",
                column: "SphereId1");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CompanyId",
                table: "Jobs",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsSpheres_JobId1",
                table: "JobsSpheres",
                column: "JobId1");

            migrationBuilder.CreateIndex(
                name: "IX_JobsSpheres_SphereId",
                table: "JobsSpheres",
                column: "SphereId");

            migrationBuilder.CreateIndex(
                name: "IX_JobsSpheres_SphereId1",
                table: "JobsSpheres",
                column: "SphereId1");

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
                name: "IX_UsersCourses_ApplicationUserId",
                table: "UsersCourses",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCourses_CourseId",
                table: "UsersCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersCourses_CourseId1",
                table: "UsersCourses",
                column: "CourseId1");

            migrationBuilder.CreateIndex(
                name: "IX_UsersJobs_ApplicationUserId",
                table: "UsersJobs",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersJobs_JobId",
                table: "UsersJobs",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersJobs_JobId1",
                table: "UsersJobs",
                column: "JobId1");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSpheres_ApplicationUserId",
                table: "UsersSpheres",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSpheres_SphereId",
                table: "UsersSpheres",
                column: "SphereId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersSpheres_SphereId1",
                table: "UsersSpheres",
                column: "SphereId1");
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
                name: "CompanyRoleRequests");

            migrationBuilder.DropTable(
                name: "CoursesSpheres");

            migrationBuilder.DropTable(
                name: "InstitutionRoleRequests");

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
