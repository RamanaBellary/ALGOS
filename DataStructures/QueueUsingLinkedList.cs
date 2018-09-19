using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.DataStructures
{
    public class QueueUsingLinkedList
    {
        public static void Do()
        {
            MyCustomQueue<int> queue = new MyCustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            var v = queue.Peek();
            var v2 = queue.DeQueue();
            queue.Enqueue(3);
            var v3 = queue.Peek();
        }
    }

    public class MyCustomQueue<T>
    {
        LinkedList<T> queue = new LinkedList<T>();

        public void Enqueue(T item)
        {
            queue.AddLast(item);
        }

        public T DeQueue()
        {
            var item = queue.First();
            queue.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            return queue.First();
        }
    }
}
