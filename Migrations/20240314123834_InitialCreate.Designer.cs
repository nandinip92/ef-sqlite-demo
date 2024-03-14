﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooManagement;

#nullable disable

namespace ZooManagementSQLite.Migrations
{
    [DbContext(typeof(Zoo))]
    [Migration("20240314123834_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("ZooManagement.Models.Data.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfAcquisition")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sex")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            DateOfAcquisition = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            DateOfBirth = new DateTime(1997, 10, 15, 23, 0, 0, 0, DateTimeKind.Utc),
                            Name = "simba",
                            Sex = 0,
                            SpeciesId = -1
                        },
                        new
                        {
                            Id = -2,
                            DateOfAcquisition = new DateTime(2001, 2, 3, 0, 0, 0, 0, DateTimeKind.Utc),
                            DateOfBirth = new DateTime(1997, 9, 9, 23, 0, 0, 0, DateTimeKind.Utc),
                            Name = "nala",
                            Sex = 1,
                            SpeciesId = -1
                        });
                });

            modelBuilder.Entity("ZooManagement.Models.Data.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Classification")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Species");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Classification = 0,
                            Name = "lion"
                        });
                });

            modelBuilder.Entity("ZooManagement.Models.Data.Animal", b =>
                {
                    b.HasOne("ZooManagement.Models.Data.Species", "Species")
                        .WithMany()
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });
#pragma warning restore 612, 618
        }
    }
}
