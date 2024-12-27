using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class AddField_CreateDateUtc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Roles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "ProjectTaskComentaries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "ProjectTaskComentaries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Projects",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Projects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Person",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Person",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Departments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDateUTC",
                table: "Departments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7969), null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7971), null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7971), null });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7972), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9167), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9176), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9178), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9179), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9181), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9182), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9231), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9233), null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9235), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5590), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5594), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5596), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5597), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5598), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5599), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5600), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5601), null });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5602), null });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7921), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7913)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7923), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7922)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7924), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7924)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7926), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7926)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7928), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7927)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7929), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7929)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7931), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7930)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7932), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7932)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(7934), new DateOnly(2024, 12, 27), null, new TimeOnly(4, 0, 37, 401).Add(TimeSpan.FromTicks(7934)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4492), null });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4497), null });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "CreatedDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(4498), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 401, DateTimeKind.Utc).AddTicks(2197), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9427), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9428), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9428), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9429), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9430), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9431), null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(9432), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(5762), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6089), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6125), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6157), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6187), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6219), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6265), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6296), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 27, 4, 0, 37, 398, DateTimeKind.Utc).AddTicks(6326), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "ProjectTasks");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "ProjectTaskComentaries");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CreateDateUTC",
                table: "Departments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "ProjectTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "ProjectTaskComentaries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Person",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdatedUTC",
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
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8848)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8856)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8857)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8858)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8860)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8892)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8894)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8895)) });

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Date", "LastUpdatedUTC", "Time" },
                values: new object[] { new DateOnly(2024, 12, 26), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(22, 17, 41, 666).Add(TimeSpan.FromTicks(8896)) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 26, 22, 17, 41, 666, DateTimeKind.Utc).AddTicks(5574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 26, 22, 17, 41, 666, DateTimeKind.Utc).AddTicks(5577), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDateUTC", "LastUpdatedUTC" },
                values: new object[] { new DateTime(2024, 12, 26, 22, 17, 41, 666, DateTimeKind.Utc).AddTicks(5578), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastUpdatedUTC",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
