using IntegrationAPIOnShow.Configurations;
using IntegrationAPIOnShow.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace IntegrationAPIOnShow.Data
{
    public class OnShowContext : DbContext
    {
        private readonly AppSettings _appSettings;

        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Populares> Populares { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<SeriesEp> SeriesEp { get; set; }
        public DbSet<Carrossel> Carrossel { get; set; }
        public OnShowContext(DbContextOptions<OnShowContext> options) : base(options)
        {
        }
    }
}
