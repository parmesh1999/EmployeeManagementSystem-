using EMS1.Data.Interface;
using EMS1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly IDistrict _district;
        public DistrictsController(IDistrict district)
        { 
            this._district = district;
        }


        [HttpGet]
        public IActionResult GetAllDistricts()
        {
            return Ok(_district.GetAllDistricts());
        }

        [HttpGet("{id}")]
        public IActionResult GetDistrict(int id)
        {
            return Ok(_district.GetDistrict(id));
        }

        [HttpPost]
        public IActionResult AddDistrict(District district)
        { 
            return Ok(_district.AddDistrict(district));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDistrict(int id, District district)
        {
            return Ok(_district.UpdateDistrict(id, district));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDistrict(int id)
        {
            return Ok(_district.DeleteDistrict(id));
        }
    }
}
