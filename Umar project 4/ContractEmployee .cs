using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umar_project_4
{
    internal class ContractEmployee : Employee
    {
        public decimal ContractAmount { get; set; }

        public override decimal CalculateSalary()
        {
            return ContractAmount;
        }
    }
}
