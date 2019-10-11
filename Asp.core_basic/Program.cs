using System;

namespace Asp.core_basic
{
    class Program
    {
        static void Main(string[] args)
        {

            //// basic concepts
            /// environments  or trasformation
            /// 
            /// <environment names = "development">
            /// <script></script>
            /// </environment>
            /// 
            /// this environment can be defined in debug level in project properties.
            /// in environment variables - Aspnetcore_environment set values
            /// 
            /// localization in ASP.core changed 
            /// iStringLocalization / iStringLocalization<T> to controller
            /// 
            /// and then intializate the resource path in startup.cs
            /// 
            /// * Attributes based routing
            /// [Route("[controller]/Details/{id}")]
            /// [httpGet("/pies")]
            /// 
            ///.








            Console.WriteLine("Hello World!");
        }
    }
}
