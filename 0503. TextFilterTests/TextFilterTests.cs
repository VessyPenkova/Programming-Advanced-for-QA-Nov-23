namespace _0503._TextFilterTests
{
    public class TextFilterTests
    {
        // TODO: finish the test
        [Test]
        public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
        {
            // Arrange
            string[] bannedWords = new[] { "I", "am", "Advanced", "QA" };

            string text = string.Empty;

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo(text));
        }

        [Test]
        public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
        {
            // Arrange
            string[] bannedWords = new[] { "I", "am", "Advanced", "QA" };

            string text = "Advanced";

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo("********"));
        }

        [Test]
        public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
        {
            // Arrange
            string[] bannedWords = new string[] { };

            string text = "I am Advanced QA";

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo("I am Advanced QA"));
        }

        [Test]
        public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
        {
            // Arrange
            string[] bannedWords = new[] { "I", "am", " Advanced", "QA" };

            string text = "Advanced";

            // Act
            string result = TextFilter.Filter(bannedWords, text);

            // Assert
            Assert.That(result, Is.EqualTo(text));
        }
    }

}