using EMS1.Data;
using EMS1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StatesController(AppDbContext _context) 
        {
            this._context = _context; 
        }

        [HttpGet]
        public IActionResult GetAllState()
        {
            return Ok(_context.States.ToList());
        }

        [HttpPost]
        public IActionResult AddState(State state)
        {
            _context.States.Add(state);
            _context.SaveChanges();
            return Ok("State Added successfully");               

        }

        [HttpPut]
        public IActionResult UpdateState(State state)
        {
            _context.States.Update(state);
            _context.SaveChanges();
            return Ok("State Updated Successfully!");
        }

        [HttpDelete]
        public IActionResult DeleteState(int id)
        {
            var state = _context.States.Find(id);
            _context.States.Remove(state);
            _context.SaveChanges();
            return Ok("State Deleted Successfullty!");
        }
    }
}
