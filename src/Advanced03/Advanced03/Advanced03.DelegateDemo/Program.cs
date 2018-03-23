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

            //var monthlyTax = 
            //    employee.CalculateTax(MonthlyCalculator);
            //var annualTax =
            //    employee.CalculateTax(AnnualCalculator);

            //var monthlyTax =
            //    employee.CalculateTax(x => x * 0.1);
            //var annualTax =
            //    employee.CalculateTax(x => x * 0.1 * 0.9 * 12);

            //var monthlyTax = EmployeeHelpers
            //    .CalculateTax(employee, x => x * 0.1);
            //var annualTax = EmployeeHelpers
            //    .CalculateTax(employee, x => x * 0.1 * 0.9 * 12);

            //var fullName = EmployeeHelpers.GetFullName(employee);

            var monthlyTax =
                employee.CalculateTax(x => x * 0.1);

            var fullName = employee.GetFullName();

            Console.WriteLine($"Monthly Tax: {monthlyTax}");
            Console.WriteLine();
        }

        //public static double MonthlyCalculator(double salary)
        //{
        //    return salary * 0.1;
        //}

        //public static double AnnualCalculator(double salary)
        //{
        //    return salary * 0.1 * 0.9 * 12;
        //}
    }
}
