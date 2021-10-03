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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Games>().HasData(
                new Games
                {
                    ID = 1,
                    Name = "Cyberpunk",
                    Genre = "Action RPG",
                    Cost = 25,
                    Platform = "Xbox"
                },
                new Games
                {
                    ID = 2,
                    Name = "Minecraft",
                    Genre = "Adeventure",
                    Cost = 7,
                    Platform = "Mobile"
                },   
                new Games
                {
                    ID = 3,
                    Name = "Fortnite",
                    Genre = "Battle Royale",
                    Cost = 0,
                    Platform = "Playstation"
                },     
             new Games
            {
                ID = 4,
                Name = "Mariokart",
                Genre = "Racing",
                Cost = 60,
                Platform = "Nintendo Consoles"
            }
                );
        }
    }
}

    

