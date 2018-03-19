using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noneed1
{
    class Program
    {
        public delegate void display(string name);


        static void testing(string test)
        {

            Console.WriteLine(test);
        }


        static void Main(string[] args)
        {

            Class6 _cls6 = new Class6();
            _cls6.run();

            Console.Read();






            //Class3 _cls = new Class3();
            //_cls.onTest += _cls_onTest;
            //_cls.display();

            //Class4 _cls1 = new Class4();
            //_cls1.display("Ruchira");    

            // display _d = testing;

            // _d("running");

            //array vs list

            //fixed number of element.....

            //constructor chaining

            //C _v = new C();
            //D V2 = new D(1,2);

            //Console.Read();

            // Class1 _cls = new Class1();
            //_cls.ThreadRun();


            //LinkedList<Student> _std = new LinkedList<Student>();
            //_std.AddLast(new Student() { ID = 1, Name = "Ruchira", Marks = 100 });
            //_std.AddLast(new Student() { ID = 2, Name = "Ruchira2", Marks = 100 });
            //_std.AddLast(new Student() { ID = 3, Name = "Ruchira3", Marks = 100 });
            //LinkedListNode<Student> _node = _std.Find(_std.Where(x => x.ID == 3).First());
            //LinkedListNode<Student> _sc = new LinkedListNode<Student>(new Student() { ID = 5, Name = "Ruchira3", Marks = 100 });
            //_node.List.AddFirst(_sc);                

            //(_node, new Student() { ID = 4, Name = "Ruchira4", Marks = 70 });

            //testLinkedList<Student> _s = new testLinkedList<Student>(new Student() { ID = 1, Name = "Ruchira", Marks = 100 });
            //_s.insert(new Student() { ID = 2, Name = "Ruchira1", Marks = 90 });
            //_s.insert(new Student() { ID = 3, Name = "Ruchira2", Marks = 80 });

            Console.Read();

        }

        private static void _cls_onTest(string events)
        {
            Console.WriteLine(events);
        }
    }
}
