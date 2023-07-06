using System.ComponentModel.DataAnnotations;

namespace Formula1.Infrastructure.Models
{
    /// <summary>The Team Class</summary>
    public class Team
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>Gets or sets the full name.</summary>
        /// <value>The full name.</value>
        [Required]
        public string FullName { get; set; }

        /// <summary>Gets or sets the base city.</summary>
        /// <value>The base city.</value>
        public string BaseCity { get; set; }

        /// <summary>Gets or sets the base country.</summary>
        /// <value>The base country.</value>
        public string BaseCountry { get; set; }

        /// <summary>Gets or sets the race entered.</summary>
        /// <value>The race entered.</value>
        public int RaceEntered { get; set; }

        /// <summary>Gets or sets the race wins.</summary>
        /// <value>The race wins.</value>
        public int RaceWins { get; set; }

        /// <summary>Gets or sets the podiums.</summary>
        /// <value>The podiums.</value>
        public int Podiums { get; set; }

        /// <summary>Gets or sets the pole positions.</summary>
        /// <value>The pole positions.</value>
        public int PolePositions { get; set; }

        /// <summary>Gets or sets the constructor championships.</summary>
        /// <value>The constructor championships.</value>
        public int ConstructorChampionships { get; set; }

        /// <summary>Gets or sets the website.</summary>
        /// <value>The website.</value>
        public string? Website { get; set; }

        /// <summary>Gets or sets the current chassis.</summary>
        /// <value>The current chassis.</value>
        public string? CurrentChassis { get; set; }

        /// <summary>Gets or sets the current engine provider.</summary>
        /// <value>The current engine provider.</value>
        public EngineProvider? CurrentEngineProvider { get; set; }

        /// <summary>Gets or sets the current team principal.</summary>
        /// <value>The current team principal.</value>
        public TeamPrincipal? CurrentTeamPrincipal { get; set; }

        /// <summary>Gets or sets the created time.</summary>
        /// <value>The created time.</value>
        public DateTime CreatedTime { get; set; }

        /// <summary>Gets or sets the modified time.</summary>
        /// <value>The modified time.</value>
        public DateTime? ModifiedTime { get; set; }
    }
}