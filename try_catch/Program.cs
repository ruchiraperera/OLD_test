using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            finally {

            }


            Console.Read();


            //But that's not the fault of using statement though. It's because how the finally blocks 
            //are handled by CLR.There ARE some cases that finally blocks will not execute. If you have 
            //an unhandled exception and if the CLR thinks that executing more code will lead to more errors, 
            //it will not execute Dispose method(because it will not execute the finally block which Dispose 
            //method is compiled down to..). Therefore, be very careful and don't put your life into the execution 
            //of Dispose method.

            //The other cases which can cause Dispose method not being executed can be listed as:

            //    Environment.FailFast
            //    OutOfMemoryException and StackOverflowException
            //    Killing the process
            //    Power loss



        }
        }
}
