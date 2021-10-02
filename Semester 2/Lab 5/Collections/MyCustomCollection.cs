using System;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Collections
{
    public class MyCustomCollection<T> : ICustomCollection<T>
    {
        public class Node
        {
            public T data { get; set; }
            public Node next;

            public Node(T d)
            {
                data = d;
                next = null;
            }
        }

        private Node head;
        private Node pointer;
        private int size;

        public MyCustomCollection()
        {
            head = null;
            pointer = null;
            size = 0;
        }

        public void Reset()
        {
            pointer = head;
        }

        public void Next()
        {
            pointer = pointer?.next;
        }
        
        public T Current()
        {
            if (size == 0)
            {
                throw new Exception("No items!");
            }

            if (pointer == null)
            {
                throw new ArgumentNullException();
            }

            return pointer.data;
        }

        public int Count => size;

        public void Add(T item)
        {
            var temp = new Node(item);

            if (head == null && size == 0)
            {
                temp.next = null;
                head = temp;
            }
            else
            {
                temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = new Node(item);
            }

            size++;
        }

        private void Pop_front()
        {
            head = head.next;
            size--;
        }

        public void Remove(T item)
        {
            if (size == 0)
            {
                throw new Exception("No items to delete!");
            }

            if (head.data.Equals(item))
            {
                Pop_front();
            }
            else
            {
                for (var temp = head; temp != null; temp = temp.next)
                {
                    if (temp.next.data.Equals(item))
                    {
                        temp.next = temp.next.next;
                        size--;
                        break;
                    }
                }
            }
        }

        public T RemoveCurrent()
        {
            T value = pointer.data;
            Remove(value);
            return value;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new Exception("Index mustn't be negative!");
                }

                if (index > size - 1)
                {
                    throw new Exception("Index mustn't be bigger than amount of items!");
                }

                var temp = head;
                for (int i = 0; i < index; ++i)
                {
                    temp = temp.next;
                }

                return temp.data;
            }
            set
            {
                if (index < 0)
                {
                    throw new Exception("Index mustn't be negative!");
                }

                if (index > size - 1)
                {
                    throw new Exception("Index mustn't be bigger than amount of items!");
                }

                var temp = head;
                for (int i = 0; i < index; ++i)
                {
                    temp = temp.next;
                }

                temp.data = value;
            }
        }

        public void Print()
        {
            for (var temp = head; temp != null; temp = temp.next)
            {
                Console.Write($"{temp.data}\t");
            }
        }
    }
}
