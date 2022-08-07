using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                { 
                    Id = 1, Name = "Elden Ring",
                    Developer = "From Software", 
                    Release = new DateTime(2022, 2, 23) 
                },

                new Game
                {
                    Id = 2,
                    Name = "The Witcher 3 Wild Hunt",
                    Developer = "CD Projekt RED",
                    Release = new DateTime(2015, 5, 18)
                }
                );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
