using System;
using NUnit.Framework;
using SimpleCalculator;

namespace StringCalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            StringCalculator = new StringCalculator();
        }

        private StringCalculator StringCalculator;

        [Test]
        public void WhenAddingEmptyString_ShouldReturn0()
        {
            // Arrange
            const string input = "";

            // Setup
            int result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void WhenAdding1_ShouldReturn1()
        {
            // Arrange
            const string input = "1";

            // Setup
            int result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void WhenAdding1And2_ShouldReturn3()
        {
            // Arrange
            const string input = "1,2";

            // Setup
            int result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void WhenAdding1Comma2NewLine3_ShouldReturn6()
        {
            // Arrange
            const string input = "1,2\n3";

            // Setup
            int result = StringCalculator.Add(input);

            // Assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void WhenEndingWithSeparator_ShouldReturnException()
        {
            // Arrange
            const string input = "1,2,3,";

            // Setup and Assert
            Assert.Throws(typeof(ArgumentException), ()=>StringCalculator.Add(input));
        }
    }
}