using Microsoft.EntityFrameworkCore;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CheckingStaff> CheckingStaffs { get; set; }
        public DbSet<Court> Courts { get; set; }
        public DbSet<DayBooking> DayBookings { get; set; }
        public DbSet<FixedBooking> FixedBookings { get; set; }
        public DbSet<FlexBooking> FlexBookings { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Slot> Slots { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Booking
            modelBuilder.Entity<Booking>()
                      .HasKey(p => p.Id);

            modelBuilder.Entity<Booking>()
                    .HasOne(p => p.User)
                    .WithMany(pc => pc.Bookings)
                    .HasForeignKey(p => p.UserID);

        }


    }
}
