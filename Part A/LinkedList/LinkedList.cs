using System;

namespace Part_A.LinkedList
{
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddLast(object data)
        {
            var newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        private Node ElementAt(int index)
        {
            if (index >= Count || index < 0)
                throw new IndexOutOfRangeException();

            var curr = head;
            for (int i = 0; i <= index; i++)
                curr = curr.Next;
            return curr;
        }

        public Node ElementFromTailAt(int indexFromTail)
        {
            //  Count starts from 1, but index starts from 0
            var index = Count - indexFromTail - 1;
            return ElementAt(index);
        }
    }
}
