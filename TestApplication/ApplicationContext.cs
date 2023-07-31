using Microsoft.EntityFrameworkCore;
using TestApplication.BussinesObjects;

namespace TestApplication
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Region> Regions { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
