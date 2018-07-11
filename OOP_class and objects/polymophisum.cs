using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_class_and_objects
{
    class polymophisum
    {





    }


    // complie time polymorphism (overloading)

    public class baseOverloading
    {

        public void display()
        {

            Console.WriteLine("base display method");

        }
    }

    public class derivedOverloading : baseOverloading
    {

        public void display(int number)
        {

            Console.WriteLine("{0} number", number);
        }
    }



    //runtime polymorphism - override


    public class baseOverride {


        public virtual void display() {
            Console.WriteLine("base class method");
        }
    }

    public class derivedClass : baseOverride {

        public override void display()
        {
            base.display();
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, "test");
        }
    }
}
