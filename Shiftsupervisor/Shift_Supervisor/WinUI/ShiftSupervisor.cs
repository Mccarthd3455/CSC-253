using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI
{
    class ShiftSupervisor: Employee
    {
        public ShiftSupervisor()
        {
            AnnualSalary = 0.0;
            AnnualProductionBonus = 0.0;
        }
        public double AnnualSalary { get; set;}
        public double AnnualProductionBonus { get; set;}
    }
}
