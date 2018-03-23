using System;

namespace Advanced03.DelegateDemo
{
    public static class EmployeeHelpers
    {
        public static double CalculateTax
            (Employee employee, Func<double,double> calculateTax)
        {
            var tax = calculateTax(employee.Salary);
            return tax;
        }

        public static string GetFullName(Employee employee)
        {
            return $"{employee.FirstName} {employee.LastName}";
        }
    }
}
