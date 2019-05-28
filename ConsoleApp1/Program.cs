using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        public Node Next { get; set; }
        public Node Previous { get; set; }
        public object Value { get; }

        public Node(object value)
        {
            Value = value;
        }
    }
    class Stack
    {
        public Node First { get; private set; }
        public Node Last { get; private set; }
        public int Count { get; set; }

        public void Clear()
        {
            First = Last = null;
            Count = 0;
        }
        public bool Contains(object obj)
        {
            if (First == null)
                return false;
            Node current = First;
            do
            {
                if (current.Value.Equals(obj))
                {
                    return true;
                }
                current = First.Next;
            }
            while (current != null);
            return false;
        }
        public object Peek()
        {
            if(First == null)
            {
                return null;
            }
            else
            {
                return First;
            }
        }
        public object[] ToArray()
        {

            object[] nodeArr = new object[Count];
            Node current = First;
            for (int i = 0; i < nodeArr.Length - 1; i++)
            {
                nodeArr[i] = current.Value;
                current = current.Next;
            }
            return nodeArr;
        }
        public void Push(object obj)
        {
            if (First == null)
            {
                First = Last = new Node(obj);
                Count++;
            }
            else
            {
                Node node = new Node(obj);
                First.Previous = node;
                node.Previous = First;
                First = node;
                Count++;
            }
        }
        public object Pop()
        {
            if (First == null)
            {
                return null;
            }
            else
            {
                Node current = First;
                var prev = current.Previous;
                var next = current.Next;
                prev.Next = next;
                next.Previous = prev;
                Count--;
                return current;
            }
        }
    }
    class Qeue
    {
        public Node First { get; private set; }
        public Node Last { get; private set; }
        public int Count { get; set; }

        public void Enqueue(object obj)
        {
            if(First == null)
            {
                First = Last = new Node(obj);
                Count++;
            }
            else
            {
                Node node = new Node(obj);
                Last.Next = node;
                node.Previous = Last;
                Last = node;
                Count++;
            }
        }
        public object Deqeue()
        {
            if (First == null)
            {
                return null;
            }
            else
            {
                Node current = First;
                var prev = current.Previous;
                var next = current.Next;
                prev.Next = next;
                next.Previous = prev;
                Count--;
                return current;
            }
        }
        public void Clear()
        {
            First = Last = null;
            Count = 0;
        }
        public bool Contains (object obj)
        {
            if (First == null)
                return false;
            Node current = First;
            do
            {
                if (current.Value.Equals(obj))
                {
                    return true;
                }
                current = First.Next;
            }
            while (current != null);
            return false;
        }
        public object Peek ()
        {
            if (First == null)
            {
                return null;
            }
            else
            {
                return First;
            }
        }
         public object[] ToArray()
        {

            object[] nodeArr = new object[Count];
            Node current = First;
            for (int i = 0; i < nodeArr.Length - 1; i++)
            {
                nodeArr[i] = current.Value;
                current = current.Next;
            }
            return nodeArr;
        }
    }
    class LinkedList
    {
        public Node First { get; private set; }
        public Node Last { get; private set; }
        public int Count { get; set; }

        public void Add(object newItem)
        {

            if (First == null)
            {
                First = Last = new Node(newItem);
                Count++;
            }
            else
            {
                Node node = new Node(newItem);
                Last.Next = node;
                node.Previous = Last;
                Last = node;
                Count++;
            }

        }

        public void AddFirst(object newItem)
        {
            if (First == null)
            {
                First = Last = new Node(newItem);
                Count++;
            }
            else
            {
                Node node = new Node(newItem);
                First.Previous = node;
                node.Next = First;
                First = node;
                Count++;
            }
        }
        public void Remove(object obj)
        {
            if (First == null)
                return;
            if (Last == First && obj.Equals(First))
            {
                First = Last = null;
            }
            else if (Last.Value.Equals(obj))
            {
                Last = Last.Previous;
                Count--;
            }
            else
            {
                Node current = First;
                do
                {
                    if (current.Value.Equals(obj))
                    {
                        var prev = current.Previous;
                        var next = current.Next;
                        prev.Next = next;
                        next.Previous = prev;
                        Count--;
                    }
                    else
                    {
                        current = First.Next;
                        Count--;
                    }
                }
                while (current != null);
            }
        }
        public void RemoveFirst()
        {
            if (First == null)
                return;
            if (Last == First)
            {
                First = Last = null;
            }
            else
            {
                First = First.Next;
                Count--;
            }
        }
        public void RemoveLast()
        {
            if (First == null)
                return;
            if (Last == First)
            {
                First = Last = null;
            }
            else
            {
                Last = Last.Previous;
                Count--;
            }
        }
        public bool Contains(object obj)
        {
            if (First == null)
                return false;
            Node current = First;
            do
            {
                if (current.Value.Equals(obj))
                {
                    return true;
                }
                current = First.Next;
            }
            while (current != null);
            return false;
        }
        public void PrintList()
        {
            if (First == null)
                return;

            Node current = First;
            do
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            while (current != null);
        }

        public object[] ToArray()
        {

            object[] nodeArr = new object[Count];
            Node current = First;
            for (int i = 0; i < nodeArr.Length - 1; i++)
            {
                nodeArr[i] = current.Value;
                current = current.Next;
            }
            return nodeArr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();

            list.Add(1);
            list.Add(234);
            list.Add(666);
            list.Add(12);
            list.Add(69);
            list.Add(100);
            list.AddFirst(13);
            list.PrintList();

            object[] arrayFromList = list.ToArray();

            for (int i = 0; i < arrayFromList.Length; i++)
            {
                Console.WriteLine(arrayFromList[i]);
            }

            //list.PrintList();
        }
    }
}
