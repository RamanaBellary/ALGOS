using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class Product
    {
        public int Id;
        public string Name;
        public string Description;
        public ProductType Type;
    }

    public enum ProductType
    {
        SmartPhone,
        WashingMachine,
        Telivision,
        Laptop
    }
}
