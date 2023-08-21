using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EMDbContext _context;

        public EmployeeRepository(EMDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> GetAll()
        {
            try
            {
                return _context.Employees.ToList();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to retrieve employees.", ex);
            }
        }

        public Employee GetById(int id)
        {
            try
            {
                return _context.Employees.Find(id);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to retrieve employee by ID.", ex);
            }
        }

        public void Add(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to add employee.", ex);
            }
        }

        public void Update(Employee employee)
        {
            try
            {
                _context.Employees.Update(employee);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to update employee."+ex.Message, ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var employee = _context.Employees.Find(id);
                if (employee != null)
                {
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to delete employee.", ex);
            }
        }
    }
}
