using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class NinehtMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1477), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1519), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1523), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1527), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1530), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1533), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1536), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1539), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateUpdated", "Views" },
                values: new object[] { new DateTime(2022, 12, 12, 8, 7, 14, 263, DateTimeKind.Local).AddTicks(1543), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "Products");

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
    }
}
