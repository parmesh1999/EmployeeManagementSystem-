using EMS1.Models;

namespace EMS1.Data.Interface
{
    public interface IDistrict
    {
        List<District> GetAllDistricts();
        District GetDistrict(int id);
        String AddDistrict(District district);
        String UpdateDistrict(int id, District district);
        String DeleteDistrict(int id);
    }
}
