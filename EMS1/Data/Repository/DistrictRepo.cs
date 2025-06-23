using EMS1.Data.Interface;
using EMS1.Models;

namespace EMS1.Data.Repository
{
    public class DistrictRepo : IDistrict
    {
        private readonly AppDbContext _context;
        public DistrictRepo(AppDbContext _context) 
        { 
                this._context = _context;
        }

        public List<District> GetAllDistricts()
        {
            return _context.Districts.ToList();
        }

        public string AddDistrict(District district)
        {
            _context.Districts.Add(district);
            _context.SaveChanges();
            return "District Added Successfully";
        }

        public string UpdateDistrict(District district)
        {
            _context.Districts.Update(district);
            _context.SaveChanges();
            return "District updated successfully!";
        }

        public string DeleteDistrict(int id)
        {
            var district = _context.Districts.Find(id);
            if (district != null)
            {
                _context.Districts.Remove(district);
                _context.SaveChanges();
                return "District Deleted Successfully!";
            }
            return "District not found!";
        }
       
    }
}
