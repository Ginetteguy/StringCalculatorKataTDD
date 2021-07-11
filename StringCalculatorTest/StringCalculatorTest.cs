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
    }
}