using Grimoire.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Grimoire.Data
{
    public class GrimoireContext : DbContext
    {
        public DbSet<Spell> Spells { get; set; }

        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add join table mapping here with Fluent API.
            //Example: modelBuilder.Entity<Spell>().HasKey(s => new { s.Id, s.SpellLevel });

            //Add required here vs in models because it is cleaner for relations to be independent of the model.
            //Example: modelBuilder.Entity<Spell>().Property(s => s.School).IsRequired();
            //modelBuilder.Entity<Spell>().Property(s => s.School).IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["Server"].ConnectionString);
        }
    }
}
