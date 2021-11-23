using EmployeeManagment.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Repositories
{
    public interface IEmployeeRepository
    {
        void AddEmployee(Models.Employee employee);
        List<Employee> GetIndex();
    }
}
