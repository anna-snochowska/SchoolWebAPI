using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly SchoolDataContext _context;

        public TeacherController(SchoolDataContext context)
        {
            _context = context;
        }

        [HttpGet("All")]
        public async Task<ActionResult<List<Teacher>>> GetAllTeachers()
        {
            var teachers = await _context.Teachers.ToListAsync();
            return Ok(teachers);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<List<Teacher>>> GetJustOneTeacher(int teacherId)
        {
            var teacher = await _context.Teachers
                .Where(c => c.TeacherID == teacherId)
                .ToListAsync();
            return Ok(teacher);
        }
    }
}
