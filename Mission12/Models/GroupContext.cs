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
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 8, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 2,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 9, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 3,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 10, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 4,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 11, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 5,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 12, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 6,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 13, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 7,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 14, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 8,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 15, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 9,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 16, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 10,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 17, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 11,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 18, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 12,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 19, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 13,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 27, 20, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                // Monday appointments
                new Appointment
                {
                    AppointmentId = 14,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 8, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 15,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 9, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 16,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 10, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 17,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 11, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 18,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 12, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 19,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 13, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 20,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 14, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 21,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 15, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 22,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 16, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 23,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 17, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 24,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 18, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 25,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 19, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 26,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 28, 20, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                // Tuesday appointments
                new Appointment
                {
                    AppointmentId = 27,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 8, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 28,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 9, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 29,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 10, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 30,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 11, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 31,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 12, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 32,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 13, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 33,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 14, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 34,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 15, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 35,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 16, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 36,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 17, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 37,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 18, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 38,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 19, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 39,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 29, 20, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                // Wednesday appointments
                new Appointment
                {
                    AppointmentId = 40,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 8, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 41,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 9, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 42,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 10, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 43,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 11, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 44,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 12, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 45,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 13, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 46,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 14, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 47,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 15, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 48,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 16, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 49,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 17, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 50,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 18, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 51,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 19, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 52,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 30, 20, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                // Thursday appointments
                new Appointment
                {
                    AppointmentId = 53,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 8, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 54,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 9, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 55,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 10, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 56,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 11, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 57,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 12, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 58,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 13, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 59,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 14, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 60,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 15, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 61,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 16, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 62,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 17, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 63,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 18, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 64,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 19, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 65,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 3, 31, 20, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                // Friday appointments
                new Appointment
                {
                    AppointmentId = 66,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 8, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 67,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 9, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 68,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 10, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 69,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 11, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 70,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 12, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 71,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 13, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 72,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 14, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 73,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 15, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 74,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 16, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 75,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 17, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 76,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 18, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 77,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 19, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 78,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 1, 20, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                // Saturday appointments
                new Appointment
                {
                    AppointmentId = 79,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 8, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 80,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 9, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 81,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 10, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 82,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 11, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 83,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 12, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 84,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 13, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 85,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 14, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 86,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 15, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 87,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 16, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 88,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 17, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 89,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 18, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 90,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 19, 0, 0), DateTimeKind.Local),
                    Available = true
                },

                new Appointment
                {
                    AppointmentId = 91,
                    Time = DateTime.SpecifyKind(new DateTime(2022, 4, 2, 20, 0, 0), DateTimeKind.Local),
                    Available = true
                }
                );

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
