using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 28, 43, 416, DateTimeKind.Local).AddTicks(2077), new DateTime(2022, 12, 11, 14, 28, 43, 416, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 28, 43, 416, DateTimeKind.Local).AddTicks(2125), new DateTime(2022, 12, 11, 14, 28, 43, 416, DateTimeKind.Local).AddTicks(2127) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2814), new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2859) });
        }
    }
}
