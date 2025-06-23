using EMS1.Data.Interface;
using EMS1.Models;

namespace EMS1.Data.Repository
{
    public class CountryRepo : ICountry
    {
        private readonly AppDbContext _context;
        
        public CountryRepo(AppDbContext context)
        {
            _context = context;
        }

        public List<Country> GetAllCountries()
        {
            return _context.Countries.ToList();
        }
        public String AddCountry(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
            return "Country Added Successfully!";
        }

        public string UpdateCountry(int id, Country country)
        {
            _context.Countries.Update(country);
            _context.SaveChanges();
            return "Country Updated Successfully!";
        }

        public string DeleteCountry(int id)
        {
            var country = _context.Countries.Find(id);
            if (country != null)
            {
                _context.Countries.Remove(country);
                _context.SaveChanges();
                return "Country Deleted Successfully!";
            }
            return "Country not Found!";
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Find(id);
        }
    }
}
