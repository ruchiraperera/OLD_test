using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public class Aclass
    {
        public Aclass()
        {

        }

        public void display() {

            Console.WriteLine("testing extension method");
        }
    }



    public static class XX {

        public static void newMethod(this Aclass _on,int x) {

            Console.WriteLine("new method added {0}",x);
        }
    }
    
}
