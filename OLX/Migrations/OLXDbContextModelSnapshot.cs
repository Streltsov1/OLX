﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OLX.Data;

#nullable disable

namespace OLX.Migrations
{
    [DbContext(typeof(OLXDbContext))]
    partial class OLXDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OLX.Data.Entities.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Announcements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Electronics",
                            City = "Rivne",
                            ContactInformation = "3124324235",
                            Description = "iPhone X for sale in good condition",
                            Price = 750m,
                            SellerName = "Mark",
                            Title = "iPhone X"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Sport",
                            City = "Kiyv",
                            ContactInformation = "3124324235",
                            Price = 45.5m,
                            SellerName = "Katya",
                            Title = "PowerBall"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Fashion",
                            City = "Lviv",
                            ContactInformation = "3124324235",
                            Price = 189m,
                            SellerName = "Oleg",
                            Title = "Nike T-Shirt"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Electronics",
                            City = "Kharkiv",
                            ContactInformation = "3124324235",
                            Description = "New samsung s23 phone for sale",
                            Price = 600m,
                            SellerName = "Boris",
                            Title = "Samsung S23"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Toys & Hobbies",
                            City = "Rivne",
                            ContactInformation = "3124324235",
                            Price = 50m,
                            SellerName = "Max",
                            Title = "Air Ball"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Electronics",
                            City = "Kiyv",
                            ContactInformation = "3124324235",
                            Description = "Used macbook pro 2019 for sale",
                            Price = 1200m,
                            SellerName = "Anya",
                            Title = "MacBook Pro 2019"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}