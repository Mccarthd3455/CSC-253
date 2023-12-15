using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class Employee
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public Employee()
        {
            EmployeeName = "";
            EmployeeNumber = 0;

        }
    }
}
