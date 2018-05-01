using DataStructuresAndAlgorithms.DataStructures;
using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Doubly linked list
            LinkedLists.SLL<int> dll = new LinkedLists.SLL<int>();
            int i = dll.Delete();
            dll.Traverse();  // output -> 2, 3, 4, 5
        }
    }
}
