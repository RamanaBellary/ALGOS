using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGOS.DataStructures
{
    public class Node<T>
    {
        private Node<T> _next;
        private Node<T> _previous;
        private T _data;
        public Node(T data)
        {
            _data = data;
            _next = null;
            _previous = null;
        }

        public Node<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }

        public Node<T> Previous
        {
            get { return _previous; }
            set { _previous = value; }
        }
    }

    public class DoubleLinkedList<T>
    {
        private Node<T> _first;
        public Node<T> First
        {
            get { return _first; }
            set
            {
                _first = value;
            }
        }

        private Node<T> _last;
        public Node<T> Last
        {
            get { return _last; }
            set
            {
                _last = value;
            }
        }

        public Node<T> AddFirst(Node<T> newNode)
        {
            if (_first == null)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                newNode.Next = _first;
                _first = newNode;
                _last = newNode.Next;
                newNode.Next.Previous = newNode;
            }
            return _first;
        }

        public Node<T> AddLast(Node<T> newNode)
        {
            if (_last == null)
            {
                _first = newNode;
                _last = newNode;
            }
            else
            {
                _last.Next = newNode;
                newNode.Previous = _last;
                _last = newNode;
                
            }
            return _last;
        }
    }



    public class MyLinkedList
    {
        public static void Do()
        {
            DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
            var f = dll.First;
            var l = dll.Last;

            Node<int> n2 = new DataStructures.Node<int>(2);
            dll.AddFirst(n2);

            Node<int> n1 = new Node<int>(1);
            dll.AddFirst(n1);

            Node<int> n3 = new Node<int>(3);
            dll.AddLast(n3);
        }
    }
}
