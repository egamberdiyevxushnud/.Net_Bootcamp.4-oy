using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void AddTest()
        {
            Calculator calculator = new Calculator();

            var result = calculator.add(2, 3);

            Assert.Equal(5, result);

        }
        [Fact]
        public void Subtract()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Subtract(10, 5);

            Assert.Equal(5, result);
        }
        [Fact]
        public void Multiply()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Multiply(2, 3);

            Assert.Equal(6, result);
        }
        [Fact] 
        public void Divide()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Divide(10, 5);

            Assert.Equal(2,result);
        }
    }
}
