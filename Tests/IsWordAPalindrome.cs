using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class IsWordAPalindrome
    {
        public static void Do()
        {
            isWordAPalindrome();
        }

        private static void isWordAPalindrome()
        {
            while (true)
            {
                Console.WriteLine("Please enter a word to know if it is Palindrome or not :");
                var text = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(text))
                    break;
                bool isMatch = true;
                for (int i = 0, j = text.Length - 1; i < j; i++, j--)
                {
                    if (!text.Substring(i, 1).Equals(text.Substring(j, 1)))
                    {
                        isMatch = false;
                        break;
                    }
                }
                Console.WriteLine($"Is {text} a Palindrome :" + isMatch);
            }
        }
    }
}
