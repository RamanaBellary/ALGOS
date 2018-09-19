using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class ReflectionEx
    {
        public static void Do()
        {
            var assembly = Assembly.LoadFile(@"D:\Mine\Samples\ALGOS\SampleLibrary\bin\Debug\SampleLibrary.dll");
            var classType = assembly.GetType("SampleLibrary.SampleClass");
            var classInstance = Activator.CreateInstance(classType);
            var resp = classType.InvokeMember("Method1", BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.Instance, null, classInstance, new object[] { "MyValue" });
            var prop = classType.GetProperty("MyProperty");
            prop.SetValue(classInstance, 100);
            var val = prop.GetValue(classInstance);
        }
    }    
}
