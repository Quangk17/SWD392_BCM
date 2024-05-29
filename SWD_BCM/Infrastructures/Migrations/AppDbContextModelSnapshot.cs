﻿// <auto-generated />
using System;
using Infrastructures;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructures.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entites.Booking", b =>
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

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Domain.Entites.BookingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Domain.Entites.BookingType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookingTypes");
                });

            modelBuilder.Entity("Domain.Entites.CheckingStaff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Domain.Entites.Court", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Domain.Entites.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Time")
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

            modelBuilder.Entity("Domain.Entites.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Domain.Entites.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Domain.Entites.Slot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("endHours")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startHours")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Slots");
                });

            modelBuilder.Entity("Domain.Entites.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

                    b.HasIndex("userId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("Domain.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfirmationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Domain.Entites.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeleteBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("ModificationBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

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

            modelBuilder.Entity("Domain.Entites.Booking", b =>
                {
                    b.HasOne("Domain.Entites.BookingType", "BookingType")
                        .WithMany("Bookings")
                        .HasForeignKey("BookingTypeID");

                    b.HasOne("Domain.Entites.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserID");

                    b.Navigation("BookingType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entites.BookingDetail", b =>
                {
                    b.HasOne("Domain.Entites.Booking", "Booking")
                        .WithMany("BookingDetails")
                        .HasForeignKey("bookingID");

                    b.HasOne("Domain.Entites.Schedule", "Schedule")
                        .WithOne("BookingDetail")
                        .HasForeignKey("Domain.Entites.BookingDetail", "scheduleID");

                    b.Navigation("Booking");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Domain.Entites.CheckingStaff", b =>
                {
                    b.HasOne("Domain.Entites.BookingDetail", "BookingDetail")
                        .WithOne("CheckingStaff")
                        .HasForeignKey("Domain.Entites.CheckingStaff", "bookingDetailID");

                    b.HasOne("Domain.Entites.User", "User")
                        .WithMany("CheckingStaffs")
                        .HasForeignKey("customerID");

                    b.Navigation("BookingDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entites.Court", b =>
                {
                    b.HasOne("Domain.Entites.Store", "Store")
                        .WithMany("Courts")
                        .HasForeignKey("StoreID");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Domain.Entites.Invoice", b =>
                {
                    b.HasOne("Domain.Entites.Booking", "Booking")
                        .WithOne("Invoice")
                        .HasForeignKey("Domain.Entites.Invoice", "bookingID");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("Domain.Entites.Schedule", b =>
                {
                    b.HasOne("Domain.Entites.Court", "Court")
                        .WithMany("Schedules")
                        .HasForeignKey("courtID");

                    b.HasOne("Domain.Entites.Slot", "Slot")
                        .WithMany("Schedules")
                        .HasForeignKey("slotID");

                    b.Navigation("Court");

                    b.Navigation("Slot");
                });

            modelBuilder.Entity("Domain.Entites.Store", b =>
                {
                    b.HasOne("Domain.Entites.User", "User")
                        .WithMany("Store")
                        .HasForeignKey("userId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entites.User", b =>
                {
                    b.HasOne("Domain.Entites.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("roleID");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Entites.Wallet", b =>
                {
                    b.HasOne("Domain.Entites.User", "User")
                        .WithOne("Wallet")
                        .HasForeignKey("Domain.Entites.Wallet", "userID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entites.Booking", b =>
                {
                    b.Navigation("BookingDetails");

                    b.Navigation("Invoice")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entites.BookingDetail", b =>
                {
                    b.Navigation("CheckingStaff")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entites.BookingType", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Domain.Entites.Court", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Domain.Entites.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entites.Schedule", b =>
                {
                    b.Navigation("BookingDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entites.Slot", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("Domain.Entites.Store", b =>
                {
                    b.Navigation("Courts");
                });

            modelBuilder.Entity("Domain.Entites.User", b =>
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
