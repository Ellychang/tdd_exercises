using System;
using NUnit.Framework;
using Password;

namespace PasswordValidatorTest
{
    [TestFixture]
    public class PasswordValidatorTest
    {
        [Test]
        public void Validate_When_null_returns_false()
        {
            // Arrange
            var passwordValidator = new PasswordValidator();

            // Act
            var response = passwordValidator.Validate(null);

            // Assert
            Assert.AreEqual(false, response);
        }

        [Test]
        public void Validate_When_empty_returns_false()
        {
            // Arrange
            var passwordValidator = new PasswordValidator();

            // Act
            var response = passwordValidator.Validate("");

            // Assert
            Assert.AreEqual(false, response);

        }

        [Test]
        public void Validate_When_input_length_min_8_returns_true()
        {
            // Arrange
            var passwordValidator = new PasswordValidator();

            // Act
            var response = passwordValidator.Validate("abHitoe.");

            // Assert
            Assert.AreEqual(true, response);

        }

        [Test]
        public void Validate_When_input_length_less_8_returns_false()
        {
            // Arrange
            var passwordValidator = new PasswordValidator();

            // Act
            var response = passwordValidator.Validate("absito");

            // Assert
            Assert.AreEqual(false, response);

        }

        [Test]
        public void Validate_When_input_length_more_than_12_returns_false()
        {
            // Arrange
            var passwordValidator = new PasswordValidator();

            // Act
            var response = passwordValidator.Validate("absderjkdlrere");

            // Assert
            Assert.AreEqual(false, response);

        }

        [Test]
        public void Validate_When_input_contains_1_captial_letter_returns_true()
        {
            // Arrange
            var passwordValidator = new PasswordValidator();

            // Act
            var response = passwordValidator.Validate("Hellopop.");

            // Assert
            Assert.AreEqual(true, response);

        }
    }
}
