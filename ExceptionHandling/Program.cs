using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //if exception comes dividedVyZero exception then it will be complie time error
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception ee)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Result is {0}", div);



            Console.Read();
        }
    }
}
