using _0510._EmailValidator;

namespace _0510._EmailValidatorTests
{
    public class EmailValidatorTests
    {
        // TODO: finish the test
        [TestCase("ivan_ivnov@softuni.bg")]
        [TestCase("petar.petrov@softuni.bg")]
        [TestCase("veslina+123@yahoo.com")]
        public void Test_ValidEmails_ReturnsTrue(string email)
        {
            // Arrange

            // Act
            bool result = EmailValidator.IsValidEmail(email);

            // Assert
            Assert.That(result, Is.True);
        }


        [TestCase("invalid mail@valid.domain")]
        [TestCase("validmail@in_valid.domain")]
        [TestCase("invalid/mail@in_valid.d")]
        public void Test_InvalidEmails_ReturnsFalse(string email)
        {
            // Arrange

            // Act
            bool result = EmailValidator.IsValidEmail(email);

            // Assert
            Assert.That(result, Is.False);
        }
    }

}