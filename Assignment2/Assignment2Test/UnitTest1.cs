using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment2;

namespace Assignment2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BasicAddTest()
        {
            Program temp = new Program();

            // Arrange
            double expected = 4;

            // Act 
            double result = temp.calculate("2 2 +");

            // Assert
            Assert.AreEqual(expected, result, "Incorrect Object Returned");
        }

        [TestMethod]
        public void BasicSubtractTest()
        {
            Program temp = new Program();

            // Arrange
            double expected = 0;

            // Act 
            double result = temp.calculate("2 2 -");

            // Assert
            Assert.AreEqual(expected, result, "Incorrect Object Returned");
        }

        [TestMethod]
        public void BasicMultiDivideTest()
        {
            Program temp = new Program();

            // Arrange
            double expected = 1.33;

            // Act 
            double result = Math.Round(temp.calculate("2 2 3 / *"), 2);

            // Assert
            Assert.AreEqual(expected, result, "Incorrect Object Returned");
        }

        [TestMethod]
        public void BasicPowerTest()
        {
            Program temp = new Program();

            // Arrange
            double expected = 16;

            // Act 
            double result = temp.calculate("2 4 ^");

            // Assert
            Assert.AreEqual(expected, result, "Incorrect Object Returned");
        }
    }
}
