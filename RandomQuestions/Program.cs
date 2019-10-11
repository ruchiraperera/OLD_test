using System;

namespace RandomQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Array Types
             * 01. Single Dimensional Arrays []
             * 02. Multi Dimensional Arrays [,]
             * 03. Jagged Arrays [] []
             * 
             * can we override private virtual method > No
             * 
             * What object can help you maintain data across users? Application object
             * An application on the Web may consists of several ASP files that work together to perform some purpose. The Application object is used to tie these files together.
                The Application object is used to store and access variables from any page, just like the Session object. The difference is that ALL users share ONE Application object (with Sessions there is ONE Session object for EACH user).
             * 
             * 
             * Which property will you use to process different server paths in a page? > Server
             * 
             * Single datatype (System.Single) == float (2.0f) (4 bytes)
             * 
             * overloading > 
             * 
                The number of parameters in two methods.
                The data types of the parameters of methods.
                The Order of the parameters of methods.

             * structs doent have destructor/ can't have default parameterless constructor
             * 
             * C# copy constructor 
             * public Person(Person previousPerson)
             * 
             * Convert vs. Parse methods > Convert allows null values, Parse cannot
             * 
             * What is indexer? (objects like a array)
             * if we define an indexer for a class then class will behave like a virtual array. 
             * 
             * 
             * 
             * try block - > A return or break statement cannot exit a finally block.
             * 
             * return type of Predicate <T>() ??? boolean and its a delegate
             * 
             * 
             * ASP.net MVC
             * 
             * Which of the followings are ActionSelectors?
             * What is action filters?
             * Area allows us to ? Partition large application into smaller units. 
             * Bundling allows to? 
             * TempData is useful to > Transfer data from one view to another view 
             */




            Console.ReadKey();
        }
    }

    class A {

        public string Test() {

            try
            {

            }
            catch (Exception)
            {
                return "";
            }
            finally {
            }

        }
    }
}
