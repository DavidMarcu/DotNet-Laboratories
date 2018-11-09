using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab6.Data
{
    public class PoiContext : DbContext
    {
        public PoiContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Poi> pois { get; private set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=Shop;Trusted_Connection=True;");
            }
        }
    }

}
