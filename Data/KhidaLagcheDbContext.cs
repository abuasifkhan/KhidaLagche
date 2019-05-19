using KhidhaLagche.Models;
using Microsoft.EntityFrameworkCore;

namespace KhidhaLagche.Data
{
    public class KhidaLagcheDbContext: DbContext
    {
        public KhidaLagcheDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
