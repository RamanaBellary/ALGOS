using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.DataStructures
{
    public class StackUsingLinkedList
    {
        public static void Do()
        {
            MyCustomStack<int> stack = new MyCustomStack<int>();
            stack.Push(10);
            stack.Push(9);
            var v = stack.Peek();
            v = stack.Pop();
        }
    }

    public class MyCustomStack<T>
    {
        LinkedList<T> lst = new LinkedList<T>();

        public void Push(T item)
        {
            var first = lst.First;

            if(first == null)
            {
                lst.AddFirst(item);
            }
            else
            {
                lst.AddBefore(first,item);
            }
        }

        public T Pop()
        {
            T node = default(T);

            if (lst.Count == 0)
                return node;

            node = lst.First();
            lst.RemoveFirst();

            return node;
        }

        public T Peek()
        {
            return lst.First();
        }
    }
}
