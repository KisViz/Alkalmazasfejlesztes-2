using het12._2.Models;
using Microsoft.EntityFrameworkCore;

namespace het12._2.Context
{
    public class EFContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Puppy> Puppies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./DB/db.db");
        }
    }
}
