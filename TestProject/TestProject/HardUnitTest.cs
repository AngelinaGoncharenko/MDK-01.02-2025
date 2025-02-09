using System.Collections.Generic;
using System;

namespace TestProject
{
    public class HardUnitTest
    {
        private readonly Calculator _calculator = new();

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-1, 1, 0)]
        [InlineData(0, 0, 0)]
        public void Add_MultipleInputs_ReturnsCorrectSum(int a, int b, int expected)
        {
            int result = _calculator.Add(a, b);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Divide_DivideByZero_ThrowsException()
        {
            double a = 10;
            double b = 0;

            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 6, 8 }, true)]
        [InlineData(new int[] { 1, 3, 5, 7 }, false)]
        [InlineData(new int[] { 2, 4, 6, 7 }, false)]
        public void IsEven_MultipleNumbers_ReturnsCorrectResults(int[] numbers, bool expectedAllEven)
        {
            List<bool> results = [];
            foreach (int number in numbers)
            {
                results.Add(_calculator.IsEven(number));
            }

            bool allEven = results.TrueForAll(x => x);
            Assert.Equal(expectedAllEven, allEven);
        }

        [Fact]
        public void Divide_LargeNumbers_ReturnsCorrectDecimalValue()
        {
            double a = 1000000000000000;
            double b = 3;

            double result = _calculator.Divide(a, b);

            Assert.Equal(a / b, result, 10);
        }

        [Fact]
        public void Add_IntegerMaxValue_Overflow()
        {
            int a = int.MaxValue;
            int b = 1;

            try
            {
                int result = _calculator.Add(a, b);

            }
            catch (OverflowException)
            {}
            catch (Exception)
            {
                Assert.Fail("Unexpected Exception");
            }
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            int a = -5;
            int b = -3;

            int result = _calculator.Add(a, b);

            Assert.Equal(-8, result);
        }
    }
}
