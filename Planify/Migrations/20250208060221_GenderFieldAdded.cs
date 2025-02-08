using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class GenderFieldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3313), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3323), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3325), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3327), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3328), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3330), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3331), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3333), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3334), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2163), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2155)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2165), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2165)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2206), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2206)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2208), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2208)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2210), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2209)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2211), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2211)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2213), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2212)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2214), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2214)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2216), new DateOnly(2025, 2, 8), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2215)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 118, DateTimeKind.Utc).AddTicks(8925), new DateTime(2025, 2, 8, 6, 2, 20, 118, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 118, DateTimeKind.Utc).AddTicks(8930), new DateTime(2025, 2, 8, 6, 2, 20, 118, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 118, DateTimeKind.Utc).AddTicks(8932), new DateTime(2025, 2, 8, 6, 2, 20, 118, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 118, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 116, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 2, 20, 115, DateTimeKind.Utc).AddTicks(9097));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8613), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8606)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8615), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8615)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8617), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8616)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8618), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8618)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8620), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8619)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8621), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8621)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8623), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8623)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8624), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8624)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8626), new DateOnly(2025, 2, 3), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8626)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5066), new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5074), new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 15, 39, 878, DateTimeKind.Utc).AddTicks(6208));
        }
    }
}
