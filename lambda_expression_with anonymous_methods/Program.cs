using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expression_with_anonymous_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, string> func = (x, y) => (x * y).ToString();
            Console.WriteLine(func(5, 20));

            Console.Read();
        }
    }
}
