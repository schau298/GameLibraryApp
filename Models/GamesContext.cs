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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

    

