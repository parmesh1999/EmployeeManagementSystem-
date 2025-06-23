using EMS1.Models;

namespace EMS1.Data.Interface
{
    public interface IDistrict
    {
        List<District> GetAllDistricts();
        String AddDistrict(District district);
        String UpdateDistrict(District district);
        String DeleteDistrict(int id);
    }
}
