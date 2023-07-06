using Formula1.Infrastructure;
using Formula1.Infrastructure.Models;

namespace Formula1
{
    /// <summary>The DataSeeder Class</summary>
    public static class DataSeeder
    {
        /// <summary>Seeds the specified host.</summary>
        /// <param name="host">The host.</param>
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<F1DataContext>();
            context.Database.EnsureCreated();
            AddDrivers(context);
        }

        /// <summary>Adds the drivers.</summary>
        /// <param name="context">The context.</param>
        private static void AddDrivers(F1DataContext context)
        {
            var driver = context.Drivers.FirstOrDefault();
            if (driver != null) return;

            context.Drivers.Add(new Driver
            {
                Name = "Nico Rosberg",
                DateOfBirth = new DateOnly(1985, 6, 27),
                Nationality = "German",
                RaceStarts = 206,
                RaceWins = 23,
                PodiumFinishes = 57,
                PolePositions = 30,
                FastestLaps = 20,
                ChampionshipWins = 1,
                CareerPoints = 1594.5,
                FirstRace = "Bahrain Grand Prix 2006",
                LastRace = "Abu Dhabi Grand Prix 2016",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Sir Lewis Hamilton",
                DateOfBirth = new DateOnly(1985, 1, 7),
                Nationality = "British",
                RaceStarts = 319,
                RaceWins = 103,
                PodiumFinishes = 194,
                PolePositions = 103,
                FastestLaps = 62,
                ChampionshipWins = 7,
                CareerPoints = 4511.5,
                CurrentTeam = new Team
                {
                    Name = "Mercedes",
                    FullName = "Mercedes-AMG Petronas F1 Team",
                    BaseCity = "Brackle and Brixworth",
                    BaseCountry = "England, UK",
                    RaceEntered = 280,
                    RaceWins = 125,
                    Podiums = 285,
                    PolePositions = 136,
                    ConstructorChampionships = 8,
                    Website = "https://www.mercedesamgf1.com/",
                    CurrentChassis = "F1 W14",
                    CurrentEngineProvider = new EngineProvider
                    {
                        Name = "Mercedes AMG High Performance Powertrains",
                        CreatedTime = DateTime.UtcNow,
                    },
                    CurrentTeamPrincipal = new TeamPrincipal
                    {
                        Name = "Toto Wolff",
                        CreatedTime = DateTime.UtcNow
                    },
                    CreatedTime = DateTime.UtcNow
                },
                FirstRace = "Australian Grand Prix 2007",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Nico Rosberg",
                DateOfBirth = new DateOnly(1985, 6, 27),
                Nationality = "German",
                RaceStarts = 206,
                RaceWins = 23,
                PodiumFinishes = 57,
                PolePositions = 0,
                FastestLaps = 0,
                ChampionshipWins = 0,
                CareerPoints = 0,
                CurrentTeam = new Team
                {
                    Name = "",
                    FullName = "",
                    BaseCity = "",
                    BaseCountry = "",
                    RaceEntered = 0,
                    RaceWins = 0,
                    Podiums = 0,
                    PolePositions = 0,
                    ConstructorChampionships = 0,
                    Website = "",
                    CurrentChassis = "",
                    CurrentEngineProvider = new EngineProvider
                    {
                        Name = "",
                        CreatedTime = DateTime.UtcNow,
                    },
                    CurrentTeamPrincipal = new TeamPrincipal
                    {
                        Name = "",
                        CreatedTime = DateTime.UtcNow
                    },
                    CreatedTime = DateTime.UtcNow
                },
                FirstRace = "",
                LastRace = "",
                CreatedTime = DateTime.UtcNow
            });
        }
    }
}
