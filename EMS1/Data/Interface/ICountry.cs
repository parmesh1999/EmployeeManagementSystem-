using EMS1.Models;
using Microsoft.CodeAnalysis.Options;

namespace EMS1.Data.Interface
{
    public interface ICountry
    {
        List<Country> GetAllCountries();
        String AddCountry(Country country);
        String UpdateCountry(int id,Country country);
        String DeleteCountry(int id);
        Country GetCountry(int id);
    }
}
