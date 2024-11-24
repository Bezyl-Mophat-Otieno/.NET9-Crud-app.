using Microsoft.EntityFrameworkCore;
using VideoGameApi.Models;

namespace VideoGameApi.Database;

public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options):DbContext(options)
{
    public DbSet<VideoGame> VideoGames => Set<VideoGame>();
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<VideoGame>().HasData
        (
            
            new VideoGame
        {
            Id = 1,
            Title = "The Legend of Zelda: Breath of the Wild",
            Platform = "Nintendo Switch",
            Developer = "Nintendo",
            Publisher = "Nintendo",
        },
        new VideoGame
        {
            Id = 2,
            Title = "God of War: Ragnarok",
            Platform = "PS5",
            Developer = "Santa Monica Studio",
            Publisher = "Sony Interactive Entertainment",
        },
        new VideoGame
        {
            Id = 3,
            Title = "Halo Infinite",
            Platform = "Xbox Series X",
            Developer = "343 Industries",
            Publisher = "Xbox Game Studios",
        },
        new VideoGame
        {
            Id = 4,
            Title = "Elden Ring",
            Platform = "PC",
            Developer = "FromSoftware",
            Publisher = "Bandai Namco Entertainment",
        },
        new VideoGame
        {
            Id = 5,
            Title = "Minecraft",
            Platform = "PC",
            Developer = "Mojang Studios",
            Publisher = "Microsoft",
        },
        new VideoGame
        {
            Id = 6,
            Title = "Cyberpunk 2077",
            Platform = "PC",
            Developer = "CD Projekt Red",
            Publisher = "CD Projekt",
        },
        new VideoGame
        {
            Id = 7,
            Title = "Red Dead Redemption 2",
            Platform = "PS4",
            Developer = "Rockstar Games",
            Publisher = "Rockstar Games",
        },
        new VideoGame
        {
            Id = 8,
            Title = "Super Mario Odyssey",
            Platform = "Nintendo Switch",
            Developer = "Nintendo",
            Publisher = "Nintendo",
        },
        new VideoGame
        {
            Id = 9,
            Title = "Overwatch 2",
            Platform = "PC",
            Developer = "Blizzard Entertainment",
            Publisher = "Blizzard Entertainment",
        },
        new VideoGame
        {
            Id = 10,
            Title = "Assassin's Creed Valhalla",
            Platform = "Xbox Series X",
            Developer = "Ubisoft Montreal",
            Publisher = "Ubisoft",
        }

        );

    }
}