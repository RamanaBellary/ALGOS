using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class DelegatesEx
    {
        public static void Do()
        {
            Subscriber1 s1 = new Subscriber1();
            Subscriber2 s2 = new Subscriber2();
            Pub.Do();
        }
    }

    public delegate void PassMessage(string message);
    public class Pub
    {
        public static PassMessage passMessage;
        public static void Do()
        {
            passMessage?.Invoke("Message from Pub");
        }
    }

    public class Subscriber1
    {
        public Subscriber1()
        {
            Pub.passMessage += GetMessage;
        }

        private void GetMessage(string msg)
        {
            Console.WriteLine("Subscriber1: " + msg);
        }
    }

    public class Subscriber2
    {
        public Subscriber2()
        {
            Pub.passMessage += GetMessage;
        }

        private void GetMessage(string msg)
        {
            Console.WriteLine("Subscriber2: " + msg);
        }
    }
}
