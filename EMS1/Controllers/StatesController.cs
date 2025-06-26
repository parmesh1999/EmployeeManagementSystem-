using EMS1.Data.Interface;
using EMS1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly IState _state;
        public StatesController(IState state) 
        {
            this._state = state;
        }


        [HttpGet]
        public IActionResult GetAllStates()
        {
            return Ok(_state.GetAllStates());
        }

        [HttpGet("{id}")]
        public IActionResult GetStates(int id) 
        { 
            return Ok(_state.GetState(id));
        }

        [HttpPost]
        public IActionResult AddState(State state)
        {
            return Ok(_state.AddState(state));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateState(int id,State state)
        {
            return Ok(_state.UpdateState(id, state));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteState(int id)
        {
            return Ok(_state.DeleteState(id));
        }
    }
}
