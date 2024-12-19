using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class AssignEmployeesToProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1766)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1775)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1776)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1777)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1778)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1780)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1781)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1782)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1783)));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 6, 54, 38, 289, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 6, 54, 38, 289, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 6, 54, 38, 289, DateTimeKind.Utc).AddTicks(8358));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeesId", "ProjectsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeesId", "ProjectsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeesId", "ProjectsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeesId", "ProjectsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(37)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(46)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(47)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(48)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(49)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(51)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(52)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(53)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeOnly(6, 43, 36, 503).Add(TimeSpan.FromTicks(54)));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 6, 43, 36, 502, DateTimeKind.Utc).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 6, 43, 36, 502, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 6, 43, 36, 502, DateTimeKind.Utc).AddTicks(6730));
        }
    }
}
