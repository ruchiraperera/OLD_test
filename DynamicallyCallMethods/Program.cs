using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace DynamicallyCallMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //4.5 //callerMemberName Attribute System.Runtime.CompilerServices
            excuteFunction();


            var _customer = new customer();
            MethodInfo _c = _customer.GetType().GetMethod("display");
            _c.Invoke(_customer, new object[] { 1 });


            Console.Read();
        }

        public static void excuteFunction([CallerMemberName] string memberName = "")
        {
            Console.WriteLine(memberName);
        }
        

    }
}
