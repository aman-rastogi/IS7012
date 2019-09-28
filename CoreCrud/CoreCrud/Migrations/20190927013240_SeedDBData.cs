using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCrud.Migrations
{
    public partial class SeedDBData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HockeyTeam",
                columns: new[] { "ID", "Budget", "GoalsAgainst", "GoalsScored", "IsTeamActive", "Loss", "NationalityID", "TeamCreationDate", "TeamEndDate", "TeamName", "Wins" },
                values: new object[,]
                {
                    { 12, 23234m, 4, 12, true, 1, 3, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 15 },
                    { 26, 23234m, 4, 12, false, 16, 8, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 55 },
                    { 25, 23234m, 4, 12, true, 12, 7, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 54 },
                    { 24, 23234m, 4, 12, true, 14, 6, new DateTime(1997, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 53 },
                    { 23, 23265m, 4, 12, false, 1, 4, new DateTime(1996, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 5 },
                    { 32, 655454m, 4, 12, false, 21, 3, new DateTime(1948, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 35 },
                    { 21, 223234m, 4, 12, true, 11, 2, new DateTime(1994, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 15 },
                    { 17, 23654m, 4, 12, true, 12, 8, new DateTime(1999, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 54 },
                    { 13, 42342m, 4, 12, true, 21, 1, new DateTime(1997, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 25 },
                    { 22, 234654m, 4, 12, true, 13, 3, new DateTime(1995, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 25 }
                });

            migrationBuilder.InsertData(
                table: "Nationality",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { 17, "Chile" },
                    { 9, "Argentina" },
                    { 10, "Japan" },
                    { 11, "Pakistan" },
                    { 12, "Canada" },
                    { 13, "China" },
                    { 14, "Poland" },
                    { 15, "Italy" },
                    { 16, "Russia" },
                    { 18, "Ukraine" }
                });

            migrationBuilder.InsertData(
                table: "HockeyTeam",
                columns: new[] { "ID", "Budget", "GoalsAgainst", "GoalsScored", "IsTeamActive", "Loss", "NationalityID", "TeamCreationDate", "TeamEndDate", "TeamName", "Wins" },
                values: new object[,]
                {
                    { 16, 26534m, 4, 12, true, 11, 9, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 55 },
                    { 27, 23253m, 4, 12, true, 31, 9, new DateTime(1999, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 56 },
                    { 15, 4563234m, 4, 12, true, 11, 10, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 45 },
                    { 20, 23234m, 4, 12, false, 51, 10, new DateTime(1993, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 52 },
                    { 28, 23265m, 4, 12, true, 41, 10, new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 57 },
                    { 18, 23774m, 4, 12, true, 13, 11, new DateTime(1991, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 53 },
                    { 29, 232343m, 4, 12, true, 31, 11, new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 95 },
                    { 19, 23884m, 4, 12, true, 14, 12, new DateTime(1992, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 52 },
                    { 31, 23234m, 4, 12, false, 51, 12, new DateTime(1958, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 52 },
                    { 14, 432234m, 4, 12, true, 31, 13, new DateTime(1996, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 35 },
                    { 30, 23287m, 4, 12, true, 41, 13, new DateTime(1998, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", 59 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "HockeyTeam",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nationality",
                keyColumn: "ID",
                keyValue: 13);
        }
    }
}
