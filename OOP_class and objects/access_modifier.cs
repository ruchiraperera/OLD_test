using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_class_and_objects
{

    //public class can be accessed in any place
    public class access_modifier
    {

        public void display()
        {
            Console.WriteLine("Display here");
        }
    }




    public class basePrivateClass
    {

        private void display()
        {
            Console.WriteLine("Private base Class");
        }

    }


    //private methods can be accessed within the class only
    public class derivedPrivateClass : basePrivateClass
    {


        public void display()
        {
            //base class display method is not available.
            //base.display();
        }
    }


    //protected - same as private but additionally it can be accessed by derived class as well
    public class protectedBaseClass
    {

        protected void display()
        {
            Console.WriteLine("Display protected class");
        }
    }

    public class protectedDerivedClass : protectedBaseClass
    {
        public protectedDerivedClass()
        {
            //base class display method is available.
            base.display();
        }
    }


    //protected internal -access from same assembly or derived class

    public class BaseProtectedInternalClass
    {

        protected internal void display()
        {
            Console.WriteLine("Display here");
        }
    }


    public class DerivedProtectedInternalClass : BaseProtectedInternalClass
    {

        protected internal void display()
        {

            base.display();
        }

    }



}
