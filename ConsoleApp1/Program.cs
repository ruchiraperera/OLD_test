using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * MS test 2 / xunit 2 test
             * all these – MsTest has much better abilities for integration based testing (all these are things Nunit doesn’t even want to have):

                ability to do data-driven tests from a db data source
                ability to do performance testing
                ability to determine the order of tests (ordered tests)
                ability to easily setup and teardown and generate database data
                great integration with team system reporting for LOADS of statistics

                having said all these:
                if you’re working with team system, I’d use MsTest. the integration with other team system tools and reporting is just beyond compare and the reporting alone helps alot to find recurring breaking tests, code churn vs. new tests and others.
             */
            Console.WriteLine("Hello World!");
        }
    }
}
