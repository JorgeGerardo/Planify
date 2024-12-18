using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class ComentariesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProjectTaskComentaries",
                columns: new[] { "Id", "Comentary", "Date", "DeletedTimeUTC", "EmployeeId", "IsDeleted", "LastUpdatedUTC", "ProjectTaskId", "Time" },
                values: new object[,]
                {
                    { 1, "Comentario 1", new DateOnly(2024, 12, 18), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(198)) },
                    { 2, "Comentario 2", new DateOnly(2024, 12, 18), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(206)) },
                    { 3, "Comentario 3", new DateOnly(2024, 12, 18), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(208)) },
                    { 4, "Comentario 4", new DateOnly(2024, 12, 18), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(209)) },
                    { 5, "Comentario 5", new DateOnly(2024, 12, 18), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(210)) },
                    { 6, "Comentario 6", new DateOnly(2024, 12, 18), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(211)) },
                    { 7, "Comentario 7", new DateOnly(2024, 12, 18), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(212)) },
                    { 8, "Comentario 8", new DateOnly(2024, 12, 18), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(214)) },
                    { 9, "Comentario 9", new DateOnly(2024, 12, 18), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new TimeOnly(22, 13, 32, 389).Add(TimeSpan.FromTicks(215)) }
                });

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 18, 22, 13, 32, 388, DateTimeKind.Utc).AddTicks(7053));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 10, 5, 27, 13, 887, DateTimeKind.Utc).AddTicks(6918));
        }
    }
}
