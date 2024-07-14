using JadooProject.DataAccess.Entites;
using Microsoft.EntityFrameworkCore;

namespace JadooProject.DataAccess.Context
{
    public class JadooContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-TOGRPIE\\SQLEXPRESS; integrated security = true; initial catalog = JadooDb; trustServerCertificate = true");
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Manuel> Manuels { get; set; }
        public DbSet<Testimonail> Testimonails { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
    }
}
