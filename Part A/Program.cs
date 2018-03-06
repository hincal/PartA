using System;

namespace Part_A
{
    class Program
    {
        static void Main(string[] args)
        {
            var lnklist = new LinkedList.LinkedList();

            lnklist.AddLast(2);
            lnklist.AddLast(3);
            lnklist.AddLast(4);
            lnklist.AddLast(5);
            lnklist.AddLast(6);
            lnklist.AddLast(7);
            lnklist.AddLast(8);
            lnklist.AddLast(9);
            lnklist.AddLast(10);
            lnklist.AddLast(11);
            lnklist.AddLast(12);

            Console.WriteLine(lnklist.ElementFromTailAt(5).Value);

            Console.ReadKey();
        }
    }
}
