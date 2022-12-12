using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class EightMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Visitis = table.Column<int>(type: "int", nullable: false),
                    LastVisit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 12, 7, 32, 14, 233, DateTimeKind.Local).AddTicks(9120));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateUpdated",
                value: new DateTime(2022, 12, 11, 16, 9, 58, 467, DateTimeKind.Local).AddTicks(7440));
        }
    }
}
