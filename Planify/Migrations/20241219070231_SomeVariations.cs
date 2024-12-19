using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class SomeVariations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8224)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8234)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 3, new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8235)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 4, new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8236)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8237)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8239)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 3, new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8240)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 4, new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8241)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8242)));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 7, 2, 30, 404, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 7, 2, 30, 404, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 7, 2, 30, 404, DateTimeKind.Utc).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Lockheed Martin Communication Software");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 1, new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1776)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 2, new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1777)) });

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
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 1, new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1781)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EmployeeId", "Time" },
                values: new object[] { 2, new TimeOnly(6, 54, 38, 290).Add(TimeSpan.FromTicks(1782)) });

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Loheed Martin Communication Software");
        }
    }
}
