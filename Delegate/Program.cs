using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //immutable as string 
    delegate void display(string name);
    class Program
    {        
        static void Main(string[] args)
        {
            //01 way
            display _h = new display(test);
            _h("Ruchira");


            //02 way
            display _u;
            _u = test;

            _u("Etst1");

            //delegate.combine

            display first, second, thrid, multidele, multiminusdele;

            first = test;
            second = test;
            thrid = test;

            //multiple delegates
            multidele = first + second + thrid;

            // multi minus delegates
            multiminusdele = multidele - (second + thrid);


            first("Ruchira");
            second("Himal");
            thrid("Perera");


            multidele("multidelegate");

            multiminusdele("test");


            Console.Read();
        }


        static void test(string u) {

            Console.WriteLine(u);
        }
    }
}
