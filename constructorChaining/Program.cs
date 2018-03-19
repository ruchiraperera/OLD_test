using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new derived(1);
            Console.Read();
        }

        class derived : Itest, IItest2
        {

            public derived()
            {

            }

            public derived(string name) : this()
            {

            }

            public derived(int i) : this("ruchira")
            {

            }


            //this is wrong.....
            /*public void testing():this()
            {
                throw new NotImplementedException();
            }*/

            public void testing()
            {
                throw new NotImplementedException();
            }
        }

        interface Itest
        {

            void testing();
        }

        interface IItest2
        {
            void testing();
        }
    }
}
