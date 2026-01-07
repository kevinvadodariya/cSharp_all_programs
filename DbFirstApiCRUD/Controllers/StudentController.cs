using DbFirstApiCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DbFirstApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext db;

        public StudentController(StudentDbContext context)
        {
            this.db = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllStudent()
        {
            var st = await db.StudentInfos.ToListAsync();
            return Ok(st);
        }
        [HttpPost("AddStudent/")]
        public async Task<IActionResult> AddStudent(StudentInfo info)
        {
            var addd = await db.StudentInfos.AddAsync(info);
            await db.SaveChangesAsync();
            return Ok();
        }
        [HttpPut("Editstudent/")]
        public async Task<IActionResult> Editstudent(int id, StudentInfo info)
        {
            if (info.Id != id)
            {
                return BadRequest("id Mismatch");
            }
            db.Entry(info).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok(info);
        }
        [HttpDelete("DeleteStudent/")]
        public async Task<IActionResult> DeleteStudent(int id, StudentInfo info)
        {
            var std = db.StudentInfos.FindAsync(id);
            if (std == null)
            {
                return BadRequest("Student Not Found");
            }
            db.StudentInfos.Remove(std.Result!);
            await db.SaveChangesAsync();
            return Ok("Student Deleted");
        }
        [HttpPatch("EditStudentNameonly/")]
        public async Task<IActionResult> EditStudentNameonly(int id,StudentInfo info,string name)
        {
            var std = db.StudentInfos.FindAsync(id);
            if (std == null)
            {
                return NotFound();
            }
            std.Result.StudName = name;
            await db.SaveChangesAsync();
            return Ok($"Student Name Changed ");

        }
    }
}
