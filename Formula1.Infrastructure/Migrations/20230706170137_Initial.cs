using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Formula1.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EngineProviders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineProviders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamPrincipals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamPrincipals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    FullName = table.Column<string>(type: "text", nullable: false),
                    Base = table.Column<string>(type: "text", nullable: false),
                    RaceEntered = table.Column<int>(type: "integer", nullable: false),
                    RaceWins = table.Column<int>(type: "integer", nullable: false),
                    Podiums = table.Column<int>(type: "integer", nullable: false),
                    PolePositions = table.Column<int>(type: "integer", nullable: false),
                    ConstructorChampionships = table.Column<int>(type: "integer", nullable: false),
                    Website = table.Column<string>(type: "text", nullable: true),
                    CurrentChassis = table.Column<string>(type: "text", nullable: true),
                    CurrentEngineProviderId = table.Column<int>(type: "integer", nullable: true),
                    CurrentTeamPrincipalId = table.Column<int>(type: "integer", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_EngineProviders_CurrentEngineProviderId",
                        column: x => x.CurrentEngineProviderId,
                        principalTable: "EngineProviders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teams_TeamPrincipals_CurrentTeamPrincipalId",
                        column: x => x.CurrentTeamPrincipalId,
                        principalTable: "TeamPrincipals",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Nationality = table.Column<string>(type: "text", nullable: false),
                    RaceStarts = table.Column<int>(type: "integer", nullable: false),
                    RaceWins = table.Column<int>(type: "integer", nullable: false),
                    PodiumFinishes = table.Column<int>(type: "integer", nullable: false),
                    PolePositions = table.Column<int>(type: "integer", nullable: false),
                    FastestLaps = table.Column<int>(type: "integer", nullable: false),
                    ChampionshipWins = table.Column<int>(type: "integer", nullable: false),
                    CareerPoints = table.Column<double>(type: "double precision", nullable: false),
                    CurrentTeamId = table.Column<int>(type: "integer", nullable: true),
                    FirstRace = table.Column<string>(type: "text", nullable: false),
                    LastRace = table.Column<string>(type: "text", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Teams_CurrentTeamId",
                        column: x => x.CurrentTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_CurrentTeamId",
                table: "Drivers",
                column: "CurrentTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CurrentEngineProviderId",
                table: "Teams",
                column: "CurrentEngineProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CurrentTeamPrincipalId",
                table: "Teams",
                column: "CurrentTeamPrincipalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "EngineProviders");

            migrationBuilder.DropTable(
                name: "TeamPrincipals");
        }
    }
}
