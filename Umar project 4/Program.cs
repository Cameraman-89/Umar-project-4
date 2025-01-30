
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umar_project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee hourlyEmployee = new HourlyEmployee
            {
                Name = "Иван Иванов",
                Position = "Разработчик",
                HourlyRate = 500,
                HoursWorked = 160
            };

            Employee monthlyEmployee = new MonthlyEmployee
            {
                Name = "Мария Петрова",
                Position = "Менеджер",
                MonthlySalary = 40000
            };

            Employee contractEmployee = new ContractEmployee
            {
                Name = "Алексей Сидоров",
                Position = "Консультант",
                ContractAmount = 150000
            };


            Console.WriteLine($"{hourlyEmployee.Name}, {hourlyEmployee.Position}: Зарплата = {hourlyEmployee.CalculateSalary()} рублей");
            Console.WriteLine($"{monthlyEmployee.Name}, {monthlyEmployee.Position}: Зарплата = {monthlyEmployee.CalculateSalary()} рублей");
            Console.WriteLine($"{contractEmployee.Name}, {contractEmployee.Position}: Зарплата = {contractEmployee.CalculateSalary()} рублей");

            Console.ReadKey();
        }
    }
}
