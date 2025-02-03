using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class StartDateRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "ProjectTaskComentaries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Person",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2354), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2347)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2356), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2355)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2357), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2357)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2359), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2358)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2360), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2360)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2362), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2361)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2363), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2363)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2365), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2365)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "Time" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 252, DateTimeKind.Utc).AddTicks(2367), new DateOnly(2025, 2, 3), new TimeOnly(6, 2, 38, 252).Add(TimeSpan.FromTicks(2366)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "Description", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9000), new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(8999), "Realizar todas las pruebas unitarias correspondientes y pruebas de integración para garantizar la calidad de nuestro software", new DateOnly(2025, 2, 2) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9006), new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9006), new DateOnly(2025, 2, 27) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9008), new DateTime(2025, 2, 3, 6, 2, 38, 251, DateTimeKind.Utc).AddTicks(9007), new DateOnly(2025, 2, 2) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "ProjectTaskComentaries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Person",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDateUTC",
                value: new DateTime(2025, 1, 21, 3, 49, 52, 344, DateTimeKind.Utc).AddTicks(6518));

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
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "Description", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5172), new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5170), "Realizar ...", new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5174), new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5174), new DateOnly(1, 1, 1) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "StartDate" },
                values: new object[] { new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5176), new DateTime(2025, 1, 21, 3, 49, 52, 347, DateTimeKind.Utc).AddTicks(5175), new DateOnly(1, 1, 1) });

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
    }
}
