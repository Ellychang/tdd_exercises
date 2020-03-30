using NaturalNumbers;
using NUnit.Framework;
using System;

namespace UnitTestProject1
{
    [TestFixture]
    public class NaturalNumberSum
    {
        private NaturalNumber naturalNumber;

        [SetUp]
        public void Setup()
        {
            naturalNumber = new NaturalNumber();
        }

        [TestCase(1, 0)]
        [TestCase(3, 3)]
        [TestCase(5, 8)]
        [TestCase(10, 23)]
        public void SumOf_When_input_returns_SumOf(int input, int exacted)
        {
            var response = naturalNumber.SumOf(input);

            // Assert
            Assert.AreEqual(response, exacted);
        }

        [Test]
        public void SumOf_When_input_1000_returns_SumOf()
        {
            var response = naturalNumber.SumOf(1000);

            // Assert
            Assert.Greater(response, 1000);

            Console.Write(String.Format("Sum of 1000 is {0}", response));
        }

    }
}
