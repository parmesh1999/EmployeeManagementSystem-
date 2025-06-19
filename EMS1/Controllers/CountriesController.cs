using EMS1.Data;
using EMS1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CountriesController(AppDbContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult GetCountries()
        {
            return Ok(_context.Countries.ToList());
        }
        [HttpPost]
        public IActionResult AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCountry), new { id = country.Id }, country);
        }

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
           return Ok(_context.Countries.Find(id));
        }

        [HttpPut]
        public IActionResult UpdateCountry(Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
            return Ok("Country Update Successfully!");
        }

        [HttpDelete]
        public IActionResult DeleteCountry(int id)
        {
            var country = _context.Countries.Find(id);
            _context.Countries.Remove(country);
            _context.SaveChanges();
            return Ok("Country Deleted Successfully!");
        }

    }
}
