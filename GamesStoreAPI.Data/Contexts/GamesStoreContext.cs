using System;
using GamesStoreAPI.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamesStoreAPI.Data.Contexts
{
    public class GamesStoreContext : DbContext
    {
        public GamesStoreContext(DbContextOptions<GamesStoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creating many to many relationship with composite key
            modelBuilder.Entity<GameCategory>().HasKey(sc => new { sc.CategoryId, sc.GameId });
        }

        public DbSet<AgeRestriction> AgeRestrictions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GameCategory> GamesCategories { get; set; }
    }
}
