using _0502._Substring;
using System.Data.SqlTypes;

namespace _0502.__SubstringTests
{
    public class SubstringTests
    {
        // TODO: finish the test
        [Test]
        public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
        {
            // Arrange
            string toRemove = "fox";
            string input = "The quick brown fox jumps over the lazy dog";

            // Act
            string result = Substring.RemoveOccurrences(toRemove, input);

            // Assert
            Assert.That(result, Is.EqualTo("The quick brown jumps over the lazy dog"));
        }

        [Test]
        public void Test_RemoveOccurrences_RemovesSubstringFromStart()
        {
            // Arrange
            string toRemove = "Fox";
            string input = "Fox quick jump over the lazy dog";

            // Act
            string result = Substring.RemoveOccurrences(toRemove, input);

            // Assert
            Assert.That(result, Is.EqualTo("quick jump over the lazy dog"));
        }

        [Test]
        public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
        {
            // Arrange
            string toRemove = "dog";
            string input = "Fox quick jump over the lazy dog";

            // Act
            string result = Substring.RemoveOccurrences(toRemove, input);

            // Assert
            Assert.That(result, Is.EqualTo("Fox quick jump over the lazy"));
        }

        [Test]
        public void Test_RemoveOccurrences_RemovesAllOccurrences()
        {
            // Arrange
            string toRemove = "Fox quick jump over the lazy dog";
            string input = "Fox quick jump over the lazy dog";

            // Act
            string result = Substring.RemoveOccurrences(toRemove, input);

            // Assert
            Assert.That(result, Is.EqualTo(String.Empty));
        }
    }
}