using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BornDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LastNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentEmployee",
                columns: table => new
                {
                    DepartmentsId = table.Column<int>(type: "int", nullable: false),
                    EmployeesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployee", x => new { x.DepartmentsId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentEmployee_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProject",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProject", x => new { x.EmployeesId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDateUTC = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EstimatedEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CompleteDate = table.Column<TimeOnly>(type: "time", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProjectTask",
                columns: table => new
                {
                    EmployeesId = table.Column<int>(type: "int", nullable: false),
                    TasksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProjectTask", x => new { x.EmployeesId, x.TasksId });
                    table.ForeignKey(
                        name: "FK_EmployeeProjectTask_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeProjectTask_ProjectTasks_TasksId",
                        column: x => x.TasksId,
                        principalTable: "ProjectTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTaskComentaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectTaskId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Comentary = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedTimeUTC = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastUpdatedUTC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTaskComentaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTaskComentaries_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTaskComentaries_ProjectTasks_ProjectTaskId",
                        column: x => x.ProjectTaskId,
                        principalTable: "ProjectTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "BornDate", "City", "Country", "DeletedTimeUTC", "IsDeleted", "LastNames", "LastUpdatedUTC", "Name", "PhoneNumber", "Sate" },
                values: new object[,]
                {
                    { 1, new DateOnly(1, 1, 1), "Guadalajara", "México", null, false, "Gerardo Rojo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jorguito", null, "Sinaloa" },
                    { 2, new DateOnly(1, 1, 1), "Culiacan", "México", null, false, "Argon Lazaro", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", null, "Sinaloa" },
                    { 3, new DateOnly(1, 1, 1), "Monterrey", "México", null, false, "Garza", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariana", null, "Nuevo Leon" },
                    { 4, new DateOnly(1, 1, 1), "Mexicali", "México", null, false, "Duran", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonella", null, "Baja california" },
                    { 5, new DateOnly(1, 1, 1), "Monterrey", "México", null, false, "Dorigan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos Mario", null, "Nuevo Leon" },
                    { 6, new DateOnly(1, 1, 1), "Culiacán", "México", null, false, "Rodriguez Sandoval", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel Juan", null, "Sinaloa" },
                    { 7, new DateOnly(1, 1, 1), "Los Mochis", "México", null, false, "Pajarito Lopez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sebastian", null, "Sinaloa" },
                    { 8, new DateOnly(1, 1, 1), "El Fuerte", "México", null, false, "Perez Sánchez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon", null, "Sinaloa" },
                    { 9, new DateOnly(1, 1, 1), "Durango", "México", null, false, "Ríos Gutiérrez", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santiago", null, "Durango" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "DeletedTimeUTC", "IsDeleted", "LastUpdatedUTC", "Name" },
                values: new object[,]
                {
                    { 1, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "sa" },
                    { 2, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" },
                    { 3, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "manager" },
                    { 4, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rh-admin" },
                    { 5, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "rh" },
                    { 6, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "viewer" },
                    { 7, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "developer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DeletedTimeUTC", "Email", "HashPassword", "IsDeleted", "LastUpdatedUTC" },
                values: new object[,]
                {
                    { 1, null, "Jorguito@example.com", "b88b88cd87cf54d08aabf61b73023cf35551850dc8da5a9d8ae410ef243f74ce", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, "anitaanita@example.com", "f0e50d441e11ee6fe5d8724d0e530e57df21f51d283009f7899b1ea47a26240e", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, "marianita@example.com", "97f7ae522f40518794e1c7d2f0399f931a911b0f007f66fa2a24c65a262a9229", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, "antonella@example.com", "6d2debd249a866cf0d19274260c7012b52725a404807dc8c5ef7e86d00ce8c03", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, "carlosmario@example.com", "934f00dc360f0b00ba471007863910c1266f76244f136885715bce48334daaf7", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, "samueljuan@example.com", "67a0978030e50d8f060cc216bc9ae8ea0e3fa38f0951cc412e5b41744f548add", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, "sebastian@example.com", "4dd68e2ab3a30973318ea903e088b3d3480655ef4236109fe47272c1c1582880", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, "brandon@example.com", "fdb7d5c701a3b4a9981e98fd486d22b51b51f2e91605540e57081d440573c009", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, "santiago@example.com", "49faaade493be8b6b6164ee67f7e4d101812a5dda970d6ca693dda8b8cf82e4b", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DeletedTimeUTC", "HireDate", "IsDeleted", "LastUpdatedUTC", "Name", "PersonId", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateOnly(2022, 5, 1), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jorge", 1, 1 },
                    { 2, null, new DateOnly(2020, 11, 1), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", 2, 2 },
                    { 3, null, new DateOnly(2021, 12, 31), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariana", 3, 3 },
                    { 4, null, new DateOnly(2018, 12, 31), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonella", 4, 4 },
                    { 5, null, new DateOnly(2017, 5, 1), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonella", 5, 5 },
                    { 6, null, new DateOnly(2021, 1, 1), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos Mario", 6, 6 },
                    { 7, null, new DateOnly(2022, 6, 29), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel Juan", 7, 7 },
                    { 8, null, new DateOnly(2023, 2, 27), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon", 8, 8 },
                    { 9, null, new DateOnly(2024, 2, 10), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santiago", 9, 9 }
                });

            migrationBuilder.InsertData(
                table: "RoleUser",
                columns: new[] { "RolesId", "UsersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 7, 8 },
                    { 7, 9 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "DeletedTimeUTC", "IsDeleted", "LastUpdatedUTC", "ManagerId", "Name" },
                values: new object[] { 1, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lockheed Martin Communication Software" });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeesId", "ProjectsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "CompleteDate", "CreatedDateUTC", "DeletedTimeUTC", "Description", "EstimatedEndDate", "IsCompleted", "IsDeleted", "LastUpdatedUTC", "Name", "Priority", "ProjectId", "StartDate", "Status" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 12, 20, 22, 18, 26, 408, DateTimeKind.Utc).AddTicks(9748), null, "Realizar ...", new DateOnly(1, 1, 1), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actividad 1", "Critical", 1, new DateOnly(1, 1, 1), "Pending" },
                    { 2, null, new DateTime(2024, 12, 20, 22, 18, 26, 408, DateTimeKind.Utc).AddTicks(9752), null, "Ajustar los parámetros del modelo...", new DateOnly(1, 1, 1), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actividad 2", "Medium", 1, new DateOnly(1, 1, 1), "Pending" },
                    { 3, null, new DateTime(2024, 12, 20, 22, 18, 26, 408, DateTimeKind.Utc).AddTicks(9753), null, "Realizar pruebas", new DateOnly(1, 1, 1), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actividad 3", "Low", 1, new DateOnly(1, 1, 1), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjectTask",
                columns: new[] { "EmployeesId", "TasksId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 2 },
                    { 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTaskComentaries",
                columns: new[] { "Id", "Comentary", "Date", "DeletedTimeUTC", "EmployeeId", "IsDeleted", "LastUpdatedUTC", "ProjectTaskId", "Time" },
                values: new object[,]
                {
                    { 1, "Comentario 1", new DateOnly(2024, 12, 20), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3084)) },
                    { 2, "Comentario 2", new DateOnly(2024, 12, 20), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3097)) },
                    { 3, "Comentario 3", new DateOnly(2024, 12, 20), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3098)) },
                    { 4, "Comentario 4", new DateOnly(2024, 12, 20), null, 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3099)) },
                    { 5, "Comentario 5", new DateOnly(2024, 12, 20), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3100)) },
                    { 6, "Comentario 6", new DateOnly(2024, 12, 20), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3102)) },
                    { 7, "Comentario 7", new DateOnly(2024, 12, 20), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3103)) },
                    { 8, "Comentario 8", new DateOnly(2024, 12, 20), null, 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3104)) },
                    { 9, "Comentario 9", new DateOnly(2024, 12, 20), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3106)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployee_EmployeesId",
                table: "DepartmentEmployee",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProject_ProjectsId",
                table: "EmployeeProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProjectTask_TasksId",
                table: "EmployeeProjectTask",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonId",
                table: "Employees",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ManagerId",
                table: "Projects",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskComentaries_EmployeeId",
                table: "ProjectTaskComentaries",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTaskComentaries_ProjectTaskId",
                table: "ProjectTaskComentaries",
                column: "ProjectTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTasks_ProjectId",
                table: "ProjectTasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentEmployee");

            migrationBuilder.DropTable(
                name: "EmployeeProject");

            migrationBuilder.DropTable(
                name: "EmployeeProjectTask");

            migrationBuilder.DropTable(
                name: "ProjectTaskComentaries");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "ProjectTasks");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
