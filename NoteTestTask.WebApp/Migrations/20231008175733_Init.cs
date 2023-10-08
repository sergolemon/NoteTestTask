using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NoteTestTask.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    note_id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(90)", maxLength: 90, nullable: false),
                    description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    updated_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.note_id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "note_id", "created_date", "description", "title", "updated_date" },
                values: new object[,]
                {
                    { new Guid("37ad9f3c-30e0-4555-9425-c1c6f89cdbb5"), new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7497), "Lunch at 2pm", "Lunch", new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7485) },
                    { new Guid("3efd4303-ede5-4aa1-82a9-89ae46f3c6d4"), new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7506), "Dinner at 8pm", "Dinner", new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7503) },
                    { new Guid("535b8f81-2bb9-4e1a-bd62-a4df777b9a82"), new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(7227), "Breakfast at 10em", "Breakfast", new DateTime(2023, 10, 8, 20, 57, 32, 953, DateTimeKind.Local).AddTicks(5350) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
