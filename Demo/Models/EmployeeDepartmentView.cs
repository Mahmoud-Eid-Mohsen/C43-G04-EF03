using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
 public  class EmployeeDepartmentView
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;

        public int DepartmwntId { get; set; }
        public string DepartmwntName { get; set; } = string.Empty;
    }


}
