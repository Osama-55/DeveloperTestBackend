using EmployeeManagment.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.EFCore.EntityFrameworkCore
{
    public class UserDbContext : DbContext
    {
        protected UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}
