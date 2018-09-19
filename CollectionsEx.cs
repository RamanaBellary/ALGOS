using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class CollectionsEx
    {
        public static void Do()
        {
            Enumerable();
        }

        private static void Enumerable()
        {
            List<Product> lstEntities = new List<Product>()
            {
                new Product {Id=1,Name="RedmiNote5",Description="RedmiNote5",Type=ProductType.SmartPhone },
                new Product {Id=2,Name="Dell Laptop1",Description="Dell Laptop1",Type=ProductType.Laptop },
                new Product {Id=3,Name="Samsung galaxy SL",Description="Samsung galaxy SL",Type=ProductType.SmartPhone },
                new Product {Id=4,Name="Redmi Mi",Description="Redmi Mi",Type=ProductType.SmartPhone },
                new Product {Id=5,Name="Lenovo Laptop 1",Description="Lenovo Laptop 1",Type=ProductType.Laptop },
                new Product {Id=6,Name="LG smart wash",Description="LG smart wash",Type=ProductType.WashingMachine }
            };
            IEnumerable<Product> coll = lstEntities.Where(p => p.Type == ProductType.SmartPhone);
            foreach(var p in coll)
            {

            }
        }
    }
}
