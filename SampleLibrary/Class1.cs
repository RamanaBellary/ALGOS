using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public class SampleClass
    {
        public int MyProperty { get; set; }

        private string localVar;
        public string Method1(string s)
        {
            localVar = "You have set localVar to :" + s;
            return localVar;
        }
    }
}
