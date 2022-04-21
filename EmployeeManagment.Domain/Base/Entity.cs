using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagment.Domain.Base
{
    public abstract class Entity : IHaveCreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
