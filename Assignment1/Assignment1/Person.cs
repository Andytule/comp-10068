using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Represents a Person
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Person : Entity
    {
        /// <summary>
        /// Initializes a new instance of the </ see cref="Person" /> class
        /// </summary>
        public Person()
        {
            Console.WriteLine("Default Person constructor invoked");
        }

        /// <summary>
        /// Gets or sets the First Name
        /// </summary>
        /// <value>The First Name</value>
        [XmlElement]
        [JsonProperty]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the Last Name
        /// </summary>
        /// <value>The Last Name</value>
        [XmlElement]
        [JsonProperty]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the Middle Name
        /// </summary>
        /// <value>The Middle Name</value>
        [XmlElement]
        [JsonProperty]
        public string MiddleName { get; set; }

        /// <summary>
        /// Initializes a new instance of the </ see cref="Person" /> class with initialized First Name and Last Name
        /// </summary>
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// To String Method
        /// </summary>
        /// <returns>the String Representation of the Object</returns>
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
