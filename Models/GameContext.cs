using Microsoft.EntityFrameworkCore;

namespace GameList.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) 
            : base(options)
        { }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Name = "Test",
                    Year = 2023,
                    Rating = 4
                },
                new Game
                {
                    GameId = 2,
                    Name = "Test",
                    Year = 2002,
                    Rating = 4
                },
                new Game
                {
                    GameId = 3,
                    Name = "Test",
                    Year = 2000,
                    Rating = 4
                }
                );
        }

    }
}
