using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> students = new List<Student> {

        new Student{id=1,StudentName="Kevin",FatherName="Viththalbhai",Rollno=12},
        new Student{ id=2,StudentName="Meet",FatherName="Sanjaybhai",Rollno=8} 
        };

        [HttpGet]//get all recoards
        public async Task<ActionResult<List<Student>>> Get()
        {
            return Ok(students);
        }


        [HttpGet("GetStudentbyid/{id}")]//get by id
        public async Task<IActionResult> GetStudentbyid([FromRoute] int id)
        {
            Student? std = students.Find(i => i.id == id);
            return Ok(std);
        }


        //[HttpGet("GetbyRollno/{rollno}")]//get by roll no
        //public async Task<ActionResult<Student>> GetbyRollno([FromQuery] int rollno)
        //{
        //    Student? st = students.Find(a => a.Rollno == rollno);
        //    return Ok(st);
        //}


        //[HttpPost]
        //public async Task<Student> AddData([FromQuery] Student value)
        //{
        //    return students.Add(value);
        //}



        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> Deletebyid([FromQuery] int id)
        {
            Student? s = students.Find(i => i.id == id);

            return Ok(students.Remove(s));
        }
    }
}
