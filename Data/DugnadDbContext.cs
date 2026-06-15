using DugnadApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DugnadApp.Data
{
    public class DugnadDbContext : DbContext
    {
        public DugnadDbContext(DbContextOptions<DugnadDbContext> options)
            : base(options)
        {
        }
             
    
        public DbSet<Beboer> Beboere { get; set; }
        public DbSet<Leilighet> Leiligheter { get; set; }
        public DbSet<Dugnad> Dugnader { get; set; }
        public DbSet<Deltakelse> Deltakelser { get; set; }
        public DbSet<LoginToken> LoginTokens { get; set; }
    }
}
