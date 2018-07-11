using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedList_linkedListNode
{

    class test
    {

        public int amount { get; set; }
        public test Node { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            LinkedListNode<test> lln1 = new LinkedListNode<test>(new test { amount = 20 });

            LinkedList<test> _linkedNode = new LinkedList<test>();
            _linkedNode.AddLast(new test() { amount = 10 });
            _linkedNode.AddLast(new test() { amount = 10 });
            _linkedNode.AddLast(new test() { amount = 10 });


            _linkedNode.AddLast(lln1);

            _linkedNode.AddLast(new test() { amount = 20 });

            DisplayProperties(lln1);



            Console.Read();

        }

        public static void DisplayProperties(LinkedListNode<test> lln)
        {
            if (lln.List == null)
                Console.WriteLine("   Node is not linked.");
            else
                Console.WriteLine("   Node belongs to a linked list with {0} elements.", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("   Previous node is null.");
            else
                Console.WriteLine("   Value of previous node: {0}", lln.Previous.Value);

            Console.WriteLine("   Value of current node:  {0}", lln.Value);

            if (lln.Next == null)
                Console.WriteLine("   Next node is null.");
            else
                Console.WriteLine("   Value of next node:     {0}", lln.Next.Value);

            Console.WriteLine();
        }
    }
}
