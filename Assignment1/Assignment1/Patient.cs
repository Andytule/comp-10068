using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Represents a Patient
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Patient
    {
        /// <summary>
        /// Initializes a new instance of the </ see cref="Patient" /> class
        /// </summary>
        public Patient()
        {
            Console.WriteLine("Default Patient constructor invoked");
        }

        /// <summary>
        /// Gets or sets the Date Of Birth
        /// </summary>
        /// <value>The Date Of Birth</value>
        [XmlElement]
        [JsonProperty]
        public DateTimeOffset DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the Gender
        /// </summary>
        /// <value>The Gender</value>
        [XmlElement]
        [JsonProperty]
        public string Gender { get; set; }

        /// <summary>
        /// Initializes a new instance of the </ see cref="Patient" /> class with initialized Gender and Date Time Offset
        /// </summary>
        public Patient(string gender, DateTimeOffset dateOfBirth)
        {
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }
    }
}
