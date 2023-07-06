using System.ComponentModel.DataAnnotations;

namespace Formula1.Infrastructure.Models
{
    /// <summary>The TeamPrincipal Class</summary>
    public class TeamPrincipal
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }

        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Required]
        public string Name { get; set; }

        /// <summary>Gets or sets the created time.</summary>
        /// <value>The created time.</value>
        public DateTime CreatedTime { get; set; }

        /// <summary>Gets or sets the modified time.</summary>
        /// <value>The modified time.</value>
        public DateTime? ModifiedTime { get; set; }
    }
}