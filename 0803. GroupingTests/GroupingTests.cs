using _0803._Grouping;
using System.Linq;
using System.Text;

namespace _0803._GroupingTests
{

    public class GroupingTests
    {
        [Test]
        public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
        {
            // Arrange
            List<int> input = new();

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new() { 1, 2, 3, 4 };

            StringBuilder sb = new();
            sb.AppendLine("Odd numbers: 1, 3");
            sb.AppendLine("Even numbers: 2, 4");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new() { 6, 8, 2, 4 };

            StringBuilder sb = new();
            sb.AppendLine("Even numbers: 6, 8, 2, 4");


            string expexted = sb.ToString().Trim();

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));

        }

        [Test]
        public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new() { 7, 1, 3 };

            StringBuilder sb = new();
            sb.AppendLine("Odd numbers: 7, 1, 3");

            //sb.AppendLine($"{group.Key} numbers: {string.Join(", ", group.Value)}");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));

        }

        [Test]
        public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new() { -1, -2, -3, -4 };

            StringBuilder sb = new();
            sb.AppendLine("Odd numbers: -1, -3");
            sb.AppendLine("Even numbers: -2, -4");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));

        }
        [Test]
        public void Test_GroupNumbers_WithNegativeiveEvenNumbers_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new() { -2, -4 };

            StringBuilder sb = new();
            sb.AppendLine("Even numbers: -2, -4");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));

        }
        [Test]
        public void Test_GroupNumbers_WithZero_ShouldReturnGroupedString()
        {
            // Arrange
            List<int> input = new() { 0 };

            StringBuilder sb = new();
            sb.AppendLine("Even numbers: 0");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Grouping.GroupNumbers(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));

        }
    }
}