using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public static class SeedData
    {
        public static void Initialize(this ModelBuilder modelBuilder)
        {
            SeedNationalities(modelBuilder);
            SeedHockeyTeams(modelBuilder);
        }

        public static void SeedHockeyTeams(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HockeyTeam>().HasData(
                new HockeyTeam {ID=12 ,TeamName = "", Budget = 23234, TeamCreationDate = new DateTime(1998, 04, 21), IsTeamActive = true, Wins=15,Loss=1,GoalsScored=12,GoalsAgainst=4,NationalityID=3},
                new HockeyTeam {ID=13 ,TeamName = "", Budget = 42342, TeamCreationDate = new DateTime(1997, 04, 21), IsTeamActive = true, Wins = 25, Loss = 21, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 1 },
                new HockeyTeam {ID=14 ,TeamName = "", Budget = 432234, TeamCreationDate = new DateTime(1996, 04, 21), IsTeamActive = true, Wins = 35, Loss = 31, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 13 },
                new HockeyTeam {ID=15 ,TeamName = "", Budget = 4563234, TeamCreationDate = new DateTime(1998, 04, 21), IsTeamActive = true, Wins = 45, Loss = 11, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 10 },
                new HockeyTeam {ID=16 ,TeamName = "", Budget = 26534, TeamCreationDate = new DateTime(1998, 04, 21), IsTeamActive = true, Wins = 55, Loss = 11, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 9 },
                new HockeyTeam {ID=17 ,TeamName = "", Budget = 23654, TeamCreationDate = new DateTime(1999, 04, 21), IsTeamActive = true, Wins = 54, Loss = 12, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 8 },
                new HockeyTeam {ID=18 ,TeamName = "", Budget = 23774, TeamCreationDate = new DateTime(1991, 04, 21), IsTeamActive = true, Wins = 53, Loss = 13, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 11 },
                new HockeyTeam {ID=19 ,TeamName = "", Budget = 23884, TeamCreationDate = new DateTime(1992, 04, 21), IsTeamActive = true, Wins = 52, Loss = 14, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 12 },
                new HockeyTeam {ID=20 ,TeamName = "", Budget = 23234, TeamCreationDate = new DateTime(1993, 04, 21), IsTeamActive = false, Wins = 52, Loss = 51, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 10 },
                new HockeyTeam {ID=21 ,TeamName = "", Budget = 223234, TeamCreationDate = new DateTime(1994, 04, 21), IsTeamActive = true, Wins = 15, Loss = 11, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 2 },
                new HockeyTeam {ID=22 ,TeamName = "", Budget = 234654, TeamCreationDate = new DateTime(1995, 04, 21), IsTeamActive = true, Wins = 25, Loss = 13, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 3 },
                new HockeyTeam {ID=23 ,TeamName = "", Budget = 23265, TeamCreationDate = new DateTime(1996, 04, 21), IsTeamActive = false, Wins = 5, Loss = 1, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 4 },
                new HockeyTeam {ID=24 ,TeamName = "", Budget = 23234, TeamCreationDate = new DateTime(1997, 04, 21), IsTeamActive = true, Wins = 53, Loss = 14, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 6 },
                new HockeyTeam {ID=25 ,TeamName = "", Budget = 23234, TeamCreationDate = new DateTime(1998, 04, 21), IsTeamActive = true, Wins = 54, Loss = 12, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 7 },
                new HockeyTeam {ID=26 ,TeamName = "", Budget = 23234, TeamCreationDate = new DateTime(1998, 04, 21), IsTeamActive = false, Wins = 55, Loss = 16, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 8 },
                new HockeyTeam {ID=27 ,TeamName = "", Budget = 23253, TeamCreationDate = new DateTime(1999, 04, 21), IsTeamActive = true, Wins = 56, Loss = 31, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 9 },
                new HockeyTeam {ID=28 ,TeamName = "", Budget = 23265, TeamCreationDate = new DateTime(1990, 04, 21), IsTeamActive = true, Wins = 57, Loss = 41, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 10 },
                new HockeyTeam {ID=29 ,TeamName = "", Budget = 232343, TeamCreationDate = new DateTime(1990, 04, 21), IsTeamActive = true, Wins = 95, Loss = 31, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 11 },
                new HockeyTeam {ID=30 ,TeamName = "", Budget = 23287, TeamCreationDate = new DateTime(1998, 04, 21), IsTeamActive = true, Wins = 59, Loss = 41, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 13 },
                new HockeyTeam {ID=31 ,TeamName = "", Budget = 23234, TeamCreationDate = new DateTime(1958, 04, 21), IsTeamActive = false, Wins = 52, Loss = 51, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 12 },
                new HockeyTeam {ID = 32 ,TeamName = "", Budget = 655454, TeamCreationDate = new DateTime(1948, 04, 21), IsTeamActive = false, Wins = 35, Loss = 21, GoalsScored = 12, GoalsAgainst = 4, NationalityID = 3 }
                );
        }

        public static void SeedNationalities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nationality>().HasData(
                new Nationality {ID=9 , CountryName="Argentina" },
                new Nationality {ID=10 , CountryName="Japan"},
                new Nationality {ID=11 , CountryName="Pakistan"},
                new Nationality {ID=12 , CountryName="Canada"},
                new Nationality {ID=13 , CountryName="China"},
                new Nationality {ID=14 , CountryName="Poland"},
                new Nationality {ID=15 , CountryName="Italy"},
                new Nationality {ID=16 , CountryName="Russia"},
                new Nationality {ID=17 , CountryName="Chile"},
                new Nationality {ID=18 , CountryName="Ukraine"}
                );
        }
    }
}