using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double salary;
            string repeat;

            var validation = new Validation();
            do
            {
                Console.WriteLine("\nTax Calculator");
                try
                {
                    Console.Write("Please enter your Age : ");
                    validation.Valid_Age(age = int.Parse(Console.ReadLine()));

                    Console.Write("Please enter your Salary : ");
                    validation.Valid_Salary(salary = double.Parse(Console.ReadLine()));

                    TaxCalculator taxCalculator = new TaxCalculator(age, salary);
                    taxCalculator.CalculateTax();
                    Console.WriteLine("Total Payable Tax : " + taxCalculator._tax);

                    Console.WriteLine("\nDo you want to Calculate Tax again?(Y/N)");
                    repeat = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("**Please enter data in valid format");
                    repeat = "Y";
                }
            } while (repeat == "Y" || repeat == "y");
        }
    }
}
