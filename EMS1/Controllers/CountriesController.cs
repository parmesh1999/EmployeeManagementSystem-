using EMS1.Data.Interface;
using EMS1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountry _country;

        public CountriesController(ICountry country)
        {
            _country = country;
        }
        [HttpGet]
        public IActionResult GetAllCountries()
        {
            return Ok(_country.GetAllCountries());
        }

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id) 
        {
            return Ok(_country.GetCountry(id));
        }


        [HttpPost]
        public IActionResult AddCountry(Country country)
        { 
            return Ok(_country.AddCountry(country));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCountry(int id,Country country) 
        { 
            return Ok(_country.UpdateCountry(id,country));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        { 
            return Ok(_country.DeleteCountry(id));
        }
    }
}
