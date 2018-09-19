using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class ManipulativeEmployee
    {
        public static void Do()
        {
            while (true)
            {
                var scenarios = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(scenarios))
                    break;
                int t = 0;
                if (int.TryParse(scenarios, out t) && t >= 1 && t <= 20)
                {
                    for (int i = 0; i < t; i++)
                    {
                        var l = Console.ReadLine();
                        var values = Console.ReadLine();
                        var arr = values.Split(new char[] { ' ' }, StringSplitOptions.None);
                        int len = 0;
                        if (int.TryParse(l, out len) && 1 <= len && len <= 20 &&
                           !string.IsNullOrWhiteSpace(values) && arr.Length == len)
                        {
                            bool isYes = false;
                            int count = 0;
                            for (int k = 0; k < arr.Length; k++)
                            {
                                if (arr.Length <= k + 1)
                                    break;
                                int m = Convert.ToInt32(arr[k]);
                                int n = Convert.ToInt32(arr[k + 1]);

                                if (m <= n && m >= 1 && m <= 2000 && n >= 1 && n <= 2000)
                                {
                                    isYes = true;
                                }
                                else
                                {
                                    isYes = false;
                                    count++;
                                }
                            }

                            if (isYes)
                                Console.WriteLine("YES");
                            else
                            {
                                if (count <= 1)
                                    Console.WriteLine("YES");
                                else
                                    Console.WriteLine("NO");
                            }
                        }
                    }
                }
            }
        }
    }
}
