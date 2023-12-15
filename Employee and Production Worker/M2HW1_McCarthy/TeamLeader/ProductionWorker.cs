using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClassLibrary
{
    public class ProductionWorker:Employee
    {
        public int ShiftNumber { get; set; }
        public double HourlyPay { get; set; }
        public ProductionWorker()
        {
            ShiftNumber = 0;
            HourlyPay = 0.0;
        }   
    }
}
