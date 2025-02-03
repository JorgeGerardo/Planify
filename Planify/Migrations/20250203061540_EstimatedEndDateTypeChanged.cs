using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class EstimatedEndDateTypeChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EstimatedEndDate",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

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
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8613), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8606)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8615), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8615)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8617), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8616)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8618), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8618)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8620), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8619)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8621), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8621)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8623), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8623)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8624), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8624)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(8626), new TimeOnly(6, 15, 39, 881).Add(TimeSpan.FromTicks(8626)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "EstimatedEndDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5066), new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5064), new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "EstimatedEndDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5074), new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5074), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "EstimatedEndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 2, 3, 6, 15, 39, 881, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2025, 2, 4) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "EstimatedEndDate",
                table: "ProjectTasks",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2354), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2347)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2356), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2355)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2357), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2357)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2359), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2358)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2360), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2360)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2362), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2361)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2363), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2363)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2365), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2365)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2367), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2366)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "EstimatedEndDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9000), new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(8999), new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "EstimatedEndDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9006), new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "EstimatedEndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9008), new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9007), new DateOnly(1, 1, 1), new DateOnly(2025, 2, 2) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 249, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 2, 3, 6, 2, 38, 248, DateTimeKind.Utc).AddTicks(9833));
        }
    }
}
