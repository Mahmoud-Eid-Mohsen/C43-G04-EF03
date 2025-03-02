using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class PartTimeEmployee:Employee
    {

        public int HourWorked { get; set; }
        public int HourRate { get; set; }
    }
}
