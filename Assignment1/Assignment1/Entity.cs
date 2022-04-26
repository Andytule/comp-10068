using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Represents an Entity
    /// </summary>
    /// [XmlRoot]
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Entity
    {
        /// <summary>
        /// Initializes a new instance of the </ see cref="Entity" /> class
        /// </summary>
        public Entity()
        {
            Console.WriteLine("Default Entity constructor invoked");
        }

        /// <summary>
        /// Gets or sets the Addresses
        /// </summary>
        /// <value>The Addresses</value>
        [XmlElement]
        [JsonProperty]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the Identifier
        /// </summary>
        /// <value>The Identifier</value>
        [XmlElement]
        [JsonProperty]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the Identifiers
        /// </summary>
        /// <value>The Identifiers</value>
        [XmlElement]
        [JsonProperty]
        public List<Identifier> Identifiers { get; set; }

        /// <summary>
        /// Initializes a new instance of the </ see cref="Entity" /> class with initalized Identifier
        /// </summary>
        /// <param name="Id">The Identifier</param>
        public Entity(Guid id)
        {
            Id = id;
        }
    }
}
