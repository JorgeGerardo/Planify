using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class GenderDataSeedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8262), "Male" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8269), "Female" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8271), "Female" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8273), "Female" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8275), "Female" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8276), "Male" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8314), "Male" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8315), "Male" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Gender" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 5, 38, 677, DateTimeKind.Utc).AddTicks(8317), "Male" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2163), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2155)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2165), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2165)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2206), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2206)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2208), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2208)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2210), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2209)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2211), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2211)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2213), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2212)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2214), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2214)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 8, 6, 2, 20, 119, DateTimeKind.Utc).AddTicks(2216), new TimeOnly(6, 2, 20, 119).Add(TimeSpan.FromTicks(2215)) });

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
    }
}
