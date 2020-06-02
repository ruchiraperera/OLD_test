using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyResolver.Models
{
    public class Logger : ILog
    {
        public void display(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
