using _0507._MatchPhoneNumbers;

namespace _0507._MatchPhoneNumbersTests
{
    public class MatchPhoneNumbersTests
    {
        // TODO: finish the test
        [Test]
        public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
        {
            // Arrange
            string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
            string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_NoValidPhoneNumbers_ReturnsEmptyString()
        {
            // Arrange
            string phoneNumbers = "+359/2-124-5678, +359 2 9866 5432, +359-2-555-55557";
            string expected = string.Empty;

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string phoneNumbers = "";
            string expected = string.Empty;

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
        {
            // Arrange
            string phoneNumbers = "+359-2-124-5678, +35929865432, +359-2-555-5555";
            string expected = "+359-2-124-5678, +359-2-555-5555";

            // Act
            string result = MatchPhoneNumbers.Match(phoneNumbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}