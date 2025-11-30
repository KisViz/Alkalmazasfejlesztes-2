using Microsoft.EntityFrameworkCore;
using het12._3.Models;

namespace het12._3.Context
{
    public class EFContext : DbContext
    {
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./DB/db.db");
            //optionsBuilder.UseSqlite("@Data Source=./DB/db.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>() // entitas a kulso kulccsal
                .HasOne(p => p.ReferencedTeam) // hivatkozzuk a masik entitast
                .WithMany() //jelezzuk, hogy ez 1:N kapcsolat
                .HasForeignKey(p => p.TeamId) // megadjuk a kulso kapcsolatot
                .OnDelete(DeleteBehavior.Restrict); //nem toroljuk ha van jatekos
        }
    }
}
