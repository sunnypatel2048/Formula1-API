using System.ComponentModel.DataAnnotations;

namespace Formula1.Infrastructure.Models
{
    /// <summary>The Driver Class</summary>
    public class Driver
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>Gets or sets the date of birth.</summary>
        /// <value>The date of birth.</value>
        [Required]
        public DateTime DateOfBirth { get; set; }

        /// <summary>Gets or sets the nationality.</summary>
        /// <value>The nationality.</value>
        [Required]
        public string Nationality { get; set; }

        /// <summary>Gets or sets the race starts.</summary>
        /// <value>The race starts.</value>
        public int RaceStarts { get; set; }

        /// <summary>Gets or sets the race wins.</summary>
        /// <value>The race wins.</value>
        public int RaceWins { get; set; }

        /// <summary>Gets or sets the podium finishes.</summary>
        /// <value>The podium finishes.</value>
        public int PodiumFinishes { get; set; }

        /// <summary>Gets or sets the pole positions.</summary>
        /// <value>The pole positions.</value>
        public int PolePositions { get; set; }

        /// <summary>Gets or sets the fastest laps.</summary>
        /// <value>The fastest laps.</value>
        public int FastestLaps { get; set; }

        /// <summary>Gets or sets the championship wins.</summary>
        /// <value>The championship wins.</value>
        public int ChampionshipWins { get; set; }

        /// <summary>Gets or sets the career points.</summary>
        /// <value>The career points.</value>
        public double CareerPoints { get; set; }

        /// <summary>Gets or sets the current team.</summary>
        /// <value>The current team.</value>
        public Team? CurrentTeam { get; set; }

        /// <summary>Gets or sets the first race.</summary>
        /// <value>The first race.</value>
        [Required]
        public string FirstRace { get; set; }

        /// <summary>Gets or sets the last race.</summary>
        /// <value>The last race.</value>
        public string? LastRace { get; set; }

        /// <summary>Gets or sets the created time.</summary>
        /// <value>The created time.</value>
        public DateTime CreatedTime { get; set; }

        /// <summary>Gets or sets the modified time.</summary>
        /// <value>The modified time.</value>
        public DateTime? ModifiedTime { get; set; }
    }
}