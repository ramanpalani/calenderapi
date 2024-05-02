using Calendar.Models.Models.Auth;
using Calendar.Models.Models.Events;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Calendar.DbContexts.DbContexts
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Application> Applications { get; set; }

        public DbSet<Device> Devices { get; set; }

        public DbSet<EventAttachment> EventAttachments { get; set; }

        public DbSet<EventAttendee> EventAttendees { get; set;}

        public DbSet<Eventperiod> EventPeriods { get; set; }

        public DbSet<Location> Locations { get; set; } 

        public DbSet<RecurringEvent> RecurringEvents { get; set;}

        public DbSet<Reminder> Reminders { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserDevice> UserDevices { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<User> Users { get; set; }

    }
}