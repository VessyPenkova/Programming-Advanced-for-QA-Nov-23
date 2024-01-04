using _0504._ReverseConcatenate;

namespace _0504._ReverseConcatenateTests
{
    public class ReverseConcatenateTests
    {
        [Test]
        public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string[] inputStrings = new string[] { };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
        {
            // Arrange
            string[] inputStrings = new string[] { "I" };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

            // Assert
            Assert.That(result, Is.EqualTo("I"));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
        {
            // Arrange
            string[] inputStrings = new string[] { "I", "am", "I" };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

            // Assert
            Assert.That(result, Is.EqualTo("IamI"));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
        {
            // Arrange
            string[] inputStrings = null;

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
        {
            // Arrange
            string[] inputStrings = new string[] { " I", "am", "I" };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

            // Assert
            Assert.That(result, Is.EqualTo("Iam I"));
        }

        [Test]
        public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
        {
            // Arrange
            string[] inputStrings = new string[] { "I", "am", "QA", "student", "since", "september" };

            // Act
            string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

            // Assert
            Assert.That(result, Is.EqualTo("septembersincestudentQAamI"));
        }
    }

}