using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolLevelController : ControllerBase
    {
        private readonly SchoolDataContext _context;

        public SchoolLevelController(SchoolDataContext context)
        {
            _context = context;
        }

        [HttpGet("All")]
        public async Task<ActionResult<List<SchoolLevel>>> GetAllLevels()
        {
            var levels = await _context.SchoolLevels
                .ToListAsync();

            return Ok(levels);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(SchoolLevel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<SchoolLevel>>> GetJustOneLevel(int id)
        {
            var level = await _context.SchoolLevels
                .FindAsync(id);

            return level== null ? NotFound() : Ok(level);
        }
    }
}
