using _0804._OddOccurrences;

namespace _084._OddOccurrencesTests
{
    public class OddOccurrencesTests
    {
        [Test]
        public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = Array.Empty<string>();

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[] { "the", "the" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
        {
            // Arrange
            string[] input = new string[] { "the" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo("the"));
        }

        [Test]
        public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
        {
            // Arrange
            string[] input = new string[] { "the", "the", "the", "ho", "ho", "ho" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo("the ho"));
        }

        [Test]
        public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
        {
            // Arrange
            string[] input = new string[] { "tHe", "thE", "The", "Ho", "hO", "ho" };

            // Act
            string result = OddOccurrences.FindOdd(input);

            // Assert
            Assert.That(result, Is.EqualTo("the ho"));
        }
    }
}