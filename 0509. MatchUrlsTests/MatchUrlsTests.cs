using _0509._MatchUrls;

namespace _0509._MatchUrlsTests
{
    public class MatchUrlsTests
    {
        [Test]
        public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
        {
            // Arrange
            string text = "";
            List<string> expected = new();

            // Act
            List<string> result = MatchUrls.ExtractUrls(text);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
        {
            // Arrange
            string text = "No valid URLs !!!";

            // Act
            List<string> result = MatchUrls.ExtractUrls(text);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
        {
            // Arrange
            string text = "Single URL: https://softuni.bg";
            List<string> expected = new() { "https://softuni.bg" };

            // Act
            List<string> result = MatchUrls.ExtractUrls(text);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
        {
            // Arrange
            string text = "Multiply URL: https://softuni.bg, https://digital.softuni.bg, https://creative.softuno.bg";
            List<string> expected = new() { "https://softuni.bg", "https://digital.softuni.bg", "https://creative.softuno.bg" };

            // Act
            List<string> result = MatchUrls.ExtractUrls(text);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
        {
            // Arrange
            string text = "Single URL: \"https://softuni.bg\"";
            List<string> expected = new() { "https://softuni.bg" };

            // Act
            List<string> result = MatchUrls.ExtractUrls(text);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }

}