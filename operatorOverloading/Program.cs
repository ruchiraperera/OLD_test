using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle obj1 = new Rectangle(1,2);
            Rectangle obj2 = new Rectangle(2,6);

            if (obj1 > obj2)
            {
                Console.WriteLine("Rectangle1 is greater than Rectangle2");
            }

            if (obj1 < obj2)
            {
                Console.WriteLine("Rectangle1 is less than Rectangle2");
            }
        }
    }
}
