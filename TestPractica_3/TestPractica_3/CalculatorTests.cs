using System;

namespace TestPractica_3
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Multiply(int a, int b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }

    [Collection("CalculatorCollection")]
    public class CalculatorTests
    {
        private Calculator _calculator = new();

        [Fact]
        public void Add_PositiveNumbers_ReturnsSum() => Assert.Equal(5, _calculator.Add(2, 3));

        [Fact]
        public void Subtract_PositiveNumbers_ReturnsDifference() => Assert.Equal(1, _calculator.Subtract(3, 2));

        [Fact]
        public void Multiply_PositiveNumbers_ReturnsProduct() => Assert.Equal(6, _calculator.Multiply(2, 3));

        [Fact]
        public void Divide_PositiveNumbers_ReturnsQuotient() => Assert.Equal(2.5, _calculator.Divide(5, 2));

        [Fact]
        public void Divide_DivideByZero_ThrowsException() => Assert.Throws<DivideByZeroException>(() => _calculator.Divide(5, 0));
    }
}
