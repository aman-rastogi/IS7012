﻿// <auto-generated />
using System;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCrud.Migrations
{
    [DbContext(typeof(CoreCrudContext))]
    [Migration("20190927013240_SeedDBData")]
    partial class SeedDBData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCrud.Models.HockeyTeam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget");

                    b.Property<int>("GoalsAgainst");

                    b.Property<int>("GoalsScored");

                    b.Property<bool>("IsTeamActive");

                    b.Property<int>("Loss");

                    b.Property<int>("NationalityID");

                    b.Property<DateTime>("TeamCreationDate");

                    b.Property<DateTime?>("TeamEndDate");

                    b.Property<string>("TeamName");

                    b.Property<int>("Wins");

                    b.HasKey("ID");

                    b.HasIndex("NationalityID");

                    b.ToTable("HockeyTeam");

                    b.HasData(
                        new { ID = 12, Budget = 23234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 1, NationalityID = 3, TeamCreationDate = new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 15 },
                        new { ID = 13, Budget = 42342m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 21, NationalityID = 1, TeamCreationDate = new DateTime(1997, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 25 },
                        new { ID = 14, Budget = 432234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 31, NationalityID = 13, TeamCreationDate = new DateTime(1996, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 35 },
                        new { ID = 15, Budget = 4563234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 11, NationalityID = 10, TeamCreationDate = new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 45 },
                        new { ID = 16, Budget = 26534m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 11, NationalityID = 9, TeamCreationDate = new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 55 },
                        new { ID = 17, Budget = 23654m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 12, NationalityID = 8, TeamCreationDate = new DateTime(1999, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 54 },
                        new { ID = 18, Budget = 23774m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 13, NationalityID = 11, TeamCreationDate = new DateTime(1991, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 53 },
                        new { ID = 19, Budget = 23884m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 14, NationalityID = 12, TeamCreationDate = new DateTime(1992, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 52 },
                        new { ID = 20, Budget = 23234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = false, Loss = 51, NationalityID = 10, TeamCreationDate = new DateTime(1993, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 52 },
                        new { ID = 21, Budget = 223234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 11, NationalityID = 2, TeamCreationDate = new DateTime(1994, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 15 },
                        new { ID = 22, Budget = 234654m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 13, NationalityID = 3, TeamCreationDate = new DateTime(1995, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 25 },
                        new { ID = 23, Budget = 23265m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = false, Loss = 1, NationalityID = 4, TeamCreationDate = new DateTime(1996, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 5 },
                        new { ID = 24, Budget = 23234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 14, NationalityID = 6, TeamCreationDate = new DateTime(1997, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 53 },
                        new { ID = 25, Budget = 23234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 12, NationalityID = 7, TeamCreationDate = new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 54 },
                        new { ID = 26, Budget = 23234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = false, Loss = 16, NationalityID = 8, TeamCreationDate = new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 55 },
                        new { ID = 27, Budget = 23253m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 31, NationalityID = 9, TeamCreationDate = new DateTime(1999, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 56 },
                        new { ID = 28, Budget = 23265m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 41, NationalityID = 10, TeamCreationDate = new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 57 },
                        new { ID = 29, Budget = 232343m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 31, NationalityID = 11, TeamCreationDate = new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 95 },
                        new { ID = 30, Budget = 23287m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = true, Loss = 41, NationalityID = 13, TeamCreationDate = new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 59 },
                        new { ID = 31, Budget = 23234m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = false, Loss = 51, NationalityID = 12, TeamCreationDate = new DateTime(1958, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 52 },
                        new { ID = 32, Budget = 655454m, GoalsAgainst = 4, GoalsScored = 12, IsTeamActive = false, Loss = 21, NationalityID = 3, TeamCreationDate = new DateTime(1948, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), TeamName = "", Wins = 35 }
                    );
                });

            modelBuilder.Entity("CoreCrud.Models.Nationality", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName");

                    b.HasKey("ID");

                    b.ToTable("Nationality");

                    b.HasData(
                        new { ID = 9, CountryName = "Argentina" },
                        new { ID = 10, CountryName = "Japan" },
                        new { ID = 11, CountryName = "Pakistan" },
                        new { ID = 12, CountryName = "Canada" },
                        new { ID = 13, CountryName = "China" },
                        new { ID = 14, CountryName = "Poland" },
                        new { ID = 15, CountryName = "Italy" },
                        new { ID = 16, CountryName = "Russia" },
                        new { ID = 17, CountryName = "Chile" },
                        new { ID = 18, CountryName = "Ukraine" }
                    );
                });

            modelBuilder.Entity("CoreCrud.Models.HockeyTeam", b =>
                {
                    b.HasOne("CoreCrud.Models.Nationality", "nationality")
                        .WithMany("HockeyTeams")
                        .HasForeignKey("NationalityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
