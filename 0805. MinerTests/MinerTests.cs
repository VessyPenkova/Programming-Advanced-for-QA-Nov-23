using _0805._Miner;
using System.Text;

namespace _0805._MinerTests
{
    public class MinerTests
    {
        [Test]
        public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = Array.Empty<string>();

            // Act
            var result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
        {
            // Arrange
            string[] input = new string[] { "Gold 4", "silver 30", "gold 4" };

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
        }

        [Test]
        public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
        {
            // Arrange
            string[] input = new string[] { "Gold 4", "silver 30", "gold 4", "cupper 30" };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("gold -> 8");
            sb.AppendLine("silver -> 30");
            sb.AppendLine("cupper -> 30");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Miner.Mine(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }
    }

}