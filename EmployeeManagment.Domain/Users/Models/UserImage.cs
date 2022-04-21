using EmployeeManagment.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Users.Models
{
    public class UserImage : Entity
    {
        public string ImageName { get; set; }
        public bool IsMainImage { get; set; }
    }
}
