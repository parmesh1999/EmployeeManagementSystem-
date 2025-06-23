using EMS1.Data.Interface;
using EMS1.Models;

namespace EMS1.Data.Repository
{
    public class EmployeeRepo : IEmployee
    {
        private readonly AppDbContext _context;
        public EmployeeRepo(AppDbContext context) 
        {
            _context = context;
        }


        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public string AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return "Employee Added Successfully!";
        }

        public string UpdateEmployee(int id, Employee employee)
        {

            _context.Employees.Update(employee);
            _context.SaveChanges ();
            return "Employee Updated Successfully!";
        }

        public string DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
                return "Employee Deleted successfully!";
            }
            return "Employee not found!";
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.Find(id);
        }
    }
}
