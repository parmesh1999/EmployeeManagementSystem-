using EMS1.Models;

namespace EMS1.Data.Interface
{
    public interface IEmployee
    {
        List<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        String AddEmployee(Employee employee);
        String UpdateEmployee(int id, Employee employee);
        String DeleteEmployee(int id);
    }
}
