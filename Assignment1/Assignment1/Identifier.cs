using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Represents an Identifier
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Identifier
    {
        /// <summary>
        /// Initializes a new instance of the </ see cref="Identifier" /> class
        /// </summary>
        public Identifier()
        {
            Console.WriteLine("Default Identifier constructor invoked");
        }

        /// <summary>
        /// Gets or sets the Authority
        /// </summary>
        /// <value>The Authority</value>
        [XmlElement]
        [JsonProperty] 
        public string Authority { get; set; }

        /// <summary>
        /// Gets or sets the Entity Identifier
        /// </summary>
        /// <value>The Entity Identifier</value>
        [XmlElement]
        [JsonProperty]
        public Guid EntityId { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        /// <value>The Value</value>
        [XmlElement]
        [JsonProperty]
        public string Value { get; set; }

        /// <summary>
        /// Initializes a new instance of the </ see cref="Identifier" /> class with initalized Authority and Value
        /// </summary>
        /// <param name="authority">The Authority</param>
        /// <param name="value">the Value</param>
        public Identifier(string authority, string value)
        {
            Authority = authority;
            Value = value;
        }
    }
}
