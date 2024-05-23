using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CheckingStaff> CheckingStaffs { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<BookingType> BookingTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; }
        public DbSet<Wallet> Wallets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Booking
            modelBuilder.Entity<Booking>().HasKey(p => p.Id);

            modelBuilder.Entity<Booking>().Property(x => x.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Booking>()
                    .HasOne(p => p.User)
                    .WithMany(pc => pc.Bookings)
                    .HasForeignKey(p => p.UserID);
            modelBuilder.Entity<Booking>()
                    .HasMany(x => x.BookingDetails)
                    .WithOne(x => x.Booking);
            modelBuilder.Entity<Booking>()
                    .HasOne(x => x.BookingType)
                    .WithMany(x => x.Bookings)
                    .HasForeignKey(x => x.BookingTypeID);
            modelBuilder.Entity<Booking>()
                    .HasOne(x => x.Invoice)
                    .WithOne(x => x.Booking);

            //CheckingStaff
            modelBuilder.Entity<CheckingStaff>().HasKey(x => x.Id);
            modelBuilder.Entity<CheckingStaff>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<CheckingStaff>()
                .HasOne(x => x.User)
                .WithMany(x => x.CheckingStaffs)
                .HasForeignKey(x => x.customerID);
            modelBuilder.Entity<CheckingStaff>()
                .HasOne(x => x.BookingDetail)
                .WithOne(x => x.CheckingStaff);

            //Courts
            modelBuilder.Entity<Court>().HasKey(x => x.Id);
            modelBuilder.Entity<Court>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Court>()
                .HasOne(x => x.Store)
                .WithMany(x => x.Courts)
                .HasForeignKey(x => x.StoreID);
            modelBuilder.Entity<Court>()
                .HasMany(x => x.Schedules)
                .WithOne(x => x.Court);

            //BookingDetails
            modelBuilder.Entity<BookingDetail>().HasKey(x => x.Id);
            modelBuilder.Entity<BookingDetail>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<BookingDetail>()
                .HasOne(x => x.CheckingStaff)
                .WithOne(x => x.BookingDetail)
                .HasForeignKey<CheckingStaff>(x => x.bookingDetailID);
            modelBuilder.Entity<BookingDetail>()
                .HasOne(x => x.Schedule)
                .WithOne(x => x.BookingDetail)
                .HasForeignKey<BookingDetail>(x => x.scheduleID);
            modelBuilder.Entity<BookingDetail>()
                .HasOne(x => x.Booking)
                .WithMany(x => x.BookingDetails)
                .HasForeignKey(x => x.bookingID);

            //BookingTypes
            modelBuilder.Entity<BookingType>().HasKey(x => x.Id);
            modelBuilder.Entity<BookingType>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<BookingType>()
                .HasMany(x => x.Bookings)
                .WithOne(x => x.BookingType);

            //Invoices
            modelBuilder.Entity<Invoice>().HasKey(x => x.Id);
            modelBuilder.Entity<Invoice>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Invoice>()
                .HasOne(x => x.Booking)
                .WithOne(x => x.Invoice)
                .HasForeignKey<Invoice>(x => x.bookingID);

            // Roles
            modelBuilder.Entity<Role>().HasKey(x => x.Id);
            modelBuilder.Entity<Role>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Role>()
                .HasMany(x => x.Users)
                .WithOne(x => x.Role);

            //Schedules
            modelBuilder.Entity<Schedule>().HasKey(x => x.Id);
            modelBuilder.Entity<Schedule>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Schedule>()
                .HasOne(x => x.Court)
                .WithMany(x => x.Schedules)
                .HasForeignKey(x => x.courtID);
            modelBuilder.Entity<Schedule>()
                .HasOne(x => x.BookingDetail)
                .WithOne(x => x.Schedule);
            modelBuilder.Entity<Schedule>()
                .HasOne(x => x.Slot)
                .WithMany(x => x.Schedules)
                .HasForeignKey(x => x.slotID);

            //Slots
            modelBuilder.Entity<Slot>().HasKey(x => x.Id);
            modelBuilder.Entity<Slot>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Slot>()
                .HasMany(x => x.Schedules)
                .WithOne(x => x.Slot);

            //Stores
            modelBuilder.Entity<Store>().HasKey(x => x.Id);
            modelBuilder.Entity<Store>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Store>()
                .HasOne(x => x.User)
                .WithOne(x => x.Store)
                .HasForeignKey<Store>(x => x.userId);
            modelBuilder.Entity<Store>()
                .HasMany(x => x.Courts)
                .WithOne(x => x.Store);

            //Users
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
                .HasOne(x => x.Role)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.roleID);
            modelBuilder.Entity<User>()
                .HasOne(x => x.Store)
                .WithOne(x => x.User);
            modelBuilder.Entity<User>()
                .HasMany(x => x.Bookings)
                .WithOne(x => x.User);
            modelBuilder.Entity<User>()
                .HasMany(x => x.CheckingStaffs)
                .WithOne(x => x.User);
            modelBuilder.Entity<User>()
                .HasOne(x => x.Wallet)
                .WithOne(x => x.User);

            //Wallets
            modelBuilder.Entity<Wallet>().HasKey(x => x.Id);
            modelBuilder.Entity<Wallet>().Property(x => x.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Wallet>()
                .HasOne(x => x.User)
                .WithOne(x => x.Wallet)
                .HasForeignKey<Wallet>(x => x.userID);

        }


    }
}
