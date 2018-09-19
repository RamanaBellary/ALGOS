using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.Tests
{
    public class taum_and_bday
    {
        public static void Do()
        {
            var t = Convert.ToInt64(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] bw = Console.ReadLine().Split(' ');

                var b = Convert.ToInt64(bw[0]);

                var w = Convert.ToInt64(bw[1]);

                string[] bcWcz = Console.ReadLine().Split(' ');

                var bc = Convert.ToInt64(bcWcz[0]);

                var wc = Convert.ToInt64(bcWcz[1]);

                var z = Convert.ToInt64(bcWcz[2]);

                var result = taumBday(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }

        static long taumBday(long b, long w, long bc, long wc, long z)
        {
            if (bc > z)
            {
                return w * wc + b * wc + z;
            }

            if (wc > z)
            {
                return w * bc + b * bc + z;
            }

            return b * bc + w * wc;
        }
    }
}
