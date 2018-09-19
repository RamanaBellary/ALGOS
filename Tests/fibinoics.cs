using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class Fibinoics
    {
        public static void Do()
        {
            fibinoics();
        }

        private static void fibinoics()
        {
            Console.WriteLine("Enter a number to get the Fibinoic :");
            string num = Console.ReadLine();
            int n, val = 0;

            if (int.TryParse(num, out n))
            {
                val = n;
                for (int i = n; i > 1; i--)
                {
                    val *= (i - 1);
                }
            }

            Console.WriteLine($"Fibnoic of {num} is " + val);
        }
    }
}
