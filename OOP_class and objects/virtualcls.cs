using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_class_and_objects
{
    class virtualcls
    {



        public virtualcls()
        {
            Vehicle _v = new Car();
            _v.display(); //This is a car
        }

    }


    class Vehicle {

        public int ID { get; set; }


        public virtual void display() {

            Console.WriteLine("This is a vehicle");
        }
    }


    class Car : Vehicle {


        public override void display()
        {
            Console.WriteLine("This is a car");
        }

    }
}
