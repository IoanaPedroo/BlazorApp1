using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class ThirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Books", "books" },
                    { 2, "camera-srl", "Electronics", "electronics" },
                    { 3, "vase", "Pottery", "pottery" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2814), new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2850), "Marcus Cyron/OgreBotCeramics/2014 July 13-16", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg/572px-20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg", false, false, 19.99m, 9.99m, "Radkersburg - Ceramic jugs" },
                    { 2, 1, new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 12, 11, 14, 10, 27, 614, DateTimeKind.Local).AddTicks(2859), "INCLUDES:•Item Size: 8, L x 4.3, W x 8.75, H Country of Origin: China", "https://i.pinimg.com/originals/cf/b5/ac/cfb5ac2d0211309d5f645d248f63bc1e.jpg", false, false, 19.99m, 9.99m, "Duomo Water Filtration Pitcher" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
