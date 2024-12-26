using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class AddDeparmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DeletedTimeUTC", "IsDeleted", "LastUpdatedUTC", "Name" },
                values: new object[,]
                {
                    { 1, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RH" },
                    { 2, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DevOps" },
                    { 3, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TI" },
                    { 4, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Finance" }
                });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8848)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8856)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8857)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8858)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8860)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8892)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8894)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8895)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8896)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 26, 22, 17, 41, 666, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 26, 22, 17, 41, 666, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 26, 22, 17, 41, 666, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.InsertData(
                table: "DepartmentEmployee",
                columns: new[] { "DepartmentsId", "EmployeesId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "DepartmentEmployee",
                keyColumns: new[] { "DepartmentsId", "EmployeesId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3084)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3097)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3098)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3099)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3100)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3102)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3103)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3104)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "Time" },
                values: new object[] { new DateOnly(2024, 12, 20), new TimeOnly(22, 18, 26, 409).Add(TimeSpan.FromTicks(3106)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 20, 22, 18, 26, 408, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 20, 22, 18, 26, 408, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 20, 22, 18, 26, 408, DateTimeKind.Utc).AddTicks(9753));
        }
    }
}
