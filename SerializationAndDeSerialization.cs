using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ALGOS
{
    public class SerializationAndDeSerialization
    {
        public static void Do()
        {
            Entity1 emp = new Entity1() { Id = 1, Name = "Ram", Salary = 100.0 };
            var xml = Serialize(emp);
            var obj = DeSerialize(xml);
        }

        private static string Serialize(Entity1 emp)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Entity1));
            string xml;
            using (var sw = new StringWriter())
            {
                serializer.Serialize(sw,emp);
                xml = sw.ToString();
            }
            return xml;
        }

        private static object DeSerialize(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Entity1));
            object obj = null;
            using(var sr = new StringReader(xml))
            {
                obj = serializer.Deserialize(sr);
            }
            return obj;
        }
    }

    [Serializable]
    public class Entity1
    {
        public int Id;

        public string Name;

        [XmlIgnore]
        public double Salary;

        [OptionalField(VersionAdded = 2)]
        public Address Address;
    }

    public class Address
    {
        public int No;
        public string Street;
        public string Area;
        public string City;
        public int PinCode;
        public string Country;
    }
}
