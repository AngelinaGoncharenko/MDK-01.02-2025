using System;

namespace TestPractica_3
{
    public class WordCounter
    {
        public int CountWords(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }

            return text.Split([' ', '\t', '\n', '\r'], StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    [Collection("WordCounterCollection")]
    public class WordCounterTests
    {
        private readonly WordCounter _counter = new();

        [Fact]
        public void CountWords_MultipleWords_ReturnsCorrectCount() => Assert.Equal(4, _counter.CountWords("This is a test."));

        [Fact]
        public void CountWords_StringWithSpaces_ReturnsCorrectCount() => Assert.Equal(3, _counter.CountWords("  One   two  three "));

        [Fact]
        public void CountWords_EmptyString_ReturnsZero() => Assert.Equal(0, _counter.CountWords(""));

        [Fact]
        public void CountWords_OneWord_ReturnsOne() => Assert.Equal(1, _counter.CountWords("Test"));

        [Fact]
        public void CountWords_StringWithTabs_ReturnsCorrectCount() => Assert.Equal(2, _counter.CountWords("One	Two"));
    }
}
