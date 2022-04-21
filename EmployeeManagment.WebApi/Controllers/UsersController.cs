using EmployeeManagment.Domain.Models;
using EmployeeManagment.Domain.Repositories;
using EmployeeManagment.WebApi.Controllers.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.WebApi.Controllers
{
    public class UsersController : BaseApiController
    {

        private readonly IUserRepository _userRepository;
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetAll() => Ok(_userRepository.GetAll());
    }
}
