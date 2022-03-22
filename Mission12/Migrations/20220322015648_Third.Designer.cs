﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission12.Models;

namespace Mission12.Migrations
{
    [DbContext(typeof(GroupContext))]
    [Migration("20220322015648_Third")]
    partial class Third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission12.Models.Appointment", b =>
                {
                    b.Property<long>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentId = 1L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 2L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 3L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 4L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 5L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 6L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 13, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 7L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 8L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 9L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 10L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 11L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 12L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            AppointmentId = 13L,
                            Available = true,
                            Time = new DateTime(2022, 3, 27, 20, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("Mission12.Models.Group", b =>
                {
                    b.Property<long>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("AppointmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("GroupId");

                    b.HasIndex("AppointmentId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1L,
                            AppointmentId = 1L,
                            Email = "thomas@thomas.com",
                            Name = "thomas",
                            Phone = "9999999",
                            Size = 12
                        });
                });

            modelBuilder.Entity("Mission12.Models.Group", b =>
                {
                    b.HasOne("Mission12.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}