using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umar_project_4
{
    internal class MonthlyEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
