using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicallyCallMethods
{
    public class customer
    {

        public customer()
        {
            Console.WriteLine("Constructor");
        }

        public void display(int i) {

            Console.WriteLine("Display function executed - {0}",i);
        }
    }
}
