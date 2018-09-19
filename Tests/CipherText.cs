using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class CipherText
    {
        public static void Do()
        {
            cipherText();
        }

        private static void cipherText()
        {
            Console.WriteLine("Enter a key(single digit number) to cipher the text...");
            var key = Console.ReadLine();

            List<string> lst = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };

            int n;
            if (int.TryParse(key, out n))
            {
                while (true)
                {
                    Console.WriteLine("Enter the text which you want to cipher..");
                    var text = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(text))
                        break;
                    foreach (char c in text.ToCharArray())
                    {
                        if (lst.Contains(c.ToString().ToLower()))
                        {
                            var index = lst.IndexOf(c.ToString());
                            var newIndex = index + n;
                            if (newIndex > lst.Count() - 1)
                                newIndex = newIndex - lst.Count();
                            Console.Write(lst[newIndex]);
                        }
                        else
                        {
                            Console.Write(c);
                        }
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            }
        }
    }
}
