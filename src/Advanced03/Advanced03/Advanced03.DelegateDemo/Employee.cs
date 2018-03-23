using System;

namespace Advanced03.DelegateDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        //public string GetFullName()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        //public double CalculateTax(Func<double,double> calculateTax)
        //{
        //    var tax = calculateTax(Salary);
        //    return Salary;
        //}

        //public double CalculateTax(TaxCalculator calculateTax)
        //{
        //    var tax = calculateTax(Salary);
        //    return Salary;
        //}

        //public double CalculateMonthlyTax()
        //{
        //    return Salary * 0.1;
        //}
        //public double CalculateAnnualTax()
        //{
        //    return Salary * 0.1 * 0.9 * 12;
        //}
    }
}
