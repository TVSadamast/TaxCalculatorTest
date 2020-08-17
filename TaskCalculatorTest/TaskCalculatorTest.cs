using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel.DataAnnotations;
using TaxCalculator;

namespace TaskCalculatorTest
{
    [TestClass]
    public class TaskCalculatorTest
    {
        Validation validation = new Validation();

        [TestMethod]
        public void Valid_Input_Age()
        {
            //expected errorless inputs should be greater then 0, numeric value, without whitespace or not null value.
            int age = 10;
            validation.Valid_Age(age);
        }

        [TestMethod]
        public void Valid_Input_Salary()
        {
            //expected errorless Salary Input should be greater then 0, numeric value(with floting point or without floting point), without whitespace or not null value.
            int salary = 1000000;
            validation.Valid_Salary(salary);
        }

        [TestMethod]
        public void Invalid_InputAge_ShouldThrowArgumentException()
        {
            int age = -10;
            validation.Valid_Age(age);
        }

        [TestMethod]
        public void Invalid_InputAge_ShouldThrowArgumentNullException()
        {
            string age = "";
            validation.Valid_Age(int.Parse(age));
            //this will fire FormatException because the method accepts only int parameter and here string type parameter is passed for testing purpose.
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void Invalid_InputSalary_ShouldThrowArgumentException()
        {
            int salary = -1000000;
            validation.Valid_Salary(salary);
        }

        [TestMethod]
        public void Invalid_InputSalary_ShouldThrowArgumentNullException()
        {
            string salary = "";
            validation.Valid_Salary(double.Parse(salary));
            //this will fire FormatException because the method accepts only int parameter and here string type parameter is passed for testing purpose.
        }
    }
}
