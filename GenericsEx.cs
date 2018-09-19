using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class GenericsEx
    {
        public static void Do()
        {
            //Example1
            #region getDefaultValue
            //dynamic val = getDefaultValue<int>();
            //val = getDefaultValue<string>();
            //val = getDefaultValue<Boolean>();
            //val = getDefaultValue<bool>();
            #endregion

            //Example2
            //var c = add<int>(new int[] { 10, 20 });
        }

        private static T getDefaultValue<T>()
        {
            switch (typeof(T).Name)
            {
                case "Int32":
                    return (dynamic)(-1);
                case "String":
                    return (dynamic)string.Empty;
                case "Boolean":
                case "bool":
                    return (dynamic)false;
                default:
                    return default(T);
            }
        }

        private static T add<T>(T[] args)
        {
            dynamic sum = default(T);
            foreach (var v in args)
                sum += v;
            return sum;
        }
    }
}
