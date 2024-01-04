using _0806._Orders;
using System.Text;

namespace _0806._OrdersTests
{
    public class OrdersTests
    {
        [Test]
        public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
        {
            // Arrange
            string[] input = new string[0]; ;

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
        {
            // Arrange
            string[] input = new string[]
            {
            "orange 2.0 1",
            "orange 1.0 1",
            "tomato 1.0 1",
            "carrot 1.0 1"
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("orange -> 2.00");
            sb.AppendLine("tomato -> 1.00");
            sb.AppendLine("carrot -> 1.00");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
        {
            // Arrange
            string[] input = new string[]
            {
            "orange 2.00000000000001 1",
            "orange 0.999999999999999999 1",
            "tomato 1.0000000000000000001 1",
            "carrot 1.000000000000000012 1"
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("orange -> 2.00");
            sb.AppendLine("tomato -> 1.00");
            sb.AppendLine("carrot -> 1.00");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
        {
            // Arrange
            string[] input = new string[]
            {
            "orange 2 0.5",
            "orange 1 0.5",
            "tomato 1 1.00",
            "carrot 1 1.00"
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("orange -> 1.00");
            sb.AppendLine("tomato -> 1.00");
            sb.AppendLine("carrot -> 1.00");

            string expexted = sb.ToString().Trim();

            // Act
            string result = Orders.Order(input);

            // Assert
            Assert.That(result, Is.EqualTo(expexted));
        }
    }

}