using NUnit.Framework;
using DataStructuresAndAlgorithms.DataStructures;
using System.Collections.Generic;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StackTest()
        {
            DataStructuresAndAlgorithms.DataStructures.Stack<int> stack = 
                new DataStructuresAndAlgorithms.DataStructures.Stack<int>();
            stack.Push(1);
            int d = stack.Peek();
            int i = stack.Pop();
            Assert.IsTrue(i == 1 && d == 1);
        }

        [Test]
        public void LinkedListSLLTest()
        {
            LinkedLists.SLL<int> sll = new LinkedLists.SLL<int>();
            sll.Insert(1);
            sll.Insert(2);
            sll.Insert(3);
            sll.Delete();
            sll.Insert(4);
            sll.Insert(5);
            sll.Delete(2);
            var l = sll.GetNodesDataAsList();
            var t = new List<int>(){ 1, 2, 5 };
            Assert.AreEqual(t, l);
        }

        [Test]
        public void LinkedListDLLTest()
        {
            LinkedLists.DLL<int> dll = new LinkedLists.DLL<int>();
            dll.Insert(1);
            dll.Insert(2);
            dll.Insert(3);
            dll.Delete();
            dll.Insert(4);
            dll.Insert(5);
            dll.Delete(2);
            var l = dll.GetNodesDataAsList();
            var t = new List<int>() { 1, 2, 5 };
            Assert.AreEqual(t, l);
        }
    }
}