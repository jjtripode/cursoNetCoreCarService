﻿// <auto-generated />
using System;
using CursoNetCoreCarService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarServiceFronted.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190818193015_AllEntities")]
    partial class AllEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("CarServiceFronted.Models.Brand", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<Guid?>("ModelsID");

                    b.HasKey("ID");

                    b.HasIndex("ModelsID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CarServiceFronted.Models.Model", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.HasKey("ID");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("CarServiceFronted.Models.Service", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<decimal>("Price");

                    b.Property<string>("Status");

                    b.Property<Guid?>("VehicleID");

                    b.HasKey("ID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CarServiceFronted.Models.ServiceStatus", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<int>("IdStatus");

                    b.HasKey("ID");

                    b.ToTable("ServiceStatus");

                    b.HasData(
                        new
                        {
                            ID = new Guid("ec96d8f2-4973-4e3e-858b-47746e7c6465"),
                            Descripcion = "Pending   ",
                            IdStatus = 10
                        },
                        new
                        {
                            ID = new Guid("27755942-a6a3-45aa-915d-bb26cf5e1a4e"),
                            Descripcion = "InProgress",
                            IdStatus = 20
                        },
                        new
                        {
                            ID = new Guid("2647a3c7-3e6e-40ea-b08f-3748bf288ac9"),
                            Descripcion = "Delayed   ",
                            IdStatus = 30
                        },
                        new
                        {
                            ID = new Guid("2982e717-fe5f-4009-9c27-e61445dcbde5"),
                            Descripcion = "Ended     ",
                            IdStatus = 40
                        });
                });

            modelBuilder.Entity("CarServiceFronted.Models.Vehicle", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BrandID");

                    b.Property<string>("CarLicensePlate");

                    b.Property<DateTime>("ManufacturingDate");

                    b.Property<Guid?>("ModelID");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("ModelID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CarServiceFronted.Models.Brand", b =>
                {
                    b.HasOne("CarServiceFronted.Models.Model", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsID");
                });

            modelBuilder.Entity("CarServiceFronted.Models.Service", b =>
                {
                    b.HasOne("CarServiceFronted.Models.Vehicle")
                        .WithMany("Services")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("CarServiceFronted.Models.Vehicle", b =>
                {
                    b.HasOne("CarServiceFronted.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID");

                    b.HasOne("CarServiceFronted.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelID");
                });
#pragma warning restore 612, 618
        }
    }
}
