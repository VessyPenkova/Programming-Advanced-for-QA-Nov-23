using _0505._Pattern;

namespace _0505._PatternTests
{
    public class PatternTests
    {
        // TODO: finish the test cases
        [TestCase("string", 1, "sTrInG")]
        [TestCase("string", 2, "sTrInGsTrInG")]
        [TestCase("string", 3, "sTrInGsTrInGsTrInG")]
        [TestCase("string", 4, "sTrInGsTrInGsTrInGsTrInG")]
        [TestCase("string", 5, "sTrInGsTrInGsTrInGsTrInGsTrInG")]
        [TestCase("string", 6, "sTrInGsTrInGsTrInGsTrInGsTrInGsTrInG")]
        public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input,
            int repetitionFactor, string expected)
        {
            // Arrange

            // Act
            string result = Pattern.GeneratePatternedString(input, repetitionFactor);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
        {
            string input = string.Empty;
            int repetitionFactor = 1;

            //Act && Assert
            Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
        }

        [Test]
        public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
        {
            string input = "string";
            int repetitionFactor = -1;

            //Act && Assert
            Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
        }

        [Test]
        public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
        {
            string input = "string";
            int repetitionFactor = 0;

            //Act && Assert
            Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
        }
    }

    //[TestCase(new int[] { 1, 2, 3, 4 }, "1234")]
    //[TestCase(new int[] { 4, 3, 2, 1 }, "4321")]
    //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, "2134576")]
    //[TestCase(new int[] { 2, 1, 3, 4, 5, 7, 6 }, "1234567")]
    //[TestCase(new int[] { 4, 3, 2, 1, 5, 6, 7, 8, 9, 10, 11, 12, 16, 15, 14, 13 }, "12345678910111213141516")]
    //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, "43215678910111216151413")]
}