using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculator
{
    public class TaxCalculator
    {
        #region private readonly variables
        private readonly int _age;
        private readonly double _salary;
        private readonly double _below60 = 5, _61to80 = 5, _above80 = 20;
        #endregion

        public double _tax = 0;

        public TaxCalculator(int age, double salary)
        {
            _age = age;
            _salary = salary;
        }

        public double CalculateTax()
        {
            //condition will be true if age is 60 or below 60.
            if (_age <= 60)
            {
                if (_salary <= 250000)
                {
                    _tax = 0;
                }
                else if (_salary > 250000 && _salary <= 500000)
                {
                    _tax = (_salary * _below60) / 100;
                }
                else if (_salary > 500000 && _salary <= 1000000)
                {
                    _tax = 12500 + ((_salary - 500000) * 20) / 100;
                }
                else if (_salary > 1000000)
                {
                    _tax = 112500 + ((_salary - 1000000) * 30) / 100;
                }
            }

            //condition will be true if age is between 61 to 80.
            else if (60 < _age && _age <= 80)
            {
                if (_salary <= 300000)
                {
                    _tax = 0;
                }
                else if (_salary > 300000 && _salary <= 500000)
                {
                    _tax = (_salary * _61to80) / 100;
                }
                else if (_salary > 500000 && _salary <= 1000000)
                {
                    _tax = 10000 + ((_salary - 500000) * 20) / 100;
                }
                else if (_salary > 1000000)
                {
                    _tax = 110000 + ((_salary - 1000000) * 30) / 100;
                }
            }

            //condition will be true if age is 81 or above 80.
            else if (_age > 80)
            {
                if (_salary <= 500000)
                {
                    _tax = 0;
                }
                else if (_salary > 500000 && _salary <= 1000000)
                {
                    _tax = (_salary * _above80) / 100;
                }
                else if (_salary > 1000000)
                {
                    _tax = 100000 + ((_salary - 1000000) * 30) / 100;
                }
            }

            else { _tax = 0; }

            return _tax;
        }
    }
}
