using EMS1.Data.Interface;
using EMS1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeesController(IEmployee employee)
        {
            this._employee = employee;
        }


        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(_employee.GetAllEmployees());
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            return Ok(_employee.GetEmployee(id));
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            return Ok(_employee.AddEmployee(employee));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id,Employee employee)
        {
            return Ok(_employee.UpdateEmployee(id ,employee));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            return Ok(_employee.DeleteEmployee(id));
        }
    }
}
