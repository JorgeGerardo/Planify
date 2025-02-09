using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class UrlImageDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1442), "https://randomuser.me/api/portraits/men/97.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1447), "https://randomuser.me/api/portraits/women/95.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1449), "https://randomuser.me/api/portraits/women/80.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1451), "https://randomuser.me/api/portraits/women/96.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Name", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1452), "Alexandra", "https://randomuser.me/api/portraits/women/88.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "HireDate", "Name", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1454), new DateOnly(2022, 6, 29), "Samuel Juan", "https://randomuser.me/api/portraits/men/88.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "HireDate", "Name", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1481), new DateOnly(2018, 4, 23), "Sebastian", "https://randomuser.me/api/portraits/men/88.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1483), "https://randomuser.me/api/portraits/men/71.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1485), "https://randomuser.me/api/portraits/men/46.jpg" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Name" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7873), "Alexandra" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1473), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1466)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1476), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1475)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1477), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1477)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1479), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1479)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1481), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1480)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1482), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1482)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1484), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1483)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1485), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1485)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 42, DateTimeKind.Utc).AddTicks(1487), new DateOnly(2025, 2, 9), new TimeOnly(19, 36, 54, 42).Add(TimeSpan.FromTicks(1486)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 41, DateTimeKind.Utc).AddTicks(7850), new DateTime(2025, 2, 9, 19, 36, 54, 41, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 41, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 2, 9, 19, 36, 54, 41, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 41, DateTimeKind.Utc).AddTicks(7860), new DateTime(2025, 2, 9, 19, 36, 54, 41, DateTimeKind.Utc).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 41, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 39, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Email", "HashPassword" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8475), "alexandra@example.com", "c80194cefba53b4a38d06e32f555e1c745038550992744a876ffbe495f4f93e1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 9, 19, 36, 54, 38, DateTimeKind.Utc).AddTicks(8618));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9300), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9309), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9312), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9314), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Name", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9316), "Antonella", null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "HireDate", "Name", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9317), new DateOnly(2021, 1, 1), "Carlos Mario", null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "HireDate", "Name", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9319), new DateOnly(2022, 6, 29), "Samuel Juan", null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9352), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9354), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Name" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4766), "Carlos Mario" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9826), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9820)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9828), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9828)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9830), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9829)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9831), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9831)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9833), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9832)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9834), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9834)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9836), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9835)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9837), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9837)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9839), new DateOnly(2025, 2, 8), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9838)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(6507), new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(6513), new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(6515), new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Email", "HashPassword" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5482), "carlosmario@example.com", "934f00dc360f0b00ba471007863910c1266f76244f136885715bce48334daaf7" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5665));
        }
    }
}
