using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class AddBornDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1985, 5, 23), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1990, 3, 14), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1992, 8, 12), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1988, 6, 30), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1983, 9, 25), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1995, 1, 18), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(2000, 11, 5), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1998, 7, 16), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1999, 2, 28), new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6518) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8435), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8429)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8437), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8437)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8439), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8438)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8440), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8440)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8442), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8442)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8444), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8443)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8445), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8445)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8447), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8446)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(8448), new DateOnly(2025, 1, 21), new TimeOnly(3, 49, 52, 347).Add(TimeSpan.FromTicks(8448)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5172), new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5174), new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5176), new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 345, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(7242));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5601) });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BornDate", "CreateDateUTC" },
                values: new object[] { new DateOnly(1, 1, 1), new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7921), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7913)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7923), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7922)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7924), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7924)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7926), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7926)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7928), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7927)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7929), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7929)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7931), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7930)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7932), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7932)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7934), new DateOnly(2024, 12, 27), new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7934)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6326));
        }
    }
}
