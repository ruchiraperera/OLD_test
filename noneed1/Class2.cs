using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noneed1
{
    class A
    {

        public A()
        {
            Console.WriteLine("Constructor A");
        }
    }

    class B : A
    {


        public B():base()
        {           
            Console.WriteLine("Constructor B");
        }
    }

    class C : B
    {

        public C() : base()
        {
            Console.WriteLine("Constructor C");
        }
    }



    class D {

        public D()
        {
            Console.WriteLine("Default constructor");
        }

        public D(int x):this()
        {
            Console.WriteLine("second constructor");
        }

        public D(int x, int c):this(1)
        {
            Console.WriteLine("third constructor");
        }

        
    }
}
