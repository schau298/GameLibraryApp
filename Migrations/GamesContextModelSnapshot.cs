﻿// <auto-generated />
using GameLibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameLibraryApp.Migrations
{
    [DbContext(typeof(GamesContext))]
    partial class GamesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameLibraryApp.Models.Creator", b =>
                {
                    b.Property<string>("CreatorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

            modelBuilder.Entity("GameLibraryApp.Models.Games", b =>
                {
                    b.HasOne("GameLibraryApp.Models.Creator", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
