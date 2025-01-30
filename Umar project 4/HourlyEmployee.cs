using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umar_project_4
{
    internal class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
