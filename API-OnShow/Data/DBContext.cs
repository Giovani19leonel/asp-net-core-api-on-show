using API_OnShow.Entidades;
using Microsoft.EntityFrameworkCore;

namespace API_OnShow.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Populares> Populares { get; set; }
        public DbSet<Carrossel> Carrossel { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<SeriesEp> SeriesEp { get; set; }

        public DBContext()
        { }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=OnShow;Trusted_Connection=True;");
            }
        }
    }
}
