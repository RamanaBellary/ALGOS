using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS
{
    public class EquitableEx
    {
        public static void Do()
        {
            IEquitableEx ex1 = new IEquitableEx { Prop1 = "p1", Prop2 = 1 };
            IEquitableEx ex2 = new IEquitableEx { Prop1 = "p2", Prop2 = 2 };
            IEquitableEx ex3 = new IEquitableEx { Prop1 = "p1", Prop2 = 1 };
            IEquitableEx ex4 = ex1;

            Console.WriteLine("ex1.Equals(ex2): "+ ex1.Equals(ex2));
            Console.WriteLine("ex1.Equals(ex3): "+ex1.Equals(ex3));
            Console.WriteLine("ex1.Equals(ex4): "+ex1.Equals(ex4));

            Console.WriteLine("ex1 == ex2: " + (ex1 == ex2));
            Console.WriteLine("ex1 == ex3: " + (ex1 == ex3));
            Console.WriteLine("ex1 == ex4 : " + (ex1 == ex4));
        }
    }
    public class IEquitableEx : IEquatable<IEquitableEx>
    {
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            return Equals(obj as IEquitableEx);
        }

        public bool Equals(IEquitableEx other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (this.GetType() != other.GetType())
                return false;

            return this.Prop1.Equals(other.Prop1) && Prop2.Equals(other.Prop2);
        }

        public override int GetHashCode()
        {
            return Prop1.GetHashCode() ^ Prop2.GetHashCode();
        }
    }
}
