﻿// <auto-generated />
using System;
using Barbershop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BarberShopApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241120191356_InitialMig")]
    partial class InitialMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Barbershop.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BarberAvailabilityId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BarberId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndsOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartsOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BarberAvailabilityId");

                    b.HasIndex("BarberId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Barbershop.Models.Barber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HairSaloonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("HairSaloonId");

                    b.HasIndex("UserId");

                    b.ToTable("Barbers");
                });

            modelBuilder.Entity("Barbershop.Models.BarberAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BarberId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Reason")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BarberId");

                    b.ToTable("BarberAvailabilities");
                });

            modelBuilder.Entity("Barbershop.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Instagram")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Barbershop.Models.HairSaloon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ContactId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SaloonLocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ContactId");

                    b.HasIndex("SaloonLocationId");

                    b.ToTable("HairSaloons");
                });

            modelBuilder.Entity("Barbershop.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Barbershop.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BarberId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("ServiceTarget")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BarberId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Barbershop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Barbershop.Models.Appointment", b =>
                {
                    b.HasOne("Barbershop.Models.BarberAvailability", null)
                        .WithMany("Appointments")
                        .HasForeignKey("BarberAvailabilityId");

                    b.HasOne("Barbershop.Models.Barber", "Barber")
                        .WithMany()
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbershop.Models.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbershop.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barber");

                    b.Navigation("Customer");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Barbershop.Models.Barber", b =>
                {
                    b.HasOne("Barbershop.Models.HairSaloon", "Saloon")
                        .WithMany("Barbers")
                        .HasForeignKey("HairSaloonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbershop.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Saloon");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Barbershop.Models.BarberAvailability", b =>
                {
                    b.HasOne("Barbershop.Models.Barber", "Barber")
                        .WithMany("Availabilities")
                        .HasForeignKey("BarberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barber");
                });

            modelBuilder.Entity("Barbershop.Models.HairSaloon", b =>
                {
                    b.HasOne("Barbershop.Models.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbershop.Models.Location", "SaloonLocation")
                        .WithMany()
                        .HasForeignKey("SaloonLocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("SaloonLocation");
                });

            modelBuilder.Entity("Barbershop.Models.Service", b =>
                {
                    b.HasOne("Barbershop.Models.Barber", null)
                        .WithMany("ServicesProvided")
                        .HasForeignKey("BarberId");
                });

            modelBuilder.Entity("Barbershop.Models.User", b =>
                {
                    b.HasOne("Barbershop.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Barbershop.Models.Barber", b =>
                {
                    b.Navigation("Availabilities");

                    b.Navigation("ServicesProvided");
                });

            modelBuilder.Entity("Barbershop.Models.BarberAvailability", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Barbershop.Models.HairSaloon", b =>
                {
                    b.Navigation("Barbers");
                });
#pragma warning restore 612, 618
        }
    }
}
