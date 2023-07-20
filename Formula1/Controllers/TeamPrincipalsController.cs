using Formula1.Infrastructure;
using Formula1.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formula1.Controllers
{
    /// <summary>The TeamPrincipalsController Class</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TeamPrincipalsController : ControllerBase
    {
        private readonly F1DataContext _context;

        /// <summary>Initializes a new instance of the <see cref="TeamPrincipalsController" /> class.</summary>
        /// <param name="dataContext">The data context.</param>
        public TeamPrincipalsController(F1DataContext dataContext)
        {
            _context = dataContext;
        }

        /// <summary>Gets all the team principals.</summary>
        /// <returns>List of all team principals</returns>
        [HttpGet]
        public async Task<ActionResult<List<TeamPrincipal>>> Get()
        {
            var teamPrincipals = await _context.TeamPrincipals.ToListAsync();
            return Ok(teamPrincipals);
        }

        /// <summary>Gets the team principal by specified identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Team Principal by specified identifier</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamPrincipal>> Get(int id)
        {
            var teamPrincipal = await _context.TeamPrincipals.FindAsync(id);

            if (teamPrincipal == null)
            {
                return BadRequest("Team Principal not found.");
            }

            return Ok(teamPrincipal);
        }

        /// <summary>Adds the team principal.</summary>
        /// <param name="request"></param>
        [HttpPost]
        public async Task<IActionResult> AddTeamPrincipal(TeamPrincipal request)
        {
            request.CreatedTime = DateTime.UtcNow;

            _context.TeamPrincipals.Add(request);
            await _context.SaveChangesAsync();
            return Ok();
        }

        /// <summary>Updates the team principal.</summary>
        /// <param name="request">The request.</param>
        [HttpPut]
        public async Task<IActionResult> UpdateTeamPrincipal(TeamPrincipal request)
        {
            var teamPrincipal = await _context.TeamPrincipals.FindAsync(request.Id);

            if (teamPrincipal == null)
            {
                return BadRequest("Team Principal not found.");
            }

            teamPrincipal.Name = request.Name;
            teamPrincipal.ModifiedTime = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return Ok();
        }

        /// <summary>Deletes the team principal by specified identifier.</summary>
        /// <param name="id">The identifier.</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var teamPrincipal = await _context.TeamPrincipals.FindAsync(id);

            if (teamPrincipal == null)
            {
                return BadRequest("Team Principal not found");
            }

            _context.TeamPrincipals.Remove(teamPrincipal);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
