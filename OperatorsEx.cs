using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class OperatorsEx
    {
        public static void Do()
        {
            Box b1 = new Box(1, 2, 3);
            Box b2 = new Box(6, 5, 4);
            var b3 = b1 + b2;
        }
    }

    public struct Box
    {
        int l, b, w;
        public Box(int length, int bredth, int width)
        {
            this.l = length;
            this.b = bredth;
            this.w = width;
        }

        public static Box operator +(Box a, Box b)
        {
            return new Box(a.l + b.l, a.b + b.b, a.w + b.w);
        }

    }
}
