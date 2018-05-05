using DataStructuresAndAlgorithms.DataStructures;
using System;

namespace DataStructuresAndAlgorithms
{
    class Program   
    {
        static void Main(string[] args)
        {
            // Testing Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            int d =stack.Pop();
            Console.WriteLine($"popped value {d}");
            stack.Push(4);
            stack.Push(5);
            stack.Traverse();
        }
    }
}
