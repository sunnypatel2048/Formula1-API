using Formula1.Infrastructure;
using Formula1.Infrastructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Formula1.Controllers
{
    /// <summary>The EngineProvidersController Class</summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EngineProvidersController : ControllerBase
    {
        private readonly F1DataContext _context;

        /// <summary>Initializes a new instance of the <see cref="EngineProvidersController" /> class.</summary>
        /// <param name="dataContext">The data context.</param>
        public EngineProvidersController(F1DataContext dataContext)
        {
            _context = dataContext;
        }

        /// <summary>Gets all the engine providers.</summary>
        /// <returns>List of all engine providers</returns>
        [HttpGet]
        public async Task<ActionResult<List<EngineProvider>>> Get()
        {
            var engineProviders = await _context.EngineProviders.ToListAsync();
            return Ok(engineProviders);
        }

        /// <summary>Gets the engine provider by specified identifier.</summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Engine Provider by specified identifier</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<EngineProvider>> Get(int id)
        {
            var engineProvider = await _context.EngineProviders.FindAsync(id);

            if (engineProvider == null)
            {
                return BadRequest("Engine Provider not found.");
            }

            return Ok(engineProvider);
        }
    }
}
