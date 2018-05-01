using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class LinkedLists 
    {
        // a private node class

        // singly linked list
        public class SLL<T>
        {
            #region class variables
            private static int _count = 0;
            private Node Head;
            #endregion

            #region Constructors
            // constructor
            public SLL(T value)
            {
                Node node = new Node();
                node.data = value;
                node.next = null;
                _count += 1;
                Head = node;
            }
            #endregion

            private class Node
            {
                public T data { get; set; }
                public Node next { get; set; }

                public void Print()
                {
                    Console.WriteLine($"Node of type {typeof(T)}: ");
                    Console.WriteLine($"\tValue: {data}");
                    if (next != null)
                        Console.WriteLine($"\tNext: {next.data}");
                    Console.WriteLine("\n");
                }
            }

            // inserting a new node into the list
            public void Insert(T value, int index = -1)
            {
                Node current = Head;
                #region new node creation
                Node @new = new Node();
                @new.data = value;
                @new.next = null;
                #endregion

                // default value is -1 which specifies that the node has to be added at the end of the linkedlist
                if (index == -1)
                {
                    while(current.next != null)
                    {
                        current = current.next;
                    }

                    // adding the new node to the end of the list
                    current.next = @new;
                }  // end of the list
                else if (index == 0)
                {
                    @new.next = Head;
                    Head = @new;
                } // head of the  list
                else
                {
                    // first check if the index is greater than the count
                    if (index > _count)
                    {
                        Console.WriteLine("Index is greater than the count.");
                        return;
                    }
                    // variable to keep track of the index
                    int i = 0;
                    while (i < index - 1)
                    {
                        current = current.next;
                        i += 1;
                    }
                    // now current is pointing to the node before the required position
                    @new.next = current.next;
                    current.next = @new;
                } // middle of the list

                _count += 1; // increasing the count
            }

            // deleting a new node and returning the value from the list
            public T Delete(int index = -1)
            {
                Node current = Head;
                T val;
                if (index == -1)
                {
                    while (current.next.next != null)
                    {
                        current = current.next;
                    }

                    // current is now pointing to last but one index
                    val = current.next.data;
                    current.next = null;
                }  // end of the list
                else if (index == 0)
                {
                    val = Head.data;
                    Head = Head.next;
                } // head of the  list
                else
                {
                    // first check if the index is greater than the count
                    if (index > _count)
                    {
                        throw new IndexOutOfRangeException("Index is greater than the count.");
                    }
                    // variable to keep track of the index
                    int i = 0;
                    while (i < index - 1)
                    {
                        current = current.next;
                        i += 1;
                    }
                    // now current is pointing to the node before the required position
                    Node temp = current.next.next;
                    current.next.next = null;
                    val = current.next.data;
                    current.next = temp;
                } // middle of the list
                _count -= 1;
                return val;
            }

            // traversal of the linkedlist
            public void Traverse()
            {
                Node current = Head;
                while(current != null)
                {
                    current.Print();
                    current = current.next;
                }
            }
        }

        // Doubly linked list
        public class DLL<T>
        {

            #region class variables
            private static int _count = 0;
            private Node Head;
            #endregion
            private class Node
            {
                public T data { get; set; } = default(T);
                public Node prev { get; set; }
                public Node next { get; set; }

                public void Print()
                {
                    Console.WriteLine($"Node of type {typeof(T)}: ");
                    Console.WriteLine($"\tValue: {data}");
                    if (prev != null)
                        Console.WriteLine($"\tPrev node value: {prev.data}");
                    if (next != null)
                        Console.WriteLine($"\tNext node value: {next.data}");
                    Console.WriteLine("\n");
                }
            }

            #region Constructor
            public DLL (T val)
            {
                Node node = new Node();
                node.data = val;
                node.prev = null;
                node.next = null;

                Head = node; 
                _count += 1;
            }
            #endregion

            // inserting a new node into the doubly linked list
            public void Insert(T val, int index = -1)
            {
                Node current = Head;

                #region Creating a new node
                Node @new = new Node();
                @new.data = val;
                @new.prev = null;
                @new.next = null;
                #endregion

                if (index == -1)
                {
                    while (current.next != null)
                    {
                        current = current.next;
                    }

                    // now current points to last node
                    current.next = @new;
                    // also update the @new node prev pointer
                    @new.prev = current;
                }
                else if (index == 0)
                {
                    @new.next = Head;
                    Head.prev = @new;
                    // updating the new head
                    Head = @new;
                }
                else
                {
                    if (index > _count)
                    {
                        throw new IndexOutOfRangeException("[!!! CRIT] Index is larger than count.");
                    }

                    int i = 0;
                    while (i < index-1)
                    {
                        current = current.next;
                        i += 1;
                    }

                    // now current points to the required position
                    Node temp = current.next;
                    current.next = @new;
                    @new.prev = current;

                    @new.next = temp;
                    temp.prev = @new;
                }

                _count += 1;
            }

            // deleting a node from the doubly linked list and returning  the value of the deleted node
            public T Delete (int index = -1)
            {
                T val;
                Node current = Head;
                if (index == -1)
                {
                    while (current.next.next != null)
                    {
                        current = current.next;
                    }

                    // now current is pointing to the last but one node
                    // remove all connections of the last node
                    val = current.next.data;
                    current.next.prev = null;
                    current.next = null;
                }
                else if (index == 0)
                {
                    val = Head.data;
                    Head = Head.next;
                    Head.prev = null;
                }
                else
                {
                    if (index > _count)
                    {
                        throw new IndexOutOfRangeException("[!!! CRIT] Index is greater than count.");
                    }

                    int i = 0;
                    while (i < index - 1)
                    {
                        i += 1;
                        current = current.next;
                    }

                    val = current.next.data;

                    // remove all connections -- total 4 connections
                    Node temp = current.next.next;
                    
                    // removing the connections of the node
                    current.next.next = null;
                    current.next.prev = null;

                    current.next = temp;
                    temp.prev = current;
                }

                _count -= 1;
                return val;
            }

            // Traversing the doubly linked list
            public void Traverse()
            {
                Node current = Head;
                while(current != null)
                {
                    current.Print();
                    current = current.next;
                }
            }
        }
    }
}
