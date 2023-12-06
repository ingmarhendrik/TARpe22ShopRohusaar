﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARpe22ShopRohusaar.Data;

#nullable disable

namespace TARpe22ShopRohusaar.Data.Migrations
{
    [DbContext(typeof(TARpe22ShopRohusaarContext))]
    partial class TARpe22ShopRohusaarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.FileToApi", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExistingFilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RealEstateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("RealEstateId");

                    b.ToTable("FilesToApi");
                });

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.FileToDatabase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SpaceshipId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("FilesToDatabase");
                });

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.RealEstate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BathroomCount")
                        .HasColumnType("int");

                    b.Property<int?>("BedroomCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BuiltAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactFax")
                        .HasColumnType("int");

                    b.Property<int>("ContactPhone")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DoesHaveSwimmingPool")
                        .HasColumnType("bit");

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<int?>("FloorCount")
                        .HasColumnType("int");

                    b.Property<bool>("IsPropertySold")
                        .HasColumnType("bit");

                    b.Property<string>("ListingDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("RoomCount")
                        .HasColumnType("int");

                    b.Property<int>("SquareMeters")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("WhenEstateListedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("RealEstates");
                });

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.Spaceship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BuiltDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CargoWeight")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("CrewCount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DoesHaveAutopilot")
                        .HasColumnType("bit");

                    b.Property<bool>("DoesHaveLifeSupportSystems")
                        .HasColumnType("bit");

                    b.Property<int>("EnginePower")
                        .HasColumnType("int");

                    b.Property<int>("FuelCapacity")
                        .HasColumnType("int");

                    b.Property<int>("FuelConsumption")
                        .HasColumnType("int");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FullTripsCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastMaintenance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MaidenLaunch")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaintenanceCount")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PassengerCount")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spaceships");
                });

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.FileToApi", b =>
                {
                    b.HasOne("TARpe22ShopRohusaar.Core.Domain.Car", null)
                        .WithMany("FilesToApi")
                        .HasForeignKey("CarId");

                    b.HasOne("TARpe22ShopRohusaar.Core.Domain.RealEstate", null)
                        .WithMany("FilesToApi")
                        .HasForeignKey("RealEstateId");
                });

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.Car", b =>
                {
                    b.Navigation("FilesToApi");
                });

            modelBuilder.Entity("TARpe22ShopRohusaar.Core.Domain.RealEstate", b =>
                {
                    b.Navigation("FilesToApi");
                });
#pragma warning restore 612, 618
        }
    }
}
