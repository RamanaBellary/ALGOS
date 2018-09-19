using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class HowManyLetters
    {
        static List<List<string>> comb;
        static bool[] used;
        static List<string> combinations = new List<string>();
        static List<string> lstDictonary;

        static void GetCombinationSample(char[] arr)
        {
            //int[] arr = { 10, 50, 3, 1, 2 };
            used = new bool[arr.Length];
            for (int i = 0; i < used.Length - 1; i++)
                used[i] = false;
            comb = new List<List<string>>();
            List<string> c = new List<string>();
            GetComb(arr, 0, c);
            StringBuilder sb;
            foreach (var item in comb)
            {
                sb = new StringBuilder();
                foreach (var x in item)
                {
                    sb.Append(x);
                }
                combinations.Add(sb.ToString());
            }
        }
        static void GetComb(char[] arr, int colindex, List<string> c)
        {
            if (colindex >= arr.Length)
            {
                comb.Add(new List<string>(c));
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    c.Add(arr[i].ToString());
                    GetComb(arr, colindex + 1, c);
                    c.RemoveAt(c.Count - 1);
                    used[i] = false;
                }
            }
        }
        public static void Do()
        {
            
            int t = 0;
            if (int.TryParse(Console.ReadLine(), out t) && 1 <= t && t <= 1000)
            {
                for (int i = 0; i < t; i++)
                {
                    bool foundMatch = false;
                    var strArr = Console.ReadLine().Split(new char[] { ' ' });

                    if (strArr?.Length > 0)
                    {
                        int n = 0;
                        if (int.TryParse(strArr[0], out n) && 1 <= n && n <= 1500 && strArr.Length == n + 2)
                        {
                            lstDictonary = new List<string>();
                            for (int wi = 1; wi <= n; wi++)
                            {
                                lstDictonary.Add(strArr[wi]);
                            }

                            var str = strArr[strArr.Length - 1];
                            if (!string.IsNullOrWhiteSpace(str))
                            {
                                //GetCombinationSample(str.ToCharArray());
                                combinations.Sort();
                                foreach (var word in lstDictonary)
                                {
                                    foreach (var c in combinations)
                                    {
                                        if (c == word)
                                        {
                                            Console.Write(c);
                                            foundMatch = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (!foundMatch)
                        Console.Write("0");
                    Console.WriteLine();
                }
            }
        }
    }
}
