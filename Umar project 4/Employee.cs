using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umar_project_4
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public abstract decimal CalculateSalary();
    }
}
