﻿// <auto-generated />
using System;
using GameLibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameLibraryApp.Migrations
{
    [DbContext(typeof(GamesContext))]
    [Migration("20211122023428_Ratings")]
    partial class Ratings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameLibraryApp.Models.Creator", b =>
                {
                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CreatorId");

                    b.ToTable("Creators");

                    b.HasData(
                        new
                        {
                            CreatorId = "EG",
                            Name = "Epic Games"
                        },
                        new
                        {
                            CreatorId = "CD",
                            Name = "CD Projekt Red"
                        },
                        new
                        {
                            CreatorId = "MJ",
                            Name = "Mojang Studios"
                        },
                        new
                        {
                            CreatorId = "NE",
                            Name = "Nintendo Entertainment"
                        });
                });

            modelBuilder.Entity("GameLibraryApp.Models.Games", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnName("Gameplay Type")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.HasIndex("CreatorId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Cost = 25,
                            CreatorId = "CD",
                            Genre = "Action RPG",
                            Name = "Cyberpunk",
                            Platform = "Xbox"
                        },
                        new
                        {
                            ID = 2,
                            Cost = 7,
                            CreatorId = "MJ",
                            Genre = "Adeventure",
                            Name = "Minecraft",
                            Platform = "Mobile"
                        },
                        new
                        {
                            ID = 3,
                            Cost = 0,
                            CreatorId = "EG",
                            Genre = "Battle Royale",
                            Name = "Fortnite",
                            Platform = "Playstation"
                        },
                        new
                        {
                            ID = 4,
                            Cost = 60,
                            CreatorId = "NE",
                            Genre = "Racing",
                            Name = "Mariokart",
                            Platform = "Nintendo Consoles"
                        });
                });

            modelBuilder.Entity("GameLibraryApp.Models.Ratings", b =>
                {
                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("GamesID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingValue")
                        .HasColumnType("int");

                    b.HasKey("Rating");

                    b.HasIndex("GamesID");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Rating = "It's got decent graphics and a fun, open world map to play on. Story missions can be buggy at times.",
                            Name = "Cyberpunk",
                            RatingValue = 7
                        },
                        new
                        {
                            Rating = "A wonderful game where you can let your creativity run wild. You can build whatever you want, explore, and survive.",
                            Name = "Minecraft",
                            RatingValue = 10
                        },
                        new
                        {
                            Rating = "Nice graphics and combat but the skill differnce between players can make the game exhausting.",
                            Name = "Fortnite",
                            RatingValue = 6
                        },
                        new
                        {
                            Rating = "Classic Racing game and is defintiely a must play for anyone who enjoys mario or racing games.",
                            Name = "Mariokart",
                            RatingValue = 9
                        });
                });

            modelBuilder.Entity("GameLibraryApp.Models.Games", b =>
                {
                    b.HasOne("GameLibraryApp.Models.Creator", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameLibraryApp.Models.Ratings", b =>
                {
                    b.HasOne("GameLibraryApp.Models.Games", "Games")
                        .WithMany()
                        .HasForeignKey("GamesID");
                });
#pragma warning restore 612, 618
        }
    }
}
