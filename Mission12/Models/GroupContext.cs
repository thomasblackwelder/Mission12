using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class GroupContext : DbContext
    {
        public GroupContext(DbContextOptions<GroupContext> options) : base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Group> Groups { get; set; }

        //Seed Database 
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Appointment>().HasData(
                new Appointment
                {
                    AppointmentId = 1,
                    Time = DateTime.SpecifyKind(new DateTime(2008, 4, 10, 6, 30, 0), DateTimeKind.Local),
                    Available = true
                });

            mb.Entity<Group>().HasData(
                new Group
                {
                    GroupId = 1,
                    Name = "thomas",
                    Size = 12,
                    Email = "thomas@thomas.com",
                    Phone = "9999999",
                    AppointmentId = 1
                });
        }



    }
}
