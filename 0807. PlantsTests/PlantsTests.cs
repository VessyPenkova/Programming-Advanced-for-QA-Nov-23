using _0807._Plants;
using System.Text;

namespace _0807._PlantsTests
{
    public class PlantsTests
    {
        [Test]
        public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
        {
            //Arrange
            string[] plants = Array.Empty<string>();

            //Act
            string result = Plants.GetFastestGrowing(plants);

            //Assert
            Assert.That(result, Is.Empty);
        }

        [Test]
        public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
        {
            //Arrange
            string[] plants = new string[]
            {
        "rose"
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants with 4 letters:");
            sb.AppendLine("rose");

            string expexted = sb.ToString().Trim();

            //Act
            string result = Plants.GetFastestGrowing(plants);

            //Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
        {
            //Arrange
            string[] plants = new string[]
            {
        "rose",
        "buttrfly"
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants with 4 letters:");
            sb.AppendLine("rose");
            sb.AppendLine("Plants with 8 letters:");
            sb.AppendLine("buttrfly");


            string expexted = sb.ToString().Trim();

            //Act
            string result = Plants.GetFastestGrowing(plants);

            //Assert
            Assert.That(result, Is.EqualTo(expexted));
        }

        [Test]
        public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
        {
            //Arrange
            string[] plants = new string[]
            {
        "roSe",
        "buttrFly"
            };

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Plants with 4 letters:");
            sb.AppendLine("roSe");
            sb.AppendLine("Plants with 8 letters:");
            sb.AppendLine("buttrFly");


            string expexted = sb.ToString().Trim();

            //Act
            string result = Plants.GetFastestGrowing(plants);

            //Assert
            Assert.That(result, Is.EqualTo(expexted));
        }
    }
}