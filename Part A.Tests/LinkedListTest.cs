using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Part_A.Tests
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void GetFirstElementFromTail()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.AddLast(20);
            linkedList.AddLast(21);
            linkedList.AddLast(22);

            var actual = linkedList.ElementFromTailAt(0).Value;
            var expected = 22;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestLinkedListLowerBoundary()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.AddLast(20);
            linkedList.AddLast(21);
            linkedList.AddLast(22);

            var actual = linkedList.ElementFromTailAt(-1).Value;
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestLinkedListUpperBoundary()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.AddLast(20);
            linkedList.AddLast(21);
            linkedList.AddLast(22);

            var actual = linkedList.ElementFromTailAt(3).Value;
        }
    }
}
