using EED.DAL.Models;
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
        public DbSet<Article> Articles { get; set; }
        public DbSet<TypeAricles> Type { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=testEFdotnet;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Article>().ToTable("Articles");
            builder.Entity<TypeAricles>().ToTable("TypeArticles");
        }
    }
}
