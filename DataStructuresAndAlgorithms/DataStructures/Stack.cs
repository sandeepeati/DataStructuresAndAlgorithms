using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Stack<T>
    {
        private class Node
        {
            private static int _size = 0;
            public T data { get; set; }
            public bool IsEmpty()
            {
                return _size == 0;
            }
            public Node prev = null;

            public void Print()
            {
                Console.WriteLine("Node Found: ");
                Console.WriteLine($"\tNode Value: {data}");
            }
        }

        // an endNode to keep track of the last node
        private Node endNode = null;

        // an empty stack
        public Stack()
        {
        }

        public void Push(T val)
        {
            Node @new = new Node();
            @new.data = val;
            @new.prev = endNode;
            endNode = @new;
        }

        public T Pop()
        {
            T val = endNode.data;
            endNode = endNode.prev;
            return val;
        }

        public T Peek()
        {
            return endNode.data;
        }

        public void Traverse()
        {
            Node current = endNode;
            while (current != null)
            {
                current.Print();
                current = current.prev;
            }
        }
    }
}
