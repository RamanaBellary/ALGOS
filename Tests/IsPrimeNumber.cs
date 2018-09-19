using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class IsPrimeNumber
    {
        public static void Do()
        {
            isPrimeNumber();
        }
        private static void isPrimeNumber()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number to know if it is Prime or not:");
                var num = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(num))
                    break;
                bool isPrime = true;
                int n;
                if (int.TryParse(num, out n))
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (i == n)
                            continue;
                        if (n % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    Console.WriteLine($"Is {num} a Prime number :" + isPrime);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number..");
                }
            }
        }
    }
}
