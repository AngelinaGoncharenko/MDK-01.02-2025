namespace TestPractica_3
{
    public class EvenNumberChecker
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }

    [Collection("EvenNumberCheckerCollection")]
    public class EvenNumberCheckerTests
    {
        private readonly EvenNumberChecker _checker = new();

        [Fact]
        public void IsEven_PositiveEvenNumber_ReturnsTrue()
        {
            Assert.True(_checker.IsEven(2));
            Assert.True(_checker.IsEven(4));
            Assert.True(_checker.IsEven(6));
        }

        [Fact]
        public void IsEven_NegativeNumber_ReturnsTrueForEven()
        {
            Assert.False(_checker.IsEven(3));
            Assert.False(_checker.IsEven(-1));
            Assert.False(_checker.IsEven(-11));
        }


        [Fact]
        public void IsEven_Zero_ReturnsTrue()
        {
            Assert.True(_checker.IsEven(0));
        }
    }
}
