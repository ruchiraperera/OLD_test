using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] _test = new string[1]; //array
            string[,,] _test2 = new string[2, 2, 3]; //multi dimention array
            string[][] _test1 = new string[2][]; //jagged array

            _test1[0] = new string[5];
            _test1[1] = new string[9];

            //list or array

            //resizing array is exprensive...
            //list is one dimentional and there is no fix size of length
            //there are 3 types of arrays (multi dimention, jagged array and single array)

            //array is good when there is fix size of elements


            Console.Read();
        }
    }
}
