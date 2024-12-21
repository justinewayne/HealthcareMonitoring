using HealthcareMonitoring.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthcareMonitoring.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Physician> Physicians { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Patient> Patients { get; set; }
        public object Patient { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Patient>().HasData(
                new Patient
                {

                    Id = 1,
                    Date = new DateTime(2024, 12, 07, 0, 0, 0, DateTimeKind.Utc),
                    Temperature = 100,
                    PulseRate = 120,
                    HeartRate = 98,
                    PulseOximeter = 0,
                    Name = "tgyhujik"
                }
                );
        }
    }
}
