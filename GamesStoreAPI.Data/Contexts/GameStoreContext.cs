using System;
using GamesStoreAPI.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GamesStoreAPI.Data.Contexts
{
    public class GameStoreContext : DbContext
    {
        public GameStoreContext()
        {
        }

        public DbSet<AgeRestriction> AgeRestrictions { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
