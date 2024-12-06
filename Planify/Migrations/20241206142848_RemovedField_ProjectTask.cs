using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Planify.Migrations
{
    /// <inheritdoc />
    public partial class RemovedField_ProjectTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comments",
                table: "ProjectTasks");

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateUTC",
                value: new DateTime(2024, 12, 6, 14, 28, 46, 454, DateTimeKind.Utc).AddTicks(3101));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comments",
                table: "ProjectTasks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.UpdateData(
                table: "ProjectTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comments", "CreatedDateUTC" },
                values: new object[] { "[\"Comentario 1\",\"Comentario 2\",\"Comentario 3\",\"Comentario 4\"]", new DateTime(2024, 12, 4, 6, 28, 54, 399, DateTimeKind.Utc).AddTicks(3315) });
        }
    }
}
