using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public abstract class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int EmployeeId { get; set; }
        public string Email { get; set; }= string.Empty;
        public string Adress { get; set; } = string.Empty;
    }
}
