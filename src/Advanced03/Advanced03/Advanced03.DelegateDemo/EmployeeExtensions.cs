using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced03.DelegateDemo
{
    public static class EmployeeExtensions
    {
        public static double CalculateTax
            (this Employee employee, Func<double, double> calculateTax)
        {
            var tax = calculateTax(employee.Salary);
            return tax;
        }

        public static string GetFullName(this Employee employee)
        {
            return $"{employee.FirstName} {employee.LastName}";
        }
    }
}
