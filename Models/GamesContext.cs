using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace GameLibraryApp.Models
{
    public class GamesContext :DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options) : base(options) { }
        public DbSet<Games> Games { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<Ratings> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ratings>().HasData(
                new Ratings 
                { 
                 Rating = "It's got decent graphics and a fun, open world map to play on. Story missions can be buggy at times.", 
                 RatingValue = 7,
                 Name="Cyberpunk"
                },
                new Ratings
                {
                    Rating = "A wonderful game where you can let your creativity run wild. You can build whatever you want, explore, and survive.",
                    RatingValue = 10,
                    Name = "Minecraft"
                },
                new Ratings
                { 
                    Rating = "Nice graphics and combat but the skill differnce between players can make the game exhausting.",
                    RatingValue = 6,
                    Name = "Fortnite"
                },
                new Ratings
                {
                    Rating = "Classic Racing game and is defintiely a must play for anyone who enjoys mario or racing games.",
                    RatingValue = 9,
                    Name = "Mariokart"
                }
                );
            modelBuilder.Entity<Creator>().HasData(
                new Creator { CreatorId = "EG", Name = "Epic Games" },
                new Creator{ CreatorId = "CD", Name = "CD Projekt Red" },
                new Creator{ CreatorId = "MJ", Name = "Mojang Studios" },
                new Creator{ CreatorId = "NE", Name = "Nintendo Entertainment" }
                );
            modelBuilder.Entity<Games>().HasData(
                new Games
                {
                    ID = 1,
                    Name = "Cyberpunk",
                    Genre = "Action RPG",
                    Cost = 25,
                    Platform = "Xbox",
                    CreatorId = "CD"
                },
                new Games
                {
                    ID = 2,
                    Name = "Minecraft",
                    Genre = "Adeventure",
                    Cost = 7,
                    Platform = "Mobile",
                    CreatorId = "MJ"
                },   
                new Games
                {
                    ID = 3,
                    Name = "Fortnite",
                    Genre = "Battle Royale",
                    Cost = 0,
                    Platform = "Playstation",
                    CreatorId = "EG"
                },     
             new Games
            {
                ID = 4,
                Name = "Mariokart",
                Genre = "Racing",
                Cost = 60,
                Platform = "Nintendo Consoles",
                CreatorId = "NE"
            }
                );
        }
    }
}

    

