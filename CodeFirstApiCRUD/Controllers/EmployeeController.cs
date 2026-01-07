using CodeFirstApiCRUD.DataContext;
using CodeFirstApiCRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext db;
        public EmployeeController(EmployeeDbContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            var emp = await db.EmployeeInfo.ToListAsync();
            return Ok(emp);
        }


        [HttpGet("GetById/")]
        public async Task<IActionResult> GetById(int id)
        {
            var emp = await db.EmployeeInfo.FindAsync(id);
            if (emp != null)
            {
                return Ok(emp);
            }
            return BadRequest("Employee Not Found");
        }

        [HttpPost("AddEmployee/")]
        public async Task<IActionResult> AddEmployee(Employee info)
        {
            db.EmployeeInfo.AddAsync(info);
            await db.SaveChangesAsync();
            return Ok("Employee added");
        }
        [HttpPut("EditEmployee/")]
        public async Task<IActionResult> EditEmployee(int id, Employee info)
        {

            if (info.emp_id != id)
            {
                return NotFound();
            }
            db.Entry(info).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return Ok("Employee Updated");
        }
        [HttpDelete("DeleteEmployee/")]
        public async Task<IActionResult> DeleteEmployee(int id, Employee emp)
        {
            var employee = db.EmployeeInfo.FindAsync(id);
            db.EmployeeInfo.Remove(employee.Result);
            await db.SaveChangesAsync();
            return Ok("Employee Deleted");
        }
        [HttpPatch("editName/")]
        public async Task<IActionResult>editName(int id,string name)
        {
            var data = await db.EmployeeInfo.FindAsync(id);
            if (data == null)
            {
                return BadRequest("Employee not Found");
            }
            data.EmployeeName = name;
            await db.SaveChangesAsync();
            return Ok("Name Changes Done");
        }
    }
}
