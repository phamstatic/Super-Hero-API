using Microsoft.EntityFrameworkCore;
using Super_Hero_API.Entities;

namespace Super_Hero_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        
        public DbSet<SuperHero> SuperHeroes {  get; set; }
    }
}
