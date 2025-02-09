using Xunit;

namespace TestProject
{
    public class EasyUnitTest
    {
        private readonly Calculator _calculator = new();

        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            int a = 5;
            int b = 3;

            int result = _calculator.Add(a, b);

            Assert.Equal(8, result);
        }

        [Fact]
        public void Divide_PositiveNumbers_ReturnsQuotient()
        {
            double a = 10;
            double b = 2;

            double result = _calculator.Divide(a, b);

            Assert.Equal(5, result);
        }

        [Fact]
        public void IsEven_EvenNumber_ReturnsTrue()
        {
            int number = 4;

            bool result = _calculator.IsEven(number);

            Assert.True(result);
        }
    }
}
