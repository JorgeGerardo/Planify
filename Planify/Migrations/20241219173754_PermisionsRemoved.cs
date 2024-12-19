using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class PermisionsRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermisionsUser");

            migrationBuilder.DropTable(
                name: "Permisions");

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9136)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9146)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9148)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9149)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9151)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9191)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9192)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9194)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeOnly(17, 37, 52, 625).Add(TimeSpan.FromTicks(9196)));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 17, 37, 52, 625, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 17, 37, 52, 625, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 19, 17, 37, 52, 625, DateTimeKind.Utc).AddTicks(3526));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermisionsUser",
                columns: table => new
                {
                    PermisionsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisionsUser", x => new { x.PermisionsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_PermisionsUser_Permisions_PermisionsId",
                        column: x => x.PermisionsId,
                        principalTable: "Permisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermisionsUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Permisions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Permiso para crear.", "create" },
                    { 2, "Permiso para leer.", "read" },
                    { 3, "Permiso para editar.", "edit" },
                    { 4, "Permiso para eliminar.", "soft-delete" },
                    { 5, "Permiso para quitar eliminación lógica.", "restore" }
                });

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
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8235)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8236)));

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
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8240)));

            migrationBuilder.UpdateData(
                table: "ProjectTaskComentaries",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeOnly(7, 2, 30, 404).Add(TimeSpan.FromTicks(8241)));

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

            migrationBuilder.InsertData(
                table: "PermisionsUser",
                columns: new[] { "PermisionsId", "UsersId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 4 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 2 },
                    { 5, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PermisionsUser_UsersId",
                table: "PermisionsUser",
                column: "UsersId");
        }
    }
}
