using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1,2,3)]
        [InlineData(4,5,9)]
        [InlineData(7,8,15)]
        public void AddTest(double a, double b, double res)
        {
            Calculator calculator = new Calculator();

            var result = calculator.add(a,b);

            Assert.Equal(res, result);

        }
        [Theory]
        [InlineData(10,5,5)]
        [InlineData(11,10,1)]
        [InlineData(16,11,5)]
        public void Subtract(double a, double b, double res)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Subtract(a,b);

            Assert.Equal(res, result);
        }
        [Theory]
        [InlineData(2,5,10)]
        [InlineData(3,5,15)]
        [InlineData(8,2,16)]
        public void Multiply(double a, double b, double res)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Multiply(a,b);

            Assert.Equal(res, result);
        }
        [Theory]
        [InlineData(10,5,2)]
        [InlineData(40,10,4)]
        [InlineData(45,3,15)]
        public void Divide(double a, double b, double res)
        {
            Calculator calculator = new Calculator();

            var result = calculator.Divide(a,b);

            Assert.Equal(res ,result);
        }
    }
}
