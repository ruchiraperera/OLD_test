using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noneed1
{

   


    class Class3
    {

        public delegate void eventHandler(string events);
        public event eventHandler onTest = null;

        public Class3()
        {

        }

        public void display() {

            if (onTest != null)
                onTest("Ruchira");
        }
    }
}
