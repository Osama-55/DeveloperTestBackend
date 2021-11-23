using EmployeeManagment.Domain.Models;
using EmployeeManagment.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.WebApi.Controllers
{
    [Route("employee")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _empolyeeRepository;
        public EmployeesController(IEmployeeRepository empolyeeRepository)
        {
            _empolyeeRepository = empolyeeRepository;
        }

        [HttpPost]
        public void AddEmployee(Employee employee)
        {
            _empolyeeRepository.AddEmployee(employee);
        }

        [HttpGet]
        public List<Employee> GetFromDb()
        {
            var employees = _empolyeeRepository.GetIndex();
            return employees;
        }


        [HttpGet("Index")]
        public List<Employee> Index()
        {
            var employees = new List<Employee>()
            {
                new Employee{ Id = 1, FullName = "Mark Keeling", PhoneNumber ="965522022"},
                new Employee{ Id = 2, FullName = "Destiny Hays", PhoneNumber ="685255620"},
                new Employee{ Id = 3, FullName = "Lorcan Harrington", PhoneNumber ="454751215"},
                new Employee{ Id = 4, FullName = "Alec Townsend", PhoneNumber ="582256325"},
                new Employee{ Id = 5, FullName = "Jethro Cortes", PhoneNumber ="215525555"},
                new Employee{ Id = 6, FullName = "Dru Black", PhoneNumber ="126582825"},
                new Employee{ Id = 7, FullName = "Claudia Barker", PhoneNumber ="784446225"},
                new Employee{ Id = 8, FullName = "Kunal Farrell", PhoneNumber ="576652555"},
                new Employee{ Id = 9, FullName = "Shaun Burton", PhoneNumber ="787522552"},
            };

            return employees;
        }


    }
}
