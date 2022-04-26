using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment1;

namespace Assignment1Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SerializingToJsonAndBack()
        {
            // Arrange
            Assignment1Serializer serializer = new Assignment1Serializer();
            var expected = new Person
            {
                FirstName = "Andy",
                LastName = "Le"
            };

            // Act
            byte[] instance = serializer.SerializeToJson(typeof(Person), expected);
            var actual = serializer.DeserializeFromJson(typeof(Person), instance);

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString(), "Incorrect Object Returned");
        }

        [TestMethod]
        public void SerializingToXmlAndBack()
        {
            // Arrange
            Assignment1Serializer serializer = new Assignment1Serializer();
            var expected = new Person
            {
                FirstName = "Andy",
                LastName = "Le"
            };

            // Act
            byte[] instance = serializer.SerializeToXml(typeof(Person), expected);
            var actual = serializer.DeserializeFromXml(typeof(Person), instance);

            // Assert
            Assert.AreEqual(expected.ToString(), actual.ToString(), "Incorrect Object Returned");
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void SerializingtoXml_IncorrectType()
        {
            // Arrange
            Assignment1Serializer serializer = new Assignment1Serializer();
            var expected = new Person
            {
                FirstName = "Andy",
                LastName = "Le"
            };

            // Act
            byte[] instance = serializer.SerializeToXml(typeof(Address), expected);

            // Assert
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void SerializingToJson_And_DeserializingFromXml()
        {
            // Arrange
            Assignment1Serializer serializer = new Assignment1Serializer();
            var expected = new Person
            {
                FirstName = "Andy",
                LastName = "Le"
            };

            // Act
            byte[] instance = serializer.SerializeToJson(typeof(Person), expected);
            var actual = serializer.DeserializeFromXml(typeof(Person), instance);

            // Assert
        }
    }
}
