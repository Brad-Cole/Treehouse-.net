using GameList.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GameList.DAL
{
    public class GameContext : DbContext
    {

        public GameContext() : base("GameContext")
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Platform> Platforms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}