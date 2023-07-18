using Formula1.Infrastructure;
using Formula1.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formula1.Controllers
{
    /// <summary>The TeamsController Class</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly F1DataContext _context;

        /// <summary>Initializes a new instance of the <see cref="TeamsController" /> class.</summary>
        /// <param name="dataContext">The data context.</param>
        public TeamsController(F1DataContext dataContext)
        {
            _context = dataContext;
        }

        /// <summary>Gets all the teams.</summary>
        /// <returns>List of all teams</returns>
        [HttpGet]
        public async Task<ActionResult<List<Team>>> Get()
        {
            var teams = await _context.Teams.Include(t => t.CurrentTeamPrincipal)
                                            .Include(t => t.CurrentEngineProvider)
                                            .ToListAsync();
            return Ok(teams);
        }

        /// <summary>Gets the team by specified identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Team by specified identifier</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> Get(int id)
        {
            var team = await _context.Teams.Include(t => t.CurrentTeamPrincipal)
                                            .Include(t => t.CurrentEngineProvider)
                                            .FirstOrDefaultAsync(t => t.Id == id);

            if (team == null)
            {
                return BadRequest("Team not found.");
            }

            return Ok(team);
        }
    }
}
