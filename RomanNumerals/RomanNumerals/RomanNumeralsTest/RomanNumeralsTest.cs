
using System;
using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class RomanNumeralsTest
    {
        [Test]
        public void GetRomanNumerals_empty_returns_empty()
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual("", RomanNumeral.GetRomanNumerals(0));
        }

        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(9, "IX")]
        public void GetRomanNumerals_with_input_returns_output(int input, string output)
        {
            // Arrange
            // Act
            // Assert
            Assert.AreEqual(output, RomanNumeral.GetRomanNumerals(input));
        }
    }
}
