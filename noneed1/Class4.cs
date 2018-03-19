using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noneed1
{
    class Class4
    {
    }



    static class ExtensionCls {


        public static void display(this Class4 _on, string name) {

            Console.WriteLine(name);
        }
    }


}
