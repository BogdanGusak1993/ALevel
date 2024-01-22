﻿// <auto-generated />
using System;
using ConsoleEFApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleEFApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240122114834_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseHiLo(modelBuilder, "EntityFrameworkHiLoSequence");

            modelBuilder.HasSequence("EntityFrameworkHiLoSequence")
                .IncrementsBy(10);

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.BreedEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"));

                    b.Property<string>("BreedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.LocationEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"));

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.PetEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseHiLo(b.Property<int>("Id"));

                    b.Property<float>("Age")
                        .HasColumnType("real");

                    b.Property<int?>("BreedId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LocationId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.BreedEntity", b =>
                {
                    b.HasOne("ConsoleEFApp.Data.Entities.CategoryEntity", "Category")
                        .WithMany("Breeds")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.PetEntity", b =>
                {
                    b.HasOne("ConsoleEFApp.Data.Entities.BreedEntity", "Breed")
                        .WithMany("Pets")
                        .HasForeignKey("BreedId");

                    b.HasOne("ConsoleEFApp.Data.Entities.CategoryEntity", "Category")
                        .WithMany("Pets")
                        .HasForeignKey("CategoryId");

                    b.HasOne("ConsoleEFApp.Data.Entities.LocationEntity", "Location")
                        .WithMany("Pets")
                        .HasForeignKey("LocationId");

                    b.Navigation("Breed");

                    b.Navigation("Category");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.BreedEntity", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.CategoryEntity", b =>
                {
                    b.Navigation("Breeds");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("ConsoleEFApp.Data.Entities.LocationEntity", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
