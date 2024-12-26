using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class update_coiffeurShift : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoiffeurShifts",
                columns: new[] { "Id", "CoiffeurId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 75319, 753159, new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) },
                    { 91357, 951357, new TimeSpan(0, 22, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoiffeurShifts",
                keyColumn: "Id",
                keyValue: 75319);

            migrationBuilder.DeleteData(
                table: "CoiffeurShifts",
                keyColumn: "Id",
                keyValue: 91357);
        }
    }
}
