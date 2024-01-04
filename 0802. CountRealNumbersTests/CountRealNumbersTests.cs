using _0802._CountRealNumbers;
using System.Text;

namespace _0802._CountRealNumbersTests
{
    public class CountRealNumbersTests
    {

        [Test]
        public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
        {
            // Arrange
            int[] input = Array.Empty<int>();

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Count_WithSingleNumber_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[1] { 1 };

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo("1 -> 1"));
        }

        [Test]
        public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[4] { 1, 2, 3, 2 };

            StringBuilder sb = new();
            sb.AppendLine("1 -> 1");
            sb.AppendLine("2 -> 2");
            sb.AppendLine("3 -> 1");

            string expexted = sb.ToString().Trim();

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[3] { -2, -3, -2 };

            StringBuilder sb = new();
            sb.AppendLine("-3 -> 1");
            sb.AppendLine("-2 -> 2");

            string expexted = sb.ToString().Trim();

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_Count_WithZero_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[4] { 0, 0, 0, 0 };

            StringBuilder sb = new();
            sb.AppendLine("0 -> 4");

            string expexted = sb.ToString().Trim();

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }
        [Test]
        public void Test_Count_WithMultiplyNumbers_ShouldReturnCountString()
        {
            // Arrange
            int[] input = new int[4] { 1, 2, 3, 2 };

            StringBuilder sb = new();
            sb.AppendLine("1 -> 1");
            sb.AppendLine("2 -> 2");
            sb.AppendLine("3 -> 1");

            string expexted = sb.ToString().Trim();

            // Act
            string result = CountRealNumbers.Count(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }
    }
}