using System;

namespace Advanced03.DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                Id = 1,
                FirstName = "trendov",
                Salary = 1000
            };
            var monthlyTax =
                employee.CalculateTax(x => x * 0.1);
            var annualTax =
                employee.CalculateTax(x=>x * 0.1 * 0.9 * 12);

            Console.WriteLine($"Monthly Tax: {monthlyTax}");
            Console.WriteLine($"Annual Tax {annualTax}");
        }
    }
}
