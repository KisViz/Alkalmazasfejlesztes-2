using het_12._2.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net.Context
{
    public class EFContext : DbContext
    {
        public virtual DbSet<Kategoria>Kategorias { get; set; }
        public virtual DbSet<Kisallat>Kisallats { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./DB/heroes.db");
        }
    }
}