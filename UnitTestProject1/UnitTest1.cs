using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTestLib;

namespace UnitTestProject1
{
    [TestClass] 
    public class UnitTest1
    {
        [TestMethod]
        public void Display_showRuning_printString() {

            var _customer = new Customer();
            _customer.display();
            //Assert.AreSame("1", "2");

        }
    }
}
