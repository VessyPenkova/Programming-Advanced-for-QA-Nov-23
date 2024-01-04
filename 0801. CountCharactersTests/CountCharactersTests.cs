using _0801.__Count_Characters;
using System.Text;

namespace _0801._CountCharactersTests
{
    public class CountCharactersTests
    {
        [Test]
        public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new();

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
        {
            // Arrange
            List<string> input = new() { "", "", "" };

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
        {
            // Arrange
            List<string> input = new() { "a" };

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("a -> 1"));
        }

        [Test]
        public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
        {
            // Arrange
            List<string> input = new() { "abc", "ab", "b" };

            StringBuilder sb = new();
            sb.AppendLine("a -> 2");
            sb.AppendLine("b -> 3");
            sb.AppendLine("c -> 1");

            string expexted = sb.ToString().Trim();

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
        {
            // Arrange
            List<string> input = new() { "\\", "\\", "\\" };

            StringBuilder sb = new();
            sb.AppendLine("\\ -> 3");

            string expexted = sb.ToString().Trim();

            // Act
            string result = CountCharacters.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("\\ -> 3"));
        }
    }
}