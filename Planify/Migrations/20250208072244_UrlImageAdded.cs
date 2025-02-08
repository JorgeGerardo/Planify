using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class UrlImageAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlProfileImage",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9316), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9317), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "UrlProfileImage" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(9319), null });

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
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(4766));

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
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9826), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9820)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9828), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9828)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9830), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9829)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9831), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9831)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9833), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9832)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9834), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9834)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9836), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9835)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9837), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9837)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 7, 22, 43, 692, DateTimeKind.Utc).AddTicks(9839), new TimeOnly(7, 22, 43, 692).Add(TimeSpan.FromTicks(9838)) });

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
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 7, 22, 43, 689, DateTimeKind.Utc).AddTicks(5482));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlProfileImage",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(468), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(461)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(471), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(470)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(472), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(472)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(474), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(473)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(475), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(475)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(477), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(476)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(478), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(478)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(480), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(479)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 681, DateTimeKind.Utc).AddTicks(481), new TimeOnly(6, 5, 38, 681).Add(TimeSpan.FromTicks(481)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 680, DateTimeKind.Utc).AddTicks(6449), new DateTime(2025, 2, 8, 6, 5, 38, 680, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 680, DateTimeKind.Utc).AddTicks(6458), new DateTime(2025, 2, 8, 6, 5, 38, 680, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 680, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 2, 8, 6, 5, 38, 680, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 680, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4301));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(4890));
        }
    }
}
