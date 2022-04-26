using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Represents an Organization
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Organization : Entity
    {
        /// <summary>
        /// Initializes a new instance of the </ see cref="Organization" /> class
        /// </summary>
        public Organization()
        {
            Console.WriteLine("Default Organization constructor invoked");
        }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        /// <value>The Name</value>
        [XmlElement]
        [JsonProperty]
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the </ see cref="Organization" /> class with initialized Name
        /// </summary>
        /// <param name="name">The Name</param>
        public Organization(string name)
        {
            Name = name;
        }
    }
}
