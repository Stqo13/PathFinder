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
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Couse's start date"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Couse's end date"),
                    InstitutionId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Institution's foreign key"),
                    AverageStarRating = table.Column<double>(type: "float", nullable: true, comment: "Course's average star rating"),
                    MonthlyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Course's monthly price"),
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
                    { "16226cef-b670-447e-99a9-b627cb16ae0b", 0, "Bulgaria, Ruse, ул. \"Rila\" 5", "44097fd5-0a50-4ef0-9e6a-4fb4cf860824", new DateTime(2016, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "sttuning@gmail.com", true, "STTuning", "OOD", false, null, "STTUNING@GMAIL.COM", "STTUNING123", "AQAAAAIAAYagAAAAEKMTIW9u9mUMGgbpX3pJ8k5mSWX7MMHfMXwWne9595Be/yGomg87yASbtp7pfFUr5Q==", "0876794891", true, "d97a7d61-dfcd-419d-a84d-5d22e50335bb", true, "sttuning123" },
                    { "17585a62-c173-4c68-9e4a-2ba93a419b21", 0, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "051a83d0-d786-4766-bed7-5c2dedeedf15", new DateTime(1986, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "healthcarecentre@gmail.com", true, "HealthCare Center", "OD", false, null, "HEALTHCARECENTRE@GMAIL.COM", "HEALTHCARECENTRE123", "AQAAAAIAAYagAAAAEF3Q7x8spB7+BibVlRROUcu3G6GOcuW1XlxGiQ0dvIUcW6hXSeZk4sSNpdCkANKbLw==", "0870063844", true, "04384c80-eb18-4046-93de-42e12b78644f", true, "healthcarecentre123" },
                    { "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0", 0, "Bulgaria, Kazanluk, ul. \"Petko Stainov\" 6", "747682f9-4c5a-4bff-a3d4-24af143b8c3d", new DateTime(2004, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "stefandimitrov@gmail.com", true, "Stefan", "Dimitrov", false, null, "STEFANDIMITROV@GMAIL.COM", "STEFANDIMITROV123", "AQAAAAIAAYagAAAAEHXU5SuJyIa1/WF74mqufD/G2swuLnCFGqr+Eixtc2VM/HvFaxKET5RotGy0ydF/dg==", "0890854939", true, "fd5dcc18-faab-4c10-9dc6-0aacccc771a6", true, "stefandimitrov123" },
                    { "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1", 0, "Bulgaria, Varna, ul. \"Oborishte\" 13A", "50c079c9-188e-4c0e-80c7-cf651cab279d", new DateTime(1991, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "tastecraftacademy@gmail.com", true, "TasteCraft Academy", "OOD", false, null, "TASTECRAFTACADEMY@GMAIL.COM", "TASTECRAFTACADEMY123", "AQAAAAIAAYagAAAAEPE2i9Ea790Kx+z0JxJQK5fRph5A8Zn3K0IY9cC8S0LXtq7n7Ia3kIMC49kDXFOlCw==", "0895002619", true, "52a43a62-f21f-4637-b446-92356550c3e6", true, "tastecraftacademy123" },
                    { "3cf3fb4a-235e-4c93-b66f-c1557006e067", 0, "Bulgaria, Plovdiv, bul. \"Tsar Boris 3ti Obedinitel\"", "5c89dedb-5f89-4e0f-90ff-91be800d9967", new DateTime(1980, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "telerikikus@gmail.com", true, "Telerikikus", "OD", false, null, "TELERIKIKUS@GMAIL.COM", "TELERIKIKUS123", "AQAAAAIAAYagAAAAEFSIjukZnRSneiMqelLKC8Nr20G/Is692eM/9HOirEJlvIutGjrEJC0eFs9Ut1kyBw==", "0898769871", true, "6a797843-71bc-480f-be9a-ec1a7bbad8cb", true, "telerikikus123" },
                    { "428bcf46-40f2-47b2-ac4a-a49f570178ad", 0, "Bulgaria, Sofia, bul. \"Alexandur Malinov\" 78", "1c6eaffe-009a-499c-bd5b-140214e40e62", new DateTime(2000, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "softschool@gmail.com", true, "SoftSchool", "AD", false, null, "SOFTSCHOOL@GMAIL.COM", "SOFTSCHOOL123", "AQAAAAIAAYagAAAAEBihif51D//kWVKFNo73MQZ7P2fjOg0Jtkive7fj17iJj+266/m1xssYUg8x5I9RSQ==", "0878765781", true, "5887cf60-b5e2-4b54-a8a8-8d93298e4a23", true, "softschool123" },
                    { "596c6add-eaae-4890-8d4d-38aa5a0671bd", 0, "Bulgaria, Pleven, ul. \"Ivan Vazov\"", "3c49b67c-3975-4c87-ace5-6acfb766b56b", new DateTime(1985, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "primaryinovativeschool.com", true, "Primary Inovative School", "ET", false, null, "PRIMARYINOVATIVESCHOOL@GMAIL.COM", "PRIMARYINOVATIVESCHOOL123", "AQAAAAIAAYagAAAAEIbAAul4MMoULcZ509gRvDkpkfqXFikHTiEFhVrzc0l+Jkj/GCy0Ee7X0DhJL5D+eg==", "0890811871", true, "d3672cf5-84d3-402d-986a-6e666ddeccc1", true, "primaryinovativeschool123" },
                    { "6a358b17-ffbe-4ac9-8d20-92544e3b739d", 0, "Bulgaria, Ruse, ul. \"Hristo Yasenov\" 7", "cd38f12e-ce98-45d8-b26f-8e32fac3ccde", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "artacademy@gmail.com", true, "ArtAcademy", "OOD", false, null, "ARTACADEMY@GMAIL.COM", "ARTACADEMY123", "AQAAAAIAAYagAAAAEAQIJtgWp90LepjnYUrl75YCIlGeFmMyMSRCdgkgPSIqDA4ww/vIlcRinABR+N27VA==", "0897902119", true, "60e70da7-50c1-409e-aa2c-d4de8822336d", true, "artacademy123" },
                    { "723444b3-9434-4465-9044-f7e04fdcca2f", 0, "Bulgaria, Sofia, ul. \"Petar B. Velichkov\" 43", "0ee3aa1c-540a-4aca-a44d-ad01fff81be3", new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "marketingacademy@gmail.com", true, "Marketing Academy", "OOD", false, null, "MARKETINGACADEMY@GMAIL.COM", "MARKETINGACADEMY123", "AQAAAAIAAYagAAAAEJiyY3oZTras+63HW+Bcb/RFtryMhMKnWrvwxdIcOlgnpt3p+LQgjroDz5T2di+V0Q==", "0877742199", true, "329f8a3b-b6cc-4b08-b7a3-01c486654a77", true, "marketingacademy123" },
                    { "7d089603-dc80-415a-913b-f24b1a90b5f1", 0, "Bulgaria, Pleven, ul. \"Hadzi Dimitur\" 10", "7e342975-16a6-48ca-80cd-063e86830e28", new DateTime(1995, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "georgivasilev@gmail.com", true, "Georgi", "Vasilev", false, null, "GEORGIVASILEV@GMAIL.COM", "GEORGIVASILEV123", "AQAAAAIAAYagAAAAEHD6oDlolIqKGuaj1gZ7e+ogUCAZBF2yeGWIw9uJxCfFYchVPEAuWJ/gEcF7txaP7w==", "0804442391", true, "edd2d272-99fd-45bb-9aa0-850ac2c4cd27", true, "georgivasilev123" },
                    { "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", 0, "Bulgaria, Vrana, ul. \"Kozloduy\" 4", "022b0554-7f15-48d5-a9c3-b4bf87c8e34a", new DateTime(2006, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "imaginationacademy@gmail.com", true, "Imagination Academy", "OOD", false, null, "IMAGINATIONACADEMY@GMAIL.COM", "IMAGINATIONACADEMY123", "AQAAAAIAAYagAAAAEA4G28zteQKOAdDqpvqdAEqKQGAu4Bjjb9gAhJYltTednxNS+P3/0XEHm5g5NFlxFQ==", "0878433392", true, "97e818ea-a5e5-417a-9304-cf5bdeae6205", true, "imaginationacandemy123" },
                    { "8d0c3b82-be4b-4fdf-834a-8e436176d9bd", 0, "Bulgaria, Pleven, ul. \"Stefan Karadza\" 6", "ff26b231-baab-495f-aff1-c617625e4896", new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "svetlingeorgiev@gmail.com", true, "Svetlin", "Georgiev", false, null, "SVETLINGEORGIEV@GMAIL.COM", "SVETLINGEORGIEV123", "AQAAAAIAAYagAAAAEEp91p1whqrmE7IXRmZ4RzgceozvNTygpiI08PWJoO7fTqtQucCD1rDQv97CoJ+lCg==", "0894555881", true, "00602830-11ed-44e6-b3ef-b7564174de74", true, "svetlingeorgiev123" },
                    { "9e547484-9ea8-45e6-a488-d657f6f1c598", 0, "Bulgaria, Kazanluk, ul. \"General Gurko\" 4", "bf77faa8-2af5-445e-bd56-d84de36c0535", new DateTime(2002, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "monikapetrova@gmail.com", true, "Monika", "Petrova", false, null, "MONIKAPETROVA@GMAIL.COM", "MONIKAPETROVA123", "AQAAAAIAAYagAAAAENH2Bg/EHWahOLPSUQrqFLFGXN0jhtHYXccb4CCmdVPwUJs0ZplfZ0APzzH5s4PJYA==", "0898760394", true, "41a17cac-8160-45b2-b006-1a7ca1af3c2e", true, "monikapetrova123" },
                    { "b3693b0c-9c11-48ee-a3be-db37d5439ab0", 0, "Bulgaria, Ruse, ul. \"Рила\" 5", "c3437868-642d-4832-a50a-4899a8038c80", new DateTime(1990, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "codecrafters@gmail.com", true, "CodeCrafters", "ET", false, null, "CODECRAFTERS@GMAIL.COM", "CODECRAFTERS123", "AQAAAAIAAYagAAAAEAq6mkUrw+oIw9gp+XWWg3NVg4IcCkjbLTDz1ptzPXX/p/FLZmbFSN2hnbGA6wdhQA==", "0877769431", true, "e672dfd2-d97b-4ed8-9fca-226e675e9949", true, "codecrafters123" },
                    { "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355", 0, "Bulgaria, Plovdiv, ul. \"Georgi Rakovski\" 7", "9864f358-da07-4403-af88-f72ca82ed259", new DateTime(1989, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "simonamincheva@gmail.com", true, "Simona", "Mincheva", false, null, "SIMONAMINCHEVA@GMAIL.COM", "SIMONAMINCHEVA123", "AQAAAAIAAYagAAAAEM1my70s7F5WwnIrvbLNWWzV3y41JolVPwKsrP+zwgbBSfFUNCchyT0G0o2paL6Ujw==", "0897448199", true, "de4aa780-9c2f-4a5d-b4e0-664dd08be86d", true, "simonamincheva123" },
                    { "ca145762-b5db-4836-b963-85eff67fb124", 0, "Bulgaria, Pleven, ul. \"Hristo Botev\" 4", "04a09354-0047-4e5a-89b8-2575669ebf43", new DateTime(1999, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "krasimirdraganov@gmail.com", true, "Krasimir", "Draganov", false, null, "KRASIMIRDRAGANOV@GMAIL.COM", "KRASIMIRDRAGANOV123", "AQAAAAIAAYagAAAAEM7vbQ18IiJIkwhtzgs7z+x+DZC6+aFWuSrPVkX/0sDfKKiI+f/cajy3M7jfWk1eHQ==", "0894555391", true, "2fa45efd-2c23-441f-8434-85fbd30903b0", true, "krasimirdraganov123" },
                    { "d444522c-71c1-4cc9-b815-4ea25a49f17b", 0, "Bulgaria, Kazanluk, ul. \"Georgi Sava Rakovski\" 7", "43c580a5-e428-47da-a240-520f14ed53f8", new DateTime(1998, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "atanasgudov@gmail.com", true, "Atanas", "Gudov", false, null, "ATANASGUDOV@GMAIL.COM", "ATANASGUDOV123", "AQAAAAIAAYagAAAAEOnlVmvsROonnq5Jper1c8cEYUWPLoMMEE0OWIYviOCSDoZubwlhZlowMDsMmLR7nQ==", "0885248739", true, "b64a104a-83d5-4054-863a-f5a25d1c31e2", true, "atanasgudov123" },
                    { "e0d6328d-f003-4bb1-8daa-21dcf49db469", 0, "Bulgaria, Pleven, ul. \"Vasil Petleshkov\" 6", "6661e1de-66dd-43f0-9de4-012d4d46d72e", new DateTime(2002, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chick@gmail.com", true, "Chic Cuts & Styles", "ET", false, null, "CHIC@GMAIL.COM", "CHIC123", "AQAAAAIAAYagAAAAEI9X8OY+DP8pUjQutS3USpfLlbFGIvFsaCqmzd+UiJmWbviz6UOR1mzDO0bKDtC3zw==", "0898769871", true, "010b765a-a89c-4506-b64d-e9b9dc9ad509", true, "chic123" },
                    { "e2041514-c5ce-4e68-8956-f92298aa3b74", 0, "Bulgaria, Kazanluk, ul. \"Hemus\" 5", "a127be4f-bfa3-4e6b-8716-3fd4a2632a45", new DateTime(2004, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "teodoranedkova@gmail.com", true, "Teodora", "Nedkova", false, null, "TEODORANEDKOVA@GMAIL.COM", "TEODORANEDKOVA123", "AQAAAAIAAYagAAAAEOQoPUMh4E7Fd3SIXCU8+qYaKHsVHbZ+BmpTk4igk/kObJBoJWYKUgtAK87YKwe9pQ==", "0879859335", true, "b26db4f8-439b-4bc4-b287-b1489a3d1e11", true, "teodoranedkova123" },
                    { "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", 0, "Bulgaria, Kazanluk, ul. \"Dobri Chintulov\" 5", "0263ab12-e377-4f75-ae63-ae7a64435f4a", new DateTime(2005, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alexstefanov@gmail.com", true, "Alex", "Stefanov", false, null, "ALEXSTEFANOV@GMAIL.COM", "ALEXSTEFANOV123", "AQAAAAIAAYagAAAAEEq9aeP0mcmBMPWBsTGDsBNa6z4wb1H2FDWcIRJH5jjO0E4twygLHYFnjSMd3tEXaw==", "0883856039", true, "95643437-19d4-4682-84b8-f0c57176d0fa", true, "alexstefanov123" },
                    { "e8d223af-7285-41c5-8c38-9e6989d4410d", 0, "Bulgaria, Kazanluk, ul. \"General Stoletov\" 3", "370ae08a-3487-4a1b-8a91-d1fc08afa8ba", new DateTime(2001, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "iliqmilenov@gmail.com", true, "Iliq", "Milenov", false, null, "ILIQMILENOV@GMAIL.COM", "ILIQMILENOV123", "AQAAAAIAAYagAAAAEEwrwfBPEoB5zqLm5n0nmoR9tq/HwZGp8D9f+2tuNB/xUVHb8XcNQ6qlOHvIt7e/zA==", "0895068785", true, "72c607ec-1b9d-4d69-ae40-12f994439f4f", true, "iliqmilenov123" },
                    { "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", 0, "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А", "496b3ba8-feb7-4c38-9bba-26438d6daabc", new DateTime(2003, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "theurbangrillandbar@gmail.com", true, "The Urban Grill & Bar", "ET", false, null, "THEURBANGRILLANDBAR@GMAIL.COM", "THEURBANGRILLANDBAR123", "AQAAAAIAAYagAAAAEHCWfuJwFI7XSbceANyVBYJW9HBWHJyyChFuMxcpWt8BLFlOjOF3zQyQ2I3Gy9kmJw==", "0878439866", true, "533658ad-0cd1-4ec3-beb3-f1a27775dfdf", true, "theurbangrillandbar123" },
                    { "fa360a62-9355-474a-824d-aaa85d9fbd65", 0, "Bulgaria, Stara Zagora, ul. \"Stefan Stambolov\" 38", "fa3df27f-b9a7-481d-a568-eb6529678cbd", new DateTime(2001, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "wittmath@gmail.com", true, "WittMath", "OOD", false, null, "WITTMATH@GMAIL.COM", "WITTMATH123", "AQAAAAIAAYagAAAAEJHoThhzUKhgPlSflUfax3gJukn1vh2+3Jr2N8sH9mUYexXI/70RSj1LZ5OlBvG4rg==", "0880796431", true, "642bfea3-31f1-4a97-beca-ca89ef813c25", true, "wittmath123" },
                    { "fc7c5678-22b4-4650-af6e-4c5f90fa494d", 0, "Bulgaria, Sofia, ul. \"Tsar Asen\" 112", "1cae9e09-1e82-4121-b5a2-abddadc257de", new DateTime(1994, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "globallingua@gmail.com", true, "GlobalLingua", "OOD", false, null, "GLOBALLINGUA@GMAIL.COM", "GLOBALLINGUA123", "AQAAAAIAAYagAAAAEJe/OWBef2FiO6yONvpR9Khzjm/VYP/9urvfQNYwNuJgh0OOit7LxZGnOL9QpEt/9Q==", "0897662398", true, "12ed5640-74a4-4f8c-ba53-4122b8db93a6", true, "globallingua123" }
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
                columns: new[] { "Id", "AverageStarRating", "CourseDuration", "Description", "DurationInMinutes", "EndDate", "InstitutionId", "IsDeleted", "Location", "Mode", "MonthlyPrice", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 4.0, 6, "Learn the fundamentals of digital marketing, including SEO, PPC, and social media strategies.", 120, new DateTime(2027, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "723444b3-9434-4465-9044-f7e04fdcca2f", false, "Remote", 0, 30m, "Introduction to Digital Marketing", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 4.5, 8, "Master the basics of HTML, CSS, and JavaScript in this beginner-friendly web development course.", 150, new DateTime(2028, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "Remote", 0, 35m, "Web Development for Beginners", new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4.7999999999999998, 12, "Dive into the world of data science and learn machine learning algorithms using Python and R.", 180, new DateTime(2029, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cf3fb4a-235e-4c93-b66f-c1557006e067", false, "Remote", 0, 45m, "Data Science and Machine Learning", new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4.7000000000000002, 3, "Gain a foundational understanding of AI, its applications, and how it is changing industries.", 150, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "Remote", 0, 50m, "Introduction to Artificial Intelligence", new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4.5999999999999996, 9, "Master the basics of Spanish, including vocabulary, grammar, and conversational skills, in an engaging and interactive environment.", 90, new DateTime(2030, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc7c5678-22b4-4650-af6e-4c5f90fa494d", false, "Bulgaria, Burgas, ul. \"Odrin\" 2", 1, 200m, "Spanish for beginners", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 4.7999999999999998, 10, "Learn the basics of cooking techniques, kitchen safety, and food presentation in this hands-on culinary course.", 120, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1", false, "Bulgaria, Varna, ul. \"Oborishte\" 13A", 1, 220m, "Introduction to Culinary Arts", new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4.5, 1, "Relax, rejuvenate, and learn mindfulness practices along with beginner-friendly yoga postures in this course.", 90, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "Bulgaria, Pazardzik, ul. \"Nayden Gerov\" 6", 1, 100m, "Yoga and Mindfulness for Beginners", new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4.7000000000000002, 4, "Improve your English language skills in speaking, listening, reading, and writing through practical lessons and exercises.", 180, new DateTime(2025, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "fc7c5678-22b4-4650-af6e-4c5f90fa494d", false, "Bulgaria, Kazanlak, ul. \"Ivan Vazov\" 3", 1, 90m, "English Language Mastery", new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 4.7999999999999998, 7, "Explore the basics of fine art, including sketching, painting, and sculpting, in a hands-on creative environment.", 240, new DateTime(2025, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "Bulgaria, Sofia, Vasil Levski Blvd 62", 1, 250m, "Fundamentals of Fine Art", new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4.7999999999999998, 14, "Learn the principles of embedded systems design, microcontrollers, and real-time programming in this comprehensive beginner-friendly course.", 240, new DateTime(2031, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cf3fb4a-235e-4c93-b66f-c1557006e067", false, "Remote", 0, 60m, "Introduction to Embedded Systems", new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4.7000000000000002, 3, "Master the principles of interior design, space planning, and color theory with hands-on projects.", 180, new DateTime(2025, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "Bulgaria, Sofia, ul. \"Kapitan Andreev\" 29", 1, 280m, "Interior Design Masterclass", new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 4.7999999999999998, 10, "Learn the essentials of music production, including recording, mixing, and mastering, with hands-on studio sessions.", 120, new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "6a358b17-ffbe-4ac9-8d20-92544e3b739d", false, "Bulgaria, Plovdiv, ul. \"Ivan Vazov\" 23", 1, 200m, "Music Production Essentials", new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 4.9000000000000004, 2, "Deepen your understanding of calculus concepts, including multivariable calculus, differential equations, and real-world applications.", 45, new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fa360a62-9355-474a-824d-aaa85d9fbd65", false, "Bulgaria, Plovdiv, ul. \"Perushtitsa\" 15", 1, 110m, "Advanced Calculus Workshop", new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 4.7999999999999998, 8, "Learn essential front-end technologies like HTML, CSS, JavaScript, and React to build stunning and responsive web applications.", 100, new DateTime(2027, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "Remote", 0, 150m, "Front-End Web Development Bootcamp", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 4.7000000000000002, 4, "Explore the core principles of computer engineering, including hardware design, embedded systems, and software integration.", 160, new DateTime(2025, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cf3fb4a-235e-4c93-b66f-c1557006e067", false, "Remote", 0, 300m, "Foundations of Computer Engineering", new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 4.7999999999999998, 6, "Get hands-on experience with cybersecurity protocols, encryption techniques, ethical hacking, and network security to protect digital assets.", 260, new DateTime(2025, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "428bcf46-40f2-47b2-ac4a-a49f570178ad", false, "Bulgaria, Plovdiv, ul. \"Zahari Zograf\" 10", 1, 350m, "Cybersecurity Fundamentals", new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "AverageStarRating", "CompanyId", "Description", "IsDeleted", "JobType", "Location", "Position", "Requirement", "Salary", "Title" },
                values: new object[,]
                {
                    { 1, 4.5, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Develop and maintain software solutions.", false, 0, "Remote", "Junior Developer", "1+ year experience in C# and .NET", 12000m, "Software Developer" },
                    { 2, 3.5, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Create visual designs for marketing materials.", false, 0, "Remote", "Senior Designer", "Proficiency in Adobe Suite", 14500m, "Graphic Designer" },
                    { 3, 3.2000000000000002, "e0d6328d-f003-4bb1-8daa-21dcf49db469", "Provide hair styling, cutting, and treatment services to clients.", false, 1, "Bulgaria, Karlovo, ul. \"Dabensko shose\" 2", "Professional Hairdresser", "Certified cosmetologist with 2+ years of experience.", 4000m, "Hairdresser" },
                    { 4, 4.2999999999999998, "16226cef-b670-447e-99a9-b627cb16ae0b", "Perform vehicle inspections, repairs, and routine maintenance tasks.", false, 1, "Bulgaria, Plovdiv, ul. \"Dimo Hadzhidimov\" 4В", "Automotive Technician", "Basic mechanical skills and willingness to learn. No prior certification required.", 8000m, "Auto Mechanic" },
                    { 5, 4.0, "17585a62-c173-4c68-9e4a-2ba93a419b21", "Diagnose and treat skin conditions, provide expert advice on skincare, and perform dermatological procedures.", false, 1, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "Certified Dermatologist", "Medical degree with specialization in dermatology. Valid state medical license required.", 12000m, "Dermatologist" },
                    { 6, 2.6000000000000001, "596c6add-eaae-4890-8d4d-38aa5a0671bd", "Teach mathematics to students, prepare lesson plans, and assess student progress.", false, 1, "Bulgaria, Pleven, ul. \"Ivan Vazov\"", "High School Math Teacher", "Bachelor's degree in Mathematics or Education. Teaching certification preferred.", 5000m, "Math Teacher" },
                    { 7, 4.0999999999999996, "596c6add-eaae-4890-8d4d-38aa5a0671bd", "Maintain cleanliness and orderliness of the school toilets by performing routine cleaning tasks such as sweeping, mopping, and sanitizing surfaces.", false, 1, "Bulgaria, Pleven, ul. \"Ivan Vazov\"", "Toilet Cleaner", "No prior experience required, but attention to detail and reliability are essential.", 1500m, "School Cleaner" },
                    { 8, 4.0999999999999996, "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", "Prepare and serve alcoholic and non-alcoholic beverages, provide excellent customer service, and maintain a clean and organized bar area to ensure a great experience for guests.", false, 1, "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А", "Toilet Cleaner", "No prior experience required, but attention to detail and reliability are essential.", 1500m, "Bartender" },
                    { 9, 3.3999999999999999, "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd", "Provide excellent customer service by taking orders, serving food and beverages, and ensuring customer satisfaction.", false, 1, "Bulgaria, Sliven,bul. \"Tsar Osvoboditel\" 15А", "Restaurant Waiter", "Good communication skills and a friendly attitude. No prior experience required.", 2000m, "Waiter" },
                    { 10, 4.9000000000000004, "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", "Write engaging articles, blogs, and web content for clients across various industries.", false, 0, "Remote", "Freelance Writer", "Excellent writing skills and creativity. Portfolio preferred.", 5000m, "Content Writer" },
                    { 11, 3.7000000000000002, "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf", "Edit and enhance video content, add transitions, effects, and soundtracks to create high-quality productions.", false, 0, "Remote", "Freelance Video Editor", "Proficiency in video editing software such as Adobe Premiere Pro, Final Cut Pro, or DaVinci Resolve. Portfolio required.", 6000m, "Video Editor" },
                    { 12, 4.0999999999999996, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Assist in developing, testing, and debugging software applications under the guidance of senior developers.", false, 2, "Bulgaria, Varna, bul. \"8-mi Primorski polk\" 54", "Software Developer Intern", "Enrolled in a Computer Science or related degree program. Basic knowledge of programming languages such as Python or Java.", 500m, "Software Development Intern" },
                    { 13, 3.7999999999999998, "b3693b0c-9c11-48ee-a3be-db37d5439ab0", "Assist the design team in creating visual assets, including social media graphics, marketing materials, and presentations.", false, 2, "Bulgaria, Sofia, ul. \"Munchen\" 14", "Graphic Design Intern", "Enrolled in a Graphic Design or related program. Proficiency in design software such as Adobe Illustrator and Photoshop is preferred.", 700m, "Graphic Design Intern" },
                    { 14, 3.8999999999999999, "17585a62-c173-4c68-9e4a-2ba93a419b21", "Assist pharmacists with dispensing medication, preparing prescriptions, managing inventory, and providing customer service under supervision.", false, 2, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "Pharmacy Intern", "Currently enrolled in a Pharmacy or Pharmaceutical Sciences program. Strong attention to detail and communication skills.", 900m, "Pharmacy Intern" },
                    { 15, 4.0999999999999996, "17585a62-c173-4c68-9e4a-2ba93a419b21", "Provide medical care related to women's health, including diagnosis, treatment, and prevention of reproductive health issues, as well as conducting gynecological exams and procedures.", false, 1, "Bulgaria, Ruse, bul. \"Lipnik\" 8", "Certified Gynecologist", "Medical degree with specialization in gynecology. Valid state medical license required.", 13000m, "Gynecologist" }
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
                columns: new[] { "CourseId", "UserId", "ApplicationUserId", "CourseId1" },
                values: new object[,]
                {
                    { 16, "9e547484-9ea8-45e6-a488-d657f6f1c598", null, null },
                    { 5, "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2", null, null }
                });

            migrationBuilder.InsertData(
                table: "UsersJobs",
                columns: new[] { "JobId", "UserId", "ApplicationUserId", "JobId1" },
                values: new object[,]
                {
                    { 2, "d444522c-71c1-4cc9-b815-4ea25a49f17b", null, null },
                    { 1, "e8d223af-7285-41c5-8c38-9e6989d4410d", null, null }
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
