using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Company:BaseEntity
    {
        public string Name { get; set; } = null!;
        public virtual ICollection<Employee> Employees { get; set; } = null!;
    }
}
