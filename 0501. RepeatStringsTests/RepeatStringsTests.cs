using _0501._RepeatStrings;

namespace _0501._RepeatStringsTests
{
    public class RepeatStringsTests
    {
        [Test]
        public void Test_Repeat_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string[] input = Array.Empty<string>();

            // Act
            string result = RepeatStrings.Repeat(input);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
        {
            // Arrange
            string[] input = new[] { "h" };

            // Act
            string result = RepeatStrings.Repeat(input);

            // Assert
            Assert.That(result, Is.EqualTo("h"));
        }

        [Test]
        public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
        {
            // Arrange
            string[] input = new[] { "hh", "a", "aaa" };

            // Act
            string result = RepeatStrings.Repeat(input);

            // Assert
            Assert.That(result, Is.EqualTo("hhhhaaaaaaaaaa"));
        }
    }
}