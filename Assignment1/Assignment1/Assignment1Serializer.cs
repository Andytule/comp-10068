using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Assignment1
{
    /// <summary>
    /// Assignment 1 Serializers
    /// </summary>
    public class Assignment1Serializer
    {
        public Assignment1Serializer()
        {
        }

        /// <summary>
        /// Deserialize From JSON method with Type and Instance parameter
        /// </summary>
        /// <param name="type">The Type</param>
        /// <param name="instance">The Instance</param>
        /// <returns>The Object</returns>
        public object DeserializeFromJson(Type type, byte[] instance)
        {
            var serializer = new JsonSerializer();
            try
            {
                var jsonReader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(instance)));
                Console.WriteLine("Deserialized from JSON");
                return Convert.ChangeType(serializer.Deserialize(jsonReader, type), type);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Deserializing from JSON", nameof(instance), e);
            }
        }

        /// <summary>
        /// Deserialize From JSON method with Instance
        /// </summary>
        /// <typeparam name="T">The Generic Type</typeparam>
        /// <param name="instance">The Instance</param>
        /// <returns>The Generic Type</returns>
        public T DeserializeFromJson<T>(byte[] instance)
        {
            var serializer = new JsonSerializer();
            try
            {
                var jsonReader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(instance)));
                Console.WriteLine("Deserialized from JSON");
                return (T)serializer.Deserialize(jsonReader, typeof(T));
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Deserializing from JSON", nameof(instance), e);
            }
        }

        /// <summary>
        /// Deserialize From XML method with Type and Instance
        /// </summary>
        /// <param name="type">The Type</param>
        /// <param name="instance">The Instance</param>
        /// <returns>The Object</returns>
        public object DeserializeFromXml(Type type, byte[] instance)
        {
            var serializer = new XmlSerializer(type);
            try
            {
                Console.WriteLine("Deserialized from XML");
                return Convert.ChangeType(serializer.Deserialize(new MemoryStream(instance)), type);
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Deserializing from XML", nameof(instance), e);
            }
        }

        /// <summary>
        /// Deserialize From XML method with Instance
        /// </summary>
        /// <typeparam name="T">The Generic Type</typeparam>
        /// <param name="instance">The Instance</param>
        /// <returns>The Generic Object</returns>
        public T DeserializeFromXml<T>(byte[] instance)
        {
            var serializer = new XmlSerializer(typeof(T));
            try
            {
                Console.WriteLine("Deserialized from XML");
                return (T)serializer.Deserialize(new MemoryStream(instance));
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Deserializing from XML", nameof(instance), e);
            }
        }

        /// <summary>
        /// Serialize to JSON method with Type and Instance
        /// </summary>
        /// <param name="type">The Type</param>
        /// <param name="instance">The Instance</param>
        /// <returns>The Byte Array</returns>
        public byte[] SerializeToJson(Type type, object instance)
        {
            var serializer = new JsonSerializer();
            var stringWriter = new StringWriter();

            try
            {
                serializer.Serialize(stringWriter, instance);
                Console.WriteLine("Serialized to JSON");
                return Encoding.UTF8.GetBytes(stringWriter.ToString());
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Serializing to JSON", nameof(instance), e);
            }            
        }

        /// <summary>
        /// Serialize to JSON with Instance
        /// </summary>
        /// <typeparam name="T">The Generic type</typeparam>
        /// <param name="instance">The Instane</param>
        /// <returns>The Byte Array</returns>
        public byte[] SerializeToJson<T>(T instance) where T : Entity
        {
            var serializer = new JsonSerializer();
            var stringWriter = new StringWriter();

            try
            {
                serializer.Serialize(stringWriter, instance);
                Console.WriteLine("Serialized to JSON");
                return Encoding.UTF8.GetBytes(stringWriter.ToString());
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Serializing to JSON", nameof(instance), e);
            }
        }

        /// <summary>
        /// Serialize To XML with Type and Instance
        /// </summary>
        /// <param name="type">The Type</param>
        /// <param name="instance">The Instnace</param>
        /// <returns>The Byte Array</returns>
        public byte[] SerializeToXml(Type type, object instance)
        {
            var serializer = new XmlSerializer(type);
            var memoryStream = new MemoryStream();

            try
            {
                serializer.Serialize(memoryStream, instance);
                Console.WriteLine("Serialized to XML");
                return memoryStream.ToArray();
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Serializing to XML", nameof(instance), e);
            }
        }

        /// <summary>
        /// Serialize to XML with Instance
        /// </summary>
        /// <typeparam name="T">The Generic Type</typeparam>
        /// <param name="instance">The Instance</param>
        /// <returns>The Byte Array</returns>
        public byte[] SerializeToXml<T>(T instance) where T : Entity
        {
            var serializer = new XmlSerializer(typeof(T));
            var memoryStream = new MemoryStream();

            try
            {
                serializer.Serialize(memoryStream, instance);
                Console.WriteLine("Serialized to XML");
                return memoryStream.ToArray();
            }
            catch (Exception e)
            {
                throw new ArgumentException("Error Serializing to XML", nameof(instance), e);
            }
        }
    }
}
