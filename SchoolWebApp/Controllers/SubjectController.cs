using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly SchoolDataContext _context;

        public SubjectController(SchoolDataContext context)
        {
            _context = context;
        }

        [HttpGet("All")]   
        public async Task<ActionResult<List<Subject>>> GetAllSubject()
        {
            var subjects = await _context.Subjects.ToListAsync();

            return Ok(subjects);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<List<Teacher>>> GetJustOneSubject(int subjectId)
        {
            var subject = await _context.Subjects
                .Where(s => s.SubjectID == subjectId)
                .ToListAsync();
            return Ok(subject);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateSubject(Subject request)
        {
            await _context.Subjects.AddAsync(request);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetJustOneSubject), new { id = request.SubjectID }, request);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult> DeleteSubject(int id)
        {
            var subjectToDelete = await _context.Subjects.FindAsync(id);
            if (subjectToDelete == null) return BadRequest();

            _context.Subjects.Remove(subjectToDelete);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

