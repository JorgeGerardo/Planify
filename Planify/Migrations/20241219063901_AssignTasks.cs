using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class AssignTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeProjectTask",
                columns: new[] { "EmployeesId", "TasksId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "BornDate", "City", "Country", "DeletedTimeUTC", "IsDeleted", "LastNames", "LastUpdatedUTC", "Name", "PhoneNumber", "Sate" },
                values: new object[,]
                {
                    { 3, new DateOnly(1, 1, 1), "Monterrey", "México", null, false, "Garza", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariana", null, "Nuevo Leon" },
                    { 4, new DateOnly(1, 1, 1), "Mexicali", "México", null, false, "Duran", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antonella", null, "Baja california" }
                });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8486)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8495)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8496)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8497)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8498)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8499)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8501)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8502)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 19), new TimeOnly(6, 39, 0, 846).Add(TimeSpan.FromTicks(8503)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 6, 39, 0, 846, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.InsertData(
                table: "ProjectTasks",
                columns: new[] { "Id", "CompleteDate", "CreatedDateUTC", "DeletedTimeUTC", "Description", "EstimatedEndDate", "IsCompleted", "IsDeleted", "LastUpdatedUTC", "Name", "Priority", "ProjectId", "StartDate", "Status" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2024, 12, 19, 6, 39, 0, 846, DateTimeKind.Utc).AddTicks(4945), null, "Ajustar los parámetros del modelo...", new DateOnly(1, 1, 1), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actividad 2", "Medium", 1, new DateOnly(1, 1, 1), "Pending" },
                    { 3, null, new DateTime(2024, 12, 19, 6, 39, 0, 846, DateTimeKind.Utc).AddTicks(4946), null, "Realizar pruebas", new DateOnly(1, 1, 1), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Actividad 3", "Low", 1, new DateOnly(1, 1, 1), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjectTask",
                columns: new[] { "EmployeesId", "TasksId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DeletedTimeUTC", "HireDate", "IsDeleted", "LastUpdatedUTC", "Name", "PersonId", "UserId" },
                values: new object[,]
                {
                    { 3, null, new DateOnly(2021, 12, 31), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariana", 3, 3 },
                    { 4, null, new DateOnly(2018, 12, 31), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anita", 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "EmployeeProjectTask",
                columns: new[] { "EmployeesId", "TasksId" },
                values: new object[,]
                {
                    { 3, 2 },
                    { 4, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProjectTask",
                keyColumns: new[] { "EmployeesId", "TasksId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeProjectTask",
                keyColumns: new[] { "EmployeesId", "TasksId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeProjectTask",
                keyColumns: new[] { "EmployeesId", "TasksId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeeProjectTask",
                keyColumns: new[] { "EmployeesId", "TasksId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeProjectTask",
                keyColumns: new[] { "EmployeesId", "TasksId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(198)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(206)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(208)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(209)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(210)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(211)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(212)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(214)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 18), new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(215)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 18, 22, 13, 32, 388, DateTimeKind.Utc).AddTicks(7053));
        }
    }
}
