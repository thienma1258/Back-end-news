using Microsoft.EntityFrameworkCore;

namespace EED.DAL.Context
{
    public class EEDSqlContext : DbContext
    {
        public EEDSqlContext(DbContextOptions<EEDSqlContext> options) : base(options)
        {
        }

        public EEDSqlContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=163.22.17.198;Initial Catalog=LoveTrip;Integrated Security=False;User ID=LoveTripDatabaseManager;Password=abc@123;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
