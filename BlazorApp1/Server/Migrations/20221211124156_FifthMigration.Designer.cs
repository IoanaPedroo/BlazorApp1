﻿// <auto-generated />
using System;
using BlazorApp1.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221211124156_FifthMigration")]
    partial class FifthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp1.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-srl",
                            Name = "Electronics",
                            Url = "electronics"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "vase",
                            Name = "Pottery",
                            Url = "pottery"
                        });
                });

            modelBuilder.Entity("BlazorApp1.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 12, 11, 14, 41, 56, 250, DateTimeKind.Local).AddTicks(9042),
                            DateUpdated = new DateTime(2022, 12, 11, 14, 41, 56, 250, DateTimeKind.Local).AddTicks(9081),
                            Description = "Marcus Cyron/OgreBotCeramics/2014 July 13-16",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg/572px-20140708_Radkersburg_-_Ceramic_jugs_-_H3216.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Radkersburg - Ceramic jugs"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 12, 11, 14, 41, 56, 250, DateTimeKind.Local).AddTicks(9088),
                            DateUpdated = new DateTime(2022, 12, 11, 14, 41, 56, 250, DateTimeKind.Local).AddTicks(9089),
                            Description = "INCLUDES:•Item Size: 8, L x 4.3, W x 8.75, H Country of Origin: China",
                            Image = "https://i.pinimg.com/originals/cf/b5/ac/cfb5ac2d0211309d5f645d248f63bc1e.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Duomo Water Filtration Pitcher"
                        });
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.Property<int>("EditionsId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("EditionsId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("EditionProduct");
                });

            modelBuilder.Entity("BlazorApp1.Shared.Product", b =>
                {
                    b.HasOne("BlazorApp1.Shared.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EditionProduct", b =>
                {
                    b.HasOne("BlazorApp1.Shared.Edition", null)
                        .WithMany()
                        .HasForeignKey("EditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorApp1.Shared.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorApp1.Shared.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
