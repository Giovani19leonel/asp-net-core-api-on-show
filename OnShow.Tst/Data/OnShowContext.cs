using Microsoft.EntityFrameworkCore;
using OnShow.Tst.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnShow.Tst.Data
{
    public class OnShowContext : DbContext
    {
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Populares> Populares { get; set; }

        public OnShowContext()
        {

        }
        public OnShowContext(DbContextOptions<OnShowContext> options) : base(options)
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
