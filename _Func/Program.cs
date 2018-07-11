using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Func
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> _func = (x, t) => x + t;
            _func(1, 2);

            Func<int, int> method = display;

            IAsyncResult _result = method.BeginInvoke(1, null, null);

            Console.WriteLine("Closed {0}", _result.ToString());

            int result = method.EndInvoke(_result);
            Console.WriteLine("String length is: " + result);

            Console.Read();

        }


        public static int display(int i) {
            System.Threading.Thread.Sleep(2000);
            return i;

        }
    }
}
