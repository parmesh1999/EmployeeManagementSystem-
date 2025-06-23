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

        [HttpPost]
        public IActionResult AddState(State state)
        {
            return Ok(_state.AddState(state));
        }

        [HttpPut]
        public IActionResult UpdateState(State state)
        {
            return Ok(_state.UpdateState(state));
        }

        [HttpDelete]
        public IActionResult DeleteState(int id)
        {
            return Ok(_state.DeleteState(id));
        }



    }
}
