using EmployeeManagment.Domain.Models;
using EmployeeManagment.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.EFCore.EntityFrameworkCore.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public void AddEmployee(Employee employee)
        {
            _employeeDbContext.Add(employee);
            _employeeDbContext.SaveChanges();
        }

        public List<Employee> GetIndex()
        {
            var employees = _employeeDbContext.Employees.ToList();
            return employees;
        }
    }
}
