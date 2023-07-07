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
                Name = "Sebastian Vettel",
                DateOfBirth = new DateOnly(1987, 7, 3),
                Nationality = "German",
                RaceStarts = 299,
                RaceWins = 53,
                PodiumFinishes = 122,
                PolePositions = 57,
                FastestLaps = 38,
                ChampionshipWins = 4,
                CareerPoints = 3098,
                FirstRace = "United States Grand Prix 2007",
                LastRace = "Abu Dhabi Grand Prix 2022",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Kimi Räikkönen",
                DateOfBirth = new DateOnly(1979, 10, 17),
                Nationality = "Finnish",
                RaceStarts = 349,
                RaceWins = 21,
                PodiumFinishes = 103,
                PolePositions = 18,
                FastestLaps = 46,
                ChampionshipWins = 1,
                CareerPoints = 1873,
                FirstRace = "Australian Grand Prix 2001",
                LastRace = "Abu Dhabi Grand Prix 2021",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Sergio Pérez",
                DateOfBirth = new DateOnly(1990, 1, 26),
                Nationality = "Mexican",
                RaceStarts = 244,
                RaceWins = 6,
                PodiumFinishes = 31,
                PolePositions = 3,
                FastestLaps = 11,
                CareerPoints = 1349,
                CurrentTeam = new Team
                {
                    Name = "Red Bull",
                    FullName = "Red Bull Racing",
                    BaseCity = "Milton Keynes",
                    BaseCountry = "England, UK",
                    RaceEntered = 358,
                    RaceWins = 101,
                    Podiums = 248,
                    PolePositions = 89,
                    ConstructorChampionships = 5,
                    Website = "https://www.redbullracing.com/",
                    CurrentChassis = "RB19",
                    CurrentEngineProvider = new EngineProvider
                    {
                        Name = "Red Bull Powertrains",
                        CreatedTime = DateTime.UtcNow,
                    },
                    CurrentTeamPrincipal = new TeamPrincipal
                    {
                        Name = "Christian Horner",
                        CreatedTime = DateTime.UtcNow
                    },
                    CreatedTime = DateTime.UtcNow
                },
                FirstRace = "Australian Grand Prix 2011",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Nico Hülkenberg",
                DateOfBirth = new DateOnly(1987, 8, 19),
                Nationality = "German",
                RaceStarts = 190,
                RaceWins = 0,
                PodiumFinishes = 0,
                PolePositions = 1,
                FastestLaps = 2,
                ChampionshipWins = 0,
                CareerPoints = 530,
                CurrentTeam = new Team
                {
                    Name = "Haas",
                    FullName = "MoneyGram Haas F1 Team",
                    BaseCity = "Kannapolis, North Carolina",
                    BaseCountry = "United States",
                    RaceEntered = 154,
                    RaceWins = 0,
                    Podiums = 0,
                    PolePositions = 0,
                    ConstructorChampionships = 0,
                    Website = "https://www.haasf1team.com/",
                    CurrentChassis = "VF-23",
                    CurrentEngineProvider = new EngineProvider
                    {
                        Name = "Ferrari",
                        CreatedTime = DateTime.UtcNow,
                    },
                    CurrentTeamPrincipal = new TeamPrincipal
                    {
                        Name = "Guenther Steiner",
                        CreatedTime = DateTime.UtcNow
                    },
                    CreatedTime = DateTime.UtcNow
                },
                FirstRace = "Bahrain Grand Prix 2010",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Romain Grosjean",
                DateOfBirth = new DateOnly(1986, 4, 17),
                Nationality = "French-Swiss",
                RaceStarts = 179,
                PodiumFinishes = 10,
                FastestLaps = 1,
                CareerPoints = 391,
                FirstRace = "European Grand Prix 2009",
                LastRace = "Bahrain Grand Prix 2020",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Esteban Gutiérrez",
                DateOfBirth = new DateOnly(1991, 8, 5),
                Nationality = "Mexican",
                RaceStarts = 59,
                FastestLaps = 1,
                CareerPoints = 6,
                FirstRace = "Australian Grand Prix 2013",
                LastRace = "Abu Dhabi Grand Prix 2016",
                CreatedTime = DateTime.UtcNow
            });

            var mercedesEngine = context.EngineProviders.FirstOrDefault(e => e.Name == "Mercedes AMG High Performance Powertrains");

            context.Drivers.Add(new Driver
            {
                Name = "Fernando Alonso",
                DateOfBirth = new DateOnly(1981, 7, 29),
                Nationality = "Spanish",
                RaceStarts = 364,
                RaceWins = 32,
                PodiumFinishes = 104,
                PolePositions = 22,
                FastestLaps = 23,
                ChampionshipWins = 2,
                CareerPoints = 2192,
                CurrentTeam = new Team
                {
                    Name = "Aston Martin",
                    FullName = "Aston Martin Aramco Cognizant F1 Team",
                    BaseCity = "Silverstone",
                    BaseCountry = "England, UK",
                    RaceEntered = 60,
                    RaceWins = 0,
                    Podiums = 7,
                    PolePositions = 0,
                    ConstructorChampionships = 0,
                    Website = "https://www.astonmartinf1.com/",
                    CurrentChassis = "AMR23",
                    CurrentEngineProvider = mercedesEngine,
                    CurrentTeamPrincipal = new TeamPrincipal
                    {
                        Name = "Mike Krack",
                        CreatedTime = DateTime.UtcNow
                    },
                    CreatedTime = DateTime.UtcNow
                },
                FirstRace = "Australian Grand Prix 2001",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Stoffel Vandoorne",
                DateOfBirth = new DateOnly(1992, 3, 26),
                Nationality = "Belgian",
                RaceStarts = 42,
                FastestLaps = 0,
                CareerPoints = 26,
                FirstRace = "Bahrain Grand Prix 2016",
                LastRace = "Abu Dhabi Grand Prix 2018",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Jenson Button",
                DateOfBirth = new DateOnly(1980, 1, 19),
                Nationality = "British",
                RaceStarts = 306,
                RaceWins = 15,
                PodiumFinishes = 50,
                PolePositions = 8,
                FastestLaps = 8,
                ChampionshipWins = 1,
                CareerPoints = 1235,
                FirstRace = "Australian Grand Prix 2000",
                LastRace = "Monaco Grand Prix 2017",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Rio Haryanto",
                DateOfBirth = new DateOnly(1993, 1, 22),
                Nationality = "Indonesian",
                RaceStarts = 12,
                FirstRace = "Australian Grand Prix 2016",
                LastRace = "German Grand Prix 2016",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Esteban Ocon",
                DateOfBirth = new DateOnly(1996, 9, 17),
                Nationality = "French",
                RaceStarts = 120,
                RaceWins = 1,
                PodiumFinishes = 3,
                CareerPoints = 395,
                CurrentTeam = new Team
                {
                    Name = "Alpine",
                    FullName = "BWT Alpine F1 Team",
                    BaseCity = "Enstone",
                    BaseCountry = "England, UK",
                    RaceEntered = 54,
                    RaceWins = 1,
                    Podiums = 3,
                    Website = "https://www.alpine-cars.co.uk/formula-1.html",
                    CurrentChassis = "A523",
                    CurrentEngineProvider = new EngineProvider
                    {
                        Name = "Renault",
                        CreatedTime = DateTime.UtcNow,
                    },
                    CurrentTeamPrincipal = new TeamPrincipal
                    {
                        Name = "Otmar Szafnauer",
                        CreatedTime = DateTime.UtcNow
                    },
                    CreatedTime = DateTime.UtcNow
                },
                FirstRace = "Belgian Grand Prix 2016",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Pascal Wehrlein",
                DateOfBirth = new DateOnly(1994, 10, 18),
                Nationality = "German",
                RaceStarts = 39,
                CareerPoints = 6,
                FirstRace = "Australian Grand Prix 2016",
                LastRace = "Abu Dhabi Grand Prix 2017",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Daniel Ricciardo",
                DateOfBirth = new DateOnly(1989, 7, 1),
                Nationality = "Australian",
                RaceStarts = 232,
                RaceWins = 8,
                PodiumFinishes = 32,
                PolePositions = 3,
                FastestLaps = 16,
                CareerPoints = 1311,
                FirstRace = "British Grand Prix 2011",
                LastRace = "Abu Dhabi Grand Prix 2022",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Daniil Kvyat",
                DateOfBirth = new DateOnly(1994, 4, 26),
                Nationality = "Russian",
                RaceStarts = 110,
                PodiumFinishes = 3,
                FastestLaps = 1,
                CareerPoints = 202,
                FirstRace = "Australian Grand Prix 2014",
                LastRace = "Abu Dhabi Grand Prix 2020",
                CreatedTime = DateTime.UtcNow
            });

            var redBullTeam = context.Teams.FirstOrDefault(t => t.Name == "Red Bull");

            context.Drivers.Add(new Driver
            {
                Name = "Max Verstappen",
                DateOfBirth = new DateOnly(1997, 9, 30),
                Nationality = "Dutch",
                RaceStarts = 172,
                RaceWins = 42,
                PodiumFinishes = 86,
                PolePositions = 26,
                FastestLaps = 25,
                ChampionshipWins = 2,
                CareerPoints = 2240.5,
                CurrentTeam = redBullTeam,
                FirstRace = "Australian Grand Prix 2007",
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
        }
    }
}
