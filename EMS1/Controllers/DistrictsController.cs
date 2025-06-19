using EMS1.Data;
using EMS1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly AppDbContext _context;
        public DistrictsController(AppDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public IActionResult GetDistricts()
        {
            return Ok(_context.Districts.ToList());

        }

        [HttpPost]
        public IActionResult AddDistrict(District district)
        {
            _context.Districts.Add(district);
            _context.SaveChanges();
            return Ok("District Added Successfully!"+district);
        }

        [HttpPut]
        public IActionResult UpdateDistrict(District district)
        {
            _context.Districts.Update(district);
            _context.SaveChanges();
            return Ok("District updated Successfully!");
        }

        [HttpDelete]
        public IActionResult DeleteDistrict(int id)
        {
            var district = _context.Districts.Find(id);
            _context.Districts.Remove(district);
            _context.SaveChanges();
            return Ok("District Deleted successfully!");
        }

    }
}
