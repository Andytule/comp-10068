using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Represents a Provider
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Provider : Person
    {
        /// <summary>
        /// Initializes a new instance of the </ see cref="Provider" /> class
        /// </summary>
        public Provider()
        {
            Console.WriteLine("Default Provider constructor invoked");
        }

        /// <summary>
        /// Gets or sets the Specialty
        /// </summary>
        /// <value>The Specialty</value>
        [XmlElement]
        [JsonProperty]
        public string Specialty { get; set; }

        /// <summary>
        /// Initializes a new instance of the </ see cref="Provider" /> class with initialized Speciality
        /// </summary>
        public Provider(string specialty)
        {
            Specialty = specialty;
        }
    }
}
