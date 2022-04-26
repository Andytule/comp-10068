using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Represents an Address
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Address    
    {
        /// <summary>
        /// Initializes a new instance of the </ see cref="Address" /> class
        /// </summary>
        public Address ()
        {
            Console.WriteLine("Default Address constructor invoked");
        }

        /// <summary>
        /// Gets or sets the Address Line
        /// </summary>
        /// <value>The Address Line</value>
        [XmlElement]
        [JsonProperty]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or sets the City
        /// </summary>
        /// <value>The City</value>
        [XmlElement]
        [JsonProperty]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        /// <value>The Country</value>
        [XmlElement]
        [JsonProperty]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the Entity Id
        /// </summary>
        /// <value>The Entity Id</value>
        [XmlElement]
        [JsonProperty]
        public Guid EntityId { get; set; }

        /// <summary>
        /// Gets or sets the Postal Code
        /// </summary>
        /// <value>The Postal Code</value>
        [XmlElement]
        [JsonProperty]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        /// <value>The Province</value>
        [XmlElement]
        [JsonProperty]
        public string Province { get; set; }

        /// <summary>
        /// Initializes a new instance of the </ see cref="Address" /> class with initalized Postal Code
        /// </summary>
        /// <param name="postalCode">The Postal Code</param>
        public Address(string postalCode)
        {
            PostalCode = postalCode;
        }
    }
}
