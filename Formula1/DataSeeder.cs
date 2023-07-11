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
            AddEngineProviders(context);
            AddTeamPrincipals(context);
            AddTeams(context);
            AddDrivers(context);
        }

        /// <summary>Adds the engine providers.</summary>
        /// <param name="context">The context.</param>
        private static void AddEngineProviders(F1DataContext context)
        {
            var enginerProvider = context.EngineProviders.FirstOrDefault();
            if (enginerProvider != null) return;

            context.EngineProviders.Add(new EngineProvider
            {
                Name = "Mercedes AMG High Performance Powertrains",
                CreatedTime = DateTime.UtcNow,
            });

            context.EngineProviders.Add(new EngineProvider
            {
                Name = "Red Bull Powertrains",
                CreatedTime = DateTime.UtcNow,
            });

            context.EngineProviders.Add(new EngineProvider
            {
                Name = "Ferrari",
                CreatedTime = DateTime.UtcNow,
            });

            context.EngineProviders.Add(new EngineProvider
            {
                Name = "Renault",
                CreatedTime = DateTime.UtcNow,
            });

            context.SaveChanges();
        }

        /// <summary>Adds the team principals.</summary>
        /// <param name="context">The context.</param>
        private static void AddTeamPrincipals(F1DataContext context)
        {
            var teamPrincipal = context.TeamPrincipals.FirstOrDefault();
            if (teamPrincipal != null) return;

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Toto Wolff",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Christian Horner",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Guenther Steiner",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Mike Krack",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Otmar Szafnauer",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Frédéric Vasseur",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Alessandro Alunni Bravi",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Zak Brown",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "James Vowels",
                CreatedTime = DateTime.UtcNow,
            });

            context.TeamPrincipals.Add(new TeamPrincipal
            {
                Name = "Franz Tost",
                CreatedTime = DateTime.UtcNow,
            });

            context.SaveChanges();
        }

        /// <summary>Adds the teams.</summary>
        /// <param name="context">The context.</param>
        private static void AddTeams(F1DataContext context)
        {
            var team = context.Teams.FirstOrDefault();
            if (team != null) return;

            context.Teams.Add(new Team
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
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Mercedes AMG High Performance Powertrains")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Toto Wolff")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
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
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Red Bull Powertrains")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Christian Horner")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
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
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Ferrari")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Guenther Steiner")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
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
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Mercedes AMG High Performance Powertrains")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Mike Krack")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
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
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Renault")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Otmar Szafnauer")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
            {
                Name = "Ferrari",
                FullName = "Scuderia Ferrari",
                BaseCity = "Maranello",
                BaseCountry = "Italy",
                RaceEntered = 1064,
                RaceWins = 241,
                Podiums = 795,
                PolePositions = 243,
                ConstructorChampionships = 16,
                Website = "https://www.ferrari.com/formula1",
                CurrentChassis = "SF-23",
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Ferrari")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Frédéric Vasseur")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
            {
                Name = "Alfa Romeo",
                FullName = "Alfa Romeo F1 Team Stake",
                BaseCity = "Hinwil, Zürich",
                BaseCountry = "Switzerland",
                RaceEntered = 202,
                RaceWins = 10,
                Podiums = 26,
                PolePositions = 12,
                Website = "https://www.sauber-group.com/motorsport/formula-1/",
                CurrentChassis = "C43",
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Ferrari")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Alessandro Alunni Bravi")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
            {
                Name = "McLaren",
                FullName = "McLaren F1 Team",
                BaseCity = "Woking, Surrey",
                BaseCountry = "England, UK",
                RaceEntered = 938,
                RaceWins = 183,
                Podiums = 494,
                PolePositions = 156,
                ConstructorChampionships = 8,
                Website = "https://www.mclaren.com/racing/",
                CurrentChassis = "MCL60",
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Mercedes AMG High Performance Powertrains")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Zak Brown")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
            {
                Name = "Williams",
                FullName = "Williams Racing",
                BaseCity = "Grove, Oxfordshire",
                BaseCountry = "England, UK",
                RaceEntered = 802,
                RaceWins = 114,
                Podiums = 313,
                PolePositions = 128,
                ConstructorChampionships = 9,
                Website = "https://www.williamsf1.com/",
                CurrentChassis = "FW45",
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name.Equals("Mercedes AMG High Performance Powertrains")),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("James Vowels")),
                CreatedTime = DateTime.UtcNow
            });

            context.Teams.Add(new Team
            {
                Name = "AlphaTauri",
                FullName = "Scuderia AlphaTauri",
                BaseCity = "Faenza",
                BaseCountry = "Italy",
                RaceEntered = 71,
                RaceWins = 1,
                Podiums = 2,
                Website = "https://scuderia.alphatauri.com/",
                CurrentChassis = "AT 04",
                CurrentEngineProvider = context.EngineProviders.FirstOrDefault(p => p.Name == "Red Bull Powertrains"),
                CurrentTeamPrincipal = context.TeamPrincipals.FirstOrDefault(p => p.Name.Equals("Franz Tost")),
                CreatedTime = DateTime.UtcNow
            });

            context.SaveChanges();
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
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Mercedes")),
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
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Red Bull")),
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
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Haas")),
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
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Aston Martin")),
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
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Alpine")),
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
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Red Bull")),
                FirstRace = "Australian Grand Prix 2007",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Kevin Magnussen",
                DateOfBirth = new DateOnly(1992, 10, 5),
                Nationality = "Danish",
                RaceStarts = 150,
                PodiumFinishes = 1,
                PolePositions = 1,
                FastestLaps = 2,
                CareerPoints = 185,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Haas")),
                FirstRace = "Australian Grand Prix 2014",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Jolyon Palmer",
                DateOfBirth = new DateOnly(1991, 1, 20),
                Nationality = "British",
                RaceStarts = 35,
                CareerPoints = 9,
                FirstRace = "Australian Grand Prix 2016",
                LastRace = "Japanese Grand Prix 2017",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Marcus Ericsson",
                DateOfBirth = new DateOnly(1990, 9, 2),
                Nationality = "Swedish",
                RaceStarts = 97,
                CareerPoints = 18,
                FirstRace = "Australian Grand Prix 2014",
                LastRace = "Abu Dhabi Grand Prix 2018",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Felipe Nasr",
                DateOfBirth = new DateOnly(1992, 8, 21),
                Nationality = "Brazilian",
                RaceStarts = 39,
                CareerPoints = 29,
                FirstRace = "Australian Grand Prix 2015",
                LastRace = "Abu Dhabi Grand Prix 2016",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Carlos Sainz Jr.",
                DateOfBirth = new DateOnly(1994, 9, 1),
                Nationality = "Spanish",
                RaceStarts = 171,
                RaceWins = 1,
                PodiumFinishes = 15,
                PolePositions = 3,
                FastestLaps = 3,
                CareerPoints = 864.5,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Ferrari")),
                FirstRace = "Australian Grand Prix 2015",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Felipe Massa",
                DateOfBirth = new DateOnly(1981, 4, 25),
                Nationality = "Brazilian",
                RaceStarts = 269,
                RaceWins = 11,
                PodiumFinishes = 41,
                PolePositions = 16,
                FastestLaps = 15,
                CareerPoints = 1167,
                FirstRace = "Australian Grand Prix 2002",
                LastRace = "Abu Dhabi Grand Prix 2017",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Valtteri Bottas",
                DateOfBirth = new DateOnly(1989, 8, 28),
                Nationality = "Finnish",
                RaceStarts = 209,
                RaceWins = 10,
                PodiumFinishes = 67,
                PolePositions = 20,
                FastestLaps = 19,
                CareerPoints = 1792,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Alfa Romeo")),
                FirstRace = "Australian Grand Prix 2013",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Antonio Giovinazzi",
                DateOfBirth = new DateOnly(1993, 12, 14),
                Nationality = "Italian",
                RaceStarts = 62,
                CareerPoints = 21,
                FirstRace = "Australian Grand Prix 2017",
                LastRace = "Abu Dhabi Grand Prix 2021",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Pierre Gasly",
                DateOfBirth = new DateOnly(1996, 2, 7),
                Nationality = "French",
                RaceStarts = 117,
                RaceWins = 1,
                PodiumFinishes = 3,
                FastestLaps = 3,
                CareerPoints = 348,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Alpine")),
                FirstRace = "Malaysian Grand Prix 2017",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Brendon Hartley",
                DateOfBirth = new DateOnly(1989, 11, 10),
                Nationality = "New Zealander",
                RaceStarts = 25,
                CareerPoints = 4,
                FirstRace = "United States Grand Prix 2017",
                LastRace = "Abu Dhabi Grand Prix 2018",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Paul di Resta",
                DateOfBirth = new DateOnly(1986, 4, 16),
                Nationality = "British",
                RaceStarts = 59,
                CareerPoints = 21,
                FirstRace = "Australian Grand Prix 2011",
                LastRace = "Hungarian Grand Prix 2017",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Lance Stroll",
                DateOfBirth = new DateOnly(1998, 10, 29),
                Nationality = "Canadian",
                RaceStarts = 131,
                PodiumFinishes = 3,
                PolePositions = 1,
                CareerPoints = 238,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Aston Martin")),
                FirstRace = "Australian Grand Prix 2017",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Charles Leclerc",
                DateOfBirth = new DateOnly(1997, 10, 16),
                Nationality = "Monégasque",
                RaceStarts = 111,
                RaceWins = 5,
                PodiumFinishes = 26,
                PolePositions = 19,
                CareerPoints = 940,
                FastestLaps = 7,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Ferrari")),
                FirstRace = "Australian Grand Prix 2018",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Sergey Sirotkin",
                DateOfBirth = new DateOnly(1995, 8, 27),
                Nationality = "Russian",
                RaceStarts = 21,
                CareerPoints = 1,
                FirstRace = "Australian Grand Prix 2018",
                LastRace = "Abu Dhabi Grand Prix 2018",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Lando Norris",
                DateOfBirth = new DateOnly(1999, 11, 13),
                Nationality = "British",
                RaceStarts = 91,
                PodiumFinishes = 6,
                PolePositions = 1,
                FastestLaps = 5,
                CareerPoints = 452,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("McLaren")),
                FirstRace = "Australian Grand Prix 2019",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Alex Albon",
                DateOfBirth = new DateOnly(1996, 3, 26),
                Nationality = "Thai",
                RaceStarts = 68,
                PodiumFinishes = 2,
                CareerPoints = 208,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Williams")),
                FirstRace = "Australian Grand Prix 2019",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "George Russell",
                DateOfBirth = new DateOnly(1998, 2, 15),
                Nationality = "British",
                RaceStarts = 91,
                RaceWins = 1,
                PodiumFinishes = 10,
                PolePositions = 1,
                FastestLaps = 6,
                CareerPoints = 366,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Mercedes")),
                FirstRace = "Australian Grand Prix 2019",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Robert Kubica",
                DateOfBirth = new DateOnly(1984, 12, 7),
                Nationality = "Polish",
                RaceStarts = 99,
                RaceWins = 1,
                PodiumFinishes = 12,
                PolePositions = 1,
                FastestLaps = 1,
                CareerPoints = 274,
                FirstRace = "Hungarian Grand Prix 2006",
                LastRace = "Italian Grand Prix 2021",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Pietro Fittipaldi",
                DateOfBirth = new DateOnly(1996, 6, 25),
                Nationality = "Brazilian-American",
                RaceStarts = 2,
                FirstRace = "Sakhir Grand Prix 2020",
                LastRace = "Abu Dhabi Grand Prix 2020",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Nicholas Latifi",
                DateOfBirth = new DateOnly(1995, 6, 29),
                Nationality = "Canadian",
                RaceStarts = 61,
                CareerPoints = 9,
                FirstRace = "Austrian Grand Prix 2020",
                LastRace = "Abu Dhabi Grand Prix 2022",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Jack Aitken",
                DateOfBirth = new DateOnly(1995, 9, 23),
                Nationality = "British",
                RaceStarts = 1,
                FirstRace = "Sakhir Grand Prix 2020",
                LastRace = "Sakhir Grand Prix 2020",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Yuki Tsunoda",
                DateOfBirth = new DateOnly(2000, 5, 11),
                Nationality = "Japanese",
                RaceStarts = 51,
                CareerPoints = 46,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("AlphaTauri")),
                FirstRace = "Bahrain Grand Prix 2021",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Nikita Mazepin",
                DateOfBirth = new DateOnly(1999, 3, 2),
                Nationality = "Russian",
                RaceStarts = 21,
                FirstRace = "Bahrain Grand Prix 2021",
                LastRace = "Abu Dhabi Grand Prix 2021",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Mick Schumacher",
                DateOfBirth = new DateOnly(1999, 3, 22),
                Nationality = "German",
                RaceStarts = 43,
                CareerPoints = 12,
                FirstRace = "Bahrain Grand Prix 2021",
                LastRace = "Abu Dhabi Grand Prix 2022",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Zhou Guanyu",
                DateOfBirth = new DateOnly(1999, 5, 30),
                Nationality = "Chinese",
                RaceStarts = 31,
                CareerPoints = 10,
                FastestLaps = 2,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("Alfa Romeo")),
                FirstRace = "Bahrain Grand Prix 2022",
                CreatedTime = DateTime.UtcNow
            });

            context.Drivers.Add(new Driver
            {
                Name = "Nyck de Vries",
                DateOfBirth = new DateOnly(1995, 2, 6),
                Nationality = "Dutch",
                RaceStarts = 10,
                CareerPoints = 2,
                CurrentTeam = context.Teams.FirstOrDefault(t => t.Name.Equals("AlphaTauri")),
                FirstRace = "Italian Grand Prix 2022",
                CreatedTime = DateTime.UtcNow
            });

            context.SaveChanges();
        }
    }
}
