using System;

namespace Advanced03.DelegateDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public double Salary { get; set; }

        public double CalculateTax(Func<double, double> calculateTax)
        {
            double tax = calculateTax(Salary);
            return tax;
        }
    }
}
