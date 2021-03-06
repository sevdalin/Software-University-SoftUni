﻿namespace CarDealer.Data.Migrations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Migrations;
    using System;

    [DbContext(typeof(CarDealerDbContext))]
    [Migration("20171217214105_CarDealerDb")]
    partial class CarDealerDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarDealer.Domain.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Make");

                    b.Property<string>("Model");

                    b.Property<long>("TravelledDistance");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarDealer.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<bool>("IsYoungDriver");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CarDealer.Domain.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<double?>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("SupplierId")
                        .HasColumnName("Supplier_Id");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("CarDealer.Domain.PartCar", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnName("Car_Id");

                    b.Property<int>("PartId")
                        .HasColumnName("Part_Id");

                    b.HasKey("CarId", "PartId");

                    b.HasIndex("PartId");

                    b.ToTable("PartCars");
                });

            modelBuilder.Entity("CarDealer.Domain.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarId")
                        .HasColumnName("Car_Id");

                    b.Property<int>("CustomerId")
                        .HasColumnName("Customer_Id");

                    b.Property<double>("Discount");

                    b.HasKey("Id");

                    b.HasAlternateKey("CustomerId", "CarId");

                    b.HasIndex("CarId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("CarDealer.Domain.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsImporter");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("CarDealer.Domain.Part", b =>
                {
                    b.HasOne("CarDealer.Domain.Supplier", "Supplier")
                        .WithMany("Parts")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarDealer.Domain.PartCar", b =>
                {
                    b.HasOne("CarDealer.Domain.Car", "Car")
                        .WithMany("Parts")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarDealer.Domain.Part", "Part")
                        .WithMany("Cars")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarDealer.Domain.Sale", b =>
                {
                    b.HasOne("CarDealer.Domain.Car", "Car")
                        .WithMany("Sales")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarDealer.Domain.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}