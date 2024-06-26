﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240523082321_DBInit")]
    partial class DBInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repositories.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BookingName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BookingTypeID")
                        .HasColumnType("int");

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("StatusPayment")
                        .HasColumnType("bit");

                    b.Property<float?>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingTypeID");

                    b.HasIndex("UserID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Repositories.Entities.BookingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("amountHour")
                        .HasColumnType("real");

                    b.Property<int?>("bookingID")
                        .HasColumnType("int");

                    b.Property<int?>("scheduleID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bookingID");

                    b.HasIndex("scheduleID")
                        .IsUnique()
                        .HasFilter("[scheduleID] IS NOT NULL");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("Repositories.Entities.BookingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookingTypes");
                });

            modelBuilder.Entity("Repositories.Entities.CheckingStaff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("bookingDetailID")
                        .HasColumnType("int");

                    b.Property<int?>("checkingAt")
                        .HasColumnType("int");

                    b.Property<int?>("customerID")
                        .HasColumnType("int");

                    b.Property<int?>("staffID")
                        .HasColumnType("int");

                    b.Property<bool?>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("bookingDetailID")
                        .IsUnique()
                        .HasFilter("[bookingDetailID] IS NOT NULL");

                    b.HasIndex("customerID");

                    b.ToTable("CheckingStaffs");
                });

            modelBuilder.Entity("Repositories.Entities.Court", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SlotID")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("StoreID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StoreID");

                    b.ToTable("Courts");
                });

            modelBuilder.Entity("Repositories.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("bookingID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bookingID")
                        .IsUnique()
                        .HasFilter("[bookingID] IS NOT NULL");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Repositories.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Repositories.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("courtID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("date")
                        .HasColumnType("datetime2");

                    b.Property<float?>("price")
                        .HasColumnType("real");

                    b.Property<int?>("slotID")
                        .HasColumnType("int");

                    b.Property<bool?>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("courtID");

                    b.HasIndex("slotID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Repositories.Entities.Slot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("endHours")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startHours")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("Repositories.Entities.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("timeActive")
                        .HasColumnType("datetime2");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userId")
                        .IsUnique()
                        .HasFilter("[userId] IS NOT NULL");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Repositories.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("hours")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("roleID")
                        .HasColumnType("int");

                    b.Property<int?>("totalDateWallet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("roleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Repositories.Entities.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("dateWallet")
                        .HasColumnType("datetime2");

                    b.Property<int?>("userID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userID")
                        .IsUnique()
                        .HasFilter("[userID] IS NOT NULL");

                    b.ToTable("Wallets");
                });

            modelBuilder.Entity("Repositories.Entities.Booking", b =>
                {
                    b.HasOne("Repositories.Entities.BookingType", "BookingType")
                        .WithMany("Bookings")
                        .HasForeignKey("BookingTypeID");

                    b.HasOne("Repositories.Entities.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserID");

                    b.Navigation("BookingType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repositories.Entities.BookingDetail", b =>
                {
                    b.HasOne("Repositories.Entities.Booking", "Booking")
                        .WithMany("BookingDetails")
                        .HasForeignKey("bookingID");

                    b.HasOne("Repositories.Entities.Schedule", "Schedule")
                        .WithOne("BookingDetail")
                        .HasForeignKey("Repositories.Entities.BookingDetail", "scheduleID");

                    b.Navigation("Booking");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Repositories.Entities.CheckingStaff", b =>
                {
                    b.HasOne("Repositories.Entities.BookingDetail", "BookingDetail")
                        .WithOne("CheckingStaff")
                        .HasForeignKey("Repositories.Entities.CheckingStaff", "bookingDetailID");

                    b.HasOne("Repositories.Entities.User", "User")
                        .WithMany("CheckingStaffs")
                        .HasForeignKey("customerID");

                    b.Navigation("BookingDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repositories.Entities.Court", b =>
                {
                    b.HasOne("Repositories.Entities.Store", "Store")
                        .WithMany("Courts")
                        .HasForeignKey("StoreID");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Repositories.Entities.Invoice", b =>
                {
                    b.HasOne("Repositories.Entities.Booking", "Booking")
                        .WithOne("Invoice")
                        .HasForeignKey("Repositories.Entities.Invoice", "bookingID");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("Repositories.Entities.Schedule", b =>
                {
                    b.HasOne("Repositories.Entities.Court", "Court")
                        .WithMany("Schedules")
                        .HasForeignKey("courtID");

                    b.HasOne("Repositories.Entities.Slot", "Slot")
                        .WithMany("Schedules")
                        .HasForeignKey("slotID");

                    b.Navigation("Court");

                    b.Navigation("Slot");
                });

            modelBuilder.Entity("Repositories.Entities.Store", b =>
                {
                    b.HasOne("Repositories.Entities.User", "User")
                        .WithOne("Store")
                        .HasForeignKey("Repositories.Entities.Store", "userId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repositories.Entities.User", b =>
                {
                    b.HasOne("Repositories.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("roleID");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Repositories.Entities.Wallet", b =>
                {
                    b.HasOne("Repositories.Entities.User", "User")
                        .WithOne("Wallet")
                        .HasForeignKey("Repositories.Entities.Wallet", "userID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repositories.Entities.Booking", b =>
                {
                    b.Navigation("BookingDetails");

                    b.Navigation("Invoice")
                        .IsRequired();
                });

            modelBuilder.Entity("Repositories.Entities.BookingDetail", b =>
                {
                    b.Navigation("CheckingStaff")
                        .IsRequired();
                });

            modelBuilder.Entity("Repositories.Entities.BookingType", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Repositories.Entities.Court", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Repositories.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Repositories.Entities.Schedule", b =>
                {
                    b.Navigation("BookingDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Repositories.Entities.Slot", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Repositories.Entities.Store", b =>
                {
                    b.Navigation("Courts");
                });

            modelBuilder.Entity("Repositories.Entities.User", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("CheckingStaffs");

                    b.Navigation("Store");

                    b.Navigation("Wallet")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
