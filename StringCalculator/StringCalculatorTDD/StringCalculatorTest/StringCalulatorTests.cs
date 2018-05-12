using System;
using NUnit.Framework;
using StringCalculatorTDD;


namespace StringCalculatorTest
{
    [TestFixture]
    public class StringCalulatorTests
    {
        [Test]
        public void When_empty_string_returns_0()
        {
            // Arrange
            // Act
            var response = StringCalculator.Add("");
            //Assert
            Assert.AreEqual(0, response);
        }

        [Test]
        public void When_1_string_returns_1()
        {
            // Arrange
            // Act
            var response = StringCalculator.Add("1");
            //Assert
            Assert.AreEqual(1, response);
        }

        [Test]
        public void When_2_string_returns_3()
        {
            // Arrange
            // Act
            var response = StringCalculator.Add("1,2");
            //Assert
            Assert.AreEqual(3, response);
        }


        [Test]
        [TestCase("1,2", 3)]
        [TestCase("1,2,3", 6)]
        [TestCase("1,2,2", 5)]
        public void When_unknown_length_string_returns_sum(string inputString, int result)
        {
            // Arrange
            // Act
            var response = StringCalculator.Add(inputString);
            //Assert
            Assert.AreEqual(result, response);
        }

        [TestCase("1\n2,3", 6)]
        public void When_inputHasnewline_InfrontOfNumber_returns_sum(string inputString, int result)
        {
            // Arrange
            // Act
            var response = StringCalculator.Add("1\n2,3");
            //Assert
            Assert.AreEqual(result, response);
        }

        [TestCase("1\n-2,-3")]
        public void When_input_isNegative_throws_exception(string inputString)
        {
            // Arrange
            // Act
            //Assert
            var ex = Assert.Throws<Exception>(() => StringCalculator.Add(inputString));
            Assert.AreEqual("Negative is not allowed.", ex.Message);
        }
    }
}
