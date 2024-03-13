using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [Fact]
        public void AddTest()
        {

            var result = calculator.add(2, 3);

            Assert.Equal(5, result);

        }
        [Fact]
        public void Subtract()
        {
            var result = calculator.Subtract(10, 5);

            Assert.Equal(5, result);
        }
        [Fact]
        public void Multiply()
        {
            var result = calculator.Multiply(2, 3);

            Assert.Equal(6, result);
        }
        [Fact] 
        public void Divide()
        {
            var result = calculator.Divide(10, 5);

            Assert.Equal(2,result);
        }
    }
}
