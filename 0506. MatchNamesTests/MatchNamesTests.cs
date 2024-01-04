using _0506._MatchNames;

namespace _0506._MatchNamesTests
{

    public class MatchNamesTests
    {
        [Test]
        public void Test_Match_ValidNames_ReturnsMatchedNames()
        {
            // Arrange
            string names = "John Smith and Alice Johnson";
            string expected = "John Smith Alice Johnson";

            // Act
            string result = MatchNames.Match(names);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_NoValidNames_ReturnsEmptyString()
        {
            // Arrange
            string names = "JOhn Smith and Alice JOhnson";
            string expected = string.Empty;

            // Act
            string result = MatchNames.Match(names);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Match_EmptyInput_ReturnsEmptyString()
        {
            // Arrange
            string names = string.Empty;
            string expected = string.Empty;

            // Act
            string result = MatchNames.Match(names);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }


    //Regex pattern = new(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

    //MatchCollection matches = pattern.Matches(names);
}