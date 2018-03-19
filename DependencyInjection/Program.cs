using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //use class1 for demostration
            //manual process of dependency injections

            ILOG _log = new consoleLog();
            engine _engine = new engine(_log);
            car _car = new car(_engine);

            //automated with autofac
            var builder = new ContainerBuilder();
            builder.RegisterType<sampleLog>().As<ILOG>();
            builder.RegisterType<engine>();
            builder.RegisterType<car>();

            IContainer container = builder.Build();

            var car = container.Resolve<car>();

            Console.Read();
        }
    }
}
