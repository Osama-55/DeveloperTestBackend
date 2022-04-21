using EmployeeManagment.Domain.Models;
using EmployeeManagment.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.EFCore.EntityFrameworkCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _userDbContext;
        public async Task<IEnumerable<AppUser>> GetAll()
        {
            return await _userDbContext.Users.ToListAsync();
        }
    }
}
