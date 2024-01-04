using _1204._Vehicle;

namespace _1204._VehicleTests
{
    public class VehicleTests
    {
        private Vehicles _vehicles;

        [SetUp]
        public void SetUp()
        {
            this._vehicles = new();
        }

        [Test]
        public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
        {
            // Arrange

            string[] input =
                {
                "Car/Ford/Focus/120",
                "Car/Toyota/Camry/150",
                "Truck/Volvo/VNL/500"
            };

            string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp{Environment.NewLine}Toyota: Camry - 150hp{Environment.NewLine}Trucks:{Environment.NewLine}Volvo: VNL - 500kg";

            // Act
            string result = this._vehicles.AddAndGetCatalogue(input);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
        {
            // Arrange
            Vehicles _vehicles = new Vehicles();

            string[] input = { };

            string expected = $"Cars:{Environment.NewLine}Trucks:";

            // Act
            string result = this._vehicles.AddAndGetCatalogue(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}