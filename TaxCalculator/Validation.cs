using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class Validation
    {
        public bool Valid_Age(int age)
        {
            if (String.IsNullOrWhiteSpace(age.ToString()))
                throw new ArgumentNullException("Age Can't be Null or have White Spaces");
                //Console.WriteLine("Age Can't be Null or have White Spaces");
            else if (age <= 0)
                throw new ArgumentException("Age Can't be less then 0");
                //Console.WriteLine("Age Can't be less then 0");
            else
                return true;
        }

        public bool Valid_Salary(double salary)
        {
            if (String.IsNullOrWhiteSpace(salary.ToString()))
                throw new ArgumentNullException("Salary Can't be Null or have White Spaces");
                //Console.WriteLine("Salary Can't be Null or have White Spaces");
            else if (salary < 0)
                throw new ArgumentException("Salary Can't be less then 0");
                //Console.WriteLine("Salary Can't be less then 0");
            else
                return true;
        }
    }
}
