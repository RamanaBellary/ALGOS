using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ALGOS
{
    [Serializable]
    public class Customer
    {
        public int Id;
        public string Name;
        [OptionalField(VersionAdded = 2)]
        public Address1 Address;
        [XmlIgnore]
        public string Password;
    }

    public class Address1
    {
        public int No { get; set; }
        public string Address { get; set; }
    }
}
