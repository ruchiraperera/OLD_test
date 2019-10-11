using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string temp = null;

            // Use null coalescing syntax to initialize a value.
            string value1 = temp ?? "bird";
            Console.WriteLine("NULL COALESCING: " + value1);

            // Use ternary for same result.
            string value2 = temp == null ? "bird" : temp;
            Console.WriteLine("TERNARY: " + value2);


            Console.ReadKey();
        }
    }
}
