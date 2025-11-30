using asp_net.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_net.Context
{
  public class EFContext : DbContext
  {
    public virtual DbSet<Hero> Heroes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite("Data Source=./DB/heroes.db");
    }
  }
}
