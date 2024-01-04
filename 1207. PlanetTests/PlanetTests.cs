using _1207._Planet;
using System.Text;

namespace _1207._PlanetTests
{
    public class PlanetTests
    {
        private Planet _planet;

        [SetUp]
        public void Setup()
        {
            this._planet = new("Earth", 12742, 149600000, 1);
        }

        [Test]
        public void Test_CalculateGravity_ReturnsCorrectCalculation()
        {
            // Arrange
            Planet earth = new("Earth", 12742, 149600000, 1);
            double mass = 1000;
            //double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);
            double expectedGravity = 1.6443358047931488E-15d;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Planet: Earth");
            sb.AppendLine($"Diameter: 12742 km");
            sb.AppendLine($"Distance from the Sun: 149600000 km");
            sb.AppendLine($"Number of Moons: 1");

            var expected = sb;
            // Act
            var result = this._planet.CalculateGravity(1000);

            // Assert
            Assert.AreEqual(expectedGravity, result);
        }

        [Test]
        public void Test_GetPlanetInfo_ReturnsCorrectInfo()
        {
            // Arrange
            Planet earth = new("Earth", 12742, 149600000, 1);
            double mass = 1000;
            double expectedGravity = mass * 6.67430e-11 / Math.Pow(earth.Diameter / 2, 2);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Planet: Earth");
            sb.AppendLine($"Diameter: 12742 km");
            sb.AppendLine($"Distance from the Sun: 149600000 km");
            sb.AppendLine($"Number of Moons: 1");

            var expected = sb.ToString().Trim();
            // Act
            var result = this._planet.GetPlanetInfo();

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}