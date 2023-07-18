using Formula1.Infrastructure;
using Formula1.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formula1.Controllers
{
    /// <summary>The DriversController Class</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly F1DataContext _context;

        /// <summary>Initializes a new instance of the <see cref="DriversController" /> class.</summary>
        /// <param name="dataContext">The data context.</param>
        public DriversController(F1DataContext dataContext)
        {
            _context = dataContext;
        }

        /// <summary>Gets all the drivers.</summary>
        /// <returns>List of all drivers</returns>
        [HttpGet]
        public async Task<ActionResult<List<Driver>>> Get()
        {
            var drivers = await _context.Drivers.Include(d => d.CurrentTeam)
                                                .Include(d => d.CurrentTeam.CurrentTeamPrincipal)
                                                .Include(d => d.CurrentTeam.CurrentEngineProvider)
                                                .ToListAsync();
            return Ok(drivers);
        }

        /// <summary>Gets the driver by specified identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Driver by specified identifier</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Driver>> Get(int id)
        {
            var driver = await _context.Drivers.Include(d => d.CurrentTeam)
                                                .Include(d => d.CurrentTeam.CurrentTeamPrincipal)
                                                .Include(d => d.CurrentTeam.CurrentEngineProvider)
                                                .FirstOrDefaultAsync(d => d.Id == id);

            if (driver == null)
            {
                return BadRequest("Driver not found.");
            }
            
            return Ok(driver);
        }
    }
}
