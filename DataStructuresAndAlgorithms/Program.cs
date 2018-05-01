using DataStructuresAndAlgorithms.DataStructures;
using System;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Doubly linked list
            LinkedLists.DLL<int> dll = new LinkedLists.DLL<int>(1);
            dll.Insert(2);
            dll.Insert(3);
            dll.Insert(4);
            dll.Insert(5);
            int i = dll.Delete(0);
            dll.Traverse();  // output -> 2, 3, 4, 5
            }
    }
}
