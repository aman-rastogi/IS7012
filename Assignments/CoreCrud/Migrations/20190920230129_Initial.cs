using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCrud.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HockeyTeam",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TeamName = table.Column<string>(nullable: true),
                    TeamCreationDate = table.Column<DateTime>(nullable: false),
                    IsTeamActive = table.Column<bool>(nullable: false),
                    Budget = table.Column<decimal>(nullable: false),
                    Wins = table.Column<int>(nullable: false),
                    Loss = table.Column<int>(nullable: false),
                    TeamEndDate = table.Column<DateTime>(nullable: true),
                    GoalsScored = table.Column<int>(nullable: false),
                    GoalsAgainst = table.Column<int>(nullable: false),
                    NationalityID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HockeyTeam", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HockeyTeam_Nationality_NationalityID",
                        column: x => x.NationalityID,
                        principalTable: "Nationality",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HockeyTeam_NationalityID",
                table: "HockeyTeam",
                column: "NationalityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HockeyTeam");

            migrationBuilder.DropTable(
                name: "Nationality");
        }
    }
}
